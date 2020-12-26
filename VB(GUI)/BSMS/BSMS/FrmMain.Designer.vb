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
        Me.BusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditBusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RouteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TariffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusToolStripMenuItem, Me.RouteToolStripMenuItem, Me.TariffToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.TicketToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BusToolStripMenuItem
        '
        Me.BusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBusToolStripMenuItem, Me.EditBusToolStripMenuItem})
        Me.BusToolStripMenuItem.Name = "BusToolStripMenuItem"
        Me.BusToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.BusToolStripMenuItem.Text = "Bus"
        '
        'NewBusToolStripMenuItem
        '
        Me.NewBusToolStripMenuItem.Name = "NewBusToolStripMenuItem"
        Me.NewBusToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NewBusToolStripMenuItem.Text = "New Bus"
        '
        'EditBusToolStripMenuItem
        '
        Me.EditBusToolStripMenuItem.Name = "EditBusToolStripMenuItem"
        Me.EditBusToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EditBusToolStripMenuItem.Text = "Edit Bus"
        '
        'RouteToolStripMenuItem
        '
        Me.RouteToolStripMenuItem.Name = "RouteToolStripMenuItem"
        Me.RouteToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.RouteToolStripMenuItem.Text = "Route"
        '
        'TariffToolStripMenuItem
        '
        Me.TariffToolStripMenuItem.Name = "TariffToolStripMenuItem"
        Me.TariffToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.TariffToolStripMenuItem.Text = "Tariff"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'TicketToolStripMenuItem
        '
        Me.TicketToolStripMenuItem.Name = "TicketToolStripMenuItem"
        Me.TicketToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.TicketToolStripMenuItem.Text = "Ticket"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.HelpToolStripMenuItem1.Text = "Help Topics"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "Bus Service Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewBusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditBusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RouteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TariffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TicketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
