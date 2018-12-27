<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BatchJob
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GBBatch = New System.Windows.Forms.GroupBox()
        Me.PBProgress = New System.Windows.Forms.ProgressBar()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.BtnSourceBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSource = New System.Windows.Forms.TextBox()
        Me.FBDSelectDIR = New System.Windows.Forms.FolderBrowserDialog()
        Me.BackgroundConverter = New System.ComponentModel.BackgroundWorker()
        Me.LblFiles = New System.Windows.Forms.Label()
        Me.LblComplete = New System.Windows.Forms.Label()
        Me.LblRem = New System.Windows.Forms.Label()
        Me.CBStopError = New System.Windows.Forms.CheckBox()
        Me.GBBatch.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBBatch
        '
        Me.GBBatch.Controls.Add(Me.CBStopError)
        Me.GBBatch.Controls.Add(Me.LblRem)
        Me.GBBatch.Controls.Add(Me.LblComplete)
        Me.GBBatch.Controls.Add(Me.LblFiles)
        Me.GBBatch.Controls.Add(Me.PBProgress)
        Me.GBBatch.Controls.Add(Me.BtnStart)
        Me.GBBatch.Controls.Add(Me.Button1)
        Me.GBBatch.Controls.Add(Me.Label2)
        Me.GBBatch.Controls.Add(Me.txtOutput)
        Me.GBBatch.Controls.Add(Me.BtnSourceBrowse)
        Me.GBBatch.Controls.Add(Me.Label1)
        Me.GBBatch.Controls.Add(Me.TxtSource)
        Me.GBBatch.Location = New System.Drawing.Point(10, 9)
        Me.GBBatch.Name = "GBBatch"
        Me.GBBatch.Size = New System.Drawing.Size(221, 224)
        Me.GBBatch.TabIndex = 0
        Me.GBBatch.TabStop = False
        Me.GBBatch.Text = "Batch Conversion"
        '
        'PBProgress
        '
        Me.PBProgress.Location = New System.Drawing.Point(0, 195)
        Me.PBProgress.Name = "PBProgress"
        Me.PBProgress.Size = New System.Drawing.Size(215, 23)
        Me.PBProgress.TabIndex = 7
        Me.PBProgress.Visible = False
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(2, 147)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(75, 23)
        Me.BtnStart.TabIndex = 6
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Output Directory:"
        '
        'txtOutput
        '
        Me.txtOutput.AcceptsReturn = True
        Me.txtOutput.AcceptsTab = True
        Me.txtOutput.AllowDrop = True
        Me.txtOutput.Location = New System.Drawing.Point(2, 98)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(200, 20)
        Me.txtOutput.TabIndex = 3
        '
        'BtnSourceBrowse
        '
        Me.BtnSourceBrowse.Location = New System.Drawing.Point(6, 53)
        Me.BtnSourceBrowse.Name = "BtnSourceBrowse"
        Me.BtnSourceBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BtnSourceBrowse.TabIndex = 2
        Me.BtnSourceBrowse.Text = "Browse"
        Me.BtnSourceBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Source Directory:"
        '
        'TxtSource
        '
        Me.TxtSource.AcceptsReturn = True
        Me.TxtSource.AcceptsTab = True
        Me.TxtSource.AllowDrop = True
        Me.TxtSource.Location = New System.Drawing.Point(6, 33)
        Me.TxtSource.Name = "TxtSource"
        Me.TxtSource.Size = New System.Drawing.Size(200, 20)
        Me.TxtSource.TabIndex = 0
        '
        'BackgroundConverter
        '
        Me.BackgroundConverter.WorkerReportsProgress = True
        '
        'LblFiles
        '
        Me.LblFiles.AutoSize = True
        Me.LblFiles.Location = New System.Drawing.Point(83, 118)
        Me.LblFiles.Name = "LblFiles"
        Me.LblFiles.Size = New System.Drawing.Size(40, 13)
        Me.LblFiles.TabIndex = 8
        Me.LblFiles.Text = "Files: 0"
        '
        'LblComplete
        '
        Me.LblComplete.AutoSize = True
        Me.LblComplete.Location = New System.Drawing.Point(83, 137)
        Me.LblComplete.Name = "LblComplete"
        Me.LblComplete.Size = New System.Drawing.Size(63, 13)
        Me.LblComplete.TabIndex = 9
        Me.LblComplete.Text = "Complete: 0"
        '
        'LblRem
        '
        Me.LblRem.AutoSize = True
        Me.LblRem.Location = New System.Drawing.Point(83, 157)
        Me.LblRem.Name = "LblRem"
        Me.LblRem.Size = New System.Drawing.Size(69, 13)
        Me.LblRem.TabIndex = 10
        Me.LblRem.Text = "Remaining: 0"
        '
        'CBStopError
        '
        Me.CBStopError.AutoSize = True
        Me.CBStopError.Location = New System.Drawing.Point(4, 173)
        Me.CBStopError.Name = "CBStopError"
        Me.CBStopError.Size = New System.Drawing.Size(146, 17)
        Me.CBStopError.TabIndex = 11
        Me.CBStopError.Text = "Suppress Error Messages"
        Me.CBStopError.UseVisualStyleBackColor = True
        '
        'BatchJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(241, 242)
        Me.Controls.Add(Me.GBBatch)
        Me.Name = "BatchJob"
        Me.Text = "BatchJob"
        Me.GBBatch.ResumeLayout(False)
        Me.GBBatch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBBatch As GroupBox
    Friend WithEvents PBProgress As ProgressBar
    Friend WithEvents BtnStart As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents BtnSourceBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSource As TextBox
    Friend WithEvents FBDSelectDIR As FolderBrowserDialog
    Friend WithEvents BackgroundConverter As System.ComponentModel.BackgroundWorker
    Friend WithEvents LblRem As Label
    Friend WithEvents LblComplete As Label
    Friend WithEvents LblFiles As Label
    Friend WithEvents CBStopError As CheckBox
End Class
