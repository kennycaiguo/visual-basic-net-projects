' Created by kyematzen.com
' Date completed on Nov 12. 2020
Public Class frmHurricane

    ' Fires every 1/10th of a second to check if speed were changed.
    Private Sub timerRatingUpdater_Tick(sender As Object, e As EventArgs) Handles timerRatingUpdater.Tick
        Dim rating = txtBoxSpeed.Text

        ' Checks if rating is a number
        If IsNumeric(rating) Then
            ' Converts string into a number
            Dim number As Integer = CInt(rating)

            ' Select system that returns a specific category or no hurricane dependent on wind speed.
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

        ' Fires if wind speed text box is empty.
        txtBoxRating.Text = "No hurricane."
    End Sub
End Class
