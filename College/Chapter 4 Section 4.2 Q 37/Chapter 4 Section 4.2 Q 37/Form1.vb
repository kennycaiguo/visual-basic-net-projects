Public Class frmPresident

    ' Local stored variable that keeps the number of guesses.
    Public Shared guesses As Integer = 0

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click

        ' Checks whether or not user input a response
        If txtBoxAnswer.Text = "" Then Return

        ' Grabs user input into variable response.
        Dim response As String = txtBoxAnswer.Text

        ' Increases total amount of guesses by user.
        guesses += 1

        txtBoxGuesses.Text = CStr(guesses)

        ' 1. If the response that the user input is equal to Collidge then it'll mention that they got the correct answer.
        ' 2. Else it will check for the number of times the user failed and if it is equal to 3 or 7 it'll give hints.
        If response = "Coolidge" Then
            MessageBox.Show("Correct answer!", "President")
        ElseIf guesses = 3 Then
            MessageBox.Show("He once said, 'If you don't say anything, you won't be called upon to repeat it.'", "President")
        ElseIf guesses = 7 Then
            MessageBox.Show("His nickname was 'Silent Cal.'", "President")
        End If
    End Sub
End Class
