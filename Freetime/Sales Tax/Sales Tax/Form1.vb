
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

Public Class frmSalesTax
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Stops code, if the tax rate is empty, or not a valid number, or when price of item is empty, or not a valid number.
        If txtBoxTaxRate.Text = "" Or Not IsNumeric(txtBoxTaxRate.Text) Or txtBoxPriceOfItem.Text = "" Or Not IsNumeric(txtBoxPriceOfItem.Text) Then
            Return
        End If

        ' Finds tax rate and price of item from text boxes.
        Dim taxRate As Double = 1 + (CDbl(txtBoxTaxRate.Text) / 100)
        Dim priceOfItem As Double = CDbl(txtBoxPriceOfItem.Text)

        ' Calculates new value of item, after tax rate is applied.
        priceOfItem = priceOfItem * taxRate

        ' Updates total cost box after price of item is updated, and rounds to two decimals.
        txtBoxTotalCost.Text = Math.Round(priceOfItem, 2)
    End Sub
End Class