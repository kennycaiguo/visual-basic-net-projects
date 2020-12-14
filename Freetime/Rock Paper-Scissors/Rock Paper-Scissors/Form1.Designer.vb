<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPS
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
        Me.btnSelection = New System.Windows.Forms.Button()
        Me.txtBoxSelected = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSelection
        '
        Me.btnSelection.Location = New System.Drawing.Point(29, 12)
        Me.btnSelection.Name = "btnSelection"
        Me.btnSelection.Size = New System.Drawing.Size(153, 23)
        Me.btnSelection.TabIndex = 0
        Me.btnSelection.Text = "Randomly Make A Selection"
        Me.btnSelection.UseVisualStyleBackColor = True
        '
        'txtBoxSelected
        '
        Me.txtBoxSelected.Location = New System.Drawing.Point(56, 41)
        Me.txtBoxSelected.Name = "txtBoxSelected"
        Me.txtBoxSelected.ReadOnly = True
        Me.txtBoxSelected.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxSelected.TabIndex = 1
        '
        'frmRPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 81)
        Me.Controls.Add(Me.txtBoxSelected)
        Me.Controls.Add(Me.btnSelection)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRPS"
        Me.Text = "Rock-Paper-Scissors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelection As Button
    Friend WithEvents txtBoxSelected As TextBox
End Class
