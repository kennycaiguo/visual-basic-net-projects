<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddress
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
        Me.txtBoxName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnAddress = New System.Windows.Forms.Button()
        Me.listBoxLetter = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtBoxName
        '
        Me.txtBoxName.Location = New System.Drawing.Point(57, 10)
        Me.txtBoxName.Name = "txtBoxName"
        Me.txtBoxName.Size = New System.Drawing.Size(228, 20)
        Me.txtBoxName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'btnAddress
        '
        Me.btnAddress.Location = New System.Drawing.Point(12, 36)
        Me.btnAddress.Name = "btnAddress"
        Me.btnAddress.Size = New System.Drawing.Size(272, 23)
        Me.btnAddress.TabIndex = 2
        Me.btnAddress.Text = "Address Letter to a Senator"
        Me.btnAddress.UseVisualStyleBackColor = True
        '
        'listBoxLetter
        '
        Me.listBoxLetter.FormattingEnabled = True
        Me.listBoxLetter.Location = New System.Drawing.Point(13, 65)
        Me.listBoxLetter.Name = "listBoxLetter"
        Me.listBoxLetter.Size = New System.Drawing.Size(272, 82)
        Me.listBoxLetter.TabIndex = 3
        '
        'frmAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 156)
        Me.Controls.Add(Me.listBoxLetter)
        Me.Controls.Add(Me.btnAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtBoxName)
        Me.Name = "frmAddress"
        Me.Text = "Address"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBoxName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnAddress As Button
    Friend WithEvents listBoxLetter As ListBox
End Class
