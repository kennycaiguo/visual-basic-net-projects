<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputer
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
        Me.components = New System.ComponentModel.Container()
        Me.groupBoxModel = New System.Windows.Forms.GroupBox()
        Me.rButtonDeluxe = New System.Windows.Forms.RadioButton()
        Me.rButtonSuper = New System.Windows.Forms.RadioButton()
        Me.checkBoxVC = New System.Windows.Forms.CheckBox()
        Me.checkBoxModem = New System.Windows.Forms.CheckBox()
        Me.checkBoxMemory = New System.Windows.Forms.CheckBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtBoxTotalCost = New System.Windows.Forms.TextBox()
        Me.timerCost = New System.Windows.Forms.Timer(Me.components)
        Me.groupBoxModel.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBoxModel
        '
        Me.groupBoxModel.Controls.Add(Me.rButtonSuper)
        Me.groupBoxModel.Controls.Add(Me.rButtonDeluxe)
        Me.groupBoxModel.Location = New System.Drawing.Point(28, 12)
        Me.groupBoxModel.Name = "groupBoxModel"
        Me.groupBoxModel.Size = New System.Drawing.Size(128, 44)
        Me.groupBoxModel.TabIndex = 0
        Me.groupBoxModel.TabStop = False
        Me.groupBoxModel.Text = "Model"
        '
        'rButtonDeluxe
        '
        Me.rButtonDeluxe.AutoSize = True
        Me.rButtonDeluxe.Checked = True
        Me.rButtonDeluxe.Location = New System.Drawing.Point(7, 20)
        Me.rButtonDeluxe.Name = "rButtonDeluxe"
        Me.rButtonDeluxe.Size = New System.Drawing.Size(58, 17)
        Me.rButtonDeluxe.TabIndex = 0
        Me.rButtonDeluxe.TabStop = True
        Me.rButtonDeluxe.Text = "Deluxe"
        Me.rButtonDeluxe.UseVisualStyleBackColor = True
        '
        'rButtonSuper
        '
        Me.rButtonSuper.AutoSize = True
        Me.rButtonSuper.Location = New System.Drawing.Point(71, 20)
        Me.rButtonSuper.Name = "rButtonSuper"
        Me.rButtonSuper.Size = New System.Drawing.Size(53, 17)
        Me.rButtonSuper.TabIndex = 1
        Me.rButtonSuper.Text = "Super"
        Me.rButtonSuper.UseVisualStyleBackColor = True
        '
        'checkBoxVC
        '
        Me.checkBoxVC.AutoSize = True
        Me.checkBoxVC.Location = New System.Drawing.Point(28, 66)
        Me.checkBoxVC.Name = "checkBoxVC"
        Me.checkBoxVC.Size = New System.Drawing.Size(128, 17)
        Me.checkBoxVC.TabIndex = 1
        Me.checkBoxVC.Text = "Upgraded Video Card"
        Me.checkBoxVC.UseVisualStyleBackColor = True
        '
        'checkBoxModem
        '
        Me.checkBoxModem.AutoSize = True
        Me.checkBoxModem.Location = New System.Drawing.Point(28, 89)
        Me.checkBoxModem.Name = "checkBoxModem"
        Me.checkBoxModem.Size = New System.Drawing.Size(135, 17)
        Me.checkBoxModem.TabIndex = 2
        Me.checkBoxModem.Text = "Internal Modem + Wi-Fi"
        Me.checkBoxModem.UseVisualStyleBackColor = True
        '
        'checkBoxMemory
        '
        Me.checkBoxMemory.AutoSize = True
        Me.checkBoxMemory.Location = New System.Drawing.Point(28, 112)
        Me.checkBoxMemory.Name = "checkBoxMemory"
        Me.checkBoxMemory.Size = New System.Drawing.Size(139, 17)
        Me.checkBoxMemory.TabIndex = 3
        Me.checkBoxMemory.Text = "1 GB Additional Memory"
        Me.checkBoxMemory.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(12, 142)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalCost.TabIndex = 4
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'txtBoxTotalCost
        '
        Me.txtBoxTotalCost.Location = New System.Drawing.Point(76, 139)
        Me.txtBoxTotalCost.Name = "txtBoxTotalCost"
        Me.txtBoxTotalCost.ReadOnly = True
        Me.txtBoxTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTotalCost.TabIndex = 5
        '
        'timerCost
        '
        Me.timerCost.Enabled = True
        '
        'frmComputer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 170)
        Me.Controls.Add(Me.txtBoxTotalCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.checkBoxMemory)
        Me.Controls.Add(Me.checkBoxModem)
        Me.Controls.Add(Me.checkBoxVC)
        Me.Controls.Add(Me.groupBoxModel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComputer"
        Me.Text = "Computer (LIVE)"
        Me.groupBoxModel.ResumeLayout(False)
        Me.groupBoxModel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents groupBoxModel As GroupBox
    Friend WithEvents rButtonSuper As RadioButton
    Friend WithEvents rButtonDeluxe As RadioButton
    Friend WithEvents checkBoxVC As CheckBox
    Friend WithEvents checkBoxModem As CheckBox
    Friend WithEvents checkBoxMemory As CheckBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtBoxTotalCost As TextBox
    Friend WithEvents timerCost As Timer
End Class
