Public Class BatchJob
    Dim Files_ As Integer = 0
    Private Sub BtnSourceBrowse_Click(sender As Object, e As EventArgs) Handles BtnSourceBrowse.Click
        FBDSelectDIR.Description = "Select a source folder."
        Dim res As DialogResult = FBDSelectDIR.ShowDialog
        If res = DialogResult.OK Then
            TxtSource.Text = FBDSelectDIR.SelectedPath
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FBDSelectDIR.Description = "Select an output folder."
        Dim res As DialogResult = FBDSelectDIR.ShowDialog
        If res = DialogResult.OK Then
            txtOutput.Text = FBDSelectDIR.SelectedPath
        End If
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        If Not txtOutput.Text = "" And Not TxtSource.Text = "" Then
            PBProgress.Step = 1
            PBProgress.Value = 0
            PBProgress.Maximum = System.IO.Directory.GetFiles(TxtSource.Text).Count
            LblFiles.Text = "Files: " & System.IO.Directory.GetFiles(TxtSource.Text).Count
            LblComplete.Text = "Complete: 0"
            LblRem.Text = "Remaining: " & System.IO.Directory.GetFiles(TxtSource.Text).Count
            Files_ = System.IO.Directory.GetFiles(TxtSource.Text).Count
            PBProgress.Show()
            BackgroundConverter.RunWorkerAsync()

            'For Each file In System.IO.Directory.GetFiles(TxtSource.Text)
            '    Dim OrigonalScript As String = System.IO.File.ReadAllText(file).Replace(ChrW(10), "")
            '    Dim ConvertedScript As String = StandaloneConverter.ConvertToDigi(OrigonalScript)
            '    Dim FileT As IO.FileInfo = New IO.FileInfo(file)
            '    Dim NewFileName As String = FileT.Name.Replace(FileT.Extension, ".txt")
            '    Dim modifiedoutput As String = txtOutput.Text
            '    If modifiedoutput.EndsWith("\") Then
            '        'Correct
            '    Else
            '        modifiedoutput = modifiedoutput & "\"
            '    End If
            '    Dim OutFile As String = modifiedoutput & NewFileName
            '    Console.WriteLine(OutFile)
            '    System.IO.File.WriteAllText(OutFile, ConvertedScript, System.Text.Encoding.ASCII)
            'Next
        Else
            MessageBox.Show("Please select a source and output folder.")
        End If
    End Sub

    Private Sub BackgroundConverter_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundConverter.DoWork
        Dim CurrentFile_ As Integer = 0
        For Each file In System.IO.Directory.GetFiles(TxtSource.Text)
            Dim OrigonalScript As String = System.IO.File.ReadAllText(file).Replace(ChrW(10), "")
            Dim ConvertedScript As String = StandaloneConverter.ConvertToDigi(OrigonalScript, CBStopError.Checked)
            Dim FileT As IO.FileInfo = New IO.FileInfo(file)
            Dim NewFileName As String = FileT.Name.Replace(FileT.Extension, ".txt")
            Dim modifiedoutput As String = txtOutput.Text
            If modifiedoutput.EndsWith("\") Then
                'Correct
            Else
                modifiedoutput = modifiedoutput & "\"
            End If
            Dim OutFile As String = modifiedoutput & NewFileName
            Console.WriteLine(OutFile)
            System.IO.File.WriteAllText(OutFile, ConvertedScript, System.Text.Encoding.ASCII)
            CurrentFile_ = CurrentFile_ + 1
            BackgroundConverter.ReportProgress(CurrentFile_)
        Next
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundConverter.ProgressChanged
        PBProgress.PerformStep()
        LblComplete.Text = "Complete: " & PBProgress.Value
        LblRem.Text = "Remaining: " & (Files_ - PBProgress.Value)
    End Sub

    Private Sub bgw_RunWorkerCompleted(sender As Object,
             e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundConverter.RunWorkerCompleted
        MessageBox.Show("All Scripts converted!")
        PBProgress.Hide()
        Me.Close()
    End Sub
End Class