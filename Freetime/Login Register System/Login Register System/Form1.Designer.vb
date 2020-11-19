<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginRegisterSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtBoxLoginUsername = New System.Windows.Forms.TextBox()
        Me.txtBoxLoginPassword = New System.Windows.Forms.TextBox()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.txtBoxRegisterUsername = New System.Windows.Forms.TextBox()
        Me.txtBoxRegisterEmail = New System.Windows.Forms.TextBox()
        Me.txtBoxRegisterPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtBoxRegisterRetypePassword = New System.Windows.Forms.TextBox()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.Location = New System.Drawing.Point(12, 9)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(221, 192)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Username:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBoxLoginUsername
        '
        Me.txtBoxLoginUsername.Location = New System.Drawing.Point(110, 77)
        Me.txtBoxLoginUsername.Name = "txtBoxLoginUsername"
        Me.txtBoxLoginUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxLoginUsername.TabIndex = 1
        '
        'txtBoxLoginPassword
        '
        Me.txtBoxLoginPassword.Location = New System.Drawing.Point(110, 103)
        Me.txtBoxLoginPassword.Name = "txtBoxLoginPassword"
        Me.txtBoxLoginPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxLoginPassword.TabIndex = 2
        '
        'lblRegister
        '
        Me.lblRegister.Location = New System.Drawing.Point(6, 2)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(221, 206)
        Me.lblRegister.TabIndex = 3
        Me.lblRegister.Text = "Username:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Retype Password:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRegister.Visible = False
        '
        'txtBoxRegisterUsername
        '
        Me.txtBoxRegisterUsername.Location = New System.Drawing.Point(110, 51)
        Me.txtBoxRegisterUsername.Name = "txtBoxRegisterUsername"
        Me.txtBoxRegisterUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxRegisterUsername.TabIndex = 4
        Me.txtBoxRegisterUsername.Visible = False
        '
        'txtBoxRegisterEmail
        '
        Me.txtBoxRegisterEmail.Location = New System.Drawing.Point(110, 77)
        Me.txtBoxRegisterEmail.Name = "txtBoxRegisterEmail"
        Me.txtBoxRegisterEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxRegisterEmail.TabIndex = 5
        Me.txtBoxRegisterEmail.Visible = False
        '
        'txtBoxRegisterPassword
        '
        Me.txtBoxRegisterPassword.Location = New System.Drawing.Point(110, 103)
        Me.txtBoxRegisterPassword.Name = "txtBoxRegisterPassword"
        Me.txtBoxRegisterPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxRegisterPassword.TabIndex = 6
        Me.txtBoxRegisterPassword.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(88, 178)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtBoxRegisterRetypePassword
        '
        Me.txtBoxRegisterRetypePassword.Location = New System.Drawing.Point(110, 129)
        Me.txtBoxRegisterRetypePassword.Name = "txtBoxRegisterRetypePassword"
        Me.txtBoxRegisterRetypePassword.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxRegisterRetypePassword.TabIndex = 9
        Me.txtBoxRegisterRetypePassword.Visible = False
        '
        'lblOption
        '
        Me.lblOption.Location = New System.Drawing.Point(6, 204)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(246, 23)
        Me.lblOption.TabIndex = 10
        Me.lblOption.Text = "click here to create a new account"
        Me.lblOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(88, 178)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 11
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'frmLoginRegisterSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 232)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblOption)
        Me.Controls.Add(Me.txtBoxRegisterRetypePassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtBoxRegisterPassword)
        Me.Controls.Add(Me.txtBoxRegisterEmail)
        Me.Controls.Add(Me.txtBoxRegisterUsername)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.txtBoxLoginPassword)
        Me.Controls.Add(Me.txtBoxLoginUsername)
        Me.Controls.Add(Me.lblLogin)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoginRegisterSystem"
        Me.Text = "Login Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents txtBoxLoginUsername As TextBox
    Friend WithEvents txtBoxLoginPassword As TextBox
    Friend WithEvents lblRegister As Label
    Friend WithEvents txtBoxRegisterUsername As TextBox
    Friend WithEvents txtBoxRegisterEmail As TextBox
    Friend WithEvents txtBoxRegisterPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtBoxRegisterRetypePassword As TextBox
    Friend WithEvents lblOption As Label
    Friend WithEvents btnRegister As Button
End Class
