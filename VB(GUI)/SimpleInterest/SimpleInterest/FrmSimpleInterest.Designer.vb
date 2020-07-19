<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSimpleInterest
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
        Me.LblPrincipal = New System.Windows.Forms.Label()
        Me.TxtPrincipal = New System.Windows.Forms.TextBox()
        Me.LblRate = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblInterest = New System.Windows.Forms.Label()
        Me.TxtRate = New System.Windows.Forms.TextBox()
        Me.TxtTime = New System.Windows.Forms.TextBox()
        Me.TxtInterest = New System.Windows.Forms.TextBox()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblPrincipal
        '
        Me.LblPrincipal.AutoSize = True
        Me.LblPrincipal.Location = New System.Drawing.Point(72, 27)
        Me.LblPrincipal.Name = "LblPrincipal"
        Me.LblPrincipal.Size = New System.Drawing.Size(62, 17)
        Me.LblPrincipal.TabIndex = 0
        Me.LblPrincipal.Text = "Principal"
        '
        'TxtPrincipal
        '
        Me.TxtPrincipal.Location = New System.Drawing.Point(183, 27)
        Me.TxtPrincipal.Name = "TxtPrincipal"
        Me.TxtPrincipal.Size = New System.Drawing.Size(100, 22)
        Me.TxtPrincipal.TabIndex = 1
        '
        'LblRate
        '
        Me.LblRate.AutoSize = True
        Me.LblRate.Location = New System.Drawing.Point(72, 92)
        Me.LblRate.Name = "LblRate"
        Me.LblRate.Size = New System.Drawing.Size(38, 17)
        Me.LblRate.TabIndex = 2
        Me.LblRate.Text = "Rate"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Location = New System.Drawing.Point(73, 158)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(39, 17)
        Me.LblTime.TabIndex = 3
        Me.LblTime.Text = "Time"
        '
        'LblInterest
        '
        Me.LblInterest.AutoSize = True
        Me.LblInterest.Location = New System.Drawing.Point(71, 210)
        Me.LblInterest.Name = "LblInterest"
        Me.LblInterest.Size = New System.Drawing.Size(55, 17)
        Me.LblInterest.TabIndex = 4
        Me.LblInterest.Text = "Interest"
        '
        'TxtRate
        '
        Me.TxtRate.Location = New System.Drawing.Point(183, 87)
        Me.TxtRate.Name = "TxtRate"
        Me.TxtRate.Size = New System.Drawing.Size(100, 22)
        Me.TxtRate.TabIndex = 5
        '
        'TxtTime
        '
        Me.TxtTime.Location = New System.Drawing.Point(183, 153)
        Me.TxtTime.Name = "TxtTime"
        Me.TxtTime.Size = New System.Drawing.Size(105, 22)
        Me.TxtTime.TabIndex = 6
        '
        'TxtInterest
        '
        Me.TxtInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInterest.Location = New System.Drawing.Point(183, 210)
        Me.TxtInterest.Name = "TxtInterest"
        Me.TxtInterest.Size = New System.Drawing.Size(100, 22)
        Me.TxtInterest.TabIndex = 7
        Me.TxtInterest.TabStop = False
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(108, 268)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculate.TabIndex = 8
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(189, 268)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 9
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmSimpleInterest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 372)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.TxtInterest)
        Me.Controls.Add(Me.TxtTime)
        Me.Controls.Add(Me.TxtRate)
        Me.Controls.Add(Me.LblInterest)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.LblRate)
        Me.Controls.Add(Me.TxtPrincipal)
        Me.Controls.Add(Me.LblPrincipal)
        Me.Name = "FrmSimpleInterest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPrincipal As Label
    Friend WithEvents TxtPrincipal As TextBox
    Friend WithEvents LblRate As Label
    Friend WithEvents LblTime As Label
    Friend WithEvents LblInterest As Label
    Friend WithEvents TxtRate As TextBox
    Friend WithEvents TxtTime As TextBox
    Friend WithEvents TxtInterest As TextBox
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents BtnReset As Button
End Class
