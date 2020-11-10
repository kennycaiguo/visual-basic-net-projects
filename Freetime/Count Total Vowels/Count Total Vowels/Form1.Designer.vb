<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalVowels
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
        Me.lblText = New System.Windows.Forms.Label()
        Me.txtBoxText = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.vowelCounter = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(13, 13)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(289, 13)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Please enter text that you would like to find the vowels from:"
        '
        'txtBoxText
        '
        Me.txtBoxText.Location = New System.Drawing.Point(13, 30)
        Me.txtBoxText.Multiline = True
        Me.txtBoxText.Name = "txtBoxText"
        Me.txtBoxText.Size = New System.Drawing.Size(289, 197)
        Me.txtBoxText.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblTotal.Location = New System.Drawing.Point(308, 13)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(226, 214)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total Vowels: 0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'vowelCounter
        '
        Me.vowelCounter.Enabled = True
        Me.vowelCounter.Interval = 10
        '
        'frmTotalVowels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 236)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtBoxText)
        Me.Controls.Add(Me.lblText)
        Me.Name = "frmTotalVowels"
        Me.Text = "Count Total Vowels (LIVE)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblText As Label
    Friend WithEvents txtBoxText As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents vowelCounter As Timer
End Class
