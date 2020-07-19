<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubtractionApp
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
        Me.LblSubtrahend = New System.Windows.Forms.Label()
        Me.LblMinuend = New System.Windows.Forms.Label()
        Me.LblDifference = New System.Windows.Forms.Label()
        Me.TxtSubtrahend = New System.Windows.Forms.TextBox()
        Me.TxtMinuend = New System.Windows.Forms.TextBox()
        Me.TxtDifference = New System.Windows.Forms.TextBox()
        Me.BtnSubtract = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblSubtrahend
        '
        Me.LblSubtrahend.AutoSize = True
        Me.LblSubtrahend.Location = New System.Drawing.Point(87, 65)
        Me.LblSubtrahend.Name = "LblSubtrahend"
        Me.LblSubtrahend.Size = New System.Drawing.Size(82, 17)
        Me.LblSubtrahend.TabIndex = 0
        Me.LblSubtrahend.Text = "Subtrahend"
        '
        'LblMinuend
        '
        Me.LblMinuend.AutoSize = True
        Me.LblMinuend.Location = New System.Drawing.Point(90, 135)
        Me.LblMinuend.Name = "LblMinuend"
        Me.LblMinuend.Size = New System.Drawing.Size(62, 17)
        Me.LblMinuend.TabIndex = 1
        Me.LblMinuend.Text = "Minuend"
        '
        'LblDifference
        '
        Me.LblDifference.AutoSize = True
        Me.LblDifference.Location = New System.Drawing.Point(91, 202)
        Me.LblDifference.Name = "LblDifference"
        Me.LblDifference.Size = New System.Drawing.Size(73, 17)
        Me.LblDifference.TabIndex = 2
        Me.LblDifference.Text = "Difference"
        '
        'TxtSubtrahend
        '
        Me.TxtSubtrahend.Location = New System.Drawing.Point(224, 63)
        Me.TxtSubtrahend.Name = "TxtSubtrahend"
        Me.TxtSubtrahend.Size = New System.Drawing.Size(100, 22)
        Me.TxtSubtrahend.TabIndex = 3
        '
        'TxtMinuend
        '
        Me.TxtMinuend.Location = New System.Drawing.Point(223, 132)
        Me.TxtMinuend.Name = "TxtMinuend"
        Me.TxtMinuend.Size = New System.Drawing.Size(100, 22)
        Me.TxtMinuend.TabIndex = 4
        '
        'TxtDifference
        '
        Me.TxtDifference.Location = New System.Drawing.Point(225, 200)
        Me.TxtDifference.Name = "TxtDifference"
        Me.TxtDifference.ReadOnly = True
        Me.TxtDifference.Size = New System.Drawing.Size(100, 22)
        Me.TxtDifference.TabIndex = 5
        Me.TxtDifference.TabStop = False
        '
        'BtnSubtract
        '
        Me.BtnSubtract.Location = New System.Drawing.Point(134, 276)
        Me.BtnSubtract.Name = "BtnSubtract"
        Me.BtnSubtract.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubtract.TabIndex = 6
        Me.BtnSubtract.Text = "Subtract"
        Me.BtnSubtract.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(215, 276)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 7
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmSubtractionApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 409)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnSubtract)
        Me.Controls.Add(Me.TxtDifference)
        Me.Controls.Add(Me.TxtMinuend)
        Me.Controls.Add(Me.TxtSubtrahend)
        Me.Controls.Add(Me.LblDifference)
        Me.Controls.Add(Me.LblMinuend)
        Me.Controls.Add(Me.LblSubtrahend)
        Me.Name = "FrmSubtractionApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubtractionApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSubtrahend As Label
    Friend WithEvents LblMinuend As Label
    Friend WithEvents LblDifference As Label
    Friend WithEvents TxtSubtrahend As TextBox
    Friend WithEvents TxtMinuend As TextBox
    Friend WithEvents TxtDifference As TextBox
    Friend WithEvents BtnSubtract As Button
    Friend WithEvents BtnReset As Button
End Class
