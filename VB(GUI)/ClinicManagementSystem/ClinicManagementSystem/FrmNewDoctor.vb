Public Class FrmNewDoctor
    Private Sub FrmNewDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMDI

        TxtDateOfJoining.Text = Today.Date()

        '...Populating specialization combobox
        CboSpecialization.Items.Add("General Physician")
        CboSpecialization.Items.Add("Opthomologist")
        CboSpecialization.Items.Add("cardiologist")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub LlbBrower_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlbBrower.LinkClicked
        Dim ofd As New OpenFileDialog()
        ofd.ShowDialog()
    End Sub
End Class