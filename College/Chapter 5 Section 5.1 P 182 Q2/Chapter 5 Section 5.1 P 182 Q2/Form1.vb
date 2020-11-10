Public Class frmFirstName

    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        'Determine a person's first name
        txtBoxFirstName.Text = FirstName(txtBoxFullName.Text)
    End Sub

    Function FirstName(fullName As String) As String
        Return fullName.Substring(0, fullName.IndexOf(" "))
    End Function

End Class
