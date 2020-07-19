<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPalindromeApp
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
        Me.LblPalindrome = New System.Windows.Forms.Label()
        Me.TxtWord = New System.Windows.Forms.TextBox()
        Me.TxtPalindrome = New System.Windows.Forms.TextBox()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblWord
        '
        Me.LblWord.AutoSize = True
        Me.LblWord.Location = New System.Drawing.Point(100, 67)
        Me.LblWord.Name = "LblWord"
        Me.LblWord.Size = New System.Drawing.Size(42, 17)
        Me.LblWord.TabIndex = 0
        Me.LblWord.Text = "Word"
        '
        'LblPalindrome
        '
        Me.LblPalindrome.AutoSize = True
        Me.LblPalindrome.Location = New System.Drawing.Point(103, 127)
        Me.LblPalindrome.Name = "LblPalindrome"
        Me.LblPalindrome.Size = New System.Drawing.Size(87, 17)
        Me.LblPalindrome.TabIndex = 1
        Me.LblPalindrome.Text = "Palindrdome"
        '
        'TxtWord
        '
        Me.TxtWord.Location = New System.Drawing.Point(216, 67)
        Me.TxtWord.Name = "TxtWord"
        Me.TxtWord.Size = New System.Drawing.Size(100, 22)
        Me.TxtWord.TabIndex = 2
        '
        'TxtPalindrome
        '
        Me.TxtPalindrome.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPalindrome.Location = New System.Drawing.Point(216, 125)
        Me.TxtPalindrome.Name = "TxtPalindrome"
        Me.TxtPalindrome.ReadOnly = True
        Me.TxtPalindrome.Size = New System.Drawing.Size(100, 22)
        Me.TxtPalindrome.TabIndex = 3
        Me.TxtPalindrome.TabStop = False
        '
        'BtnCheck
        '
        Me.BtnCheck.Location = New System.Drawing.Point(142, 189)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(75, 23)
        Me.BtnCheck.TabIndex = 4
        Me.BtnCheck.Text = "Check"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(224, 189)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmPalindromeApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 301)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.TxtPalindrome)
        Me.Controls.Add(Me.TxtWord)
        Me.Controls.Add(Me.LblPalindrome)
        Me.Controls.Add(Me.LblWord)
        Me.Name = "FrmPalindromeApp"
        Me.Text = "PlindromeApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblWord As Label
    Friend WithEvents LblPalindrome As Label
    Friend WithEvents TxtWord As TextBox
    Friend WithEvents TxtPalindrome As TextBox
    Friend WithEvents BtnCheck As Button
    Friend WithEvents BtnReset As Button
End Class
