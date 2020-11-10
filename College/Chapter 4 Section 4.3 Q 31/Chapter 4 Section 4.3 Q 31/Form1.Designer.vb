<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgeOfATire
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
        Me.lblFourDigits = New System.Windows.Forms.Label()
        Me.maskedTxtBoxDigits = New System.Windows.Forms.MaskedTextBox()
        Me.btnDetermination = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtBoxYear = New System.Windows.Forms.TextBox()
        Me.lblWeek = New System.Windows.Forms.Label()
        Me.txtBoxWeek = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFourDigits
        '
        Me.lblFourDigits.AutoSize = True
        Me.lblFourDigits.Location = New System.Drawing.Point(10, 13)
        Me.lblFourDigits.Name = "lblFourDigits"
        Me.lblFourDigits.Size = New System.Drawing.Size(102, 13)
        Me.lblFourDigits.TabIndex = 0
        Me.lblFourDigits.Text = " Last 4 digits of TIN:"
        '
        'maskedTxtBoxDigits
        '
        Me.maskedTxtBoxDigits.Location = New System.Drawing.Point(192, 10)
        Me.maskedTxtBoxDigits.Mask = "0000"
        Me.maskedTxtBoxDigits.Name = "maskedTxtBoxDigits"
        Me.maskedTxtBoxDigits.Size = New System.Drawing.Size(33, 20)
        Me.maskedTxtBoxDigits.TabIndex = 1
        Me.maskedTxtBoxDigits.ValidatingType = GetType(Integer)
        '
        'btnDetermination
        '
        Me.btnDetermination.Location = New System.Drawing.Point(13, 40)
        Me.btnDetermination.Name = "btnDetermination"
        Me.btnDetermination.Size = New System.Drawing.Size(212, 23)
        Me.btnDetermination.TabIndex = 2
        Me.btnDetermination.Text = "Determine When Tire Was Manufactured"
        Me.btnDetermination.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(10, 77)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 3
        Me.lblYear.Text = "Year:"
        '
        'txtBoxYear
        '
        Me.txtBoxYear.Location = New System.Drawing.Point(48, 74)
        Me.txtBoxYear.Name = "txtBoxYear"
        Me.txtBoxYear.ReadOnly = True
        Me.txtBoxYear.Size = New System.Drawing.Size(58, 20)
        Me.txtBoxYear.TabIndex = 4
        '
        'lblWeek
        '
        Me.lblWeek.AutoSize = True
        Me.lblWeek.Location = New System.Drawing.Point(128, 77)
        Me.lblWeek.Name = "lblWeek"
        Me.lblWeek.Size = New System.Drawing.Size(39, 13)
        Me.lblWeek.TabIndex = 5
        Me.lblWeek.Text = "Week:"
        '
        'txtBoxWeek
        '
        Me.txtBoxWeek.Location = New System.Drawing.Point(173, 74)
        Me.txtBoxWeek.Name = "txtBoxWeek"
        Me.txtBoxWeek.ReadOnly = True
        Me.txtBoxWeek.Size = New System.Drawing.Size(52, 20)
        Me.txtBoxWeek.TabIndex = 6
        '
        'frmAgeOfATire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 102)
        Me.Controls.Add(Me.txtBoxWeek)
        Me.Controls.Add(Me.lblWeek)
        Me.Controls.Add(Me.txtBoxYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.btnDetermination)
        Me.Controls.Add(Me.maskedTxtBoxDigits)
        Me.Controls.Add(Me.lblFourDigits)
        Me.Name = "frmAgeOfATire"
        Me.Text = "Age of a Tire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFourDigits As Label
    Friend WithEvents maskedTxtBoxDigits As MaskedTextBox
    Friend WithEvents btnDetermination As Button
    Friend WithEvents lblYear As Label
    Friend WithEvents txtBoxYear As TextBox
    Friend WithEvents lblWeek As Label
    Friend WithEvents txtBoxWeek As TextBox
End Class
