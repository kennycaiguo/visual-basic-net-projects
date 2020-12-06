<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLetterAddress
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.comboBoxTitle = New System.Windows.Forms.ComboBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtBoxName = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtBoxDisplay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(13, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title"
        '
        'comboBoxTitle
        '
        Me.comboBoxTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboBoxTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.comboBoxTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBoxTitle.FormattingEnabled = True
        Me.comboBoxTitle.Items.AddRange(New Object() {"Mr.", "Ms.", "Dr.", "The Honorable", "Her Excellency"})
        Me.comboBoxTitle.Location = New System.Drawing.Point(13, 30)
        Me.comboBoxTitle.Name = "comboBoxTitle"
        Me.comboBoxTitle.Size = New System.Drawing.Size(102, 98)
        Me.comboBoxTitle.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(124, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'txtBoxName
        '
        Me.txtBoxName.Location = New System.Drawing.Point(168, 10)
        Me.txtBoxName.Name = "txtBoxName"
        Me.txtBoxName.Size = New System.Drawing.Size(112, 20)
        Me.txtBoxName.TabIndex = 3
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(127, 52)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(153, 23)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display Full Name"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtBoxDisplay
        '
        Me.txtBoxDisplay.Location = New System.Drawing.Point(127, 100)
        Me.txtBoxDisplay.Name = "txtBoxDisplay"
        Me.txtBoxDisplay.ReadOnly = True
        Me.txtBoxDisplay.Size = New System.Drawing.Size(153, 20)
        Me.txtBoxDisplay.TabIndex = 5
        '
        'frmLetterAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 132)
        Me.Controls.Add(Me.txtBoxDisplay)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtBoxName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.comboBoxTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLetterAddress"
        Me.Text = "Letter Address"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents comboBoxTitle As ComboBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtBoxName As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtBoxDisplay As TextBox
End Class
