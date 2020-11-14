<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoteForOne
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
        Me.groupBoxPresident = New System.Windows.Forms.GroupBox()
        Me.rButtonKennedy = New System.Windows.Forms.RadioButton()
        Me.rButtonNixon = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCast = New System.Windows.Forms.Button()
        Me.txtBoxVote = New System.Windows.Forms.TextBox()
        Me.groupBoxPresident.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBoxPresident
        '
        Me.groupBoxPresident.Controls.Add(Me.rButtonNixon)
        Me.groupBoxPresident.Controls.Add(Me.rButtonKennedy)
        Me.groupBoxPresident.Location = New System.Drawing.Point(55, 12)
        Me.groupBoxPresident.Name = "groupBoxPresident"
        Me.groupBoxPresident.Size = New System.Drawing.Size(96, 66)
        Me.groupBoxPresident.TabIndex = 0
        Me.groupBoxPresident.TabStop = False
        Me.groupBoxPresident.Text = "President"
        '
        'rButtonKennedy
        '
        Me.rButtonKennedy.AutoSize = True
        Me.rButtonKennedy.Location = New System.Drawing.Point(7, 20)
        Me.rButtonKennedy.Name = "rButtonKennedy"
        Me.rButtonKennedy.Size = New System.Drawing.Size(67, 17)
        Me.rButtonKennedy.TabIndex = 0
        Me.rButtonKennedy.TabStop = True
        Me.rButtonKennedy.Text = "Kennedy"
        Me.rButtonKennedy.UseVisualStyleBackColor = True
        '
        'rButtonNixon
        '
        Me.rButtonNixon.AutoSize = True
        Me.rButtonNixon.Location = New System.Drawing.Point(7, 43)
        Me.rButtonNixon.Name = "rButtonNixon"
        Me.rButtonNixon.Size = New System.Drawing.Size(52, 17)
        Me.rButtonNixon.TabIndex = 1
        Me.rButtonNixon.TabStop = True
        Me.rButtonNixon.Text = "Nixon"
        Me.rButtonNixon.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(23, 95)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(154, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Selected Candidate"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCast
        '
        Me.btnCast.Location = New System.Drawing.Point(55, 124)
        Me.btnCast.Name = "btnCast"
        Me.btnCast.Size = New System.Drawing.Size(89, 23)
        Me.btnCast.TabIndex = 2
        Me.btnCast.Text = "Cast Vote"
        Me.btnCast.UseVisualStyleBackColor = True
        '
        'txtBoxVote
        '
        Me.txtBoxVote.Location = New System.Drawing.Point(13, 161)
        Me.txtBoxVote.Name = "txtBoxVote"
        Me.txtBoxVote.ReadOnly = True
        Me.txtBoxVote.Size = New System.Drawing.Size(181, 20)
        Me.txtBoxVote.TabIndex = 3
        '
        'frmVoteForOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 188)
        Me.Controls.Add(Me.txtBoxVote)
        Me.Controls.Add(Me.btnCast)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.groupBoxPresident)
        Me.Name = "frmVoteForOne"
        Me.Text = "Vote For One"
        Me.groupBoxPresident.ResumeLayout(False)
        Me.groupBoxPresident.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents groupBoxPresident As GroupBox
    Friend WithEvents rButtonNixon As RadioButton
    Friend WithEvents rButtonKennedy As RadioButton
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCast As Button
    Friend WithEvents txtBoxVote As TextBox
End Class
