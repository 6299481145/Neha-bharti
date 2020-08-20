<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSqureRoot
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
        Me.BtnSqure = New System.Windows.Forms.Button()
        Me.BtnSqureRoot = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNumber
        '
        Me.LblNumber.AutoSize = True
        Me.LblNumber.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumber.Location = New System.Drawing.Point(85, 61)
        Me.LblNumber.Name = "LblNumber"
        Me.LblNumber.Size = New System.Drawing.Size(128, 31)
        Me.LblNumber.TabIndex = 0
        Me.LblNumber.Text = "Number"
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResult.Location = New System.Drawing.Point(95, 132)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(103, 31)
        Me.LblResult.TabIndex = 1
        Me.LblResult.Text = "Result"
        '
        'TxtNumber
        '
        Me.TxtNumber.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumber.Location = New System.Drawing.Point(273, 57)
        Me.TxtNumber.Multiline = True
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(102, 35)
        Me.TxtNumber.TabIndex = 2
        '
        'TxtResult
        '
        Me.TxtResult.Font = New System.Drawing.Font("Lucida Handwriting", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResult.Location = New System.Drawing.Point(275, 129)
        Me.TxtResult.Multiline = True
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(100, 34)
        Me.TxtResult.TabIndex = 3
        '
        'BtnSqure
        '
        Me.BtnSqure.Font = New System.Drawing.Font("Lucida Handwriting", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSqure.ForeColor = System.Drawing.Color.Black
        Me.BtnSqure.Location = New System.Drawing.Point(114, 205)
        Me.BtnSqure.Name = "BtnSqure"
        Me.BtnSqure.Size = New System.Drawing.Size(99, 39)
        Me.BtnSqure.TabIndex = 4
        Me.BtnSqure.Text = "Squre"
        Me.BtnSqure.UseVisualStyleBackColor = True
        '
        'BtnSqureRoot
        '
        Me.BtnSqureRoot.Font = New System.Drawing.Font("Lucida Handwriting", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSqureRoot.ForeColor = System.Drawing.Color.Black
        Me.BtnSqureRoot.Location = New System.Drawing.Point(219, 205)
        Me.BtnSqureRoot.Name = "BtnSqureRoot"
        Me.BtnSqureRoot.Size = New System.Drawing.Size(156, 39)
        Me.BtnSqureRoot.TabIndex = 5
        Me.BtnSqureRoot.Text = "Squre Root"
        Me.BtnSqureRoot.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("Lucida Handwriting", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.Black
        Me.BtnReset.Location = New System.Drawing.Point(197, 267)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(88, 40)
        Me.BtnReset.TabIndex = 6
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmSqureRoot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(440, 367)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnSqureRoot)
        Me.Controls.Add(Me.BtnSqure)
        Me.Controls.Add(Me.TxtResult)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.LblNumber)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "FrmSqureRoot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Squre Root"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNumber As Label
    Friend WithEvents LblResult As Label
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents TxtResult As TextBox
    Friend WithEvents BtnSqure As Button
    Friend WithEvents BtnSqureRoot As Button
    Friend WithEvents BtnReset As Button
End Class
