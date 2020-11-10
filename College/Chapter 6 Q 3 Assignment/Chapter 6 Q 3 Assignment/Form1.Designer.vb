<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMatrix
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
        Me.listBoxMatrix = New System.Windows.Forms.ListBox()
        Me.lblRowZero = New System.Windows.Forms.Label()
        Me.lblRowOne = New System.Windows.Forms.Label()
        Me.lblRowTwo = New System.Windows.Forms.Label()
        Me.lblRowThree = New System.Windows.Forms.Label()
        Me.lblRowFour = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listBoxMatrix
        '
        Me.listBoxMatrix.FormattingEnabled = True
        Me.listBoxMatrix.Location = New System.Drawing.Point(31, 25)
        Me.listBoxMatrix.Name = "listBoxMatrix"
        Me.listBoxMatrix.Size = New System.Drawing.Size(146, 121)
        Me.listBoxMatrix.TabIndex = 0
        '
        'lblRowZero
        '
        Me.lblRowZero.AutoSize = True
        Me.lblRowZero.Location = New System.Drawing.Point(12, 29)
        Me.lblRowZero.Name = "lblRowZero"
        Me.lblRowZero.Size = New System.Drawing.Size(13, 13)
        Me.lblRowZero.TabIndex = 1
        Me.lblRowZero.Text = "0"
        '
        'lblRowOne
        '
        Me.lblRowOne.AutoSize = True
        Me.lblRowOne.Location = New System.Drawing.Point(12, 54)
        Me.lblRowOne.Name = "lblRowOne"
        Me.lblRowOne.Size = New System.Drawing.Size(13, 13)
        Me.lblRowOne.TabIndex = 2
        Me.lblRowOne.Text = "1"
        '
        'lblRowTwo
        '
        Me.lblRowTwo.AutoSize = True
        Me.lblRowTwo.Location = New System.Drawing.Point(12, 77)
        Me.lblRowTwo.Name = "lblRowTwo"
        Me.lblRowTwo.Size = New System.Drawing.Size(13, 13)
        Me.lblRowTwo.TabIndex = 3
        Me.lblRowTwo.Text = "2"
        '
        'lblRowThree
        '
        Me.lblRowThree.AutoSize = True
        Me.lblRowThree.Location = New System.Drawing.Point(12, 102)
        Me.lblRowThree.Name = "lblRowThree"
        Me.lblRowThree.Size = New System.Drawing.Size(13, 13)
        Me.lblRowThree.TabIndex = 4
        Me.lblRowThree.Text = "3"
        '
        'lblRowFour
        '
        Me.lblRowFour.AutoSize = True
        Me.lblRowFour.Location = New System.Drawing.Point(12, 126)
        Me.lblRowFour.Name = "lblRowFour"
        Me.lblRowFour.Size = New System.Drawing.Size(13, 13)
        Me.lblRowFour.TabIndex = 5
        Me.lblRowFour.Text = "4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "4"
        '
        'frmMatrix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 157)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRowFour)
        Me.Controls.Add(Me.lblRowThree)
        Me.Controls.Add(Me.lblRowTwo)
        Me.Controls.Add(Me.lblRowOne)
        Me.Controls.Add(Me.lblRowZero)
        Me.Controls.Add(Me.listBoxMatrix)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMatrix"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Matrix"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listBoxMatrix As ListBox
    Friend WithEvents lblRowZero As Label
    Friend WithEvents lblRowOne As Label
    Friend WithEvents lblRowTwo As Label
    Friend WithEvents lblRowThree As Label
    Friend WithEvents lblRowFour As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
