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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.listBoxReceipt = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(37, 12)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(122, 23)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display Sales Receipt"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'listBoxReceipt
        '
        Me.listBoxReceipt.FormattingEnabled = True
        Me.listBoxReceipt.Location = New System.Drawing.Point(12, 41)
        Me.listBoxReceipt.Name = "listBoxReceipt"
        Me.listBoxReceipt.Size = New System.Drawing.Size(175, 82)
        Me.listBoxReceipt.TabIndex = 1
        '
        'frmCowboys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 129)
        Me.Controls.Add(Me.listBoxReceipt)
        Me.Controls.Add(Me.btnDisplay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCowboys"
        Me.Text = "Cowboys"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents listBoxReceipt As ListBox
End Class
