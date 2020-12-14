<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pictureBoxExample = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBoxExample, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBoxExample
        '
        Me.pictureBoxExample.Location = New System.Drawing.Point(0, -2)
        Me.pictureBoxExample.Name = "pictureBoxExample"
        Me.pictureBoxExample.Size = New System.Drawing.Size(956, 971)
        Me.pictureBoxExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBoxExample.TabIndex = 0
        Me.pictureBoxExample.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 812)
        Me.Controls.Add(Me.pictureBoxExample)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureBoxExample, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pictureBoxExample As PictureBox
End Class
