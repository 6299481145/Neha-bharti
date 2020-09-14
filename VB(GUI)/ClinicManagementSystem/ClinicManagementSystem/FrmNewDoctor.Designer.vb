<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewDoctor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDoctorId = New System.Windows.Forms.TextBox()
        Me.TxtDateOfJoining = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RdbMale = New System.Windows.Forms.RadioButton()
        Me.RdbFemale = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtContactNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboQualification = New System.Windows.Forms.ComboBox()
        Me.CboSpecialization = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PicPhoto = New System.Windows.Forms.PictureBox()
        Me.LlbBrower = New System.Windows.Forms.LinkLabel()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        CType(Me.PicPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doctor Id"
        '
        'TxtDoctorId
        '
        Me.TxtDoctorId.Location = New System.Drawing.Point(178, 29)
        Me.TxtDoctorId.Name = "TxtDoctorId"
        Me.TxtDoctorId.Size = New System.Drawing.Size(100, 22)
        Me.TxtDoctorId.TabIndex = 1
        '
        'TxtDateOfJoining
        '
        Me.TxtDateOfJoining.Location = New System.Drawing.Point(670, 27)
        Me.TxtDateOfJoining.Name = "TxtDateOfJoining"
        Me.TxtDateOfJoining.Size = New System.Drawing.Size(96, 22)
        Me.TxtDateOfJoining.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(550, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date of Joining"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(178, 77)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(224, 22)
        Me.TxtName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gender"
        '
        'RdbMale
        '
        Me.RdbMale.AutoSize = True
        Me.RdbMale.Location = New System.Drawing.Point(179, 125)
        Me.RdbMale.Name = "RdbMale"
        Me.RdbMale.Size = New System.Drawing.Size(59, 21)
        Me.RdbMale.TabIndex = 7
        Me.RdbMale.TabStop = True
        Me.RdbMale.Text = "Male"
        Me.RdbMale.UseVisualStyleBackColor = True
        '
        'RdbFemale
        '
        Me.RdbFemale.AutoSize = True
        Me.RdbFemale.Location = New System.Drawing.Point(272, 125)
        Me.RdbFemale.Name = "RdbFemale"
        Me.RdbFemale.Size = New System.Drawing.Size(75, 21)
        Me.RdbFemale.TabIndex = 8
        Me.RdbFemale.TabStop = True
        Me.RdbFemale.Text = "Female"
        Me.RdbFemale.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date of Birth"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(180, 171)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(109, 22)
        Me.DateTimePicker1.TabIndex = 10
        '
        'TxtContactNo
        '
        Me.TxtContactNo.Location = New System.Drawing.Point(180, 212)
        Me.TxtContactNo.Name = "TxtContactNo"
        Me.TxtContactNo.Size = New System.Drawing.Size(100, 22)
        Me.TxtContactNo.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Contact No."
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(178, 263)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(224, 22)
        Me.TxtEmail.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Qualification"
        '
        'CboQualification
        '
        Me.CboQualification.FormattingEnabled = True
        Me.CboQualification.Items.AddRange(New Object() {"MBBS", "MD(Medicions)", "FRCS"})
        Me.CboQualification.Location = New System.Drawing.Point(179, 311)
        Me.CboQualification.Name = "CboQualification"
        Me.CboQualification.Size = New System.Drawing.Size(121, 24)
        Me.CboQualification.TabIndex = 16
        '
        'CboSpecialization
        '
        Me.CboSpecialization.FormattingEnabled = True
        Me.CboSpecialization.Location = New System.Drawing.Point(180, 360)
        Me.CboSpecialization.Name = "CboSpecialization"
        Me.CboSpecialization.Size = New System.Drawing.Size(121, 24)
        Me.CboSpecialization.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(59, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Specialization"
        '
        'PicPhoto
        '
        Me.PicPhoto.Location = New System.Drawing.Point(615, 80)
        Me.PicPhoto.Name = "PicPhoto"
        Me.PicPhoto.Size = New System.Drawing.Size(100, 101)
        Me.PicPhoto.TabIndex = 19
        Me.PicPhoto.TabStop = False
        '
        'LlbBrower
        '
        Me.LlbBrower.AutoSize = True
        Me.LlbBrower.Location = New System.Drawing.Point(635, 212)
        Me.LlbBrower.Name = "LlbBrower"
        Me.LlbBrower.Size = New System.Drawing.Size(52, 17)
        Me.LlbBrower.TabIndex = 20
        Me.LlbBrower.TabStop = True
        Me.LlbBrower.Text = "Brower"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(75, 431)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 31)
        Me.BtnSubmit.TabIndex = 21
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(180, 431)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 31)
        Me.BtnReset.TabIndex = 22
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(294, 431)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 31)
        Me.BtnClose.TabIndex = 23
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FrmNewDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 491)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LlbBrower)
        Me.Controls.Add(Me.PicPhoto)
        Me.Controls.Add(Me.CboSpecialization)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CboQualification)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtContactNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RdbFemale)
        Me.Controls.Add(Me.RdbMale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDateOfJoining)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDoctorId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmNewDoctor"
        Me.Text = "New Doctor"
        CType(Me.PicPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDoctorId As TextBox
    Friend WithEvents TxtDateOfJoining As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RdbMale As RadioButton
    Friend WithEvents RdbFemale As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TxtContactNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CboQualification As ComboBox
    Friend WithEvents CboSpecialization As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PicPhoto As PictureBox
    Friend WithEvents LlbBrower As LinkLabel
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnClose As Button
End Class
