
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

Public Class frmContestants
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim randomNum As New Random
        Dim contestant As String() = {"Mary", "Pat", "Linda", "Barbara", "Maria"}

        Dim number As Integer, temp As String

        For i As Integer = 0 To 4
            number = randomNum.Next(i, 5)
            temp = contestant(i)
            contestant(i) = contestant(number)
            contestant(number) = temp
        Next

        lstOutput.Items.Clear()

        For i As Integer = 0 To 4
            lstOutput.Items.Add(contestant(i))
        Next
    End Sub
End Class