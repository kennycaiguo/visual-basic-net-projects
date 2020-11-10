<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelected
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.listBox = New System.Windows.Forms.ListBox()
        Me.listBox2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(95, 8)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'listBox
        '
        Me.listBox.FormattingEnabled = True
        Me.listBox.Items.AddRange(New Object() {"Abbot", "Adam", "Azam", "Baber", "Bond", "Bush", "Charles", "David", "Davis", "Frank"})
        Me.listBox.Location = New System.Drawing.Point(12, 37)
        Me.listBox.Name = "listBox"
        Me.listBox.Size = New System.Drawing.Size(77, 134)
        Me.listBox.TabIndex = 2
        '
        'listBox2
        '
        Me.listBox2.FormattingEnabled = True
        Me.listBox2.Location = New System.Drawing.Point(95, 37)
        Me.listBox2.Name = "listBox2"
        Me.listBox2.Size = New System.Drawing.Size(77, 134)
        Me.listBox2.TabIndex = 3
        '
        'frmSelected
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(185, 189)
        Me.Controls.Add(Me.listBox2)
        Me.Controls.Add(Me.listBox)
        Me.Controls.Add(Me.btnDelete)
        Me.Name = "frmSelected"
        Me.Text = "Selected"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelete As Button
    Friend WithEvents listBox As ListBox
    Friend WithEvents listBox2 As ListBox
End Class
