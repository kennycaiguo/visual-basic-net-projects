Public Class frmSelected

    Public Shared highlighted As Boolean = False

    ' Fires when wanting to delete from list box
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Checks if anything is highlighted.
        If Not highlighted Then Return

        ' 1. Delete First, Last and the selected item

        ' Only fires in specific scenarios when there is a low amount of items in listBox.
        If listBox.Items.Count = 2 Or listBox.Items.Count = 1 Then
            listBox.Items.Clear()
        End If

        If listBox.Items.Count >= 3 Then
            ' Deletes last item
            listBox.Items.RemoveAt(listBox.Items.Count - 1)
            Dim index As Integer = listBox.SelectedIndex

            If Not index = -1 Then
                ' Deletes selected item
                listBox.Items.RemoveAt(index)
            End If

            If Not index = 0 Then
                ' Deletes last item
                listBox.Items.RemoveAt(0)
            End If

        End If

        ' 2. Un-highlight

        If listBox.Items.Count > 1 Then
            highlighted = False
        End If

        listBox2.Items.Clear()
    End Sub

    ' Fires when interacting with the list box filled with numbers.
    Private Sub listBoxIndexChanged(sender As Object, e As EventArgs) Handles listBox.SelectedIndexChanged
        highlighted = True

        ' Clears display to to update it.
        listBox2.Items.Clear()

        Dim index As Integer = listBox.SelectedIndex

        If Not index = -1 Then

            ' 1. Display the current Selected item

            listBox2.Items.Add(listBox.Items(index))

            ' 2. Display the index value of selected Item

            listBox2.Items.Add(index)

            ' 3. Display the number of items above it.

            listBox2.Items.Add(index)

            ' 4. Display the number of items following it.

            Dim after As Integer = (listBox.Items.Count - 1) - index
            listBox2.Items.Add(after)

        End If

        ' 2. Display the index value of selected Item

    End Sub
End Class
