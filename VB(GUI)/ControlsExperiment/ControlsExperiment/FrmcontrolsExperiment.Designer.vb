<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmcontrolsExperiment
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
        Me.LlbClickMe = New System.Windows.Forms.LinkLabel()
        Me.LstNames = New System.Windows.Forms.ListBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'LlbClickMe
        '
        Me.LlbClickMe.AutoSize = True
        Me.LlbClickMe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlbClickMe.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LlbClickMe.Location = New System.Drawing.Point(653, 55)
        Me.LlbClickMe.Name = "LlbClickMe"
        Me.LlbClickMe.Size = New System.Drawing.Size(94, 25)
        Me.LlbClickMe.TabIndex = 0
        Me.LlbClickMe.TabStop = True
        Me.LlbClickMe.Text = "Click Me!"
        '
        'LstNames
        '
        Me.LstNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstNames.FormattingEnabled = True
        Me.LstNames.ItemHeight = 25
        Me.LstNames.Items.AddRange(New Object() {"Neha Bharti ", "Tanishka Bharti", "Simran Kumari", "Sahina Kumari", "Sonal Kumari", "Samiksha Kumari"})
        Me.LstNames.Location = New System.Drawing.Point(66, 135)
        Me.LstNames.Name = "LstNames"
        Me.LstNames.Size = New System.Drawing.Size(201, 104)
        Me.LstNames.TabIndex = 2
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(340, 175)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(187, 30)
        Me.TxtName.TabIndex = 3
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(438, 59)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox1.TabIndex = 4
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'FrmcontrolsExperiment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LstNames)
        Me.Controls.Add(Me.LlbClickMe)
        Me.Name = "FrmcontrolsExperiment"
        Me.Text = "Controls Experiment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LlbClickMe As LinkLabel
    Friend WithEvents LstNames As ListBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
