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
