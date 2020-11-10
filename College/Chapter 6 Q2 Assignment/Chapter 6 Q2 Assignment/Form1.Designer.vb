<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelection
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
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.Items.AddRange(New Object() {" ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " "})
        Me.lstBox.Location = New System.Drawing.Point(-3, -10)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(242, 199)
        Me.lstBox.TabIndex = 0
        '
        'frmSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 172)
        Me.Controls.Add(Me.lstBox)
        Me.Name = "frmSelection"
        Me.Text = "Selection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstBox As ListBox
End Class
