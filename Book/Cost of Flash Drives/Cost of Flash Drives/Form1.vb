
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

Public Class frmFlashDrives
    ' Method used for calculating cost of flash dries
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Checks if the quantity is a number
        If IsNumeric(txtBoxQuantity.Text) Then

            ' Localized variable for cost to be used later when processing cost of flash drives.
            Dim cost As Double = 0D

            ' Converts quantity text box into a integer amount
            Dim quantity As Integer = CInt(txtBoxQuantity.Text)

            ' Calculates cost dependent on size of drives

            If rButton16GB.Checked Then
                cost = 5.99 * quantity
            Else
                cost = 9.99 * quantity
            End If

            ' Checks for discount 
            Select Case quantity
                Case Is > 25
                    cost *= 0.9
                Case Is > 50
                    cost *= 0.85
                Case Is > 100
                    cost *= 0.8
            End Select

            ' Sets txtBoxCost's text to cost that is formatted with a currency symbol.
            txtBoxCost.Text = cost.ToString("C")
        Else
            MessageBox.Show("Please enter a valid amount", "Place Order")
        End If
    End Sub
End Class
