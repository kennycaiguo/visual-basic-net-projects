Public Class frmSelection
    Dim clickFlag As Boolean

    Private Sub lstBox_Click(sender As Object, e As EventArgs) Handles lstBox.Click
        clickFlag = True
    End Sub

    Private Sub lstBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBox.SelectedIndexChanged
        Dim msg As String = "The SelectedIndexChanged event was caused by "

        If clickFlag Then
            MessageBox.Show(msg & "clicking on an item of the list box.")
        Else
            MessageBox.Show(msg & "pressing an arrow key.")
        End If

        clickFlag = False
    End Sub

End Class
