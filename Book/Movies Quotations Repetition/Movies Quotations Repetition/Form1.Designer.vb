<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovie
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
        Me.txtQuotation = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(60, 12)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(180, 23)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display a Movie Quotation"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtQuotation
        '
        Me.txtQuotation.Location = New System.Drawing.Point(60, 38)
        Me.txtQuotation.Name = "txtQuotation"
        Me.txtQuotation.ReadOnly = True
        Me.txtQuotation.Size = New System.Drawing.Size(180, 20)
        Me.txtQuotation.TabIndex = 1
        '
        'frmMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 70)
        Me.Controls.Add(Me.txtQuotation)
        Me.Controls.Add(Me.btnDisplay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovie"
        Me.Text = "Movies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtQuotation As TextBox
End Class
