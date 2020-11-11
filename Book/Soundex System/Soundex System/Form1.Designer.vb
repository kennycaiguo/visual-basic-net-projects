<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoundex
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
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtBoxCode = New System.Windows.Forms.TextBox()
        Me.btnEncode = New System.Windows.Forms.Button()
        Me.lblEncoded = New System.Windows.Forms.Label()
        Me.txtBoxEncoded = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(48, 13)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(75, 13)
        Me.lblCode.TabIndex = 0
        Me.lblCode.Text = "Word to code:"
        '
        'txtBoxCode
        '
        Me.txtBoxCode.Location = New System.Drawing.Point(129, 10)
        Me.txtBoxCode.Name = "txtBoxCode"
        Me.txtBoxCode.Size = New System.Drawing.Size(125, 20)
        Me.txtBoxCode.TabIndex = 1
        '
        'btnEncode
        '
        Me.btnEncode.Location = New System.Drawing.Point(51, 46)
        Me.btnEncode.Name = "btnEncode"
        Me.btnEncode.Size = New System.Drawing.Size(203, 23)
        Me.btnEncode.TabIndex = 2
        Me.btnEncode.Text = "Encode Word"
        Me.btnEncode.UseVisualStyleBackColor = True
        '
        'lblEncoded
        '
        Me.lblEncoded.AutoSize = True
        Me.lblEncoded.Location = New System.Drawing.Point(48, 84)
        Me.lblEncoded.Name = "lblEncoded"
        Me.lblEncoded.Size = New System.Drawing.Size(79, 13)
        Me.lblEncoded.TabIndex = 3
        Me.lblEncoded.Text = "Encoded word:"
        '
        'txtBoxEncoded
        '
        Me.txtBoxEncoded.Location = New System.Drawing.Point(129, 81)
        Me.txtBoxEncoded.Name = "txtBoxEncoded"
        Me.txtBoxEncoded.Size = New System.Drawing.Size(125, 20)
        Me.txtBoxEncoded.TabIndex = 4
        '
        'frmSoundex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 107)
        Me.Controls.Add(Me.txtBoxEncoded)
        Me.Controls.Add(Me.lblEncoded)
        Me.Controls.Add(Me.btnEncode)
        Me.Controls.Add(Me.txtBoxCode)
        Me.Controls.Add(Me.lblCode)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSoundex"
        Me.Text = "Soundex"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCode As Label
    Friend WithEvents txtBoxCode As TextBox
    Friend WithEvents btnEncode As Button
    Friend WithEvents lblEncoded As Label
    Friend WithEvents txtBoxEncoded As TextBox
End Class
