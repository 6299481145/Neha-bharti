Public Class FrmMDI
    Private Sub FrmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NewHostellersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewHostellersToolStripMenuItem.Click
        FrmNewHosteller.Show()

    End Sub

    Private Sub EditHostellersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditHostellersToolStripMenuItem.Click
        FrmEditHostellers.Show()
    End Sub
End Class
