Public Class frmUSStates
    Private Sub btnFindName_Click(sender As Object, e As EventArgs) Handles btnFindName.Click
        Dim sr As IO.StreamReader = IO.File.OpenText("USStates.txt")
        Dim abbr As String = txtBoxAbbreviation.Text.ToUpper
        Dim line As String
        Dim foundFlag As Boolean = False

        Do Until foundFlag Or sr.EndOfStream
            line = sr.ReadLine
            If line.Split(","c)(1) = abbr Then
                txtBoxName.Text = line.Split(","c)(0)
                foundFlag = True
            End If
        Loop

        If Not foundFlag Then
            Dim str As String = " is not a valid state abbreviation."
            MessageBox.Show(txtBoxAbbreviation.Text.ToUpper & str, "Error")
            txtBoxAbbreviation.Clear()
            txtBoxAbbreviation.Focus()
        End If

        sr.Close()
    End Sub
End Class
