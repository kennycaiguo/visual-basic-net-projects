<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlashDrives
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
        Me.groupBoxFlashDrives = New System.Windows.Forms.GroupBox()
        Me.rButton16GB = New System.Windows.Forms.RadioButton()
        Me.rButton32GB = New System.Windows.Forms.RadioButton()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtBoxQuantity = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtBoxCost = New System.Windows.Forms.TextBox()
        Me.groupBoxFlashDrives.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBoxFlashDrives
        '
        Me.groupBoxFlashDrives.Controls.Add(Me.rButton32GB)
        Me.groupBoxFlashDrives.Controls.Add(Me.rButton16GB)
        Me.groupBoxFlashDrives.Location = New System.Drawing.Point(13, 13)
        Me.groupBoxFlashDrives.Name = "groupBoxFlashDrives"
        Me.groupBoxFlashDrives.Size = New System.Drawing.Size(134, 70)
        Me.groupBoxFlashDrives.TabIndex = 0
        Me.groupBoxFlashDrives.TabStop = False
        Me.groupBoxFlashDrives.Text = "USB Flash Drives"
        '
        'rButton16GB
        '
        Me.rButton16GB.AutoSize = True
        Me.rButton16GB.Checked = True
        Me.rButton16GB.Location = New System.Drawing.Point(7, 20)
        Me.rButton16GB.Name = "rButton16GB"
        Me.rButton16GB.Size = New System.Drawing.Size(55, 17)
        Me.rButton16GB.TabIndex = 0
        Me.rButton16GB.TabStop = True
        Me.rButton16GB.Text = "16 GB"
        Me.rButton16GB.UseVisualStyleBackColor = True
        '
        'rButton32GB
        '
        Me.rButton32GB.AutoSize = True
        Me.rButton32GB.Location = New System.Drawing.Point(7, 43)
        Me.rButton32GB.Name = "rButton32GB"
        Me.rButton32GB.Size = New System.Drawing.Size(55, 17)
        Me.rButton32GB.TabIndex = 1
        Me.rButton32GB.TabStop = True
        Me.rButton32GB.Text = "32 GB"
        Me.rButton32GB.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(170, 13)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 13)
        Me.lblQuantity.TabIndex = 1
        Me.lblQuantity.Text = "Quantity:"
        '
        'txtBoxQuantity
        '
        Me.txtBoxQuantity.Location = New System.Drawing.Point(162, 29)
        Me.txtBoxQuantity.Name = "txtBoxQuantity"
        Me.txtBoxQuantity.Size = New System.Drawing.Size(67, 20)
        Me.txtBoxQuantity.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(60, 89)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(104, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(57, 121)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(31, 13)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Cost:"
        '
        'txtBoxCost
        '
        Me.txtBoxCost.Location = New System.Drawing.Point(94, 118)
        Me.txtBoxCost.Name = "txtBoxCost"
        Me.txtBoxCost.ReadOnly = True
        Me.txtBoxCost.Size = New System.Drawing.Size(70, 20)
        Me.txtBoxCost.TabIndex = 5
        '
        'frmFlashDrives
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 142)
        Me.Controls.Add(Me.txtBoxCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtBoxQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.groupBoxFlashDrives)
        Me.Name = "frmFlashDrives"
        Me.Text = "Place Order"
        Me.groupBoxFlashDrives.ResumeLayout(False)
        Me.groupBoxFlashDrives.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents groupBoxFlashDrives As GroupBox
    Friend WithEvents rButton32GB As RadioButton
    Friend WithEvents rButton16GB As RadioButton
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtBoxQuantity As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblCost As Label
    Friend WithEvents txtBoxCost As TextBox
End Class
