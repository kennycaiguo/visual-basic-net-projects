<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumber
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
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.txtBoxNumber = New System.Windows.Forms.TextBox()
        Me.btnDetermination = New System.Windows.Forms.Button()
        Me.listBoxOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(13, 13)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(148, 13)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "What is your favorite number?"
        '
        'txtBoxNumber
        '
        Me.txtBoxNumber.Location = New System.Drawing.Point(167, 10)
        Me.txtBoxNumber.Name = "txtBoxNumber"
        Me.txtBoxNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxNumber.TabIndex = 1
        '
        'btnDetermination
        '
        Me.btnDetermination.Location = New System.Drawing.Point(63, 48)
        Me.btnDetermination.Name = "btnDetermination"
        Me.btnDetermination.Size = New System.Drawing.Size(155, 23)
        Me.btnDetermination.TabIndex = 2
        Me.btnDetermination.Text = "Determine Sum and Product"
        Me.btnDetermination.UseVisualStyleBackColor = True
        '
        'listBoxOutput
        '
        Me.listBoxOutput.FormattingEnabled = True
        Me.listBoxOutput.Location = New System.Drawing.Point(12, 88)
        Me.listBoxOutput.Name = "listBoxOutput"
        Me.listBoxOutput.Size = New System.Drawing.Size(255, 30)
        Me.listBoxOutput.TabIndex = 3
        '
        'frmNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 127)
        Me.Controls.Add(Me.listBoxOutput)
        Me.Controls.Add(Me.btnDetermination)
        Me.Controls.Add(Me.txtBoxNumber)
        Me.Controls.Add(Me.lblQuestion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNumber"
        Me.Text = "Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion As Label
    Friend WithEvents txtBoxNumber As TextBox
    Friend WithEvents btnDetermination As Button
    Friend WithEvents listBoxOutput As ListBox
End Class
