Public Class frmMonopoly
    Private Sub selectedProperty(sender As Object, e As EventArgs) Handles listBoxProperties.SelectedIndexChanged
        If Not listBoxProperties.SelectedIndex = -1 Then
            Dim name As String = listBoxProperties.Items(listBoxProperties.SelectedIndex)

            Select Case name
                Case "Short Line"
                    MessageBox.Show("Short Line is a bus company.", "Correct")
                Case Else
                    MessageBox.Show(name & " is a railroad.", "Wrong")
            End Select
        End If
    End Sub
End Class
