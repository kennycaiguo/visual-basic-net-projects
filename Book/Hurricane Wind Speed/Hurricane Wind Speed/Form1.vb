Public Class frmHurricane
    Private Sub timerRatingUpdater_Tick(sender As Object, e As EventArgs) Handles timerRatingUpdater.Tick
        Dim rating = txtBoxSpeed.Text

        If IsNumeric(rating) Then
            Dim number As Integer = CInt(rating)

            Select Case number
                Case 74 To 95
                    txtBoxRating.Text = "Category One hurricane."
                Case 96 To 110
                    txtBoxRating.Text = "Category Two hurricane."
                Case 111 To 130
                    txtBoxRating.Text = "Category Three hurricane."
                Case 131 To 155
                    txtBoxRating.Text = "Category Four hurricane."
                Case Is > 155
                    txtBoxRating.Text = "Category Five hurricane."
                Case Else
                    txtBoxRating.Text = "No hurricane."
            End Select

            Return
        End If

        txtBoxRating.Text = "No hurricane."
    End Sub
End Class
