' Created by kyematzen.com
' Date completed on Nov 10. 2020
Public Class frmQuasiPalindrome
    ' Ticks every 1/10th of a second to check whether or not the word entered is quasi palindrome
    Private Sub tickConclusion(sender As Object, e As EventArgs) Handles timerConclusion.Tick

        ' Creates local instance of txtBoxWord's text.
        Dim word As String = txtBoxWord.Text

        ' Checks if entered text length is only 1

        If word.Length <= 1 Then
            updateNo()
            Return
        End If

        ' Checks if entered text is spaces only.

        Dim spacesIndex As Integer = 0

        ' Loops through each character in word.
        For Each localCharacter In word
            ' Checks if the character is a space.
            If localCharacter = " " Then
                spacesIndex += 1
            End If
        Next

        ' Cancels if the amount of spaces equals the length of the word entered.
        If spacesIndex > 1 Then
            updateNo()
            Return
        End If

        ' Reverses word.
        Dim reversed = StrReverse(word)
        Dim moved = word.Clone.Substring(1, word.Length - 1) & word(0)

        ' Checks if reversed is equal to moved where the first letter is moved to end.
        If reversed.Equals(moved) Then
            lblConclusionAnswer.ForeColor = Color.Green
            lblConclusionAnswer.Text = "YES"
        Else
            updateNo()
        End If
    End Sub

    ' Sub used to optimize and reduce overall duplication of code
    Sub updateNo()
        lblConclusionAnswer.ForeColor = Color.Red
        lblConclusionAnswer.Text = "NO"
    End Sub
End Class
