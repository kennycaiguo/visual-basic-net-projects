<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresident
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
        Me.txtBoxAnswer = New System.Windows.Forms.TextBox()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.lblGuesses = New System.Windows.Forms.Label()
        Me.txtBoxGuesses = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(13, 13)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(205, 13)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Which U.S. president was born on July 4?"
        '
        'txtBoxAnswer
        '
        Me.txtBoxAnswer.Location = New System.Drawing.Point(224, 10)
        Me.txtBoxAnswer.Name = "txtBoxAnswer"
        Me.txtBoxAnswer.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxAnswer.TabIndex = 1
        '
        'btnEvaluate
        '
        Me.btnEvaluate.Location = New System.Drawing.Point(16, 42)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(98, 23)
        Me.btnEvaluate.TabIndex = 2
        Me.btnEvaluate.Text = "Evaluate Answer"
        Me.btnEvaluate.UseVisualStyleBackColor = True
        '
        'lblGuesses
        '
        Me.lblGuesses.AutoSize = True
        Me.lblGuesses.Location = New System.Drawing.Point(16, 86)
        Me.lblGuesses.Name = "lblGuesses"
        Me.lblGuesses.Size = New System.Drawing.Size(104, 13)
        Me.lblGuesses.TabIndex = 3
        Me.lblGuesses.Text = "Number of guesses: "
        '
        'txtBoxGuesses
        '
        Me.txtBoxGuesses.Location = New System.Drawing.Point(301, 86)
        Me.txtBoxGuesses.Name = "txtBoxGuesses"
        Me.txtBoxGuesses.ReadOnly = True
        Me.txtBoxGuesses.Size = New System.Drawing.Size(23, 20)
        Me.txtBoxGuesses.TabIndex = 4
        '
        'frmPresident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 116)
        Me.Controls.Add(Me.txtBoxGuesses)
        Me.Controls.Add(Me.lblGuesses)
        Me.Controls.Add(Me.btnEvaluate)
        Me.Controls.Add(Me.txtBoxAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "frmPresident"
        Me.Text = "President"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion As Label
    Friend WithEvents txtBoxAnswer As TextBox
    Friend WithEvents btnEvaluate As Button
    Friend WithEvents lblGuesses As Label
    Friend WithEvents txtBoxGuesses As TextBox
End Class
