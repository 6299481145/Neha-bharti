<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDoctorList
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
        Me.DGVDoctorList = New System.Windows.Forms.DataGridView()
        CType(Me.DGVDoctorList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVDoctorList
        '
        Me.DGVDoctorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDoctorList.Location = New System.Drawing.Point(87, 32)
        Me.DGVDoctorList.Name = "DGVDoctorList"
        Me.DGVDoctorList.RowHeadersWidth = 51
        Me.DGVDoctorList.RowTemplate.Height = 24
        Me.DGVDoctorList.Size = New System.Drawing.Size(603, 356)
        Me.DGVDoctorList.TabIndex = 0
        '
        'FrmDoctorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DGVDoctorList)
        Me.Name = "FrmDoctorList"
        Me.Text = "FrmDoctorList"
        CType(Me.DGVDoctorList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVDoctorList As DataGridView
End Class
