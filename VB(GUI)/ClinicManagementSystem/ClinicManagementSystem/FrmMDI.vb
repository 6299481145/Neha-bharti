Public Class FrmMDI
    Private Sub NewEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEditToolStripMenuItem.Click
        FrmEditPatient.Show()
    End Sub

    Private Sub NewPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPatientToolStripMenuItem.Click
        FrmNewPatient.Show()
    End Sub

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
End Class
