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
End Class