<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LblYear = New System.Windows.Forms.Label()
        Me.LblShow = New System.Windows.Forms.Label()
        Me.TxtYear = New System.Windows.Forms.TextBox()
        Me.TxtShow = New System.Windows.Forms.TextBox()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblYear
        '
        Me.LblYear.AutoSize = True
        Me.LblYear.Location = New System.Drawing.Point(86, 51)
        Me.LblYear.Name = "LblYear"
        Me.LblYear.Size = New System.Drawing.Size(38, 17)
        Me.LblYear.TabIndex = 0
        Me.LblYear.Text = "Year"
        '
        'LblShow
        '
        Me.LblShow.AutoSize = True
        Me.LblShow.Location = New System.Drawing.Point(86, 124)
        Me.LblShow.Name = "LblShow"
        Me.LblShow.Size = New System.Drawing.Size(42, 17)
        Me.LblShow.TabIndex = 1
        Me.LblShow.Text = "Show"
        '
        'TxtYear
        '
        Me.TxtYear.Location = New System.Drawing.Point(205, 51)
        Me.TxtYear.Multiline = True
        Me.TxtYear.Name = "TxtYear"
        Me.TxtYear.Size = New System.Drawing.Size(119, 29)
        Me.TxtYear.TabIndex = 2
        '
        'TxtShow
        '
        Me.TxtShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtShow.ForeColor = System.Drawing.Color.Green
        Me.TxtShow.Location = New System.Drawing.Point(205, 124)
        Me.TxtShow.Multiline = True
        Me.TxtShow.Name = "TxtShow"
        Me.TxtShow.ReadOnly = True
        Me.TxtShow.Size = New System.Drawing.Size(119, 27)
        Me.TxtShow.TabIndex = 3
        Me.TxtShow.TabStop = False
        '
        'BtnCheck
        '
        Me.BtnCheck.Location = New System.Drawing.Point(127, 191)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(75, 35)
        Me.BtnCheck.TabIndex = 4
        Me.BtnCheck.Text = "Check"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(205, 191)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 35)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 314)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.TxtShow)
        Me.Controls.Add(Me.TxtYear)
        Me.Controls.Add(Me.LblShow)
        Me.Controls.Add(Me.LblYear)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leap Year"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblYear As Label
    Friend WithEvents LblShow As Label
    Friend WithEvents TxtYear As TextBox
    Friend WithEvents TxtShow As TextBox
    Friend WithEvents BtnCheck As Button
    Friend WithEvents BtnReset As Button
End Class
