<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopulation
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
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.txtBoxCalculation = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(12, 12)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(262, 23)
        Me.btnDetermine.TabIndex = 0
        Me.btnDetermine.Text = "Determine When Population Is 8 Billion"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'txtBoxCalculation
        '
        Me.txtBoxCalculation.Location = New System.Drawing.Point(13, 42)
        Me.txtBoxCalculation.Name = "txtBoxCalculation"
        Me.txtBoxCalculation.ReadOnly = True
        Me.txtBoxCalculation.Size = New System.Drawing.Size(261, 20)
        Me.txtBoxCalculation.TabIndex = 1
        '
        'frmPopulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 74)
        Me.Controls.Add(Me.txtBoxCalculation)
        Me.Controls.Add(Me.btnDetermine)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPopulation"
        Me.Text = "Population"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDetermine As Button
    Friend WithEvents txtBoxCalculation As TextBox
End Class
