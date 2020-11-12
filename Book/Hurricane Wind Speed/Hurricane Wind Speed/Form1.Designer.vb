<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHurricane
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
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.txtBoxSpeed = New System.Windows.Forms.TextBox()
        Me.txtBoxRating = New System.Windows.Forms.TextBox()
        Me.timerRatingUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(13, 13)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(67, 13)
        Me.lblSpeed.TabIndex = 0
        Me.lblSpeed.Text = "Wind speed:"
        '
        'txtBoxSpeed
        '
        Me.txtBoxSpeed.Location = New System.Drawing.Point(86, 10)
        Me.txtBoxSpeed.Name = "txtBoxSpeed"
        Me.txtBoxSpeed.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxSpeed.TabIndex = 1
        '
        'txtBoxRating
        '
        Me.txtBoxRating.Location = New System.Drawing.Point(16, 45)
        Me.txtBoxRating.Name = "txtBoxRating"
        Me.txtBoxRating.ReadOnly = True
        Me.txtBoxRating.Size = New System.Drawing.Size(170, 20)
        Me.txtBoxRating.TabIndex = 2
        '
        'timerRatingUpdater
        '
        Me.timerRatingUpdater.Enabled = True
        '
        'frmHurricane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(202, 77)
        Me.Controls.Add(Me.txtBoxRating)
        Me.Controls.Add(Me.txtBoxSpeed)
        Me.Controls.Add(Me.lblSpeed)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHurricane"
        Me.Text = "Hurricane (LIVE)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSpeed As Label
    Friend WithEvents txtBoxSpeed As TextBox
    Friend WithEvents txtBoxRating As TextBox
    Friend WithEvents timerRatingUpdater As Timer
End Class
