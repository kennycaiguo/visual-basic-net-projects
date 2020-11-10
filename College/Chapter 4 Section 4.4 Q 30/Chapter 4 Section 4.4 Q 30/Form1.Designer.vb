<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHello
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
        Me.rButtonRed = New System.Windows.Forms.RadioButton()
        Me.rButtonBlue = New System.Windows.Forms.RadioButton()
        Me.rButtonGreen = New System.Windows.Forms.RadioButton()
        Me.rButtonEnglish = New System.Windows.Forms.RadioButton()
        Me.rButtonFrench = New System.Windows.Forms.RadioButton()
        Me.rButtonItalian = New System.Windows.Forms.RadioButton()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.groupBoxColor = New System.Windows.Forms.GroupBox()
        Me.groupBoxLanguage = New System.Windows.Forms.GroupBox()
        Me.groupBoxColor.SuspendLayout()
        Me.groupBoxLanguage.SuspendLayout()
        Me.SuspendLayout()
        '
        'rButtonRed
        '
        Me.rButtonRed.AutoSize = True
        Me.rButtonRed.Checked = True
        Me.rButtonRed.Location = New System.Drawing.Point(6, 19)
        Me.rButtonRed.Name = "rButtonRed"
        Me.rButtonRed.Size = New System.Drawing.Size(45, 17)
        Me.rButtonRed.TabIndex = 0
        Me.rButtonRed.TabStop = True
        Me.rButtonRed.Text = "Red"
        Me.rButtonRed.UseVisualStyleBackColor = True
        '
        'rButtonBlue
        '
        Me.rButtonBlue.AutoSize = True
        Me.rButtonBlue.Location = New System.Drawing.Point(6, 42)
        Me.rButtonBlue.Name = "rButtonBlue"
        Me.rButtonBlue.Size = New System.Drawing.Size(46, 17)
        Me.rButtonBlue.TabIndex = 2
        Me.rButtonBlue.Text = "Blue"
        Me.rButtonBlue.UseVisualStyleBackColor = True
        '
        'rButtonGreen
        '
        Me.rButtonGreen.AutoSize = True
        Me.rButtonGreen.Location = New System.Drawing.Point(6, 65)
        Me.rButtonGreen.Name = "rButtonGreen"
        Me.rButtonGreen.Size = New System.Drawing.Size(54, 17)
        Me.rButtonGreen.TabIndex = 3
        Me.rButtonGreen.Text = "Green"
        Me.rButtonGreen.UseVisualStyleBackColor = True
        '
        'rButtonEnglish
        '
        Me.rButtonEnglish.AutoSize = True
        Me.rButtonEnglish.Checked = True
        Me.rButtonEnglish.Location = New System.Drawing.Point(6, 19)
        Me.rButtonEnglish.Name = "rButtonEnglish"
        Me.rButtonEnglish.Size = New System.Drawing.Size(59, 17)
        Me.rButtonEnglish.TabIndex = 5
        Me.rButtonEnglish.TabStop = True
        Me.rButtonEnglish.Text = "English"
        Me.rButtonEnglish.UseVisualStyleBackColor = True
        '
        'rButtonFrench
        '
        Me.rButtonFrench.AutoSize = True
        Me.rButtonFrench.Location = New System.Drawing.Point(6, 42)
        Me.rButtonFrench.Name = "rButtonFrench"
        Me.rButtonFrench.Size = New System.Drawing.Size(58, 17)
        Me.rButtonFrench.TabIndex = 6
        Me.rButtonFrench.Text = "French"
        Me.rButtonFrench.UseVisualStyleBackColor = True
        '
        'rButtonItalian
        '
        Me.rButtonItalian.AutoSize = True
        Me.rButtonItalian.Location = New System.Drawing.Point(6, 65)
        Me.rButtonItalian.Name = "rButtonItalian"
        Me.rButtonItalian.Size = New System.Drawing.Size(53, 17)
        Me.rButtonItalian.TabIndex = 7
        Me.rButtonItalian.Text = "Italian"
        Me.rButtonItalian.UseVisualStyleBackColor = True
        '
        'lblHello
        '
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!)
        Me.lblHello.Location = New System.Drawing.Point(12, 120)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(191, 32)
        Me.lblHello.TabIndex = 8
        Me.lblHello.Text = "Hello"
        Me.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupBoxColor
        '
        Me.groupBoxColor.Controls.Add(Me.rButtonRed)
        Me.groupBoxColor.Controls.Add(Me.rButtonBlue)
        Me.groupBoxColor.Controls.Add(Me.rButtonGreen)
        Me.groupBoxColor.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxColor.Name = "groupBoxColor"
        Me.groupBoxColor.Size = New System.Drawing.Size(75, 100)
        Me.groupBoxColor.TabIndex = 9
        Me.groupBoxColor.TabStop = False
        Me.groupBoxColor.Text = "Color"
        '
        'groupBoxLanguage
        '
        Me.groupBoxLanguage.Controls.Add(Me.rButtonEnglish)
        Me.groupBoxLanguage.Controls.Add(Me.rButtonFrench)
        Me.groupBoxLanguage.Controls.Add(Me.rButtonItalian)
        Me.groupBoxLanguage.Location = New System.Drawing.Point(128, 12)
        Me.groupBoxLanguage.Name = "groupBoxLanguage"
        Me.groupBoxLanguage.Size = New System.Drawing.Size(75, 100)
        Me.groupBoxLanguage.TabIndex = 10
        Me.groupBoxLanguage.TabStop = False
        Me.groupBoxLanguage.Text = "Language"
        '
        'frmHello
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 161)
        Me.Controls.Add(Me.groupBoxLanguage)
        Me.Controls.Add(Me.groupBoxColor)
        Me.Controls.Add(Me.lblHello)
        Me.MaximizeBox = False
        Me.Name = "frmHello"
        Me.Text = "Hello"
        Me.groupBoxColor.ResumeLayout(False)
        Me.groupBoxColor.PerformLayout()
        Me.groupBoxLanguage.ResumeLayout(False)
        Me.groupBoxLanguage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rButtonRed As RadioButton
    Friend WithEvents rButtonBlue As RadioButton
    Friend WithEvents rButtonGreen As RadioButton
    Friend WithEvents rButtonEnglish As RadioButton
    Friend WithEvents rButtonFrench As RadioButton
    Friend WithEvents rButtonItalian As RadioButton
    Friend WithEvents lblHello As Label
    Friend WithEvents groupBoxColor As GroupBox
    Friend WithEvents groupBoxLanguage As GroupBox
End Class
