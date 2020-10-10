Imports System.Data.SqlClient
Public Class FrmEditDoctor

    Dim con As New SqlConnection("Server=(localdb)\mssqllocaldb; Database=Clinic")
    Dim cmd As New SqlCommand()
    Dim dr As SqlDataReader

    Private Sub FrmEditDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMDI
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT *FROM Doctor WHERE doctor_id='" & TxtDoctorId.Text & "'"
        dr = cmd.ExecuteReader()
        dr.Read()
        TxtName.Text = dr("name")
        If (dr("gender")) = "M" Then
            RdbMale.Checked = True
        Else
            RdbFemale.Checked = True
        End If
        DtpDateOfBirth.Value = dr("DOB")
        dr.Close()
        con.Close()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim g As String
        If (RdbMale.Checked) Then
            g = "M"
        Else
            g = "F"
        End If
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "UPDATE Doctor SET doctor_name='" & TxtName.Text & "', gender='" & g & "'WHERE doctor _id ='" & TxtDoctorId.Text & "'"
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show("Data update successfully...")
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "DELETE FROM Doctor WHERE doctor_id='" & TxtDoctorId.Text & "'"
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show("Data deleted successfully....")
    End Sub
End Class