
' 
' Copyright 2020, Kye Matzen, http://kyematzen.com
' <p>
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the
' Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software,
' and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
' <p>
' The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
' <p>
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
' MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR
' ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
' THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
'

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
