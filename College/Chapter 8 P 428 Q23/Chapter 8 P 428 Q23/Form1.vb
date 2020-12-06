
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
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        ' Checks if a item has been entered/is valid.


        If txtBoxItem.Text = "" OrElse txtBoxItem.Text.Trim = "" Then
            MessageBox.Show("Please enter a valid item name.", "Cowboys")
            Return
        End If

        If txtBoxPrice.Text = "" OrElse txtBoxPrice.Text.Trim = "" OrElse Not IsNumeric(txtBoxPrice.Text) Then
            MessageBox.Show("Please enter a valid price.", "Cowboys")
            Return
        End If

        ' Checks if a price has been entered/is valid.

        ' Checks if cowboy previously exists.
        If Not IO.File.Exists("Cowboy.txt") Then
            ' Creates cowboy product array with pricing
            Dim lines As String() = {"Colt Peacemaker,12.20", "Holster,2.00", "Levi Strauss jeans,1.35", "Saddle,40.00", "Stetson,10.00"}

            ' Writes cowboy file to project storage.
            IO.File.WriteAllLines("Cowboy.txt", lines)
        End If

        ' Reads cowboy file from project storage.
        Dim cowboyFile As String() = IO.File.ReadAllLines("Cowboy.txt")

        ' Create dictionary of name (string) and price (double)
        Dim dictionary As Dictionary(Of String, Double) = New Dictionary(Of String, Double)

        ' Add items from cowboy file into dictionary.

        For index As Integer = 0 To cowboyFile.Count - 1 Step 1
            Dim split As String() = cowboyFile(index).Split(",")

            dictionary.Add(split(0), CDbl(split(1)))
        Next

        ' Adds new item to dictionary of original items.
        dictionary.Add(txtBoxItem.Text, CDbl(txtBoxPrice.Text))

        ' Loops through all item names in dictionary, and sorts by pricing
        Dim query = From name As String In dictionary.Keys.ToList
                    Order By name Ascending
                    Select name

        ' Converts query into a array of names
        Dim itemArray As String() = query.ToList.ToArray

        ' Creates new local array for Cowboy2.txt
        Dim cowboy2Array As String() = {}

        ' Resizes array

        Array.Resize(cowboy2Array, itemArray.Count)

        ' Updates array with new information from query sorted. 
        For index As Integer = 0 To itemArray.Count - 1 Step 1
            cowboy2Array(index) = itemArray(index) & "," & dictionary(itemArray(index))
        Next

        ' Writes cowboy2 file to project storage.
        IO.File.WriteAllLines("Cowboy2.txt", cowboy2Array)
    End Sub
End Class