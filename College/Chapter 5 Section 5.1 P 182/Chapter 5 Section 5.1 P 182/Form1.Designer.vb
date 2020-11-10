<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemperature
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
        Me.lblFahrenheit = New System.Windows.Forms.Label()
        Me.txtBoxTemperature = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblCelsius = New System.Windows.Forms.Label()
        Me.txtBoxCelsius = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFahrenheit
        '
        Me.lblFahrenheit.AutoSize = True
        Me.lblFahrenheit.Location = New System.Drawing.Point(13, 13)
        Me.lblFahrenheit.Name = "lblFahrenheit"
        Me.lblFahrenheit.Size = New System.Drawing.Size(129, 13)
        Me.lblFahrenheit.TabIndex = 0
        Me.lblFahrenheit.Text = "Temperature (Fahrenheit):"
        '
        'txtBoxTemperature
        '
        Me.txtBoxTemperature.Location = New System.Drawing.Point(148, 10)
        Me.txtBoxTemperature.Name = "txtBoxTemperature"
        Me.txtBoxTemperature.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTemperature.TabIndex = 1
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(92, 51)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(113, 23)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert to Celsius"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lblCelsius
        '
        Me.lblCelsius.AutoSize = True
        Me.lblCelsius.Location = New System.Drawing.Point(13, 98)
        Me.lblCelsius.Name = "lblCelsius"
        Me.lblCelsius.Size = New System.Drawing.Size(112, 13)
        Me.lblCelsius.TabIndex = 3
        Me.lblCelsius.Text = "Temperature (Celsius):"
        '
        'txtBoxCelsius
        '
        Me.txtBoxCelsius.Location = New System.Drawing.Point(148, 95)
        Me.txtBoxCelsius.Name = "txtBoxCelsius"
        Me.txtBoxCelsius.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxCelsius.TabIndex = 4
        '
        'frmTemperature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 120)
        Me.Controls.Add(Me.txtBoxCelsius)
        Me.Controls.Add(Me.lblCelsius)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtBoxTemperature)
        Me.Controls.Add(Me.lblFahrenheit)
        Me.Name = "frmTemperature"
        Me.Text = "Temperature"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents txtBoxTemperature As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents lblCelsius As Label
    Friend WithEvents txtBoxCelsius As TextBox
End Class
