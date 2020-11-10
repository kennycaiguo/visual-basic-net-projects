Public Class frmPayRaise
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If txtBoxFirstName.Text = "" Then Return
        If txtBoxLastName.Text = "" Then Return
        If txtBoxCurrentSalary.Text = "" Or Not IsNumeric(txtBoxCurrentSalary.Text) Then Return

        Dim salary As Double = CDbl(txtBoxCurrentSalary.Text)

        txtBoxNewSalary.Text = "New Salary for " & txtBoxFirstName.Text & " " & txtBoxLastName.Text & ": " & getSalary(salary).ToString("C")
    End Sub

    Function getSalary(ByVal salary As Double) As Double

        If salary < 40000 Then
            salary = salary + (salary * 0.05)
        Else
            salary = 2000 + ((0.02 * salary) + salary)
        End If

        Return salary
    End Function
End Class
