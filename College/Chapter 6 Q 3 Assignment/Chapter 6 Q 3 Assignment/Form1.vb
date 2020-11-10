Public Class frmMatrix
    Private Sub frmMatrix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lines As String() = {"*                                           *", "", "          *                      *          ", "", "                      *                      ", "", "          *                      *          ", "", "*                                           *"}

        For number As Integer = 0 To lines.GetLength(0) - 1 Step 1
            listBoxMatrix.Items.Add(lines(number))
        Next
    End Sub
End Class
