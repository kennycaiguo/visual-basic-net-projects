Public Class frmAddress
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listBoxLetter.Items.Clear()
    End Sub

    Private Sub btnAddress_Click(sender As Object, e As EventArgs) Handles btnAddress.Click

        If txtBoxName.Text = "" Then Return

        Dim lastName As String() = txtBoxName.Text.Split(" ")

        If Not lastName.Length = 2 Then Return

        listBoxLetter.Items.Clear()

        listBoxLetter.Items.Add("The Honorable " & txtBoxName.Text)
        listBoxLetter.Items.Add("Washing, DC 20001")
        listBoxLetter.Items.Add("")
        listBoxLetter.Items.Add("Dear Senator " & lastName(1) & ",")
    End Sub
End Class
