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
        Me.ConsumerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarrifEnergyChargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TariffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewConsumerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditConsumerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransationToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsumerToolStripMenuItem, Me.TarrifEnergyChargeToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'ConsumerToolStripMenuItem
        '
        Me.ConsumerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewConsumerToolStripMenuItem, Me.EditConsumerToolStripMenuItem})
        Me.ConsumerToolStripMenuItem.Name = "ConsumerToolStripMenuItem"
        Me.ConsumerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ConsumerToolStripMenuItem.Text = "Consumer"
        '
        'TarrifEnergyChargeToolStripMenuItem
        '
        Me.TarrifEnergyChargeToolStripMenuItem.Name = "TarrifEnergyChargeToolStripMenuItem"
        Me.TarrifEnergyChargeToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TarrifEnergyChargeToolStripMenuItem.Text = "Tarrif Energy charge"
        '
        'TransationToolStripMenuItem
        '
        Me.TransationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillToolStripMenuItem})
        Me.TransationToolStripMenuItem.Name = "TransationToolStripMenuItem"
        Me.TransationToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.TransationToolStripMenuItem.Text = "Transation"
        '
        'BillToolStripMenuItem
        '
        Me.BillToolStripMenuItem.Name = "BillToolStripMenuItem"
        Me.BillToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BillToolStripMenuItem.Text = "Bill"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TariffToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'TariffToolStripMenuItem
        '
        Me.TariffToolStripMenuItem.Name = "TariffToolStripMenuItem"
        Me.TariffToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TariffToolStripMenuItem.Text = "Tariff"
        '
        'NewConsumerToolStripMenuItem
        '
        Me.NewConsumerToolStripMenuItem.Name = "NewConsumerToolStripMenuItem"
        Me.NewConsumerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NewConsumerToolStripMenuItem.Text = "New Consumer"
        '
        'EditConsumerToolStripMenuItem
        '
        Me.EditConsumerToolStripMenuItem.Name = "EditConsumerToolStripMenuItem"
        Me.EditConsumerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EditConsumerToolStripMenuItem.Text = "Edit Consumer"
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
        Me.Text = "Electricity Billing System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsumerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarrifEnergyChargeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TariffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewConsumerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditConsumerToolStripMenuItem As ToolStripMenuItem
End Class
