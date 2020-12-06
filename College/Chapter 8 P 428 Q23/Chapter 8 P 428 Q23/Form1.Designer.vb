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
        Me.lblItem = New System.Windows.Forms.Label()
        Me.txtBoxItem = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtBoxPrice = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(12, 9)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(30, 13)
        Me.lblItem.TabIndex = 0
        Me.lblItem.Text = "Item:"
        '
        'txtBoxItem
        '
        Me.txtBoxItem.Location = New System.Drawing.Point(48, 6)
        Me.txtBoxItem.Name = "txtBoxItem"
        Me.txtBoxItem.Size = New System.Drawing.Size(58, 20)
        Me.txtBoxItem.TabIndex = 1
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(112, 9)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price:"
        '
        'txtBoxPrice
        '
        Me.txtBoxPrice.Location = New System.Drawing.Point(152, 6)
        Me.txtBoxPrice.Name = "txtBoxPrice"
        Me.txtBoxPrice.Size = New System.Drawing.Size(58, 20)
        Me.txtBoxPrice.TabIndex = 3
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(81, 32)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(92, 23)
        Me.btnAddItem.TabIndex = 4
        Me.btnAddItem.Text = "Add Item to List"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'frmCowboys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 62)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtBoxPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtBoxItem)
        Me.Controls.Add(Me.lblItem)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCowboys"
        Me.Text = "Cowboys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblItem As Label
    Friend WithEvents txtBoxItem As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtBoxPrice As TextBox
    Friend WithEvents btnAddItem As Button
End Class
