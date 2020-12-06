
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

Public Class Form1
    Private Sub produceFile(sender As Object, e As EventArgs) Handles btnProduceFile.Click
        ' Creates team array with data from it.
        Dim teams As String() = {"Balitmore,47:115", "Boston,108:54", "New York,100:62", "Tampa Bay,90:72", "Toronto,73:89"}

        ' Sorts teams by percentage of games won in descending order based on ratio.
        Dim query = From name As String In teams
                    Let nameSplit As String() = name.Split(",")
                    Let ratioSplit As String() = nameSplit(1).Split(":")
                    Let ratio As Double = (CDbl(ratioSplit(0)) / CDbl(ratioSplit(1)))
                    Order By ratio Descending
                    Select name

        ' Writes query to a list to a array into ALE.txt file into project storage.
        IO.File.WriteAllLines("ALE.txt", query.ToList.ToArray)
    End Sub
End Class