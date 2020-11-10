Public Class frmHello

    ' Listens for whether or button the red color button is selected.
    Private Sub rButtonRed_Checked(sender As Object, e As EventArgs) Handles rButtonRed.CheckedChanged
        ' Fires a function that will update color/text for greeting someone.
        updateText()
    End Sub

    ' Listens for whether or button the blue color button is selected.
    Private Sub rButtonBlue_Checked(sender As Object, e As EventArgs) Handles rButtonBlue.CheckedChanged
        ' Fires a function that will update color/text for greeting someone.
        updateText()
    End Sub

    ' Listens for whether or button the green color button is selected.
    Private Sub rButtonGreen_Checked(sender As Object, e As EventArgs) Handles rButtonGreen.CheckedChanged
        ' Fires a function that will update color/text for greeting someone.
        updateText()
    End Sub

    ' Listens for whether or button the english language button is selected.
    Private Sub rButtonEnglish_Checked(sender As Object, e As EventArgs) Handles rButtonEnglish.CheckedChanged
        ' Fires a function that will update color/text for greeting someone.
        updateText()
    End Sub

    ' Listens for whether or button the french language button is selected.
    Private Sub rButtonFrench_Checked(sender As Object, e As EventArgs) Handles rButtonFrench.CheckedChanged
        ' Fires a function that will update color/text for greeting someone.
        updateText()
    End Sub

    ' Listens for whether or button the italian language button is selected.
    Private Sub rButtonItalian_Checked(sender As Object, e As EventArgs) Handles rButtonItalian.CheckedChanged
        ' Fires a function that will update color/text for greeting someone.
        updateText()
    End Sub

    ' Function that updates the color of the text and updates the text itself to the correct language for greeting someone.
    Function updateText() As String

        ' Checks for what button is checked and updates lblHello's foreColor to that specific color between red, blue, or green.
        If rButtonRed.Checked Then
            lblHello.ForeColor = Color.Red
        ElseIf rButtonBlue.Checked Then
            lblHello.ForeColor = Color.Blue
        ElseIf rButtonGreen.Checked Then
            lblHello.ForeColor = Color.Green
        End If

        ' Checks for what button is checked and updates lblHello's text between the different languages.
        If rButtonEnglish.Checked Then
            lblHello.Text = "Hello"
        ElseIf rButtonFrench.Checked Then
            lblHello.Text = "Bonjour"
        ElseIf rButtonItalian.Checked Then
            lblHello.Text = "Ciao"
        End If

        Return ""
    End Function

End Class
