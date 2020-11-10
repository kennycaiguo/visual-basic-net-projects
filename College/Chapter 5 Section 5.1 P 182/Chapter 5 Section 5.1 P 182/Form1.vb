Public Class frmTemperature
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim fahrenheitTemp, celsiusTemp As Double

        fahrenheitTemp = CDbl(txtBoxTemperature.Text)
        celsiusTemp = FtoC(fahrenheitTemp)
        txtBoxCelsius.Text = CStr(celsiusTemp)
    End Sub

    Function FtoC(t As Double) As Double
        ' Convert Faherenheit temperature to Celsius
        Return Math.Round((5 / 9) * (t - 32), 2)
    End Function
End Class
