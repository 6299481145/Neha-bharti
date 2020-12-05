Imports System.Data.SqlClient
Public Class FrmDoctorList
    Private Sub DGVDoctorList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDoctorList.CellContentClick


    End Sub

    Private Sub FrmDoctorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMDI


        Dim con As New SqlConnection("Server=(localdb)\mssqllocaldb;Database=Clinic")
        Dim cmd As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet()



        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select *from Doctor"
        da.SelectCommand = cmd
        da.Fill(ds, "Doctor")
        DGVDoctorList.DataSource = ds.Tables("Doctor")
        con.Close()
    End Sub
End Class