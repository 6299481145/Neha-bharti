﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditPatient
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
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.LlbBrower = New System.Windows.Forms.LinkLabel()
        Me.PicPhoto = New System.Windows.Forms.PictureBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtContactNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RdbFemale = New System.Windows.Forms.RadioButton()
        Me.RdbMale = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDateOfJoining = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPatientId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        CType(Me.PicPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(298, 358)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 31)
        Me.BtnClose.TabIndex = 60
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(184, 358)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 31)
        Me.BtnReset.TabIndex = 59
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(79, 358)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 31)
        Me.BtnSubmit.TabIndex = 58
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'LlbBrower
        '
        Me.LlbBrower.AutoSize = True
        Me.LlbBrower.Location = New System.Drawing.Point(582, 257)
        Me.LlbBrower.Name = "LlbBrower"
        Me.LlbBrower.Size = New System.Drawing.Size(52, 17)
        Me.LlbBrower.TabIndex = 57
        Me.LlbBrower.TabStop = True
        Me.LlbBrower.Text = "Brower"
        '
        'PicPhoto
        '
        Me.PicPhoto.Location = New System.Drawing.Point(562, 125)
        Me.PicPhoto.Name = "PicPhoto"
        Me.PicPhoto.Size = New System.Drawing.Size(100, 101)
        Me.PicPhoto.TabIndex = 56
        Me.PicPhoto.TabStop = False
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(184, 296)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(224, 22)
        Me.TxtEmail.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Email"
        '
        'TxtContactNo
        '
        Me.TxtContactNo.Location = New System.Drawing.Point(186, 245)
        Me.TxtContactNo.Name = "TxtContactNo"
        Me.TxtContactNo.Size = New System.Drawing.Size(100, 22)
        Me.TxtContactNo.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Contact No."
        '
        'DtpDateOfBirth
        '
        Me.DtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDateOfBirth.Location = New System.Drawing.Point(186, 204)
        Me.DtpDateOfBirth.Name = "DtpDateOfBirth"
        Me.DtpDateOfBirth.Size = New System.Drawing.Size(109, 22)
        Me.DtpDateOfBirth.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Date of Birth"
        '
        'RdbFemale
        '
        Me.RdbFemale.AutoSize = True
        Me.RdbFemale.Location = New System.Drawing.Point(278, 158)
        Me.RdbFemale.Name = "RdbFemale"
        Me.RdbFemale.Size = New System.Drawing.Size(75, 21)
        Me.RdbFemale.TabIndex = 49
        Me.RdbFemale.Text = "Female"
        Me.RdbFemale.UseVisualStyleBackColor = True
        '
        'RdbMale
        '
        Me.RdbMale.AutoSize = True
        Me.RdbMale.Checked = True
        Me.RdbMale.Location = New System.Drawing.Point(185, 158)
        Me.RdbMale.Name = "RdbMale"
        Me.RdbMale.Size = New System.Drawing.Size(59, 21)
        Me.RdbMale.TabIndex = 48
        Me.RdbMale.TabStop = True
        Me.RdbMale.Text = "Male"
        Me.RdbMale.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Gender"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(184, 110)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(224, 22)
        Me.TxtName.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Name"
        '
        'TxtDateOfJoining
        '
        Me.TxtDateOfJoining.Location = New System.Drawing.Point(640, 72)
        Me.TxtDateOfJoining.Name = "TxtDateOfJoining"
        Me.TxtDateOfJoining.Size = New System.Drawing.Size(96, 22)
        Me.TxtDateOfJoining.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(497, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Date of Registration"
        '
        'TxtPatientId
        '
        Me.TxtPatientId.Location = New System.Drawing.Point(184, 62)
        Me.TxtPatientId.Name = "TxtPatientId"
        Me.TxtPatientId.Size = New System.Drawing.Size(100, 22)
        Me.TxtPatientId.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Patient Id"
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(308, 58)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 31)
        Me.BtnSearch.TabIndex = 61
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'FrmEditPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LlbBrower)
        Me.Controls.Add(Me.PicPhoto)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtContactNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtpDateOfBirth)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RdbFemale)
        Me.Controls.Add(Me.RdbMale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDateOfJoining)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPatientId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmEditPatient"
        Me.Text = "Edit Patient"
        CType(Me.PicPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents LlbBrower As LinkLabel
    Friend WithEvents PicPhoto As PictureBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtContactNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpDateOfBirth As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents RdbFemale As RadioButton
    Friend WithEvents RdbMale As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDateOfJoining As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPatientId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSearch As Button
End Class
