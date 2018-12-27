Public Class ControlMain
#Region "KeyDictionaryDeclaration"
    Public Shared KeyDictionary As New Dictionary(Of String, String) From {
{"LEFTARROW", "KEY_ARROW_LEFT"},
{"RIGHTARROW", "KEY_ARROW_RIGHT"},
{"UPARROW", "KEY_ARROW_UP"},
{"DOWNARROW", "KEY_ARROW_DOWN"},
{"LEFT", "KEY_ARROW_LEFT"},
{"RIGH", "KEY_ARROW_RIGHT"},
{"UP", "KEY_ARROW_UP"},
{"DOWN", "KEY_ARROW_DOWN"},
{"DELETE", "KEY_DELETE"},
{"DEL", "KEY_DELETE"},
{"PRINTSCREEN", "KEY_PRT_SCR"},
{"TAB", "KEY_TAB"},
{"ESCAPE", "KEY_ESC"},
{"SPACE", "KEY_SPACE"},
{"ENTER", "KEY_ENTER"},
{"a", "KEY_A"},
{"b", "KEY_B"},
{"c", "KEY_C"},
{"d", "KEY_D"},
{"e", "KEY_E"},
{"f", "KEY_F"},
{"g", "KEY_G"},
{"h", "KEY_H"},
{"i", "KEY_I"},
{"j", "KEY_J"},
{"k", "KEY_K"},
{"l", "KEY_L"},
{"m", "KEY_M"},
{"n", "KEY_N"},
{"o", "KEY_O"},
{"p", "KEY_P"},
{"q", "KEY_Q"},
{"r", "KEY_R"},
{"s", "KEY_S"},
{"t", "KEY_T"},
{"u", "KEY_U"},
{"v", "KEY_V"},
{"w", "KEY_W"},
{"x", "KEY_X"},
{"y", "KEY_Y"},
{"z", "KEY_Z"},
{"F1", "KEY_F1"},
{"F2", "KEY_F2"},
{"F3", "KEY_F3"},
{"F4", "KEY_F4"},
{"F5", "KEY_F5"},
{"F6", "KEY_F6"},
{"F7", "KEY_F7"},
{"F8", "KEY_F8"},
{"F9", "KEY_F9"},
{"F10", "KEY_F10"},
{"F11", "KEY_F11"},
{"F12", "KEY_F12"},
{"CONTROL_LEFT", "MOD_CONTROL_LEFT"},
{"CONTROL", "MOD_CONTROL_LEFT"},
{"CTRL_RIGHT", "MOD_CONTROL_RIGHT"},
{"CTRL_LEFT", "MOD_CONTROL_LEFT"},
{"CTRL", "MOD_CONTROL_LEFT"},
{"SHIFT_RIGHT", "MOD_SHIFT_RIGHT"},
{"SHIFT_LEFT", "MOD_SHIFT_LEFT"},
{"SHIFT", "MOD_SHIFT_LEFT"},
{"ALT_RIGHT", "MOD_ALT_RIGHT"},
{"ALT_LEFT", "MOD_ALT_LEFT"},
{"ALT", "MOD_ALT_LEFT"},
{"GUI_RIGHT", "MOD_GUI_RIGHT"},
{"GUI_LEFT", "MOD_GUI_LEFT"},
{"GUI", "MOD_GUI_LEFT"},
{"WINDOWS", "MOD_GUI_LEFT"}}
    Public Shared KeyDictionarySpecials As New Dictionary(Of String, String) From {
    {"CONTROL_LEFT", "MOD_CONTROL_LEFT"},
{"CONTROL", "MOD_CONTROL_LEFT"},
{"CTRL_RIGHT", "MOD_CONTROL_RIGHT"},
{"CTRL_LEFT", "MOD_CONTROL_LEFT"},
{"CTRL", "MOD_CONTROL_LEFT"},
{"SHIFT_RIGHT", "MOD_SHIFT_RIGHT"},
{"SHIFT_LEFT", "MOD_SHIFT_LEFT"},
{"SHIFT", "MOD_SHIFT_LEFT"},
{"ALT_RIGHT", "MOD_ALT_RIGHT"},
{"ALT_LEFT", "MOD_ALT_LEFT"},
{"ALT", "MOD_ALT_LEFT"},
{"GUI_RIGHT", "MOD_GUI_RIGHT"},
{"GUI_LEFT", "MOD_GUI_LEFT"},
{"GUI", "MOD_GUI_LEFT"},
{"WINDOWS", "MOD_GUI_LEFT"}}
#End Region
    Private Sub RunCodeConversion(sender As Object, e As EventArgs) Handles BtnConvert.Click
        TxtDigiScript.Text = ""
#Region "CodeImports"
        DigiWriteLine("#include ""DigiKeyboard.h""")
#End Region
#Region "CodeDeclarations"
        If TxtDuckyScript.Text.ToLower.Contains("KEY_ESC") Then
            DigiWriteLine("#define KEY_ESC     41")
        End If
        If TxtDuckyScript.Text.ToLower.Contains("KEY_BACKSPACE") Then
            DigiWriteLine("#define KEY_BACKSPACE 42")
        End If
        If TxtDuckyScript.Text.ToLower.Contains("KEY_TAB") Then
            DigiWriteLine("#define KEY_TAB     43")
        End If
        If TxtDuckyScript.Text.ToLower.Contains("KEY_PRT_SCR") Then
            DigiWriteLine("#define KEY_PRT_SCR 70")
        End If
        If TxtDuckyScript.Text.ToLower.Contains("KEY_DELETE") Then
            DigiWriteLine("#define KEY_DELETE  76")
        End If
        If TxtDuckyScript.Text.ToLower.Contains("KEY_ARROW_RIGHT") Then
            DigiWriteLine("#define KEY_ARROW_RIGHT 0x4F")
        End If
        If TxtDuckyScript.Text.ToLower.Contains("KEY_ARROW_DOWN") Then
            DigiWriteLine("#define KEY_ARROW_DOWN  0x51")
        End If
        If TxtDuckyScript.Text.ToLower.Contains("KEY_ARROW_UP") Then
            DigiWriteLine("#define KEY_ARROW_UP    0x52")
        End If
#End Region
#Region "CodeOpening"
        DigiWriteLine("void setup() {")
        DigiWriteLine("DigiKeyboard.delay(5000);")
        DigiWriteLine("DigiKeyboard.sendKeyStroke(0);")
#End Region
#Region "CodeConversion"
        Dim BreakFor As Boolean = False
        For Each DuckyLine As String In TxtDuckyScript.Lines
            Dim LineArgs As New List(Of String)
            For Each arg In DuckyLine.Split(" ")
                LineArgs.Add(arg)
            Next
            If LineArgs.Count = 0 Then
                DigiWriteLine("")
            Else
                Console.WriteLine("INTERPRIT-> " & LineArgs(0).ToLower)
                Select Case (LineArgs(0).ToLower)
                    Case "rem"
                        Console.WriteLine("NONCOMP.COMMENT")
                        Dim ModifiedStr As String = DuckyLine.Remove(0, 3)
                        ModifiedStr = "  //" & ModifiedStr
                        DigiWriteLine(ModifiedStr)
                    Case "delay"
                        Console.WriteLine("FUNCT.DELEY")
                        Dim LineCode As String = "  DigiKeyboard.delay(" & DuckyLine.Remove(0, 6) & ");"
                        DigiWriteLine(LineCode)
                    Case "string"
                        Console.WriteLine("FUNCT.TYPE")
                        Dim LineCode As String = "  DigiKeyboard.print(F(""" & DuckyLine.Remove(0, 7) & """));"
                        DigiWriteLine(LineCode)
                    Case "menu"
                        Console.WriteLine("FUNCT.KEYSTROKE.MENU")
                        DigiWriteLine("  DigiKeyboard.sendKeyStroke(KEY_F10,MOD_SHIFT_LEFT);")

                    Case Else
                        Console.WriteLine("FUNCT.ABSTRACT")
                        Dim LowerCase As String = DuckyLine.ToLower
                        Dim IsValidLine As Boolean = False
                        For Each KeyType In KeyDictionary
                            If LowerCase.StartsWith(KeyType.Key.ToLower) Then
                                IsValidLine = True
                            End If
                        Next
                        Console.WriteLine("")
                        If IsValidLine Then
                            Dim Keys As New List(Of String)
                            For Each KeyStroke In LineArgs
                                For Each keyType In KeyDictionary
                                    If KeyStroke.ToLower = keyType.Key.ToLower Then
                                        Console.WriteLine("Adding Key to listings: " & keyType.Key)
                                        Keys.Add(keyType.Value)
                                    End If
                                Next
                            Next
                            If Keys.Count = 1 Then
                                DigiWriteLine("  DigiKeyboard.sendKeyStroke(" & Keys(0) & ");")
                            Else
                                Dim resstr As String = ""
                                For Each Stri In Keys
                                    Console.WriteLine("Key Query: " & Stri)
                                    Dim IsSpecial As Boolean = False
                                    For Each SpecialKey In KeyDictionarySpecials
                                        If SpecialKey.Value.ToLower = Stri.ToLower Then
                                            IsSpecial = True
                                        End If
                                    Next
                                    Console.WriteLine("Key Is Special: " & IsSpecial)
                                    If IsSpecial Then
                                        resstr = resstr & Stri & "|"
                                    Else
                                        resstr = resstr & Stri & ","
                                    End If
                                Next


                                resstr = resstr.Trim("|").Trim(",")
                                Console.WriteLine("Final -> " & resstr)
                                DigiWriteLine("  DigiKeyboard.sendKeyStroke(" & resstr & ");")

                            End If
                        Else
                            Dim res As DialogResult = MessageBox.Show(Me, "Unknown Command: """ & DuckyLine & """. Would you like to break the operation?", "Unknown Command", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                            If res = DialogResult.Yes Then
                                TxtDigiScript.Text = ("//Error converting script: Unkown Command: """ & DuckyLine & """")
                                BreakFor = True
                                Exit For
                            Else
                                DigiWriteLine("  //Error converting script: Unkown Command: """ & DuckyLine & """")
                            End If
                        End If



                End Select



            End If
        Next
#End Region
#Region "CodeClosing"
        If BreakFor = False Then
            DigiWriteLine(" for (;;) {
    /*empty*/
  }

}")

        End If
#End Region
    End Sub
    Public Sub DigiWriteLine(Line As String)
        Console.WriteLine("CODE APPENSION -> " & Line)
        If TxtDigiScript.Text = "" Then
            TxtDigiScript.AppendText(Line)
        Else
            TxtDigiScript.AppendText(vbNewLine & Line)
        End If
    End Sub

    Private Sub BtnDuckyPaste_Click(sender As Object, e As EventArgs) Handles BtnDuckyPaste.Click
        Try
            TxtDuckyScript.Text = My.Computer.Clipboard.GetText
        Catch ex As Exception
            MessageBox.Show("No text in clipboard.")
        End Try
    End Sub

    Private Sub BtnDuckyLoad_Click(sender As Object, e As EventArgs) Handles BtnDuckyLoad.Click
        Dim res As DialogResult = OpenDucky.ShowDialog
        If res = DialogResult.OK Then
            TxtDuckyScript.Lines = System.IO.File.ReadAllLines(OpenDucky.FileName)
        End If
    End Sub

    Private Sub BtnDigiSave_Click(sender As Object, e As EventArgs) Handles BtnDigiSave.Click
        Dim res As DialogResult = SaveDigi.ShowDialog
        If res = DialogResult.OK Then
            System.IO.File.WriteAllLines(SaveDigi.FileName, TxtDigiScript.Lines)
        End If
    End Sub
    Private Sub BtnDigiCopy_Click(sender As Object, e As EventArgs) Handles BtnDigiCopy.Click
        My.Computer.Clipboard.SetText(TxtDuckyScript.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BatchJob.Show()
    End Sub
End Class
Public Class StandaloneConverter
    Private Shared ScriptRes As String = ""
    Private Shared Sub DigiWriteLine(Line As String)
        Console.WriteLine("CODE APPENSION -> " & Line)
        If ScriptRes = "" Then
            ScriptRes = ScriptRes & Line
        Else
            ScriptRes = ScriptRes & vbNewLine & Line
        End If
    End Sub

    Public Shared Function ConvertToDigi(Script As String, SuppressErrorMessages As Boolean)
        ScriptRes = ""




#Region "CodeImports"
        DigiWriteLine("#include ""DigiKeyboard.h""")
#End Region
#Region "CodeDeclarations"
        If Script.ToLower.Contains("KEY_ESC") Then
            DigiWriteLine("#define KEY_ESC     41")
        End If
        If Script.ToLower.Contains("KEY_BACKSPACE") Then
            DigiWriteLine("#define KEY_BACKSPACE 42")
        End If
        If Script.ToLower.Contains("KEY_TAB") Then
            DigiWriteLine("#define KEY_TAB     43")
        End If
        If Script.ToLower.Contains("KEY_PRT_SCR") Then
            DigiWriteLine("#define KEY_PRT_SCR 70")
        End If
        If Script.ToLower.Contains("KEY_DELETE") Then
            DigiWriteLine("#define KEY_DELETE  76")
        End If
        If Script.ToLower.Contains("KEY_ARROW_RIGHT") Then
            DigiWriteLine("#define KEY_ARROW_RIGHT 0x4F")
        End If
        If Script.ToLower.Contains("KEY_ARROW_DOWN") Then
            DigiWriteLine("#define KEY_ARROW_DOWN  0x51")
        End If
        If Script.ToLower.Contains("KEY_ARROW_UP") Then
            DigiWriteLine("#define KEY_ARROW_UP    0x52")
        End If
#End Region
#Region "CodeOpening"
        DigiWriteLine("void setup() {")
        DigiWriteLine("DigiKeyboard.delay(5000);")
        DigiWriteLine("DigiKeyboard.sendKeyStroke(0);")
#End Region
#Region "CodeConversion"
        Dim BreakFor As Boolean = False
        For Each DuckyLine As String In Script.Split(vbNewLine)
            Dim LineArgs As New List(Of String)
            For Each arg In DuckyLine.Split(" ")
                LineArgs.Add(arg)
            Next
            If LineArgs.Count = 0 Then
                DigiWriteLine("")
            Else
                Console.WriteLine("INTERPRIT-> " & LineArgs(0).ToLower)
                Select Case (LineArgs(0).ToLower)
                    Case "rem"
                        Console.WriteLine("NONCOMP.COMMENT")
                        Dim ModifiedStr As String = DuckyLine.Remove(0, 3)
                        ModifiedStr = "  //" & ModifiedStr
                        DigiWriteLine(ModifiedStr)
                    Case "delay"
                        Console.WriteLine("FUNCT.DELEY")
                        Dim LineCode As String = "  DigiKeyboard.delay(" & DuckyLine.Remove(0, 6) & ");"
                        DigiWriteLine(LineCode)
                    Case "deley"
                        Console.WriteLine("FUNCT.DELEY")
                        Dim LineCode As String = "  DigiKeyboard.delay(" & DuckyLine.Remove(0, 6) & ");"
                        DigiWriteLine(LineCode)
                    Case "string"
                        Console.WriteLine("FUNCT.TYPE")
                        Dim LineCode As String = "  DigiKeyboard.print(F(""" & DuckyLine.Remove(0, 7) & """));"
                        DigiWriteLine(LineCode)
                    Case "menu"
                        Console.WriteLine("FUNCT.KEYSTROKE.MENU")
                        DigiWriteLine("  DigiKeyboard.sendKeyStroke(KEY_F10,MOD_SHIFT_LEFT);")

                    Case Else
                        Console.WriteLine("FUNCT.ABSTRACT")
                        Dim LowerCase As String = DuckyLine.ToLower
                        Dim IsValidLine As Boolean = False
                        For Each KeyType In ControlMain.KeyDictionary
                            If LowerCase.StartsWith(KeyType.Key.ToLower) Then
                                IsValidLine = True
                            End If
                        Next
                        Console.WriteLine("")
                        If IsValidLine Then
                            Dim Keys As New List(Of String)
                            For Each KeyStroke In LineArgs
                                For Each keyType In ControlMain.KeyDictionary
                                    If KeyStroke.ToLower = keyType.Key.ToLower Then
                                        Console.WriteLine("Adding Key to listings: " & keyType.Key)
                                        Keys.Add(keyType.Value)
                                    End If
                                Next
                            Next
                            If Keys.Count = 1 Then
                                DigiWriteLine("  DigiKeyboard.sendKeyStroke(" & Keys(0) & ");")
                            Else
                                Dim resstr As String = ""
                                For Each Stri In Keys
                                    Console.WriteLine("Key Query: " & Stri)
                                    Dim IsSpecial As Boolean = False
                                    For Each SpecialKey In ControlMain.KeyDictionarySpecials
                                        If SpecialKey.Value.ToLower = Stri.ToLower Then
                                            IsSpecial = True
                                        End If
                                    Next
                                    Console.WriteLine("Key Is Special: " & IsSpecial)
                                    If IsSpecial Then
                                        resstr = resstr & Stri & "|"
                                    Else
                                        resstr = resstr & Stri & ","
                                    End If
                                Next


                                resstr = resstr.Trim("|").Trim(",")
                                Console.WriteLine("Final -> " & resstr)
                                DigiWriteLine("  DigiKeyboard.sendKeyStroke(" & resstr & ");")

                            End If
                        Else
                            If SuppressErrorMessages = False Then
                                Dim res As DialogResult = MessageBox.Show(BatchJob, "Unknown Command: """ & DuckyLine & """. Would you like to break the operation?", "Unknown Command", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                                If res = DialogResult.Yes Then
                                    ControlMain.TxtDigiScript.Text = ("//Error converting script: Unkown Command: """ & DuckyLine & """")
                                    BreakFor = True
                                    Exit For
                                Else
                                    DigiWriteLine("  //Error converting script: Unkown Command: """ & DuckyLine & """")
                                End If
                            Else
                                DigiWriteLine("  //Error converting script: Unkown Command: """ & DuckyLine & """")
                            End If
                        End If

                End Select



            End If
        Next
#End Region
#Region "CodeClosing"
        If BreakFor = False Then
            DigiWriteLine(" for (;;) {
    /*empty*/
  }

}")

        End If
#End Region
        Return ScriptRes
    End Function


End Class