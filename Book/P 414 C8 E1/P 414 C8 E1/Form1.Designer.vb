<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUSStates
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
        Me.lblAbbreviation = New System.Windows.Forms.Label()
        Me.txtBoxAbbreviation = New System.Windows.Forms.TextBox()
        Me.btnFindName = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtBoxName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAbbreviation
        '
        Me.lblAbbreviation.AutoSize = True
        Me.lblAbbreviation.Location = New System.Drawing.Point(13, 13)
        Me.lblAbbreviation.Name = "lblAbbreviation"
        Me.lblAbbreviation.Size = New System.Drawing.Size(96, 13)
        Me.lblAbbreviation.TabIndex = 0
        Me.lblAbbreviation.Text = "State abbreviation:"
        '
        'txtBoxAbbreviation
        '
        Me.txtBoxAbbreviation.Location = New System.Drawing.Point(115, 10)
        Me.txtBoxAbbreviation.Name = "txtBoxAbbreviation"
        Me.txtBoxAbbreviation.Size = New System.Drawing.Size(58, 20)
        Me.txtBoxAbbreviation.TabIndex = 1
        '
        'btnFindName
        '
        Me.btnFindName.Location = New System.Drawing.Point(29, 36)
        Me.btnFindName.Name = "btnFindName"
        Me.btnFindName.Size = New System.Drawing.Size(118, 23)
        Me.btnFindName.TabIndex = 2
        Me.btnFindName.Text = "Find Name of State"
        Me.btnFindName.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 62)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name:"
        '
        'txtBoxName
        '
        Me.txtBoxName.Location = New System.Drawing.Point(58, 62)
        Me.txtBoxName.Name = "txtBoxName"
        Me.txtBoxName.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxName.TabIndex = 4
        '
        'frmUSStates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 87)
        Me.Controls.Add(Me.txtBoxName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnFindName)
        Me.Controls.Add(Me.txtBoxAbbreviation)
        Me.Controls.Add(Me.lblAbbreviation)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUSStates"
        Me.Text = "U.S. States"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAbbreviation As Label
    Friend WithEvents txtBoxAbbreviation As TextBox
    Friend WithEvents btnFindName As Button
    Friend WithEvents lblName As Label
    Friend WithEvents txtBoxName As TextBox
End Class
