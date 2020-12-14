<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesTax
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTaxRate = New System.Windows.Forms.Label()
        Me.lblPriceOfItem = New System.Windows.Forms.Label()
        Me.txtBoxTaxRate = New System.Windows.Forms.TextBox()
        Me.txtBoxPriceOfItem = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtBoxTotalCost = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTaxRate
        '
        Me.lblTaxRate.AutoSize = True
        Me.lblTaxRate.Location = New System.Drawing.Point(12, 9)
        Me.lblTaxRate.Name = "lblTaxRate"
        Me.lblTaxRate.Size = New System.Drawing.Size(49, 13)
        Me.lblTaxRate.TabIndex = 0
        Me.lblTaxRate.Text = "Tax rate:"
        '
        'lblPriceOfItem
        '
        Me.lblPriceOfItem.AutoSize = True
        Me.lblPriceOfItem.Location = New System.Drawing.Point(12, 31)
        Me.lblPriceOfItem.Name = "lblPriceOfItem"
        Me.lblPriceOfItem.Size = New System.Drawing.Size(68, 13)
        Me.lblPriceOfItem.TabIndex = 1
        Me.lblPriceOfItem.Text = "Price of item:"
        '
        'txtBoxTaxRate
        '
        Me.txtBoxTaxRate.Location = New System.Drawing.Point(92, 6)
        Me.txtBoxTaxRate.Name = "txtBoxTaxRate"
        Me.txtBoxTaxRate.Size = New System.Drawing.Size(82, 20)
        Me.txtBoxTaxRate.TabIndex = 2
        '
        'txtBoxPriceOfItem
        '
        Me.txtBoxPriceOfItem.Location = New System.Drawing.Point(92, 28)
        Me.txtBoxPriceOfItem.Name = "txtBoxPriceOfItem"
        Me.txtBoxPriceOfItem.Size = New System.Drawing.Size(82, 20)
        Me.txtBoxPriceOfItem.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 54)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(115, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Total Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(12, 88)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'txtBoxTotalCost
        '
        Me.txtBoxTotalCost.Location = New System.Drawing.Point(91, 85)
        Me.txtBoxTotalCost.Name = "txtBoxTotalCost"
        Me.txtBoxTotalCost.Size = New System.Drawing.Size(82, 20)
        Me.txtBoxTotalCost.TabIndex = 6
        '
        'frmSalesTax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(185, 110)
        Me.Controls.Add(Me.txtBoxTotalCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtBoxPriceOfItem)
        Me.Controls.Add(Me.txtBoxTaxRate)
        Me.Controls.Add(Me.lblPriceOfItem)
        Me.Controls.Add(Me.lblTaxRate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesTax"
        Me.Text = "Sales Tax"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTaxRate As Label
    Friend WithEvents lblPriceOfItem As Label
    Friend WithEvents txtBoxTaxRate As TextBox
    Friend WithEvents txtBoxPriceOfItem As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtBoxTotalCost As TextBox
End Class
