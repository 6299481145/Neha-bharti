Imports System.Data.SqlClient
Public Class FrmNewPatient
    Dim Con As New SqlConnection("server=(localdb)\mssqllocaldb; Database= Clinic")
    Dim cmd As New SqlCommand()
    Dim dr As SqlDataReader
    Private Sub FrmNewPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FrmMDI

        GeneratePatientId()
    End Sub

    Private Sub GeneratePatientId()
        Con.Open()
        cmd.Connection = Con
        cmd.CommandText = "SELECT patient_id FROM Patient"
        dr = cmd.ExecuteReader()
        While (dr.Read())
            TxtPatientId.Text = dr("patient_id")
        End While
        dr.Close()
        Con.Close()

        TxtPatientId.Text = TxtPatientId.Text.Substring(1)

        TxtPatientId.Text += 1

        If (TxtPatientId.Text < 10) Then
            TxtPatientId.Text = "P00" & TxtPatientId.Text
        ElseIf (TxtPatientId.Text < 100) Then
            TxtPatientId.Text = "P0" & TxtPatientId.Text
        ElseIf (TxtPatientId.Text < 1000) Then
            TxtPatientId.Text = "P" & TxtPatientId.Text
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim DT As New DataTable()
        Dim sqlDA As New SqlDataAdapter()
        Dim sqlCB As New SqlCommandBuilder(sqlDA)
        Dim DR As DataRow

        Con.Open()
        cmd.Connection = Con
        cmd.CommandText = "SELECT * FROM patient"
        sqlDA.SelectCommand = cmd
        sqlDA.Fill(DT)

        DR = DT.NewRow()
        DR("patient_id") = TxtPatientId.Text
        DR("patient_name") = TxtName.Text

        If (RdbMale.Checked) Then
            DR("gender") = "M"
        Else
            DR("gender") = "F"
        End If
        DR("date_of_birth") = DtpDateOfBirth.Value.Date

        DT.Rows.Add(DR)

        sqlDA.Update(DT)     'Adding DR to DT

        Con.Close()

        MessageBox.Show("Patient Registered successfully...")
    End Sub
End Class