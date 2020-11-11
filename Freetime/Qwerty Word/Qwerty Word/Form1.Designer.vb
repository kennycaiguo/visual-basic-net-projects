<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQwertyWord
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
        Me.txtBoxWord = New System.Windows.Forms.TextBox()
        Me.lblQwertyBoolean = New System.Windows.Forms.Label()
        Me.timerDetermination = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtBoxWord
        '
        Me.txtBoxWord.Location = New System.Drawing.Point(112, 12)
        Me.txtBoxWord.Name = "txtBoxWord"
        Me.txtBoxWord.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxWord.TabIndex = 0
        Me.txtBoxWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQwertyBoolean
        '
        Me.lblQwertyBoolean.Location = New System.Drawing.Point(12, 55)
        Me.lblQwertyBoolean.Name = "lblQwertyBoolean"
        Me.lblQwertyBoolean.Size = New System.Drawing.Size(315, 23)
        Me.lblQwertyBoolean.TabIndex = 1
        Me.lblQwertyBoolean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerDetermination
        '
        Me.timerDetermination.Enabled = True
        '
        'frmQwertyWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 109)
        Me.Controls.Add(Me.lblQwertyBoolean)
        Me.Controls.Add(Me.txtBoxWord)
        Me.Name = "frmQwertyWord"
        Me.Text = "Qwerty Word (LIVE)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBoxWord As TextBox
    Friend WithEvents lblQwertyBoolean As Label
    Friend WithEvents timerDetermination As Timer
End Class
