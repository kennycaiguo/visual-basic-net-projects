Public Class frmMonopoly
    Private Sub selectedProperty(sender As Object, e As EventArgs) Handles listBoxProperties.SelectedIndexChanged
        If Not listBoxProperties.SelectedIndex = -1 Then
            Dim name As String = listBoxProperties.Items(listBoxProperties.SelectedIndex)

            Select Case name
                Case "Reading"
                    MessageBox.Show(name & " is a railroad.", "Wrong")
                Case "Pennsylvania"
                    MessageBox.Show(name & " is a railroad.", "Wrong")
                Case "B & O"
                    MessageBox.Show(name & " is a railroad.", "Wrong")
                Case Else
                    MessageBox.Show("Short Line is a bus company.", "Correct")
            End Select
        End If
    End Sub
End Class
