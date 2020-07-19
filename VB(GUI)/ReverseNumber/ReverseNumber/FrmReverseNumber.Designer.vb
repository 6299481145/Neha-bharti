<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReverseNumber
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
        Me.LblReverse = New System.Windows.Forms.Label()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.TxtReverse = New System.Windows.Forms.TextBox()
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNumber
        '
        Me.LblNumber.AutoSize = True
        Me.LblNumber.Location = New System.Drawing.Point(67, 49)
        Me.LblNumber.Name = "LblNumber"
        Me.LblNumber.Size = New System.Drawing.Size(58, 17)
        Me.LblNumber.TabIndex = 0
        Me.LblNumber.Text = "Number"
        '
        'LblReverse
        '
        Me.LblReverse.AutoSize = True
        Me.LblReverse.Location = New System.Drawing.Point(67, 109)
        Me.LblReverse.Name = "LblReverse"
        Me.LblReverse.Size = New System.Drawing.Size(61, 17)
        Me.LblReverse.TabIndex = 1
        Me.LblReverse.Text = "Reverse"
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(184, 44)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumber.TabIndex = 2
        '
        'TxtReverse
        '
        Me.TxtReverse.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReverse.Location = New System.Drawing.Point(184, 104)
        Me.TxtReverse.Name = "TxtReverse"
        Me.TxtReverse.ReadOnly = True
        Me.TxtReverse.Size = New System.Drawing.Size(100, 22)
        Me.TxtReverse.TabIndex = 3
        Me.TxtReverse.TabStop = False
        '
        'BtnDone
        '
        Me.BtnDone.Location = New System.Drawing.Point(103, 169)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(75, 33)
        Me.BtnDone.TabIndex = 4
        Me.BtnDone.Text = "Done"
        Me.BtnDone.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(184, 169)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 33)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmReverseNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 280)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.TxtReverse)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.LblReverse)
        Me.Controls.Add(Me.LblNumber)
        Me.Name = "FrmReverseNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReverseNumber"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNumber As Label
    Friend WithEvents LblReverse As Label
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents TxtReverse As TextBox
    Friend WithEvents BtnDone As Button
    Friend WithEvents BtnReset As Button
End Class
