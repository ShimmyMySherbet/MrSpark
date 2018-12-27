<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlMain))
        Me.TxtDuckyScript = New System.Windows.Forms.TextBox()
        Me.BtnDuckyPaste = New System.Windows.Forms.Button()
        Me.BtnDigiCopy = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnDuckyLoad = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnDigiSave = New System.Windows.Forms.Button()
        Me.TxtDigiScript = New System.Windows.Forms.TextBox()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.OpenDucky = New System.Windows.Forms.OpenFileDialog()
        Me.SaveDigi = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtDuckyScript
        '
        Me.TxtDuckyScript.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDuckyScript.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDuckyScript.Location = New System.Drawing.Point(8, 19)
        Me.TxtDuckyScript.Multiline = True
        Me.TxtDuckyScript.Name = "TxtDuckyScript"
        Me.TxtDuckyScript.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TxtDuckyScript.Size = New System.Drawing.Size(380, 364)
        Me.TxtDuckyScript.TabIndex = 1
        '
        'BtnDuckyPaste
        '
        Me.BtnDuckyPaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDuckyPaste.Location = New System.Drawing.Point(6, 389)
        Me.BtnDuckyPaste.Name = "BtnDuckyPaste"
        Me.BtnDuckyPaste.Size = New System.Drawing.Size(75, 23)
        Me.BtnDuckyPaste.TabIndex = 4
        Me.BtnDuckyPaste.Text = "Paste"
        Me.BtnDuckyPaste.UseVisualStyleBackColor = True
        '
        'BtnDigiCopy
        '
        Me.BtnDigiCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnDigiCopy.Location = New System.Drawing.Point(6, 383)
        Me.BtnDigiCopy.Name = "BtnDigiCopy"
        Me.BtnDigiCopy.Size = New System.Drawing.Size(75, 23)
        Me.BtnDigiCopy.TabIndex = 5
        Me.BtnDigiCopy.Text = "Copy"
        Me.BtnDigiCopy.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnDuckyLoad)
        Me.GroupBox1.Controls.Add(Me.TxtDuckyScript)
        Me.GroupBox1.Controls.Add(Me.BtnDuckyPaste)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 421)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ducky Script"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button1.Location = New System.Drawing.Point(168, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Batch"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnDuckyLoad
        '
        Me.BtnDuckyLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDuckyLoad.Location = New System.Drawing.Point(87, 389)
        Me.BtnDuckyLoad.Name = "BtnDuckyLoad"
        Me.BtnDuckyLoad.Size = New System.Drawing.Size(75, 23)
        Me.BtnDuckyLoad.TabIndex = 5
        Me.BtnDuckyLoad.Text = "From File"
        Me.BtnDuckyLoad.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Controls.Add(Me.BtnDigiSave)
        Me.GroupBox2.Controls.Add(Me.TxtDigiScript)
        Me.GroupBox2.Controls.Add(Me.BtnDigiCopy)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(429, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 415)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DigiSpark Script"
        '
        'BtnDigiSave
        '
        Me.BtnDigiSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnDigiSave.Location = New System.Drawing.Point(87, 383)
        Me.BtnDigiSave.Name = "BtnDigiSave"
        Me.BtnDigiSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnDigiSave.TabIndex = 6
        Me.BtnDigiSave.Text = "To File"
        Me.BtnDigiSave.UseVisualStyleBackColor = True
        '
        'TxtDigiScript
        '
        Me.TxtDigiScript.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDigiScript.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDigiScript.Location = New System.Drawing.Point(8, 19)
        Me.TxtDigiScript.Multiline = True
        Me.TxtDigiScript.Name = "TxtDigiScript"
        Me.TxtDigiScript.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TxtDigiScript.Size = New System.Drawing.Size(380, 358)
        Me.TxtDigiScript.TabIndex = 1
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(403, 211)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(29, 23)
        Me.BtnConvert.TabIndex = 8
        Me.BtnConvert.Text = ">"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'OpenDucky
        '
        Me.OpenDucky.Filter = "Text Files|*.txt|Any File|*.*"
        Me.OpenDucky.Title = "Open a Rubber Ducky Payload"
        '
        'SaveDigi
        '
        Me.SaveDigi.DefaultExt = "txt"
        Me.SaveDigi.Filter = "Text Files|*.txt"
        Me.SaveDigi.Title = "Save the Digispark Script to a text file"
        '
        'ControlMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(833, 449)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ControlMain"
        Me.Text = "MrSpark"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtDuckyScript As TextBox
    Friend WithEvents BtnDuckyPaste As Button
    Friend WithEvents BtnDigiCopy As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtDigiScript As TextBox
    Friend WithEvents BtnDuckyLoad As Button
    Friend WithEvents BtnDigiSave As Button
    Friend WithEvents BtnConvert As Button
    Friend WithEvents OpenDucky As OpenFileDialog
    Friend WithEvents SaveDigi As SaveFileDialog
    Friend WithEvents Button1 As Button
End Class
