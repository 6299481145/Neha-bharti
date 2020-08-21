<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCubeRoot
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
        Me.LblResult = New System.Windows.Forms.Label()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.TxtResult = New System.Windows.Forms.TextBox()
        Me.BtnCube = New System.Windows.Forms.Button()
        Me.BtnCubeRoot = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNumber
        '
        Me.LblNumber.AutoSize = True
        Me.LblNumber.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumber.Location = New System.Drawing.Point(84, 52)
        Me.LblNumber.Name = "LblNumber"
        Me.LblNumber.Size = New System.Drawing.Size(128, 31)
        Me.LblNumber.TabIndex = 0
        Me.LblNumber.Text = "Number"
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResult.Location = New System.Drawing.Point(90, 131)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(103, 31)
        Me.LblResult.TabIndex = 1
        Me.LblResult.Text = "Result"
        '
        'TxtNumber
        '
        Me.TxtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumber.Location = New System.Drawing.Point(251, 48)
        Me.TxtNumber.Multiline = True
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(112, 33)
        Me.TxtNumber.TabIndex = 2
        '
        'TxtResult
        '
        Me.TxtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResult.Location = New System.Drawing.Point(251, 127)
        Me.TxtResult.Multiline = True
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(112, 34)
        Me.TxtResult.TabIndex = 3
        '
        'BtnCube
        '
        Me.BtnCube.Font = New System.Drawing.Font("Lucida Handwriting", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCube.ForeColor = System.Drawing.Color.Black
        Me.BtnCube.Location = New System.Drawing.Point(118, 210)
        Me.BtnCube.Name = "BtnCube"
        Me.BtnCube.Size = New System.Drawing.Size(85, 32)
        Me.BtnCube.TabIndex = 4
        Me.BtnCube.Text = "Cube"
        Me.BtnCube.UseVisualStyleBackColor = True
        '
        'BtnCubeRoot
        '
        Me.BtnCubeRoot.Font = New System.Drawing.Font("Lucida Handwriting", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCubeRoot.ForeColor = System.Drawing.Color.Black
        Me.BtnCubeRoot.Location = New System.Drawing.Point(209, 210)
        Me.BtnCubeRoot.Name = "BtnCubeRoot"
        Me.BtnCubeRoot.Size = New System.Drawing.Size(154, 32)
        Me.BtnCubeRoot.TabIndex = 5
        Me.BtnCubeRoot.Text = "Cube Root"
        Me.BtnCubeRoot.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("Lucida Handwriting", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.Black
        Me.BtnReset.Location = New System.Drawing.Point(203, 268)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(100, 34)
        Me.BtnReset.TabIndex = 6
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmCubeRoot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(477, 417)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnCubeRoot)
        Me.Controls.Add(Me.BtnCube)
        Me.Controls.Add(Me.TxtResult)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.LblNumber)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "FrmCubeRoot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cube Root"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNumber As Label
    Friend WithEvents LblResult As Label
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents TxtResult As TextBox
    Friend WithEvents BtnCube As Button
    Friend WithEvents BtnCubeRoot As Button
    Friend WithEvents BtnReset As Button
End Class
