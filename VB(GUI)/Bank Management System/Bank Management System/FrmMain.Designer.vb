<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BranchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBranchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditBranchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransationToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(995, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.BranchToolStripMenuItem, Me.AccountTypeToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(68, 26)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewUserToolStripMenuItem, Me.EditUserToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.NewUserToolStripMenuItem.Text = "New User"
        '
        'EditUserToolStripMenuItem
        '
        Me.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        Me.EditUserToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.EditUserToolStripMenuItem.Text = "Edit User"
        '
        'BranchToolStripMenuItem
        '
        Me.BranchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBranchToolStripMenuItem, Me.EditBranchToolStripMenuItem})
        Me.BranchToolStripMenuItem.Name = "BranchToolStripMenuItem"
        Me.BranchToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.BranchToolStripMenuItem.Text = "Branch"
        '
        'NewBranchToolStripMenuItem
        '
        Me.NewBranchToolStripMenuItem.Name = "NewBranchToolStripMenuItem"
        Me.NewBranchToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.NewBranchToolStripMenuItem.Text = "New Branch"
        '
        'EditBranchToolStripMenuItem
        '
        Me.EditBranchToolStripMenuItem.Name = "EditBranchToolStripMenuItem"
        Me.EditBranchToolStripMenuItem.Size = New System.Drawing.Size(171, 26)
        Me.EditBranchToolStripMenuItem.Text = "Edit Branch"
        '
        'AccountTypeToolStripMenuItem
        '
        Me.AccountTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewAccountToolStripMenuItem, Me.EditAccountToolStripMenuItem})
        Me.AccountTypeToolStripMenuItem.Name = "AccountTypeToolStripMenuItem"
        Me.AccountTypeToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.AccountTypeToolStripMenuItem.Text = "Account Type"
        '
        'NewAccountToolStripMenuItem
        '
        Me.NewAccountToolStripMenuItem.Name = "NewAccountToolStripMenuItem"
        Me.NewAccountToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.NewAccountToolStripMenuItem.Text = "New Account Type"
        '
        'EditAccountToolStripMenuItem
        '
        Me.EditAccountToolStripMenuItem.Name = "EditAccountToolStripMenuItem"
        Me.EditAccountToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.EditAccountToolStripMenuItem.Text = " New Account Type"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem, Me.EditCustomerToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.NewCustomerToolStripMenuItem.Text = "New Customer"
        '
        'EditCustomerToolStripMenuItem
        '
        Me.EditCustomerToolStripMenuItem.Name = "EditCustomerToolStripMenuItem"
        Me.EditCustomerToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.EditCustomerToolStripMenuItem.Text = "Edit Customer"
        '
        'TransationToolStripMenuItem
        '
        Me.TransationToolStripMenuItem.Name = "TransationToolStripMenuItem"
        Me.TransationToolStripMenuItem.Size = New System.Drawing.Size(91, 26)
        Me.TransationToolStripMenuItem.Text = "Transation"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(74, 26)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 531)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "Bank Management System v2.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BranchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewBranchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditBranchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
