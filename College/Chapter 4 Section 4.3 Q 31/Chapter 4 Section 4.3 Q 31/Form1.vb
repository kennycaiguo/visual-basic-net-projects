Public Class frmAgeOfATire

    Private Sub btnDetermineTireManufactureTime(sender As Object, e As EventArgs) Handles btnDetermination.Click

        ' Checks whether or not the text box is filled with four digits
        If Not maskedTxtBoxDigits.MaskCompleted Then Return

        ' Grabs digits from text box and stores into a local variable
        Dim digits As String = maskedTxtBoxDigits.Text

        ' Grabs first two numbers from string digits and adds to the end of 20 for calculating the year for tire.
        Dim year As String = "20" & digits.Substring(0, 2)

        ' Grabs last two numbers from string digits for calculating the week of tire.
        Dim week As String = digits.Substring(2, 2)

        ' Grabs last number from string digits to findthe correct display at the end of the week.
        Dim lastDigit As Integer = CInt(digits.Substring(3))

        ' 1. If lastDigit is 1 then it'll end in "st"
        ' 2. ElseIf it is 2 Then it'll end in "nd"
        ' 3. ElseIf it is 3 then it'll end with "3rd"
        ' 4. Else it is not 1,2, or 3 then it'll end with "4th"

        Select Case lastDigit
            Case 1
                week = week & "st"
            Case 2
                week = week & "nd"
            Case 3
                week = week & "rd"
            Case Else
                week = week & "th"
        End Select

        ' Updates text boxes with the year and week the tire was manufuctured 
        txtBoxWeek.Text = week
        txtBoxYear.Text = year
    End Sub

End Class
