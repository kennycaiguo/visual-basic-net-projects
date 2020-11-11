<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalyze
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
        Me.timerAnalyze = New System.Windows.Forms.Timer(Me.components)
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.txtBoxSentence = New System.Windows.Forms.TextBox()
        Me.lblWords = New System.Windows.Forms.Label()
        Me.lblLetters = New System.Windows.Forms.Label()
        Me.lblVowels = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'timerAnalyze
        '
        Me.timerAnalyze.Enabled = True
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Location = New System.Drawing.Point(13, 13)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(56, 13)
        Me.lblSentence.TabIndex = 0
        Me.lblSentence.Text = "Sentence:"
        '
        'txtBoxSentence
        '
        Me.txtBoxSentence.Location = New System.Drawing.Point(75, 10)
        Me.txtBoxSentence.Name = "txtBoxSentence"
        Me.txtBoxSentence.Size = New System.Drawing.Size(236, 20)
        Me.txtBoxSentence.TabIndex = 1
        '
        'lblWords
        '
        Me.lblWords.AutoSize = True
        Me.lblWords.ForeColor = System.Drawing.Color.Black
        Me.lblWords.Location = New System.Drawing.Point(13, 40)
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(41, 13)
        Me.lblWords.TabIndex = 3
        Me.lblWords.Text = "Words:"
        '
        'lblLetters
        '
        Me.lblLetters.AutoSize = True
        Me.lblLetters.Location = New System.Drawing.Point(12, 53)
        Me.lblLetters.Name = "lblLetters"
        Me.lblLetters.Size = New System.Drawing.Size(42, 13)
        Me.lblLetters.TabIndex = 4
        Me.lblLetters.Text = "Letters:"
        '
        'lblVowels
        '
        Me.lblVowels.AutoSize = True
        Me.lblVowels.Location = New System.Drawing.Point(13, 66)
        Me.lblVowels.Name = "lblVowels"
        Me.lblVowels.Size = New System.Drawing.Size(44, 13)
        Me.lblVowels.TabIndex = 5
        Me.lblVowels.Text = "Vowels:"
        '
        'frmAnalyze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 91)
        Me.Controls.Add(Me.lblVowels)
        Me.Controls.Add(Me.lblLetters)
        Me.Controls.Add(Me.lblWords)
        Me.Controls.Add(Me.txtBoxSentence)
        Me.Controls.Add(Me.lblSentence)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnalyze"
        Me.Text = "Analyze A Sentence (LIVE)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timerAnalyze As Timer
    Friend WithEvents lblSentence As Label
    Friend WithEvents txtBoxSentence As TextBox
    Friend WithEvents lblWords As Label
    Friend WithEvents lblLetters As Label
    Friend WithEvents lblVowels As Label
End Class
