<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWordLengthApp
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
        Me.LblWord = New System.Windows.Forms.Label()
        Me.LblCharacter = New System.Windows.Forms.Label()
        Me.TxtWord = New System.Windows.Forms.TextBox()
        Me.TxtCharacter = New System.Windows.Forms.TextBox()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblWord
        '
        Me.LblWord.AutoSize = True
        Me.LblWord.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWord.Location = New System.Drawing.Point(99, 73)
        Me.LblWord.Name = "LblWord"
        Me.LblWord.Size = New System.Drawing.Size(62, 25)
        Me.LblWord.TabIndex = 0
        Me.LblWord.Text = "Word"
        '
        'LblCharacter
        '
        Me.LblCharacter.AutoSize = True
        Me.LblCharacter.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCharacter.Location = New System.Drawing.Point(101, 151)
        Me.LblCharacter.Name = "LblCharacter"
        Me.LblCharacter.Size = New System.Drawing.Size(96, 25)
        Me.LblCharacter.TabIndex = 1
        Me.LblCharacter.Text = "Character"
        '
        'TxtWord
        '
        Me.TxtWord.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWord.Location = New System.Drawing.Point(219, 67)
        Me.TxtWord.Name = "TxtWord"
        Me.TxtWord.Size = New System.Drawing.Size(100, 31)
        Me.TxtWord.TabIndex = 2
        '
        'TxtCharacter
        '
        Me.TxtCharacter.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCharacter.Location = New System.Drawing.Point(224, 149)
        Me.TxtCharacter.Name = "TxtCharacter"
        Me.TxtCharacter.Size = New System.Drawing.Size(100, 31)
        Me.TxtCharacter.TabIndex = 3
        '
        'BtnShow
        '
        Me.BtnShow.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.Location = New System.Drawing.Point(143, 232)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(75, 40)
        Me.BtnShow.TabIndex = 4
        Me.BtnShow.Text = "Show"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(227, 231)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 41)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmWordLengthApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 367)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.TxtCharacter)
        Me.Controls.Add(Me.TxtWord)
        Me.Controls.Add(Me.LblCharacter)
        Me.Controls.Add(Me.LblWord)
        Me.Name = "FrmWordLengthApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WordLength"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblWord As Label
    Friend WithEvents LblCharacter As Label
    Friend WithEvents TxtWord As TextBox
    Friend WithEvents TxtCharacter As TextBox
    Friend WithEvents BtnShow As Button
    Friend WithEvents BtnReset As Button
End Class
