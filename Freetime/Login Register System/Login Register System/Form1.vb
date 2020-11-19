
' 
' Copyright 2020, Kye Matzen, http://kyematzen.com
' <p>
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the
' Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software,
' and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
' <p>
' The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
' <p>
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
' MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR
' ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
' THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
'

Public Class frmLoginRegisterSystem
    Private Sub lblOption_Click(sender As Object, e As EventArgs) Handles lblOption.Click

        If lblOption.Text = "click here to create a new account" Then
            lblOption.Text = "click here to login"

            lblLogin.Visible = False

            btnLogin.Visible = False
            btnRegister.Visible = True

            Me.Text = "Register Form"

            txtBoxLoginUsername.Visible = False
            txtBoxLoginPassword.Visible = False

            txtBoxRegisterUsername.Visible = True
            txtBoxRegisterEmail.Visible = True
            txtBoxRegisterPassword.Visible = True
            txtBoxRegisterRetypePassword.Visible = True

            lblRegister.Visible = True


            Return
        End If

        lblOption.Text = "click here to create a new account"

        lblLogin.Visible = True
        lblRegister.Visible = False

        btnLogin.Visible = True
        btnRegister.Visible = False

        Me.Text = "Login Form"

        txtBoxLoginUsername.Visible = True
        txtBoxLoginPassword.Visible = True

        txtBoxRegisterUsername.Visible = False
        txtBoxRegisterEmail.Visible = False
        txtBoxRegisterPassword.Visible = False
        txtBoxRegisterRetypePassword.Visible = False
    End Sub

    Private Sub loginForm(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' No users in database and should return
        If Not IO.File.Exists("database.txt") Then
            Return
        End If
    End Sub

    Private Sub registerForm(sender As Object, e As EventArgs) Handles btnRegister.Click

        ' Check if username was entered.

        Dim username As String = txtBoxRegisterUsername.Text

        If username.Count = 0 Then
            MessageBox.Show("You must enter a username.", Me.Text)
            Return
        End If

        If username.Count > 20 Then
            MessageBox.Show("Username must be less than 20 characters.", Me.Text)
            Return
        End If

        ' Checks if there is a database before attemping to check/add them.
        If Not IO.File.Exists("database.txt") Then

        End If

    End Sub

    Function IsUsername(ByRef username As String) As Boolean
        If username.Count = 0 Or username.Count > 20 Then Return False

        Dim invalidCharacters As Integer = 0

        Return True
    End Function

End Class