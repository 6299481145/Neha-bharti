Imports System.Data.SqlClient
Imports System.IO
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

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim con As New sqlconnection("server=(localdb)\mssqllocaldb;Database=Clinic")
        Dim cmd As New SqlCommand()
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Doctor VALUES('D001','Neha Bharti','F',2001-10-12')"
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Data inserted successfully!")
    End Sub
End Class