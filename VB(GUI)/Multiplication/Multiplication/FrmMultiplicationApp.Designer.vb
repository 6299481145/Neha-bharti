<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMultiplicationApp
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
        Me.LblFactor1 = New System.Windows.Forms.Label()
        Me.LblFactor2 = New System.Windows.Forms.Label()
        Me.LblProduct = New System.Windows.Forms.Label()
        Me.TxtFactor1 = New System.Windows.Forms.TextBox()
        Me.TxtFactor2 = New System.Windows.Forms.TextBox()
        Me.TxtProduct = New System.Windows.Forms.TextBox()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblFactor1
        '
        Me.LblFactor1.AutoSize = True
        Me.LblFactor1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFactor1.ForeColor = System.Drawing.Color.Black
        Me.LblFactor1.Location = New System.Drawing.Point(74, 51)
        Me.LblFactor1.Name = "LblFactor1"
        Me.LblFactor1.Size = New System.Drawing.Size(79, 21)
        Me.LblFactor1.TabIndex = 0
        Me.LblFactor1.Text = "Factor1"
        '
        'LblFactor2
        '
        Me.LblFactor2.AutoSize = True
        Me.LblFactor2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFactor2.ForeColor = System.Drawing.Color.Black
        Me.LblFactor2.Location = New System.Drawing.Point(71, 126)
        Me.LblFactor2.Name = "LblFactor2"
        Me.LblFactor2.Size = New System.Drawing.Size(79, 21)
        Me.LblFactor2.TabIndex = 1
        Me.LblFactor2.Text = "Factor2"
        '
        'LblProduct
        '
        Me.LblProduct.AutoSize = True
        Me.LblProduct.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProduct.ForeColor = System.Drawing.Color.Black
        Me.LblProduct.Location = New System.Drawing.Point(70, 196)
        Me.LblProduct.Name = "LblProduct"
        Me.LblProduct.Size = New System.Drawing.Size(80, 21)
        Me.LblProduct.TabIndex = 2
        Me.LblProduct.Text = "Product"
        '
        'TxtFactor1
        '
        Me.TxtFactor1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFactor1.Location = New System.Drawing.Point(207, 47)
        Me.TxtFactor1.Name = "TxtFactor1"
        Me.TxtFactor1.Size = New System.Drawing.Size(100, 31)
        Me.TxtFactor1.TabIndex = 3
        '
        'TxtFactor2
        '
        Me.TxtFactor2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFactor2.Location = New System.Drawing.Point(207, 123)
        Me.TxtFactor2.Name = "TxtFactor2"
        Me.TxtFactor2.Size = New System.Drawing.Size(100, 31)
        Me.TxtFactor2.TabIndex = 4
        '
        'TxtProduct
        '
        Me.TxtProduct.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProduct.Location = New System.Drawing.Point(207, 187)
        Me.TxtProduct.Name = "TxtProduct"
        Me.TxtProduct.ReadOnly = True
        Me.TxtProduct.Size = New System.Drawing.Size(100, 31)
        Me.TxtProduct.TabIndex = 5
        Me.TxtProduct.TabStop = False
        '
        'BtnFind
        '
        Me.BtnFind.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.Location = New System.Drawing.Point(106, 262)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(83, 38)
        Me.BtnFind.TabIndex = 6
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(195, 264)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(86, 36)
        Me.BtnReset.TabIndex = 7
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmMultiplicationApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(409, 389)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnFind)
        Me.Controls.Add(Me.TxtProduct)
        Me.Controls.Add(Me.TxtFactor2)
        Me.Controls.Add(Me.TxtFactor1)
        Me.Controls.Add(Me.LblProduct)
        Me.Controls.Add(Me.LblFactor2)
        Me.Controls.Add(Me.LblFactor1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "FrmMultiplicationApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MultiplicationApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFactor1 As Label
    Friend WithEvents LblFactor2 As Label
    Friend WithEvents LblProduct As Label
    Friend WithEvents TxtFactor1 As TextBox
    Friend WithEvents TxtFactor2 As TextBox
    Friend WithEvents TxtProduct As TextBox
    Friend WithEvents BtnFind As Button
    Friend WithEvents BtnReset As Button
End Class
