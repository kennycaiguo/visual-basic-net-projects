<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRental
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
        Me.groupBoxResident = New System.Windows.Forms.GroupBox()
        Me.rButtonResidentYes = New System.Windows.Forms.RadioButton()
        Me.groupBoxCost = New System.Windows.Forms.GroupBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.rButtonResidentNo = New System.Windows.Forms.RadioButton()
        Me.groupBoxPeriod = New System.Windows.Forms.GroupBox()
        Me.txtBoxPeriod = New System.Windows.Forms.TextBox()
        Me.timerCostCalculation = New System.Windows.Forms.Timer(Me.components)
        Me.groupBoxResident.SuspendLayout()
        Me.groupBoxCost.SuspendLayout()
        Me.groupBoxPeriod.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBoxResident
        '
        Me.groupBoxResident.Controls.Add(Me.rButtonResidentNo)
        Me.groupBoxResident.Controls.Add(Me.rButtonResidentYes)
        Me.groupBoxResident.Location = New System.Drawing.Point(13, 13)
        Me.groupBoxResident.Name = "groupBoxResident"
        Me.groupBoxResident.Size = New System.Drawing.Size(66, 76)
        Me.groupBoxResident.TabIndex = 0
        Me.groupBoxResident.TabStop = False
        Me.groupBoxResident.Text = "Resident"
        '
        'rButtonResidentYes
        '
        Me.rButtonResidentYes.AutoSize = True
        Me.rButtonResidentYes.Location = New System.Drawing.Point(6, 19)
        Me.rButtonResidentYes.Name = "rButtonResidentYes"
        Me.rButtonResidentYes.Size = New System.Drawing.Size(43, 17)
        Me.rButtonResidentYes.TabIndex = 0
        Me.rButtonResidentYes.Text = "Yes"
        Me.rButtonResidentYes.UseVisualStyleBackColor = True
        '
        'groupBoxCost
        '
        Me.groupBoxCost.Controls.Add(Me.lblCost)
        Me.groupBoxCost.Location = New System.Drawing.Point(85, 54)
        Me.groupBoxCost.Name = "groupBoxCost"
        Me.groupBoxCost.Size = New System.Drawing.Size(66, 35)
        Me.groupBoxCost.TabIndex = 1
        Me.groupBoxCost.TabStop = False
        Me.groupBoxCost.Text = "Cost"
        '
        'lblCost
        '
        Me.lblCost.Location = New System.Drawing.Point(3, 16)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(54, 16)
        Me.lblCost.TabIndex = 0
        Me.lblCost.Text = "$0.00"
        '
        'rButtonResidentNo
        '
        Me.rButtonResidentNo.AutoSize = True
        Me.rButtonResidentNo.Checked = True
        Me.rButtonResidentNo.Location = New System.Drawing.Point(6, 41)
        Me.rButtonResidentNo.Name = "rButtonResidentNo"
        Me.rButtonResidentNo.Size = New System.Drawing.Size(39, 17)
        Me.rButtonResidentNo.TabIndex = 1
        Me.rButtonResidentNo.TabStop = True
        Me.rButtonResidentNo.Text = "No"
        Me.rButtonResidentNo.UseVisualStyleBackColor = True
        '
        'groupBoxPeriod
        '
        Me.groupBoxPeriod.Controls.Add(Me.txtBoxPeriod)
        Me.groupBoxPeriod.Location = New System.Drawing.Point(85, 12)
        Me.groupBoxPeriod.Name = "groupBoxPeriod"
        Me.groupBoxPeriod.Size = New System.Drawing.Size(66, 41)
        Me.groupBoxPeriod.TabIndex = 2
        Me.groupBoxPeriod.TabStop = False
        Me.groupBoxPeriod.Text = "Period"
        '
        'txtBoxPeriod
        '
        Me.txtBoxPeriod.Location = New System.Drawing.Point(6, 15)
        Me.txtBoxPeriod.Name = "txtBoxPeriod"
        Me.txtBoxPeriod.Size = New System.Drawing.Size(54, 20)
        Me.txtBoxPeriod.TabIndex = 0
        '
        'timerCostCalculation
        '
        Me.timerCostCalculation.Enabled = True
        '
        'frmRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(163, 99)
        Me.Controls.Add(Me.groupBoxPeriod)
        Me.Controls.Add(Me.groupBoxCost)
        Me.Controls.Add(Me.groupBoxResident)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRental"
        Me.Text = "Rental (LIVE)"
        Me.groupBoxResident.ResumeLayout(False)
        Me.groupBoxResident.PerformLayout()
        Me.groupBoxCost.ResumeLayout(False)
        Me.groupBoxPeriod.ResumeLayout(False)
        Me.groupBoxPeriod.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBoxResident As GroupBox
    Friend WithEvents rButtonResidentNo As RadioButton
    Friend WithEvents rButtonResidentYes As RadioButton
    Friend WithEvents groupBoxCost As GroupBox
    Friend WithEvents lblCost As Label
    Friend WithEvents groupBoxPeriod As GroupBox
    Friend WithEvents txtBoxPeriod As TextBox
    Friend WithEvents timerCostCalculation As Timer
End Class
