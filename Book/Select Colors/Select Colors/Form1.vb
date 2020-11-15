
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

Public Class frmSelectColors
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        ' Checks if a foreground color was selected.
        If Not rButtonForegroundWhite.Checked AndAlso Not rButtonForegroundYellow.Checked AndAlso Not rButtonForegroundRed.Checked AndAlso Not rButtonForegroundBlue.Checked Then
            MessageBox.Show("You must provide a foreground color", "Colors")
            Return
        End If

        ' Check if a background color was selected.
        If Not rButtonBackgroundWhite.Checked AndAlso Not rButtonBackgroundYellow.Checked AndAlso Not rButtonBackgroundRed.Checked AndAlso Not rButtonBackgroundBlue.Checked Then
            MessageBox.Show("You must provide a background color", "Colors")
            Return
        End If

        ' Finds what color user wants as foreground.
        Dim foreColor As Color = Color.Blue

        If rButtonForegroundWhite.Checked Then
            foreColor = Color.White
        ElseIf rButtonForegroundYellow.Checked Then
            foreColor = Color.Yellow
        ElseIf rButtonForegroundRed.Checked Then
            foreColor = Color.Red
        End If

        ' Finds what color user wants as background.
        Dim backColor As Color = Color.Blue

        If rButtonBackgroundWhite.Checked Then
            backColor = Color.White
        ElseIf rButtonBackgroundYellow.Checked Then
            backColor = Color.Yellow
        ElseIf rButtonBackgroundRed.Checked Then
            backColor = Color.Red
        End If

        ' Checks if foreColor and backColor are the same.
        If foreColor = backColor Then
            MessageBox.Show("Foreground and Background color cannot both be " & foreColor.Name.ToString.ToUpper & ".", "Colors")
            Return
        End If

        ' Updates text foreground and background color for lblVisualBasic

        lblVisualBasic.ForeColor = foreColor
        lblVisualBasic.BackColor = backColor
    End Sub
End Class
