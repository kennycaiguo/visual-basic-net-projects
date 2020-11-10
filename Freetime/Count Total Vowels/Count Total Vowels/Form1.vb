Public Class frmTotalVowels

    Public Shared vowels As Integer = 0

    Private Sub countTotalVowels(sender As Object, e As EventArgs) Handles vowelCounter.Tick

        If txtBoxText.Text = "" Then updateTotal()

        vowels = 0

        For Each character As Char In txtBoxText.Text
            If character = "a" Or character = "e" Or character = "i" Or character = "o" Or character = "u" Then
                vowels += 1
            End If
        Next

        updateTotal()
    End Sub

    Public Sub updateTotal()
        lblTotal.Text = "Total Vowels: " & vowels.ToString("N0")
    End Sub

End Class