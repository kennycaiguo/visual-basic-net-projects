<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComboBoxes
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
        Me.comboBoxSimple = New System.Windows.Forms.ComboBox()
        Me.comboBoxDropDown = New System.Windows.Forms.ComboBox()
        Me.comboBoxDropDownList = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'comboBoxSimple
        '
        Me.comboBoxSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.comboBoxSimple.FormattingEnabled = True
        Me.comboBoxSimple.Items.AddRange(New Object() {"Africa", "Antarctia", "Asia", "Australia/Oceania", "Europe", "North America", "South America"})
        Me.comboBoxSimple.Location = New System.Drawing.Point(13, 13)
        Me.comboBoxSimple.Name = "comboBoxSimple"
        Me.comboBoxSimple.Size = New System.Drawing.Size(121, 150)
        Me.comboBoxSimple.TabIndex = 0
        '
        'comboBoxDropDown
        '
        Me.comboBoxDropDown.FormattingEnabled = True
        Me.comboBoxDropDown.Items.AddRange(New Object() {"Africa", "Antarctia", "Asia", "Australia/Oceania", "Europe", "North America", "South America"})
        Me.comboBoxDropDown.Location = New System.Drawing.Point(168, 13)
        Me.comboBoxDropDown.Name = "comboBoxDropDown"
        Me.comboBoxDropDown.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxDropDown.TabIndex = 1
        '
        'comboBoxDropDownList
        '
        Me.comboBoxDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxDropDownList.FormattingEnabled = True
        Me.comboBoxDropDownList.Items.AddRange(New Object() {"Africa", "Antarctia", "Asia", "Australia/Oceania", "Europe", "North America", "South America"})
        Me.comboBoxDropDownList.Location = New System.Drawing.Point(324, 12)
        Me.comboBoxDropDownList.Name = "comboBoxDropDownList"
        Me.comboBoxDropDownList.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxDropDownList.TabIndex = 2
        '
        'frmComboBoxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 165)
        Me.Controls.Add(Me.comboBoxDropDownList)
        Me.Controls.Add(Me.comboBoxDropDown)
        Me.Controls.Add(Me.comboBoxSimple)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComboBoxes"
        Me.Text = "The Three Styles of Combo Boxes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents comboBoxSimple As ComboBox
    Friend WithEvents comboBoxDropDown As ComboBox
    Friend WithEvents comboBoxDropDownList As ComboBox
End Class
