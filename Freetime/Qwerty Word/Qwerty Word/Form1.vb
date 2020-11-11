Public Class frmQwertyWord
    Private Sub determineWord(sender As Object, e As EventArgs) Handles timerDetermination.Tick
        Dim word As String = txtBoxWord.Text

        ' Checks if the word entered is nothing
        If word = "" Then
            lblQwertyBoolean.Text = ""
            Return
        End If

        ' Keeps a local index of how many characters are validCharacters.
        Dim validCharactersIndex As Integer = 0

        ' Lists the valid characters that can be used.
        Dim validCharacters As Char() = {"Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P"}

        ' Loops through each character inside of the text box string 'word'
        For Each localCharacter As String In word


            ' Checks if the localCharacter is a space.
            If localCharacter = " " Then Continue For

            ' Makes it uppercase letter to not worry about casing.
            localCharacter = localCharacter.ToUpper()

            ' Checks whether or not it is a valid character or not
            If Not validCharacters.Contains(localCharacter) Then
                ' Not a valid character, mention that the word(s) entered are invalid.
                lblQwertyBoolean.Text = "No"
                Return
            End If

            ' Increases valid characters index by one if it passes all checks.
            validCharactersIndex += 1

        Next

        ' Checks whether or not if any text entered is considered validCharacters.
        If validCharactersIndex > 0 Then
            lblQwertyBoolean.Text = "Yes"
        Else
            lblQwertyBoolean.Text = "Entered text is not considered invalid or valid."
        End If
    End Sub
End Class
