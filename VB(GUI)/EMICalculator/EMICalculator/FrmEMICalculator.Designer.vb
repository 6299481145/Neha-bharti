﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEMICalculator
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblPrinciple = New System.Windows.Forms.Label()
        Me.TxtPrinciple = New System.Windows.Forms.TextBox()
        Me.TxtTenure = New System.Windows.Forms.TextBox()
        Me.LblTenure = New System.Windows.Forms.Label()
        Me.TxtInterestRate = New System.Windows.Forms.TextBox()
        Me.LblInterestRate = New System.Windows.Forms.Label()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.EMI = New System.Windows.Forms.Label()
        Me.LblEMI = New System.Windows.Forms.Label()
        Me.LblTotalPrinciple = New System.Windows.Forms.Label()
        Me.TxtTotalPrinciple = New System.Windows.Forms.Label()
        Me.LblTotalInterest = New System.Windows.Forms.Label()
        Me.TxtTotalInterest = New System.Windows.Forms.Label()
        Me.LblTotalPaybleAmount = New System.Windows.Forms.Label()
        Me.TxtTotalPaybleAmount = New System.Windows.Forms.Label()
        Me.DgvAmortizationSchedule = New System.Windows.Forms.DataGridView()
        Me.Year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpeningBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMI12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InterestPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Principle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClosingBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvAmortizationSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnReset)
        Me.GroupBox1.Controls.Add(Me.BtnCalculate)
        Me.GroupBox1.Controls.Add(Me.TxtInterestRate)
        Me.GroupBox1.Controls.Add(Me.LblInterestRate)
        Me.GroupBox1.Controls.Add(Me.TxtTenure)
        Me.GroupBox1.Controls.Add(Me.LblTenure)
        Me.GroupBox1.Controls.Add(Me.TxtPrinciple)
        Me.GroupBox1.Controls.Add(Me.LblPrinciple)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMI Calculation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvAmortizationSchedule)
        Me.GroupBox2.Location = New System.Drawing.Point(46, 342)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(859, 362)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Amortization Schedule"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblTotalPaybleAmount)
        Me.GroupBox3.Controls.Add(Me.TxtTotalPaybleAmount)
        Me.GroupBox3.Controls.Add(Me.LblTotalInterest)
        Me.GroupBox3.Controls.Add(Me.TxtTotalInterest)
        Me.GroupBox3.Controls.Add(Me.LblTotalPrinciple)
        Me.GroupBox3.Controls.Add(Me.TxtTotalPrinciple)
        Me.GroupBox3.Controls.Add(Me.LblEMI)
        Me.GroupBox3.Controls.Add(Me.EMI)
        Me.GroupBox3.Location = New System.Drawing.Point(554, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(351, 216)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "EMI Details"
        '
        'LblPrinciple
        '
        Me.LblPrinciple.AutoSize = True
        Me.LblPrinciple.Location = New System.Drawing.Point(26, 39)
        Me.LblPrinciple.Name = "LblPrinciple"
        Me.LblPrinciple.Size = New System.Drawing.Size(62, 17)
        Me.LblPrinciple.TabIndex = 0
        Me.LblPrinciple.Text = "Principle"
        '
        'TxtPrinciple
        '
        Me.TxtPrinciple.Location = New System.Drawing.Point(143, 37)
        Me.TxtPrinciple.Name = "TxtPrinciple"
        Me.TxtPrinciple.Size = New System.Drawing.Size(100, 22)
        Me.TxtPrinciple.TabIndex = 1
        '
        'TxtTenure
        '
        Me.TxtTenure.Location = New System.Drawing.Point(143, 93)
        Me.TxtTenure.Name = "TxtTenure"
        Me.TxtTenure.Size = New System.Drawing.Size(100, 22)
        Me.TxtTenure.TabIndex = 3
        '
        'LblTenure
        '
        Me.LblTenure.AutoSize = True
        Me.LblTenure.Location = New System.Drawing.Point(26, 95)
        Me.LblTenure.Name = "LblTenure"
        Me.LblTenure.Size = New System.Drawing.Size(54, 17)
        Me.LblTenure.TabIndex = 2
        Me.LblTenure.Text = "Tenure"
        '
        'TxtInterestRate
        '
        Me.TxtInterestRate.Location = New System.Drawing.Point(143, 144)
        Me.TxtInterestRate.Name = "TxtInterestRate"
        Me.TxtInterestRate.Size = New System.Drawing.Size(100, 22)
        Me.TxtInterestRate.TabIndex = 5
        '
        'LblInterestRate
        '
        Me.LblInterestRate.AutoSize = True
        Me.LblInterestRate.Location = New System.Drawing.Point(26, 146)
        Me.LblInterestRate.Name = "LblInterestRate"
        Me.LblInterestRate.Size = New System.Drawing.Size(89, 17)
        Me.LblInterestRate.TabIndex = 4
        Me.LblInterestRate.Text = "Interest Rate"
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(289, 37)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(84, 33)
        Me.BtnCalculate.TabIndex = 6
        Me.BtnCalculate.Text = "&Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(289, 85)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(84, 30)
        Me.BtnReset.TabIndex = 7
        Me.BtnReset.Text = "&Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'EMI
        '
        Me.EMI.AutoSize = True
        Me.EMI.Location = New System.Drawing.Point(46, 53)
        Me.EMI.Name = "EMI"
        Me.EMI.Size = New System.Drawing.Size(31, 17)
        Me.EMI.TabIndex = 0
        Me.EMI.Text = "EMI"
        '
        'LblEMI
        '
        Me.LblEMI.AutoSize = True
        Me.LblEMI.Location = New System.Drawing.Point(223, 53)
        Me.LblEMI.Name = "LblEMI"
        Me.LblEMI.Size = New System.Drawing.Size(16, 17)
        Me.LblEMI.TabIndex = 1
        Me.LblEMI.Text = "0"
        '
        'LblTotalPrinciple
        '
        Me.LblTotalPrinciple.AutoSize = True
        Me.LblTotalPrinciple.Location = New System.Drawing.Point(223, 95)
        Me.LblTotalPrinciple.Name = "LblTotalPrinciple"
        Me.LblTotalPrinciple.Size = New System.Drawing.Size(16, 17)
        Me.LblTotalPrinciple.TabIndex = 3
        Me.LblTotalPrinciple.Text = "0"
        '
        'TxtTotalPrinciple
        '
        Me.TxtTotalPrinciple.AutoSize = True
        Me.TxtTotalPrinciple.Location = New System.Drawing.Point(46, 95)
        Me.TxtTotalPrinciple.Name = "TxtTotalPrinciple"
        Me.TxtTotalPrinciple.Size = New System.Drawing.Size(98, 17)
        Me.TxtTotalPrinciple.TabIndex = 2
        Me.TxtTotalPrinciple.Text = "Total Principal"
        '
        'LblTotalInterest
        '
        Me.LblTotalInterest.AutoSize = True
        Me.LblTotalInterest.Location = New System.Drawing.Point(223, 135)
        Me.LblTotalInterest.Name = "LblTotalInterest"
        Me.LblTotalInterest.Size = New System.Drawing.Size(16, 17)
        Me.LblTotalInterest.TabIndex = 5
        Me.LblTotalInterest.Text = "0"
        '
        'TxtTotalInterest
        '
        Me.TxtTotalInterest.AutoSize = True
        Me.TxtTotalInterest.Location = New System.Drawing.Point(46, 135)
        Me.TxtTotalInterest.Name = "TxtTotalInterest"
        Me.TxtTotalInterest.Size = New System.Drawing.Size(91, 17)
        Me.TxtTotalInterest.TabIndex = 4
        Me.TxtTotalInterest.Text = "Total interest"
        '
        'LblTotalPaybleAmount
        '
        Me.LblTotalPaybleAmount.AutoSize = True
        Me.LblTotalPaybleAmount.Location = New System.Drawing.Point(225, 178)
        Me.LblTotalPaybleAmount.Name = "LblTotalPaybleAmount"
        Me.LblTotalPaybleAmount.Size = New System.Drawing.Size(16, 17)
        Me.LblTotalPaybleAmount.TabIndex = 7
        Me.LblTotalPaybleAmount.Text = "0"
        '
        'TxtTotalPaybleAmount
        '
        Me.TxtTotalPaybleAmount.AutoSize = True
        Me.TxtTotalPaybleAmount.Location = New System.Drawing.Point(49, 178)
        Me.TxtTotalPaybleAmount.Name = "TxtTotalPaybleAmount"
        Me.TxtTotalPaybleAmount.Size = New System.Drawing.Size(139, 17)
        Me.TxtTotalPaybleAmount.TabIndex = 6
        Me.TxtTotalPaybleAmount.Text = "Total Payble Amount"
        '
        'DgvAmortizationSchedule
        '
        Me.DgvAmortizationSchedule.AllowUserToAddRows = False
        Me.DgvAmortizationSchedule.AllowUserToDeleteRows = False
        Me.DgvAmortizationSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAmortizationSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Year, Me.OpeningBalance, Me.EMI12, Me.InterestPaid, Me.Principle, Me.ClosingBalance})
        Me.DgvAmortizationSchedule.Location = New System.Drawing.Point(22, 21)
        Me.DgvAmortizationSchedule.Name = "DgvAmortizationSchedule"
        Me.DgvAmortizationSchedule.ReadOnly = True
        Me.DgvAmortizationSchedule.RowHeadersWidth = 51
        Me.DgvAmortizationSchedule.RowTemplate.Height = 24
        Me.DgvAmortizationSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAmortizationSchedule.Size = New System.Drawing.Size(805, 324)
        Me.DgvAmortizationSchedule.TabIndex = 0
        '
        'Year
        '
        Me.Year.HeaderText = "Year"
        Me.Year.MinimumWidth = 6
        Me.Year.Name = "Year"
        Me.Year.ReadOnly = True
        Me.Year.Width = 125
        '
        'OpeningBalance
        '
        Me.OpeningBalance.HeaderText = "Opening Balance"
        Me.OpeningBalance.MinimumWidth = 6
        Me.OpeningBalance.Name = "OpeningBalance"
        Me.OpeningBalance.ReadOnly = True
        Me.OpeningBalance.Width = 125
        '
        'EMI12
        '
        Me.EMI12.HeaderText = "EMI * 12"
        Me.EMI12.MinimumWidth = 6
        Me.EMI12.Name = "EMI12"
        Me.EMI12.ReadOnly = True
        Me.EMI12.Width = 125
        '
        'InterestPaid
        '
        Me.InterestPaid.HeaderText = "Interest Paid (Yearly)"
        Me.InterestPaid.MinimumWidth = 6
        Me.InterestPaid.Name = "InterestPaid"
        Me.InterestPaid.ReadOnly = True
        Me.InterestPaid.Width = 125
        '
        'Principle
        '
        Me.Principle.HeaderText = "Principle (Yearly)"
        Me.Principle.MinimumWidth = 6
        Me.Principle.Name = "Principle"
        Me.Principle.ReadOnly = True
        Me.Principle.Width = 125
        '
        'ClosingBalance
        '
        Me.ClosingBalance.HeaderText = "Closing Balance"
        Me.ClosingBalance.MinimumWidth = 6
        Me.ClosingBalance.Name = "ClosingBalance"
        Me.ClosingBalance.ReadOnly = True
        Me.ClosingBalance.Width = 125
        '
        'FrmEMICalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 759)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmEMICalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMI Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DgvAmortizationSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents TxtInterestRate As TextBox
    Friend WithEvents LblInterestRate As Label
    Friend WithEvents TxtTenure As TextBox
    Friend WithEvents LblTenure As Label
    Friend WithEvents TxtPrinciple As TextBox
    Friend WithEvents LblPrinciple As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvAmortizationSchedule As DataGridView
    Friend WithEvents Year As DataGridViewTextBoxColumn
    Friend WithEvents OpeningBalance As DataGridViewTextBoxColumn
    Friend WithEvents EMI12 As DataGridViewTextBoxColumn
    Friend WithEvents InterestPaid As DataGridViewTextBoxColumn
    Friend WithEvents Principle As DataGridViewTextBoxColumn
    Friend WithEvents ClosingBalance As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LblTotalPaybleAmount As Label
    Friend WithEvents TxtTotalPaybleAmount As Label
    Friend WithEvents LblTotalInterest As Label
    Friend WithEvents TxtTotalInterest As Label
    Friend WithEvents LblTotalPrinciple As Label
    Friend WithEvents TxtTotalPrinciple As Label
    Friend WithEvents LblEMI As Label
    Friend WithEvents EMI As Label
End Class
