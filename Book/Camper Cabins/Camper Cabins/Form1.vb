
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

Public Class frmRental

    ' Fires every 1/10th of a second to check if options were changed.
    Private Sub calculateCost(sender As Object, e As EventArgs) Handles timerCostCalculation.Tick
        Dim costPerDay = 75D

        ' Checks if the period of time entered is empty or if it is a number.
        If txtBoxPeriod.Text.Trim.Length = 0 Or Not IsNumeric(txtBoxPeriod.Text) Then
            lblCost.Text = "$0.00"
            Return
        End If

        ' Localized variable to keep the total cost.
        Dim cost As Double = 0D

        ' Localized variable that converts the period of time into a amount of days.
        Dim days As Integer = CInt(txtBoxPeriod.Text)

        ' Localized variable for whether or not renter is a resident
        Dim resident As Boolean = rButtonResidentYes.Checked

        ' Checks if renter is a resident and updates the cost per day/
        If resident Then
            costPerDay = 65D
        End If

        ' Loops through each day calculating the cost.
        For dayIndex = 1 To days Step 1

            ' Updates the cost per day if renter is a resident who's cost per day isn't already $50, and if it has been over 6 days of rental period.
            If resident AndAlso dayIndex > 6 Then
                costPerDay = 50D
            End If

            ' Adds costPerDay to cost
            cost += costPerDay
        Next

        ' Converts total of cost of rental period into a proper cost label.
        lblCost.Text = cost.ToString("C")
    End Sub
End Class
