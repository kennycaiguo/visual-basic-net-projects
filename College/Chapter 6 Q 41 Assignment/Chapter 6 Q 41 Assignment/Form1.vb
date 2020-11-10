Public Class frmPopulation
    Private Sub btnDetermineYear(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim chinaPopulation As Double = 1370000000.0
        Dim indiaPopulation As Double = 1310000000.0

        Dim year As Integer = 2016

        While (chinaPopulation > indiaPopulation)

            chinaPopulation += (chinaPopulation * 0.0066)
            indiaPopulation += (indiaPopulation * 0.013)

            year += 1
        End While

        txtBoxYear.Text = CStr(year)
    End Sub
End Class