<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMDI
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewDoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPatientToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewAppoitmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditAppoitmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoctorToolStripMenuItem, Me.PatientToolStripMenuItem, Me.BedToolStripMenuItem, Me.StaffToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'DoctorToolStripMenuItem
        '
        Me.DoctorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewDoctorToolStripMenuItem, Me.EditDoctorToolStripMenuItem})
        Me.DoctorToolStripMenuItem.Name = "DoctorToolStripMenuItem"
        Me.DoctorToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.DoctorToolStripMenuItem.Text = "Doctor"
        '
        'NewDoctorToolStripMenuItem
        '
        Me.NewDoctorToolStripMenuItem.Name = "NewDoctorToolStripMenuItem"
        Me.NewDoctorToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.NewDoctorToolStripMenuItem.Text = "New Doctor"
        '
        'EditDoctorToolStripMenuItem
        '
        Me.EditDoctorToolStripMenuItem.Name = "EditDoctorToolStripMenuItem"
        Me.EditDoctorToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.EditDoctorToolStripMenuItem.Text = "Edit Doctor"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewEditToolStripMenuItem, Me.EditPatientToolStripMenuItem1})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'NewEditToolStripMenuItem
        '
        Me.NewEditToolStripMenuItem.Name = "NewEditToolStripMenuItem"
        Me.NewEditToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.NewEditToolStripMenuItem.Text = "New Patient"
        '
        'EditPatientToolStripMenuItem1
        '
        Me.EditPatientToolStripMenuItem1.Name = "EditPatientToolStripMenuItem1"
        Me.EditPatientToolStripMenuItem1.Size = New System.Drawing.Size(171, 26)
        Me.EditPatientToolStripMenuItem1.Text = "Edit Patient"
        '
        'BedToolStripMenuItem
        '
        Me.BedToolStripMenuItem.Name = "BedToolStripMenuItem"
        Me.BedToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.BedToolStripMenuItem.Text = "Bed"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'TransationToolStripMenuItem
        '
        Me.TransationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewPatientToolStripMenuItem, Me.EditPatientToolStripMenuItem})
        Me.TransationToolStripMenuItem.Name = "TransationToolStripMenuItem"
        Me.TransationToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.TransationToolStripMenuItem.Text = "Transation"
        '
        'NewPatientToolStripMenuItem
        '
        Me.NewPatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewAppoitmentToolStripMenuItem, Me.EditAppoitmentToolStripMenuItem})
        Me.NewPatientToolStripMenuItem.Name = "NewPatientToolStripMenuItem"
        Me.NewPatientToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.NewPatientToolStripMenuItem.Text = "Appoitment"
        '
        'NewAppoitmentToolStripMenuItem
        '
        Me.NewAppoitmentToolStripMenuItem.Name = "NewAppoitmentToolStripMenuItem"
        Me.NewAppoitmentToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.NewAppoitmentToolStripMenuItem.Text = "New Appoitment"
        '
        'EditAppoitmentToolStripMenuItem
        '
        Me.EditAppoitmentToolStripMenuItem.Name = "EditAppoitmentToolStripMenuItem"
        Me.EditAppoitmentToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.EditAppoitmentToolStripMenuItem.Text = "Edit Appoitment"
        '
        'EditPatientToolStripMenuItem
        '
        Me.EditPatientToolStripMenuItem.Name = "EditPatientToolStripMenuItem"
        Me.EditPatientToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.EditPatientToolStripMenuItem.Text = "Edit Patient"
        '
        'FrmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMDI"
        Me.Text = "Clinic Management System v1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoctorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewDoctorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditDoctorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewEditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPatientToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditPatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewAppoitmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditAppoitmentToolStripMenuItem As ToolStripMenuItem
End Class
