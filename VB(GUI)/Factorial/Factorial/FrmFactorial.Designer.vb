<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFactorial
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
        Me.LblNumber = New System.Windows.Forms.Label()
        Me.LblFactorial = New System.Windows.Forms.Label()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.TxtFactorial = New System.Windows.Forms.TextBox()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNumber
        '
        Me.LblNumber.AutoSize = True
        Me.LblNumber.Location = New System.Drawing.Point(81, 58)
        Me.LblNumber.Name = "LblNumber"
        Me.LblNumber.Size = New System.Drawing.Size(58, 17)
        Me.LblNumber.TabIndex = 0
        Me.LblNumber.Text = "Number"
        '
        'LblFactorial
        '
        Me.LblFactorial.AutoSize = True
        Me.LblFactorial.Location = New System.Drawing.Point(81, 114)
        Me.LblFactorial.Name = "LblFactorial"
        Me.LblFactorial.Size = New System.Drawing.Size(62, 17)
        Me.LblFactorial.TabIndex = 1
        Me.LblFactorial.Text = "Factorial"
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(202, 53)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumber.TabIndex = 2
        '
        'TxtFactorial
        '
        Me.TxtFactorial.Location = New System.Drawing.Point(202, 109)
        Me.TxtFactorial.Name = "TxtFactorial"
        Me.TxtFactorial.Size = New System.Drawing.Size(100, 22)
        Me.TxtFactorial.TabIndex = 3
        Me.TxtFactorial.TabStop = False
        '
        'BtnFind
        '
        Me.BtnFind.Location = New System.Drawing.Point(111, 171)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(75, 23)
        Me.BtnFind.TabIndex = 4
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(192, 171)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmFactorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 261)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnFind)
        Me.Controls.Add(Me.TxtFactorial)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.LblFactorial)
        Me.Controls.Add(Me.LblNumber)
        Me.Name = "FrmFactorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FactorialApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNumber As Label
    Friend WithEvents LblFactorial As Label
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents TxtFactorial As TextBox
    Friend WithEvents BtnFind As Button
    Friend WithEvents BtnReset As Button
End Class
