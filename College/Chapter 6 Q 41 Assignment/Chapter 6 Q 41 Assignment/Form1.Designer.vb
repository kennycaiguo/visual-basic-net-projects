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
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtBoxYear = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(13, 13)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(204, 41)
        Me.btnDetermine.TabIndex = 0
        Me.btnDetermine.Text = "Determine When India will have a Greater Population than China"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(60, 61)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 1
        Me.lblYear.Text = "Year:"
        '
        'txtBoxYear
        '
        Me.txtBoxYear.Location = New System.Drawing.Point(98, 58)
        Me.txtBoxYear.Name = "txtBoxYear"
        Me.txtBoxYear.ReadOnly = True
        Me.txtBoxYear.Size = New System.Drawing.Size(63, 20)
        Me.txtBoxYear.TabIndex = 2
        '
        'frmPopulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 81)
        Me.Controls.Add(Me.txtBoxYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.btnDetermine)
        Me.Name = "frmPopulation"
        Me.Text = "Population"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDetermine As Button
    Friend WithEvents lblYear As Label
    Friend WithEvents txtBoxYear As TextBox
End Class
