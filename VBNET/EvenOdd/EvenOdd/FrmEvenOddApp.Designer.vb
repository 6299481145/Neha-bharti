<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEvenOddApp
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
        Me.LblEvenOdd = New System.Windows.Forms.Label()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.TxtEvenOdd = New System.Windows.Forms.TextBox()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNumber
        '
        Me.LblNumber.AutoSize = True
        Me.LblNumber.Location = New System.Drawing.Point(90, 62)
        Me.LblNumber.Name = "LblNumber"
        Me.LblNumber.Size = New System.Drawing.Size(58, 17)
        Me.LblNumber.TabIndex = 0
        Me.LblNumber.Text = "Number"
        '
        'LblEvenOdd
        '
        Me.LblEvenOdd.AutoSize = True
        Me.LblEvenOdd.Location = New System.Drawing.Point(90, 144)
        Me.LblEvenOdd.Name = "LblEvenOdd"
        Me.LblEvenOdd.Size = New System.Drawing.Size(67, 17)
        Me.LblEvenOdd.TabIndex = 1
        Me.LblEvenOdd.Text = "EvenOdd"
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(214, 61)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumber.TabIndex = 2
        '
        'TxtEvenOdd
        '
        Me.TxtEvenOdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEvenOdd.Location = New System.Drawing.Point(214, 139)
        Me.TxtEvenOdd.Name = "TxtEvenOdd"
        Me.TxtEvenOdd.ReadOnly = True
        Me.TxtEvenOdd.Size = New System.Drawing.Size(100, 22)
        Me.TxtEvenOdd.TabIndex = 3
        Me.TxtEvenOdd.TabStop = False
        '
        'BtnCheck
        '
        Me.BtnCheck.Location = New System.Drawing.Point(137, 217)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(75, 23)
        Me.BtnCheck.TabIndex = 4
        Me.BtnCheck.Text = "Check"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(218, 217)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmEvenOddApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 338)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.TxtEvenOdd)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.LblEvenOdd)
        Me.Controls.Add(Me.LblNumber)
        Me.Name = "FrmEvenOddApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EvenOddApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNumber As Label
    Friend WithEvents LblEvenOdd As Label
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents TxtEvenOdd As TextBox
    Friend WithEvents BtnCheck As Button
    Friend WithEvents BtnReset As Button
End Class
