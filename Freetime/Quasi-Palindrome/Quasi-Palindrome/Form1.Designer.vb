<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuasiPalindrome
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
        Me.components = New System.ComponentModel.Container()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.txtBoxWord = New System.Windows.Forms.TextBox()
        Me.lblConclusion = New System.Windows.Forms.Label()
        Me.lblConclusionAnswer = New System.Windows.Forms.Label()
        Me.timerConclusion = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(13, 13)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(70, 13)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter a word:"
        '
        'txtBoxWord
        '
        Me.txtBoxWord.Location = New System.Drawing.Point(89, 10)
        Me.txtBoxWord.Name = "txtBoxWord"
        Me.txtBoxWord.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxWord.TabIndex = 1
        '
        'lblConclusion
        '
        Me.lblConclusion.AutoSize = True
        Me.lblConclusion.Location = New System.Drawing.Point(13, 47)
        Me.lblConclusion.Name = "lblConclusion"
        Me.lblConclusion.Size = New System.Drawing.Size(62, 13)
        Me.lblConclusion.TabIndex = 2
        Me.lblConclusion.Text = "Conclusion:"
        '
        'lblConclusionAnswer
        '
        Me.lblConclusionAnswer.Location = New System.Drawing.Point(86, 47)
        Me.lblConclusionAnswer.Name = "lblConclusionAnswer"
        Me.lblConclusionAnswer.Size = New System.Drawing.Size(105, 13)
        Me.lblConclusionAnswer.TabIndex = 3
        Me.lblConclusionAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerConclusion
        '
        Me.timerConclusion.Enabled = True
        '
        'frmQuasiPalindrome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 79)
        Me.Controls.Add(Me.lblConclusionAnswer)
        Me.Controls.Add(Me.lblConclusion)
        Me.Controls.Add(Me.txtBoxWord)
        Me.Controls.Add(Me.lblEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuasiPalindrome"
        Me.Text = "Quasi-Palindrome (LIVE)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnter As Label
    Friend WithEvents txtBoxWord As TextBox
    Friend WithEvents lblConclusion As Label
    Friend WithEvents lblConclusionAnswer As Label
    Friend WithEvents timerConclusion As Timer
End Class
