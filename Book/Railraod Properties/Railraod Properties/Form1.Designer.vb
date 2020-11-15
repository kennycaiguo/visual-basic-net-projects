<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonopoly
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblProperties = New System.Windows.Forms.Label()
        Me.listBoxProperties = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(13, 13)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(92, 52)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Click on the name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the propery" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that is not an" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "actual railroad."
        '
        'lblProperties
        '
        Me.lblProperties.AutoSize = True
        Me.lblProperties.Location = New System.Drawing.Point(134, 13)
        Me.lblProperties.Name = "lblProperties"
        Me.lblProperties.Size = New System.Drawing.Size(98, 13)
        Me.lblProperties.TabIndex = 1
        Me.lblProperties.Text = "Railroad properties:"
        '
        'listBoxProperties
        '
        Me.listBoxProperties.FormattingEnabled = True
        Me.listBoxProperties.Items.AddRange(New Object() {"Reading", "Pennsylvania", "B & O", "Short Line"})
        Me.listBoxProperties.Location = New System.Drawing.Point(137, 30)
        Me.listBoxProperties.Name = "listBoxProperties"
        Me.listBoxProperties.Size = New System.Drawing.Size(95, 56)
        Me.listBoxProperties.TabIndex = 2
        '
        'frmMonopoly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 98)
        Me.Controls.Add(Me.listBoxProperties)
        Me.Controls.Add(Me.lblProperties)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "frmMonopoly"
        Me.Text = "Monopoly"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblProperties As Label
    Friend WithEvents listBoxProperties As ListBox
End Class
