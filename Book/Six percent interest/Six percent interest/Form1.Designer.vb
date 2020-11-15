<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMillionare
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
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtWhen = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(12, 13)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(95, 13)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "Amount deposited:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(113, 10)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(13, 39)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(201, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Years to Become a Millionare"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtWhen
        '
        Me.txtWhen.Location = New System.Drawing.Point(15, 69)
        Me.txtWhen.Name = "txtWhen"
        Me.txtWhen.ReadOnly = True
        Me.txtWhen.Size = New System.Drawing.Size(198, 20)
        Me.txtWhen.TabIndex = 3
        '
        'frmMillionare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 95)
        Me.Controls.Add(Me.txtWhen)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMillionare"
        Me.Text = "6% Interest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtWhen As TextBox
End Class
