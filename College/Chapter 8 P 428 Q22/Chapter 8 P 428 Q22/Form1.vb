
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

Public Class frmCowboys
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Creates order array
        Dim order As String() = {"3", "2", "10", "1", "4"}

        ' Writes order file to project storage.
        IO.File.WriteAllLines("Order.txt", order)

        ' Checks if cowboy previously exists.
        If Not IO.File.Exists("Cowboy.txt") Then
            ' Creates cowboy product array with pricing
            Dim lines As String() = {"Colt Peacemaker,12.20", "Holster,2.00", "Levi Strauss jeans,1.35", "Saddle,40.00", "Stetson,10.00"}

            ' Writes cowboy file to project storage.
            IO.File.WriteAllLines("Cowboy.txt", lines)
        End If

        ' Reads cowboy file from project storage.
        Dim cowboyFile As String() = IO.File.ReadAllLines("Cowboy.txt")

        ' Creates localized variable for total receipt of sales.
        Dim totalReceipt As Double = 0

        ' Loops from first index of order array to end to calculate costs of cowboy products.
        For index As Integer = 0 To order.Count - 1 Step 1
            ' Splits line grabbed from cowboy file by a comma to find name of product and price.
            Dim itemInfo As String() = cowboyFile(index).Split(",")

            ' Finds price for number of product.
            Dim value As Double = CInt(order(index)) * CDbl(itemInfo(1))

            ' Adds to receipt information the amount of product, name, and price for number of product.
            listBoxReceipt.Items.Add(order(index) & " " & itemInfo(0) & ": " & value.ToString("C"))

            ' Adds value of product to total receipt for amount ordered.
            totalReceipt += value
        Next

        ' Adds to receipt information the total cost for all products from sale receipt.
        listBoxReceipt.Items.Add("TOTAL: " & totalReceipt.ToString("C"))
    End Sub
End Class