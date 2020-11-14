
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

Public Class frmAirline
    ' Loads form
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        listBoxFrom.Items.Add("AUS")
        listBoxFrom.Items.Add("BOS")
        listBoxFrom.Items.Add("BWI")
        listBoxFrom.Items.Add("DFW")
        listBoxFrom.Items.Add("JFK")
        listBoxFrom.Items.Add("LAX")
        listBoxFrom.Items.Add("MIA")
        listBoxFrom.Items.Add("ORD")
        listBoxFrom.Items.Add("SFO")

        listBoxTo.Items.Add("AUS")
        listBoxTo.Items.Add("BOS")
        listBoxTo.Items.Add("BWI")
        listBoxTo.Items.Add("DFW")
        listBoxTo.Items.Add("JFK")
        listBoxTo.Items.Add("LAX")
        listBoxTo.Items.Add("MIA")
        listBoxTo.Items.Add("ORD")
        listBoxTo.Items.Add("SFO")
    End Sub

    ' Book Flight Button 
    Private Sub btnBook(sender As Object, e As EventArgs) Handles btnBookFlight.Click
        ' Checks if user selected where they are flying from
        If listBoxFrom.SelectedIndex = -1 Then
            MessageBox.Show("Please enter where you are flying from.", "Airline")
            Return
        End If

        ' Checks if user selected where they are flying to
        If listBoxTo.SelectedIndex = -1 Then
            MessageBox.Show("Please enter where you are flying to.", "Airline")
            Return
        End If

        ' Upates flight text to where they are flying from to.
        txtBoxFlight.Text = "You are flying from " & listBoxFrom.Items(listBoxFrom.SelectedIndex) & " to " & listBoxTo.Items(listBoxTo.SelectedIndex) & "."
    End Sub
End Class
