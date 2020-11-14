<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirline
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
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.listBoxFrom = New System.Windows.Forms.ListBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.listBoxTo = New System.Windows.Forms.ListBox()
        Me.btnBookFlight = New System.Windows.Forms.Button()
        Me.txtBoxFlight = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(12, 14)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From:"
        '
        'listBoxFrom
        '
        Me.listBoxFrom.FormattingEnabled = True
        Me.listBoxFrom.Location = New System.Drawing.Point(12, 30)
        Me.listBoxFrom.Name = "listBoxFrom"
        Me.listBoxFrom.Size = New System.Drawing.Size(54, 121)
        Me.listBoxFrom.TabIndex = 1
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(76, 14)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To:"
        '
        'listBoxTo
        '
        Me.listBoxTo.FormattingEnabled = True
        Me.listBoxTo.Location = New System.Drawing.Point(79, 30)
        Me.listBoxTo.Name = "listBoxTo"
        Me.listBoxTo.Size = New System.Drawing.Size(54, 121)
        Me.listBoxTo.TabIndex = 3
        '
        'btnBookFlight
        '
        Me.btnBookFlight.Location = New System.Drawing.Point(139, 73)
        Me.btnBookFlight.Name = "btnBookFlight"
        Me.btnBookFlight.Size = New System.Drawing.Size(75, 38)
        Me.btnBookFlight.TabIndex = 4
        Me.btnBookFlight.Text = "Book" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Flight"
        Me.btnBookFlight.UseVisualStyleBackColor = True
        '
        'txtBoxFlight
        '
        Me.txtBoxFlight.Location = New System.Drawing.Point(24, 167)
        Me.txtBoxFlight.Name = "txtBoxFlight"
        Me.txtBoxFlight.ReadOnly = True
        Me.txtBoxFlight.Size = New System.Drawing.Size(179, 20)
        Me.txtBoxFlight.TabIndex = 5
        '
        'frmAirline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 199)
        Me.Controls.Add(Me.txtBoxFlight)
        Me.Controls.Add(Me.btnBookFlight)
        Me.Controls.Add(Me.listBoxTo)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.listBoxFrom)
        Me.Controls.Add(Me.lblFrom)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAirline"
        Me.Text = "Airline"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFrom As Label
    Friend WithEvents listBoxFrom As ListBox
    Friend WithEvents lblTo As Label
    Friend WithEvents listBoxTo As ListBox
    Friend WithEvents btnBookFlight As Button
    Friend WithEvents txtBoxFlight As TextBox
End Class
