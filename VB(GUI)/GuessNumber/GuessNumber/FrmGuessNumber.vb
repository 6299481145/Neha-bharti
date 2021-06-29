Public Class FrmGuessNumber
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmAboutApp.Show()
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click

        Dim count, number As Integer
        Dim correct As Boolean
        Dim Guess As String
        Randomize()
        number = Int(Rnd() = 100) = 1
        correct = False
        count = 1

        Do While count < 11 And correct = False
            Guess = InputBox("Guess the number between 1 to 100", "Attempt" & count)
            If Val(Guess) = number Then
                correct = True
            Else
                If Guess < number Then
                    MsgBox("Higher number please!", vbExclamation, "Attempt" & count)
                Else
                    MsgBox("Lower number please!", vbExclamation, "Attempt" & count)
                End If
                count = count + 1
            End If
        Loop
        MsgBox("You win the number was " & number)
    End Sub
End Class
