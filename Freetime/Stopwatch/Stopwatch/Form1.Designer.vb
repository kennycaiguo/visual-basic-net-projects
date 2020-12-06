<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStopwatch
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtBoxSeconds = New System.Windows.Forms.TextBox()
        Me.timerClock = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(74, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(155, 12)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.Location = New System.Drawing.Point(12, 38)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(283, 23)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Seconds"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBoxSeconds
        '
        Me.txtBoxSeconds.Location = New System.Drawing.Point(15, 65)
        Me.txtBoxSeconds.Name = "txtBoxSeconds"
        Me.txtBoxSeconds.ReadOnly = True
        Me.txtBoxSeconds.Size = New System.Drawing.Size(280, 20)
        Me.txtBoxSeconds.TabIndex = 3
        Me.txtBoxSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'timerClock
        '
        '
        'frmStopwatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 102)
        Me.Controls.Add(Me.txtBoxSeconds)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStopwatch"
        Me.Text = "Stopwatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents txtBoxSeconds As TextBox
    Friend WithEvents timerClock As Timer
End Class
