﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDivisionApp
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
        Me.LblDividend = New System.Windows.Forms.Label()
        Me.LblDivisior = New System.Windows.Forms.Label()
        Me.LblQuotient = New System.Windows.Forms.Label()
        Me.TxtDividend = New System.Windows.Forms.TextBox()
        Me.TxtDivisior = New System.Windows.Forms.TextBox()
        Me.TxtQuotient = New System.Windows.Forms.TextBox()
        Me.BtnDivide = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.LblRemainder = New System.Windows.Forms.Label()
        Me.TxtRemainder = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblDividend
        '
        Me.LblDividend.AutoSize = True
        Me.LblDividend.Location = New System.Drawing.Point(101, 58)
        Me.LblDividend.Name = "LblDividend"
        Me.LblDividend.Size = New System.Drawing.Size(63, 17)
        Me.LblDividend.TabIndex = 0
        Me.LblDividend.Text = "Dividend"
        '
        'LblDivisior
        '
        Me.LblDivisior.AutoSize = True
        Me.LblDivisior.Location = New System.Drawing.Point(100, 127)
        Me.LblDivisior.Name = "LblDivisior"
        Me.LblDivisior.Size = New System.Drawing.Size(54, 17)
        Me.LblDivisior.TabIndex = 1
        Me.LblDivisior.Text = "Divisior"
        '
        'LblQuotient
        '
        Me.LblQuotient.AutoSize = True
        Me.LblQuotient.Location = New System.Drawing.Point(100, 191)
        Me.LblQuotient.Name = "LblQuotient"
        Me.LblQuotient.Size = New System.Drawing.Size(62, 17)
        Me.LblQuotient.TabIndex = 2
        Me.LblQuotient.Text = "Quotient"
        '
        'TxtDividend
        '
        Me.TxtDividend.Location = New System.Drawing.Point(221, 53)
        Me.TxtDividend.Name = "TxtDividend"
        Me.TxtDividend.Size = New System.Drawing.Size(100, 22)
        Me.TxtDividend.TabIndex = 3
        '
        'TxtDivisior
        '
        Me.TxtDivisior.Location = New System.Drawing.Point(221, 122)
        Me.TxtDivisior.Name = "TxtDivisior"
        Me.TxtDivisior.Size = New System.Drawing.Size(100, 22)
        Me.TxtDivisior.TabIndex = 4
        '
        'TxtQuotient
        '
        Me.TxtQuotient.Location = New System.Drawing.Point(222, 186)
        Me.TxtQuotient.Name = "TxtQuotient"
        Me.TxtQuotient.Size = New System.Drawing.Size(100, 22)
        Me.TxtQuotient.TabIndex = 5
        Me.TxtQuotient.TabStop = False
        '
        'BtnDivide
        '
        Me.BtnDivide.Location = New System.Drawing.Point(145, 320)
        Me.BtnDivide.Name = "BtnDivide"
        Me.BtnDivide.Size = New System.Drawing.Size(75, 23)
        Me.BtnDivide.TabIndex = 6
        Me.BtnDivide.Text = "Divide"
        Me.BtnDivide.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(226, 320)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 7
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'LblRemainder
        '
        Me.LblRemainder.AutoSize = True
        Me.LblRemainder.Location = New System.Drawing.Point(101, 253)
        Me.LblRemainder.Name = "LblRemainder"
        Me.LblRemainder.Size = New System.Drawing.Size(77, 17)
        Me.LblRemainder.TabIndex = 8
        Me.LblRemainder.Text = "Remainder"
        '
        'TxtRemainder
        '
        Me.TxtRemainder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRemainder.Location = New System.Drawing.Point(222, 248)
        Me.TxtRemainder.Name = "TxtRemainder"
        Me.TxtRemainder.ReadOnly = True
        Me.TxtRemainder.Size = New System.Drawing.Size(100, 22)
        Me.TxtRemainder.TabIndex = 9
        '
        'FrmDivisionApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 450)
        Me.Controls.Add(Me.TxtRemainder)
        Me.Controls.Add(Me.LblRemainder)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnDivide)
        Me.Controls.Add(Me.TxtQuotient)
        Me.Controls.Add(Me.TxtDivisior)
        Me.Controls.Add(Me.TxtDividend)
        Me.Controls.Add(Me.LblQuotient)
        Me.Controls.Add(Me.LblDivisior)
        Me.Controls.Add(Me.LblDividend)
        Me.Name = "FrmDivisionApp"
        Me.Text = "DivisionApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDividend As Label
    Friend WithEvents LblDivisior As Label
    Friend WithEvents LblQuotient As Label
    Friend WithEvents TxtDividend As TextBox
    Friend WithEvents TxtDivisior As TextBox
    Friend WithEvents TxtQuotient As TextBox
    Friend WithEvents BtnDivide As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents LblRemainder As Label
    Friend WithEvents TxtRemainder As TextBox
End Class
