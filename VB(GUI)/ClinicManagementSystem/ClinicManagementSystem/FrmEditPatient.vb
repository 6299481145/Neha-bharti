Imports System.Data.SqlClient
Public Class FrmEditPatient
    Dim con As New SqlConnection("Server=(localdb)\mssqllocaldb ; Database = Clinic")
    Dim cmd As New SqlCommand()
    Dim dr As SqlDataReader
    Private Sub FrmEditPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMDI
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Select *From Patient WHERE patient_id ='" & TxtPatientId.Text & "'"
        dr = cmd.ExecuteReader() 'object of sqlDataReader class created and its address is assigned to dr
        If (dr.Read()) Then
            TxtName.Text = dr("Name")
        End If
        dr.Close()
        con.Close()
    End Sub
End Class