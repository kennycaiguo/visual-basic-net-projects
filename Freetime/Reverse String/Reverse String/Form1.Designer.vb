<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReverseString
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
        Me.txtBoxOriginal = New System.Windows.Forms.TextBox()
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.lblReversed = New System.Windows.Forms.Label()
        Me.txtBoxReversed = New System.Windows.Forms.TextBox()
        Me.reverseStringer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtBoxOriginal
        '
        Me.txtBoxOriginal.Location = New System.Drawing.Point(12, 21)
        Me.txtBoxOriginal.Name = "txtBoxOriginal"
        Me.txtBoxOriginal.Size = New System.Drawing.Size(349, 20)
        Me.txtBoxOriginal.TabIndex = 0
        '
        'lblOriginal
        '
        Me.lblOriginal.AutoSize = True
        Me.lblOriginal.Location = New System.Drawing.Point(12, 5)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(45, 13)
        Me.lblOriginal.TabIndex = 1
        Me.lblOriginal.Text = "Original:"
        '
        'lblReversed
        '
        Me.lblReversed.AutoSize = True
        Me.lblReversed.Location = New System.Drawing.Point(12, 48)
        Me.lblReversed.Name = "lblReversed"
        Me.lblReversed.Size = New System.Drawing.Size(56, 13)
        Me.lblReversed.TabIndex = 2
        Me.lblReversed.Text = "Reversed:"
        '
        'txtBoxReversed
        '
        Me.txtBoxReversed.Location = New System.Drawing.Point(12, 64)
        Me.txtBoxReversed.Name = "txtBoxReversed"
        Me.txtBoxReversed.ReadOnly = True
        Me.txtBoxReversed.Size = New System.Drawing.Size(349, 20)
        Me.txtBoxReversed.TabIndex = 3
        '
        'reverseStringer
        '
        Me.reverseStringer.Enabled = True
        Me.reverseStringer.Interval = 10
        '
        'frmReverseString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 94)
        Me.Controls.Add(Me.txtBoxReversed)
        Me.Controls.Add(Me.lblReversed)
        Me.Controls.Add(Me.lblOriginal)
        Me.Controls.Add(Me.txtBoxOriginal)
        Me.Name = "frmReverseString"
        Me.Text = "Reverse String (LIVE)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBoxOriginal As TextBox
    Friend WithEvents lblOriginal As Label
    Friend WithEvents lblReversed As Label
    Friend WithEvents txtBoxReversed As TextBox
    Friend WithEvents reverseStringer As Timer
End Class
