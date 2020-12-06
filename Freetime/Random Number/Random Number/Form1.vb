
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Declares instance of Random as randomNum
        Dim randomNum As New Random()

        ' Scenarios
        ' 1. If m and n are whole numbers with m < n then the following generates a random whole number between m and n
        ' Exclusive of n.
        ' randomNum.Next(m, n)

        lblRandomNumber.Text = "Random Number: " & randomNum.Next(2, 18)

        ' 2. Returns a floating double number that is greater than or equal to 0.0, and less than 1.0.
        ' randomNum.NextDouble()
        lblRandomDouble.Text = "Random Double: " & randomNum.NextDouble()

        ' 2. Returns a floating double number that is greater than or equal to 0.0, and less than 1.0 rounded to 2 decimals.
        ' Math.Round(randomNum.NextDouble(), 2)

        lblRandomRounded.Text = "Random Rounded: " & Math.Round(randomNum.NextDouble(), 2)

        ' 3. Returns a non-negative integer number.
        ' randomNum.Next()
        lblRandomInteger.Text = "Random Integer: " & randomNum.Next()

        ' 3. Returns a non-negative integer number within range of n.
        ' Exclusive of n.
        ' randomNum.Next(n)
        lblRandomRange.Text = "Random Range: " & randomNum.Next(5)
    End Sub
End Class