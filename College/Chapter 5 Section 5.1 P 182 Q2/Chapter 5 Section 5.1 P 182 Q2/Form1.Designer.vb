<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirstName
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
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtBoxFullName = New System.Windows.Forms.TextBox()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtBoxFirstName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(13, 13)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(57, 13)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name:"
        '
        'txtBoxFullName
        '
        Me.txtBoxFullName.Location = New System.Drawing.Point(76, 10)
        Me.txtBoxFullName.Name = "txtBoxFullName"
        Me.txtBoxFullName.Size = New System.Drawing.Size(173, 20)
        Me.txtBoxFullName.TabIndex = 1
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(65, 58)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(123, 23)
        Me.btnDetermine.TabIndex = 2
        Me.btnDetermine.Text = "Determine First Name"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(12, 117)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name:"
        '
        'txtBoxFirstName
        '
        Me.txtBoxFirstName.Location = New System.Drawing.Point(76, 114)
        Me.txtBoxFirstName.Name = "txtBoxFirstName"
        Me.txtBoxFirstName.Size = New System.Drawing.Size(173, 20)
        Me.txtBoxFirstName.TabIndex = 4
        '
        'frmFirstName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 143)
        Me.Controls.Add(Me.txtBoxFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.txtBoxFullName)
        Me.Controls.Add(Me.lblFullName)
        Me.Name = "frmFirstName"
        Me.Text = "First Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFullName As Label
    Friend WithEvents txtBoxFullName As TextBox
    Friend WithEvents btnDetermine As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtBoxFirstName As TextBox
End Class
