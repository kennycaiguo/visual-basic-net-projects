
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

'
' Demo credit card number: 58667936100244 (YES)
'
Public Class frmValidation

    ' Executes checks before process when button is clicked.
    Private Sub btnValidation(sender As Object, e As EventArgs) Handles btnValidate.Click

        ' Localized variable for text from credit number.
        Dim numberStr As String = txtBoxNumber.Text

        ' Checks whether or not there is any entered text.
        If numberStr = "" Then
            updateNo()
            Return
        End If

        ' Checks whether or not the entered text is a number.
        If Not IsNumeric(numberStr) Then
            updateNo()
            Return
        End If

        ' Checks whether or not numberStr is exactly 14 characters (length of credit card) or not.

        If Not numberStr.Length = 14 Then
            updateNo()
            Return
        End If

        ' Localized value for sum of values after processing.
        Dim sum As Integer = 0

        ' Converts numberStr into a list of numbers for each character of the string.
        Dim intList = numberStr.ToList.ConvertAll(Function(str) Int32.Parse(str))

        ' Splits up intList into two catergories for (a) & (b)
        Dim firstSet As Integer() = {intList(0), intList(2), intList(4), intList(6), intList(8), intList(10), intList(12)}
        Dim secondSet As Integer() = {intList(1), intList(3), intList(5), intList(7), intList(9), intList(11), intList(13)}

        ' Loops through the firstSet, grabbing the value, multiplying it by 2, checking if it is greater than or equal to 10, and if so
        ' it'll remove 9 and put it back into firstSet.
        For index As Integer = 0 To firstSet.GetUpperBound(0)
            Dim localNumber = firstSet(index)

            localNumber *= 2

            If localNumber >= 10 Then
                localNumber -= 9
            End If

            ' Adds all values from firstSet(index) and secondSet(index) together into sum
            sum += localNumber
            sum += secondSet(index)
        Next

        ' Checks whether or not credit card number is valid after being processed by seeing if sum is a multiple of 10.
        If sum Mod 10 = 0 Then
            lblValid.ForeColor = Color.Green
            lblValid.Text = "YES"
        Else
            updateNo()
        End If

    End Sub

    ' Sub used to optimize and reduce overall duplication of code.
    Sub updateNo()
        lblValid.ForeColor = Color.Red
        lblValid.Text = "NO"
    End Sub
End Class