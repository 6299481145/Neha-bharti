Public Class FrmMain
    Private Sub NewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewAccountToolStripMenuItem.Click

    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        FrmNewUser.Show()
    End Sub

    Private Sub EditUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditUserToolStripMenuItem.Click
        FrmEditUser.Show()
    End Sub
End Class
