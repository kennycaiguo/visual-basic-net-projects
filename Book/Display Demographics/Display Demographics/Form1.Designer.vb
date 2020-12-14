<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemographics
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
        Me.listBoxOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(73, 12)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(125, 23)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display Demographics"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'listBoxOutput
        '
        Me.listBoxOutput.FormattingEnabled = True
        Me.listBoxOutput.Location = New System.Drawing.Point(13, 36)
        Me.listBoxOutput.Name = "listBoxOutput"
        Me.listBoxOutput.Size = New System.Drawing.Size(249, 108)
        Me.listBoxOutput.TabIndex = 1
        '
        'frmDemographics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 161)
        Me.Controls.Add(Me.listBoxOutput)
        Me.Controls.Add(Me.btnDisplay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDemographics"
        Me.Text = "Density"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents listBoxOutput As ListBox
End Class
