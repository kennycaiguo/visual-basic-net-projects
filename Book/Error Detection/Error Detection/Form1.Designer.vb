<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidation
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
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtBoxNumber = New System.Windows.Forms.TextBox()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.lblValidQuestion = New System.Windows.Forms.Label()
        Me.lblValid = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(13, 13)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(99, 13)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Credit card number:"
        '
        'txtBoxNumber
        '
        Me.txtBoxNumber.Location = New System.Drawing.Point(118, 10)
        Me.txtBoxNumber.Name = "txtBoxNumber"
        Me.txtBoxNumber.Size = New System.Drawing.Size(143, 20)
        Me.txtBoxNumber.TabIndex = 1
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(74, 52)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(100, 23)
        Me.btnValidate.TabIndex = 2
        Me.btnValidate.Text = "Validate Number"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'lblValidQuestion
        '
        Me.lblValidQuestion.Location = New System.Drawing.Point(13, 91)
        Me.lblValidQuestion.Name = "lblValidQuestion"
        Me.lblValidQuestion.Size = New System.Drawing.Size(99, 23)
        Me.lblValidQuestion.TabIndex = 3
        Me.lblValidQuestion.Text = "Is number valid?"
        Me.lblValidQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblValid
        '
        Me.lblValid.AutoSize = True
        Me.lblValid.Location = New System.Drawing.Point(118, 96)
        Me.lblValid.Name = "lblValid"
        Me.lblValid.Size = New System.Drawing.Size(0, 13)
        Me.lblValid.TabIndex = 4
        '
        'frmValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 123)
        Me.Controls.Add(Me.lblValid)
        Me.Controls.Add(Me.lblValidQuestion)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.txtBoxNumber)
        Me.Controls.Add(Me.lblNumber)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmValidation"
        Me.Text = "Validation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber As Label
    Friend WithEvents txtBoxNumber As TextBox
    Friend WithEvents btnValidate As Button
    Friend WithEvents lblValidQuestion As Label
    Friend WithEvents lblValid As Label
End Class
