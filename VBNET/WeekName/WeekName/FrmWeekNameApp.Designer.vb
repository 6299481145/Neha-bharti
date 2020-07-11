<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWeekNameApp
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
        Me.LblName = New System.Windows.Forms.Label()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNumber
        '
        Me.LblNumber.AutoSize = True
        Me.LblNumber.Location = New System.Drawing.Point(85, 66)
        Me.LblNumber.Name = "LblNumber"
        Me.LblNumber.Size = New System.Drawing.Size(58, 17)
        Me.LblNumber.TabIndex = 0
        Me.LblNumber.Text = "Number"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(85, 135)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(45, 17)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Name"
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(204, 66)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(112, 22)
        Me.TxtNumber.TabIndex = 2
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(204, 135)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(112, 22)
        Me.TxtName.TabIndex = 3
        Me.TxtName.TabStop = False
        '
        'BtnShow
        '
        Me.BtnShow.Location = New System.Drawing.Point(114, 189)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(75, 32)
        Me.BtnShow.TabIndex = 4
        Me.BtnShow.Text = "Show"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(195, 189)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 32)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmWeekNameApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 315)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblNumber)
        Me.Name = "FrmWeekNameApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WeekNameApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNumber As Label
    Friend WithEvents LblName As Label
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnShow As Button
    Friend WithEvents BtnReset As Button
End Class
