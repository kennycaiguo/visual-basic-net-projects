
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
Public Class frmDensity
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        DescribeTask()
        CalculateDensity("Hawaii", 1420000, 6471)
    End Sub

    Sub DescribeTask()
        listBoxOutput.Items.Clear()
        listBoxOutput.Items.Add("This population displays the")
        listBoxOutput.Items.Add("population density of the last state")
        listBoxOutput.Items.Add("to become part of the United States.")
    End Sub

    Sub CalculateDensity(state As String, pop As Double, landArea As Double)
        Dim density As Double
        density = pop / landArea
        listBoxOutput.Items.Add("") 'insert a blank line
        listBoxOutput.Items.Add("The population density of " & state & " is")
        listBoxOutput.Items.Add(density.ToString("N1") & " people per square mile.")
    End Sub
End Class