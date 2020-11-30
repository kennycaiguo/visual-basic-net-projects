<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCowboys
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
        Me.btnCreateFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateFile
        '
        Me.btnCreateFile.Location = New System.Drawing.Point(100, 80)
        Me.btnCreateFile.Name = "btnCreateFile"
        Me.btnCreateFile.Size = New System.Drawing.Size(98, 41)
        Me.btnCreateFile.TabIndex = 0
        Me.btnCreateFile.Text = "Create File"
        Me.btnCreateFile.UseVisualStyleBackColor = True
        '
        'frmCowboys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 205)
        Me.Controls.Add(Me.btnCreateFile)
        Me.Name = "frmCowboys"
        Me.Text = "Cowboys"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreateFile As Button
End Class
