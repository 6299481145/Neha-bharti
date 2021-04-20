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
        Me.HostellerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HostellersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdmissionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewHostellersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditHostellersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HostellerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(712, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HostellerToolStripMenuItem
        '
        Me.HostellerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HostellersToolStripMenuItem, Me.MessToolStripMenuItem1, Me.StaffToolStripMenuItem1, Me.RoomToolStripMenuItem1, Me.AdmissionToolStripMenuItem1})
        Me.HostellerToolStripMenuItem.Name = "HostellerToolStripMenuItem"
        Me.HostellerToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.HostellerToolStripMenuItem.Text = "Master"
        '
        'HostellersToolStripMenuItem
        '
        Me.HostellersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewHostellersToolStripMenuItem, Me.EditHostellersToolStripMenuItem})
        Me.HostellersToolStripMenuItem.Name = "HostellersToolStripMenuItem"
        Me.HostellersToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.HostellersToolStripMenuItem.Text = "Hostellers"
        '
        'MessToolStripMenuItem1
        '
        Me.MessToolStripMenuItem1.Name = "MessToolStripMenuItem1"
        Me.MessToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.MessToolStripMenuItem1.Text = "Mess"
        '
        'StaffToolStripMenuItem1
        '
        Me.StaffToolStripMenuItem1.Name = "StaffToolStripMenuItem1"
        Me.StaffToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.StaffToolStripMenuItem1.Text = "Staff"
        '
        'RoomToolStripMenuItem1
        '
        Me.RoomToolStripMenuItem1.Name = "RoomToolStripMenuItem1"
        Me.RoomToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.RoomToolStripMenuItem1.Text = "Room "
        '
        'AdmissionToolStripMenuItem1
        '
        Me.AdmissionToolStripMenuItem1.Name = "AdmissionToolStripMenuItem1"
        Me.AdmissionToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.AdmissionToolStripMenuItem1.Text = "Admission"
        '
        'NewHostellersToolStripMenuItem
        '
        Me.NewHostellersToolStripMenuItem.Name = "NewHostellersToolStripMenuItem"
        Me.NewHostellersToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NewHostellersToolStripMenuItem.Text = "New Hostellers"
        '
        'EditHostellersToolStripMenuItem
        '
        Me.EditHostellersToolStripMenuItem.Name = "EditHostellersToolStripMenuItem"
        Me.EditHostellersToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EditHostellersToolStripMenuItem.Text = "Edit Hostellers"
        '
        'FrmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 473)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMDI"
        Me.Text = "Hostel Management System v1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HostellerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HostellersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MessToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AdmissionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NewHostellersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditHostellersToolStripMenuItem As ToolStripMenuItem
End Class
