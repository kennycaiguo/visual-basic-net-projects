' Created by kyematzen.com
' Date completed on Nov 12. 2020
Public Class frmClickHandler

    Public Sub ClickHandler(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Me.Text = "You just clicked with " & getButton(e.Button) & " at position " & MousePosition().ToString
    End Sub

    Function getButton(ByRef mouseButton As MouseButtons) As String
        Select Case mouseButton
            Case MouseButtons.Left
                Return "left button"
            Case MouseButtons.Right
                Return "right button"
            Case MouseButtons.Middle
                Return "middle button"
        End Select

        Return "another mouse button"
    End Function
End Class
