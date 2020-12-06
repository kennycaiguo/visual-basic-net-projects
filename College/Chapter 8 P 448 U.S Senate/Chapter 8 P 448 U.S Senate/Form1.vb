
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

Public Class frmUSSenate
    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click
        ' Grabs information from files
        Dim firstFile As String() = IO.File.ReadAllLines("Senate115.txt")
        Dim secondFile As String() = IO.File.ReadAllLines("RetiredSen.txt")
        Dim thirdFile As String() = IO.File.ReadAllLines("NewSen.txt")

        ' Concatations arrays together.
        Dim finalArray As String() = firstFile.Concat(secondFile.Concat(thirdFile).ToArray).ToArray

        ' Loops through final array and splits by a comma, and grabs the state, and orders by state, and finally selects the line.
        Dim query = From line In finalArray
                    Let lineSplit As String() = line.Split(",")
                    Let state As String = lineSplit(1)
                    Order By state
                    Select line

        ' Write Senate116.txt to project storage
        IO.File.WriteAllLines("Senate116.txt", query.ToList.ToArray)

    End Sub
End Class