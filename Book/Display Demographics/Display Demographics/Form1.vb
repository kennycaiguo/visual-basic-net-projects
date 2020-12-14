
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

Public Class frmDemographics
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Calculate the population densities of states.
        listBoxOutput.Items.Clear()
        Dim s As String, p As Double, a As Double
        s = "Hawaii"
        p = 1420000
        a = 6471
        CalculateDensity(s, p, a)
        listBoxOutput.Items.Add("")
        s = "Alaska"
        p = 736732
        a = 570600
        CalculateDensity(s, p, a)
    End Sub

    Sub CalculateDensity(state As String, pop As Double, landArea As Double)
        Dim density As Double
        density = pop / landArea
        listBoxOutput.Items.Add("") 'insert a blank line
        listBoxOutput.Items.Add("The population density of " & state & " is")
        listBoxOutput.Items.Add(density.ToString("N1") & " people per square mile.")
    End Sub
End Class
