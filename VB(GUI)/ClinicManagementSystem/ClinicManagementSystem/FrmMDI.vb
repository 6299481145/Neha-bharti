Public Class FrmMDI


    Private Sub NewDoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDoctorToolStripMenuItem.Click
        FrmNewDoctor.Show()
    End Sub

    Private Sub EditDoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDoctorToolStripMenuItem.Click
        FrmEditDoctor.Show()
    End Sub

    Private Sub NewAppoitmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewAppoitmentToolStripMenuItem.Click
        FrmNewAppointment.Show()
    End Sub

    Private Sub EditAppoitmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditAppoitmentToolStripMenuItem.Click
        FrmEditAppointment.Show()
    End Sub

    Private Sub NewPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEditToolStripMenuItem.Click
        FrmNewPatient.Show()
    End Sub

    Private Sub FrmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EditPatientToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditPatientToolStripMenuItem1.Click
        FrmEditPatient.Show()
    End Sub
End Class
