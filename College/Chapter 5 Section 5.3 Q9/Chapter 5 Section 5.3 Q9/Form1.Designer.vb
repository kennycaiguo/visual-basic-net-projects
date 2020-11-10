<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayRaise
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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtBoxFirstName = New System.Windows.Forms.TextBox()
        Me.txtBoxLastName = New System.Windows.Forms.TextBox()
        Me.lblCurrentSalry = New System.Windows.Forms.Label()
        Me.txtBoxCurrentSalary = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtBoxNewSalary = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(13, 12)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(58, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(12, 38)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(59, 13)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last name:"
        '
        'txtBoxFirstName
        '
        Me.txtBoxFirstName.Location = New System.Drawing.Point(164, 9)
        Me.txtBoxFirstName.Name = "txtBoxFirstName"
        Me.txtBoxFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxFirstName.TabIndex = 2
        '
        'txtBoxLastName
        '
        Me.txtBoxLastName.Location = New System.Drawing.Point(164, 35)
        Me.txtBoxLastName.Name = "txtBoxLastName"
        Me.txtBoxLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxLastName.TabIndex = 3
        '
        'lblCurrentSalry
        '
        Me.lblCurrentSalry.AutoSize = True
        Me.lblCurrentSalry.Location = New System.Drawing.Point(13, 64)
        Me.lblCurrentSalry.Name = "lblCurrentSalry"
        Me.lblCurrentSalry.Size = New System.Drawing.Size(74, 13)
        Me.lblCurrentSalry.TabIndex = 4
        Me.lblCurrentSalry.Text = "Current salary:"
        '
        'txtBoxCurrentSalary
        '
        Me.txtBoxCurrentSalary.Location = New System.Drawing.Point(164, 61)
        Me.txtBoxCurrentSalary.Name = "txtBoxCurrentSalary"
        Me.txtBoxCurrentSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxCurrentSalary.TabIndex = 5
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(75, 100)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(131, 23)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "Display New Salary"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtBoxNewSalary
        '
        Me.txtBoxNewSalary.Location = New System.Drawing.Point(13, 129)
        Me.txtBoxNewSalary.Name = "txtBoxNewSalary"
        Me.txtBoxNewSalary.ReadOnly = True
        Me.txtBoxNewSalary.Size = New System.Drawing.Size(251, 20)
        Me.txtBoxNewSalary.TabIndex = 7
        '
        'frmPayRaise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 161)
        Me.Controls.Add(Me.txtBoxNewSalary)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtBoxCurrentSalary)
        Me.Controls.Add(Me.lblCurrentSalry)
        Me.Controls.Add(Me.txtBoxLastName)
        Me.Controls.Add(Me.txtBoxFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "frmPayRaise"
        Me.Text = "Pay Raise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtBoxFirstName As TextBox
    Friend WithEvents txtBoxLastName As TextBox
    Friend WithEvents lblCurrentSalry As Label
    Friend WithEvents txtBoxCurrentSalary As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtBoxNewSalary As TextBox
End Class
