<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewBus
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
        Me.LblRegistrationNumber = New System.Windows.Forms.Label()
        Me.TxtRegistrationNumber = New System.Windows.Forms.TextBox()
        Me.TxtDateAdded = New System.Windows.Forms.TextBox()
        Me.LblDateAdded = New System.Windows.Forms.Label()
        Me.LblMake = New System.Windows.Forms.Label()
        Me.LblModel = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.CboMake = New System.Windows.Forms.ComboBox()
        Me.CboModel = New System.Windows.Forms.ComboBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblRegistrationNumber
        '
        Me.LblRegistrationNumber.AutoSize = True
        Me.LblRegistrationNumber.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistrationNumber.Location = New System.Drawing.Point(75, 66)
        Me.LblRegistrationNumber.Name = "LblRegistrationNumber"
        Me.LblRegistrationNumber.Size = New System.Drawing.Size(197, 22)
        Me.LblRegistrationNumber.TabIndex = 0
        Me.LblRegistrationNumber.Text = "Registration Number"
        '
        'TxtRegistrationNumber
        '
        Me.TxtRegistrationNumber.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegistrationNumber.Location = New System.Drawing.Point(324, 63)
        Me.TxtRegistrationNumber.Name = "TxtRegistrationNumber"
        Me.TxtRegistrationNumber.Size = New System.Drawing.Size(158, 29)
        Me.TxtRegistrationNumber.TabIndex = 1
        '
        'TxtDateAdded
        '
        Me.TxtDateAdded.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDateAdded.Location = New System.Drawing.Point(788, 56)
        Me.TxtDateAdded.Name = "TxtDateAdded"
        Me.TxtDateAdded.ReadOnly = True
        Me.TxtDateAdded.Size = New System.Drawing.Size(121, 29)
        Me.TxtDateAdded.TabIndex = 3
        Me.TxtDateAdded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblDateAdded
        '
        Me.LblDateAdded.AutoSize = True
        Me.LblDateAdded.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateAdded.Location = New System.Drawing.Point(614, 63)
        Me.LblDateAdded.Name = "LblDateAdded"
        Me.LblDateAdded.Size = New System.Drawing.Size(115, 22)
        Me.LblDateAdded.TabIndex = 2
        Me.LblDateAdded.Text = "Date Added"
        '
        'LblMake
        '
        Me.LblMake.AutoSize = True
        Me.LblMake.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMake.Location = New System.Drawing.Point(75, 129)
        Me.LblMake.Name = "LblMake"
        Me.LblMake.Size = New System.Drawing.Size(59, 22)
        Me.LblMake.TabIndex = 4
        Me.LblMake.Text = "Make"
        '
        'LblModel
        '
        Me.LblModel.AutoSize = True
        Me.LblModel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModel.Location = New System.Drawing.Point(75, 192)
        Me.LblModel.Name = "LblModel"
        Me.LblModel.Size = New System.Drawing.Size(65, 22)
        Me.LblModel.TabIndex = 5
        Me.LblModel.Text = "Model"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(79, 287)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(96, 35)
        Me.BtnSubmit.TabIndex = 6
        Me.BtnSubmit.Text = "&Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'CboMake
        '
        Me.CboMake.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMake.FormattingEnabled = True
        Me.CboMake.Location = New System.Drawing.Point(324, 126)
        Me.CboMake.Name = "CboMake"
        Me.CboMake.Size = New System.Drawing.Size(158, 30)
        Me.CboMake.TabIndex = 7
        '
        'CboModel
        '
        Me.CboModel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboModel.FormattingEnabled = True
        Me.CboModel.Location = New System.Drawing.Point(324, 184)
        Me.CboModel.Name = "CboModel"
        Me.CboModel.Size = New System.Drawing.Size(158, 30)
        Me.CboModel.TabIndex = 8
        '
        'BtnReset
        '
        Me.BtnReset.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Location = New System.Drawing.Point(249, 287)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(101, 35)
        Me.BtnReset.TabIndex = 9
        Me.BtnReset.Text = "&Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'FrmNewBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 450)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.CboModel)
        Me.Controls.Add(Me.CboMake)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LblModel)
        Me.Controls.Add(Me.LblMake)
        Me.Controls.Add(Me.TxtDateAdded)
        Me.Controls.Add(Me.LblDateAdded)
        Me.Controls.Add(Me.TxtRegistrationNumber)
        Me.Controls.Add(Me.LblRegistrationNumber)
        Me.Name = "FrmNewBus"
        Me.Text = "New Bus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblRegistrationNumber As Label
    Friend WithEvents TxtRegistrationNumber As TextBox
    Friend WithEvents TxtDateAdded As TextBox
    Friend WithEvents LblDateAdded As Label
    Friend WithEvents LblMake As Label
    Friend WithEvents LblModel As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents CboMake As ComboBox
    Friend WithEvents CboModel As ComboBox
    Friend WithEvents BtnReset As Button
End Class
