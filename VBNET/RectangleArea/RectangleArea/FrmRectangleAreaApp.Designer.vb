<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRectangleAreaApp
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
        Me.LblLength = New System.Windows.Forms.Label()
        Me.LblBreath = New System.Windows.Forms.Label()
        Me.TxtLength = New System.Windows.Forms.TextBox()
        Me.TxtBreath = New System.Windows.Forms.TextBox()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.LblArea = New System.Windows.Forms.Label()
        Me.TxtArea = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblLength
        '
        Me.LblLength.AutoSize = True
        Me.LblLength.Location = New System.Drawing.Point(80, 52)
        Me.LblLength.Name = "LblLength"
        Me.LblLength.Size = New System.Drawing.Size(52, 17)
        Me.LblLength.TabIndex = 0
        Me.LblLength.Text = "Length"
        '
        'LblBreath
        '
        Me.LblBreath.AutoSize = True
        Me.LblBreath.Location = New System.Drawing.Point(80, 110)
        Me.LblBreath.Name = "LblBreath"
        Me.LblBreath.Size = New System.Drawing.Size(50, 17)
        Me.LblBreath.TabIndex = 1
        Me.LblBreath.Text = "Breath"
        '
        'TxtLength
        '
        Me.TxtLength.Location = New System.Drawing.Point(202, 49)
        Me.TxtLength.Name = "TxtLength"
        Me.TxtLength.Size = New System.Drawing.Size(100, 22)
        Me.TxtLength.TabIndex = 2
        '
        'TxtBreath
        '
        Me.TxtBreath.Location = New System.Drawing.Point(203, 110)
        Me.TxtBreath.Name = "TxtBreath"
        Me.TxtBreath.Size = New System.Drawing.Size(100, 22)
        Me.TxtBreath.TabIndex = 3
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(115, 234)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 33)
        Me.BtnCalculate.TabIndex = 4
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(199, 234)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 33)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'LblArea
        '
        Me.LblArea.AutoSize = True
        Me.LblArea.Location = New System.Drawing.Point(83, 173)
        Me.LblArea.Name = "LblArea"
        Me.LblArea.Size = New System.Drawing.Size(38, 17)
        Me.LblArea.TabIndex = 6
        Me.LblArea.Text = "Area"
        '
        'TxtArea
        '
        Me.TxtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtArea.Location = New System.Drawing.Point(203, 173)
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.ReadOnly = True
        Me.TxtArea.Size = New System.Drawing.Size(100, 22)
        Me.TxtArea.TabIndex = 7
        Me.TxtArea.TabStop = False
        '
        'FrmRectangleAreaApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 372)
        Me.Controls.Add(Me.TxtArea)
        Me.Controls.Add(Me.LblArea)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.TxtBreath)
        Me.Controls.Add(Me.TxtLength)
        Me.Controls.Add(Me.LblBreath)
        Me.Controls.Add(Me.LblLength)
        Me.Name = "FrmRectangleAreaApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RectangleAreaApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblLength As Label
    Friend WithEvents LblBreath As Label
    Friend WithEvents TxtLength As TextBox
    Friend WithEvents TxtBreath As TextBox
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents LblArea As Label
    Friend WithEvents TxtArea As TextBox
End Class
