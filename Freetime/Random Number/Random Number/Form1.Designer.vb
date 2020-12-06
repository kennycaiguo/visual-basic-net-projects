<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblRandomNumber = New System.Windows.Forms.Label()
        Me.lblRandomDouble = New System.Windows.Forms.Label()
        Me.lblRandomRounded = New System.Windows.Forms.Label()
        Me.lblRandomInteger = New System.Windows.Forms.Label()
        Me.lblRandomRange = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRandomNumber
        '
        Me.lblRandomNumber.AutoSize = True
        Me.lblRandomNumber.Location = New System.Drawing.Point(13, 13)
        Me.lblRandomNumber.Name = "lblRandomNumber"
        Me.lblRandomNumber.Size = New System.Drawing.Size(90, 13)
        Me.lblRandomNumber.TabIndex = 0
        Me.lblRandomNumber.Text = "Random Number:"
        '
        'lblRandomDouble
        '
        Me.lblRandomDouble.AutoSize = True
        Me.lblRandomDouble.Location = New System.Drawing.Point(13, 26)
        Me.lblRandomDouble.Name = "lblRandomDouble"
        Me.lblRandomDouble.Size = New System.Drawing.Size(87, 13)
        Me.lblRandomDouble.TabIndex = 1
        Me.lblRandomDouble.Text = "Random Double:"
        '
        'lblRandomRounded
        '
        Me.lblRandomRounded.AutoSize = True
        Me.lblRandomRounded.Location = New System.Drawing.Point(12, 39)
        Me.lblRandomRounded.Name = "lblRandomRounded"
        Me.lblRandomRounded.Size = New System.Drawing.Size(97, 13)
        Me.lblRandomRounded.TabIndex = 2
        Me.lblRandomRounded.Text = "Random Rounded:"
        '
        'lblRandomInteger
        '
        Me.lblRandomInteger.AutoSize = True
        Me.lblRandomInteger.Location = New System.Drawing.Point(12, 52)
        Me.lblRandomInteger.Name = "lblRandomInteger"
        Me.lblRandomInteger.Size = New System.Drawing.Size(86, 13)
        Me.lblRandomInteger.TabIndex = 3
        Me.lblRandomInteger.Text = "Random Integer:"
        '
        'lblRandomRange
        '
        Me.lblRandomRange.AutoSize = True
        Me.lblRandomRange.Location = New System.Drawing.Point(12, 65)
        Me.lblRandomRange.Name = "lblRandomRange"
        Me.lblRandomRange.Size = New System.Drawing.Size(85, 13)
        Me.lblRandomRange.TabIndex = 4
        Me.lblRandomRange.Text = "Random Range:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 128)
        Me.Controls.Add(Me.lblRandomRange)
        Me.Controls.Add(Me.lblRandomInteger)
        Me.Controls.Add(Me.lblRandomRounded)
        Me.Controls.Add(Me.lblRandomDouble)
        Me.Controls.Add(Me.lblRandomNumber)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRandomNumber As Label
    Friend WithEvents lblRandomDouble As Label
    Friend WithEvents lblRandomRounded As Label
    Friend WithEvents lblRandomInteger As Label
    Friend WithEvents lblRandomRange As Label
End Class
