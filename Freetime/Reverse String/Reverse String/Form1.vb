Public Class frmReverseString
    Private Sub reverseOriginal(sender As Object, e As EventArgs) Handles reverseStringer.Tick
        txtBoxReversed.Text = StrReverse(txtBoxOriginal.Text)
    End Sub
End Class
