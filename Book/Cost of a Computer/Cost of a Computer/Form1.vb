Public Class frmComputer
    Private Sub calculateCost(sender As Object, e As EventArgs) Handles timerCost.Tick
        Dim cost As Double = 0D

        If rButtonDeluxe.Checked Then
            cost = 1000D
        Else
            cost = 1500D
        End If

        If checkBoxVC.Checked Then
            cost += 200D
        End If

        If checkBoxModem.Checked Then
            cost += 30D
        End If

        If checkBoxMemory.Checked Then
            cost += 120D
        End If

        txtBoxTotalCost.Text = cost.ToString("C")
    End Sub
End Class
