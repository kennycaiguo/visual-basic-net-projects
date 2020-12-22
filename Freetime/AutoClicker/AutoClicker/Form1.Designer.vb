<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoClicker
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoClicker))
        Me.groupBoxClickInterval = New System.Windows.Forms.GroupBox()
        Me.lblMilliseconds = New System.Windows.Forms.Label()
        Me.txtBoxMilliseconds = New System.Windows.Forms.TextBox()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.txtBoxSeconds = New System.Windows.Forms.TextBox()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.txtBoxMinutes = New System.Windows.Forms.TextBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtBoxHours = New System.Windows.Forms.TextBox()
        Me.groupBoxClickOptions = New System.Windows.Forms.GroupBox()
        Me.comboBoxClickType = New System.Windows.Forms.ComboBox()
        Me.comboBoxMouseButton = New System.Windows.Forms.ComboBox()
        Me.lblClickType = New System.Windows.Forms.Label()
        Me.lblMouseButton = New System.Windows.Forms.Label()
        Me.groupBoxClickRepeat = New System.Windows.Forms.GroupBox()
        Me.lblTimes = New System.Windows.Forms.Label()
        Me.numericUpDownTimes = New System.Windows.Forms.NumericUpDown()
        Me.rButtonRepeatUntilStopped = New System.Windows.Forms.RadioButton()
        Me.rButtonRepeat = New System.Windows.Forms.RadioButton()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.systemClicker = New System.Windows.Forms.Timer(Me.components)
        Me.groupBoxClickInterval.SuspendLayout()
        Me.groupBoxClickOptions.SuspendLayout()
        Me.groupBoxClickRepeat.SuspendLayout()
        CType(Me.numericUpDownTimes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBoxClickInterval
        '
        Me.groupBoxClickInterval.Controls.Add(Me.lblMilliseconds)
        Me.groupBoxClickInterval.Controls.Add(Me.txtBoxMilliseconds)
        Me.groupBoxClickInterval.Controls.Add(Me.lblSeconds)
        Me.groupBoxClickInterval.Controls.Add(Me.txtBoxSeconds)
        Me.groupBoxClickInterval.Controls.Add(Me.lblMinutes)
        Me.groupBoxClickInterval.Controls.Add(Me.txtBoxMinutes)
        Me.groupBoxClickInterval.Controls.Add(Me.lblHours)
        Me.groupBoxClickInterval.Controls.Add(Me.txtBoxHours)
        Me.groupBoxClickInterval.Location = New System.Drawing.Point(13, 13)
        Me.groupBoxClickInterval.Name = "groupBoxClickInterval"
        Me.groupBoxClickInterval.Size = New System.Drawing.Size(415, 57)
        Me.groupBoxClickInterval.TabIndex = 0
        Me.groupBoxClickInterval.TabStop = False
        Me.groupBoxClickInterval.Text = "Click interval"
        '
        'lblMilliseconds
        '
        Me.lblMilliseconds.AutoSize = True
        Me.lblMilliseconds.Location = New System.Drawing.Point(346, 25)
        Me.lblMilliseconds.Name = "lblMilliseconds"
        Me.lblMilliseconds.Size = New System.Drawing.Size(63, 13)
        Me.lblMilliseconds.TabIndex = 7
        Me.lblMilliseconds.Text = "milliseconds"
        '
        'txtBoxMilliseconds
        '
        Me.txtBoxMilliseconds.Location = New System.Drawing.Point(290, 22)
        Me.txtBoxMilliseconds.Name = "txtBoxMilliseconds"
        Me.txtBoxMilliseconds.Size = New System.Drawing.Size(50, 20)
        Me.txtBoxMilliseconds.TabIndex = 6
        Me.txtBoxMilliseconds.Text = "100"
        Me.txtBoxMilliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Location = New System.Drawing.Point(255, 25)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(29, 13)
        Me.lblSeconds.TabIndex = 5
        Me.lblSeconds.Text = "secs"
        '
        'txtBoxSeconds
        '
        Me.txtBoxSeconds.Location = New System.Drawing.Point(196, 22)
        Me.txtBoxSeconds.Name = "txtBoxSeconds"
        Me.txtBoxSeconds.Size = New System.Drawing.Size(53, 20)
        Me.txtBoxSeconds.TabIndex = 4
        Me.txtBoxSeconds.Text = "0"
        Me.txtBoxSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Location = New System.Drawing.Point(162, 25)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(28, 13)
        Me.lblMinutes.TabIndex = 3
        Me.lblMinutes.Text = "mins"
        '
        'txtBoxMinutes
        '
        Me.txtBoxMinutes.Location = New System.Drawing.Point(103, 22)
        Me.txtBoxMinutes.Name = "txtBoxMinutes"
        Me.txtBoxMinutes.Size = New System.Drawing.Size(53, 20)
        Me.txtBoxMinutes.TabIndex = 2
        Me.txtBoxMinutes.Text = "0"
        Me.txtBoxMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(64, 25)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(33, 13)
        Me.lblHours.TabIndex = 1
        Me.lblHours.Text = "hours"
        '
        'txtBoxHours
        '
        Me.txtBoxHours.Location = New System.Drawing.Point(6, 22)
        Me.txtBoxHours.Name = "txtBoxHours"
        Me.txtBoxHours.Size = New System.Drawing.Size(52, 20)
        Me.txtBoxHours.TabIndex = 0
        Me.txtBoxHours.Text = "0"
        Me.txtBoxHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'groupBoxClickOptions
        '
        Me.groupBoxClickOptions.Controls.Add(Me.comboBoxClickType)
        Me.groupBoxClickOptions.Controls.Add(Me.comboBoxMouseButton)
        Me.groupBoxClickOptions.Controls.Add(Me.lblClickType)
        Me.groupBoxClickOptions.Controls.Add(Me.lblMouseButton)
        Me.groupBoxClickOptions.Location = New System.Drawing.Point(13, 77)
        Me.groupBoxClickOptions.Name = "groupBoxClickOptions"
        Me.groupBoxClickOptions.Size = New System.Drawing.Size(203, 90)
        Me.groupBoxClickOptions.TabIndex = 1
        Me.groupBoxClickOptions.TabStop = False
        Me.groupBoxClickOptions.Text = "Click options"
        '
        'comboBoxClickType
        '
        Me.comboBoxClickType.AllowDrop = True
        Me.comboBoxClickType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxClickType.FormattingEnabled = True
        Me.comboBoxClickType.Items.AddRange(New Object() {"Single", "Double"})
        Me.comboBoxClickType.Location = New System.Drawing.Point(113, 58)
        Me.comboBoxClickType.Name = "comboBoxClickType"
        Me.comboBoxClickType.Size = New System.Drawing.Size(69, 21)
        Me.comboBoxClickType.TabIndex = 11
        '
        'comboBoxMouseButton
        '
        Me.comboBoxMouseButton.AllowDrop = True
        Me.comboBoxMouseButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxMouseButton.FormattingEnabled = True
        Me.comboBoxMouseButton.Items.AddRange(New Object() {"Left", "Right", "Middle"})
        Me.comboBoxMouseButton.Location = New System.Drawing.Point(113, 24)
        Me.comboBoxMouseButton.Name = "comboBoxMouseButton"
        Me.comboBoxMouseButton.Size = New System.Drawing.Size(69, 21)
        Me.comboBoxMouseButton.TabIndex = 10
        '
        'lblClickType
        '
        Me.lblClickType.AutoSize = True
        Me.lblClickType.Location = New System.Drawing.Point(6, 60)
        Me.lblClickType.Name = "lblClickType"
        Me.lblClickType.Size = New System.Drawing.Size(56, 13)
        Me.lblClickType.TabIndex = 9
        Me.lblClickType.Text = "Click type:"
        '
        'lblMouseButton
        '
        Me.lblMouseButton.AutoSize = True
        Me.lblMouseButton.Location = New System.Drawing.Point(6, 27)
        Me.lblMouseButton.Name = "lblMouseButton"
        Me.lblMouseButton.Size = New System.Drawing.Size(75, 13)
        Me.lblMouseButton.TabIndex = 8
        Me.lblMouseButton.Text = "Mouse button:"
        '
        'groupBoxClickRepeat
        '
        Me.groupBoxClickRepeat.Controls.Add(Me.lblTimes)
        Me.groupBoxClickRepeat.Controls.Add(Me.numericUpDownTimes)
        Me.groupBoxClickRepeat.Controls.Add(Me.rButtonRepeatUntilStopped)
        Me.groupBoxClickRepeat.Controls.Add(Me.rButtonRepeat)
        Me.groupBoxClickRepeat.Location = New System.Drawing.Point(225, 77)
        Me.groupBoxClickRepeat.Name = "groupBoxClickRepeat"
        Me.groupBoxClickRepeat.Size = New System.Drawing.Size(203, 90)
        Me.groupBoxClickRepeat.TabIndex = 2
        Me.groupBoxClickRepeat.TabStop = False
        Me.groupBoxClickRepeat.Text = "Click repeat"
        '
        'lblTimes
        '
        Me.lblTimes.AutoSize = True
        Me.lblTimes.Location = New System.Drawing.Point(159, 29)
        Me.lblTimes.Name = "lblTimes"
        Me.lblTimes.Size = New System.Drawing.Size(31, 13)
        Me.lblTimes.TabIndex = 3
        Me.lblTimes.Text = "times"
        '
        'numericUpDownTimes
        '
        Me.numericUpDownTimes.Location = New System.Drawing.Point(101, 25)
        Me.numericUpDownTimes.Name = "numericUpDownTimes"
        Me.numericUpDownTimes.Size = New System.Drawing.Size(52, 20)
        Me.numericUpDownTimes.TabIndex = 2
        Me.numericUpDownTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numericUpDownTimes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rButtonRepeatUntilStopped
        '
        Me.rButtonRepeatUntilStopped.AutoSize = True
        Me.rButtonRepeatUntilStopped.Checked = True
        Me.rButtonRepeatUntilStopped.Location = New System.Drawing.Point(17, 58)
        Me.rButtonRepeatUntilStopped.Name = "rButtonRepeatUntilStopped"
        Me.rButtonRepeatUntilStopped.Size = New System.Drawing.Size(123, 17)
        Me.rButtonRepeatUntilStopped.TabIndex = 1
        Me.rButtonRepeatUntilStopped.TabStop = True
        Me.rButtonRepeatUntilStopped.Text = "Repeat until stopped"
        Me.rButtonRepeatUntilStopped.UseVisualStyleBackColor = True
        '
        'rButtonRepeat
        '
        Me.rButtonRepeat.AutoSize = True
        Me.rButtonRepeat.Location = New System.Drawing.Point(18, 25)
        Me.rButtonRepeat.Name = "rButtonRepeat"
        Me.rButtonRepeat.Size = New System.Drawing.Size(60, 17)
        Me.rButtonRepeat.TabIndex = 0
        Me.rButtonRepeat.Text = "Repeat"
        Me.rButtonRepeat.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(22, 173)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(173, 41)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start (F6)"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(242, 173)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(173, 41)
        Me.btnStop.TabIndex = 10
        Me.btnStop.Text = "Stop (F6)"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'systemClicker
        '
        '
        'frmAutoClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(440, 221)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.groupBoxClickRepeat)
        Me.Controls.Add(Me.groupBoxClickOptions)
        Me.Controls.Add(Me.groupBoxClickInterval)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAutoClicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Clicker 1.1.5"
        Me.groupBoxClickInterval.ResumeLayout(False)
        Me.groupBoxClickInterval.PerformLayout()
        Me.groupBoxClickOptions.ResumeLayout(False)
        Me.groupBoxClickOptions.PerformLayout()
        Me.groupBoxClickRepeat.ResumeLayout(False)
        Me.groupBoxClickRepeat.PerformLayout()
        CType(Me.numericUpDownTimes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBoxClickInterval As GroupBox
    Friend WithEvents lblMilliseconds As Label
    Friend WithEvents txtBoxMilliseconds As TextBox
    Friend WithEvents lblSeconds As Label
    Friend WithEvents txtBoxSeconds As TextBox
    Friend WithEvents lblMinutes As Label
    Friend WithEvents txtBoxMinutes As TextBox
    Friend WithEvents lblHours As Label
    Friend WithEvents txtBoxHours As TextBox
    Friend WithEvents groupBoxClickOptions As GroupBox
    Friend WithEvents groupBoxClickRepeat As GroupBox
    Friend WithEvents comboBoxMouseButton As ComboBox
    Friend WithEvents lblClickType As Label
    Friend WithEvents lblMouseButton As Label
    Friend WithEvents comboBoxClickType As ComboBox
    Friend WithEvents lblTimes As Label
    Friend WithEvents numericUpDownTimes As NumericUpDown
    Friend WithEvents rButtonRepeatUntilStopped As RadioButton
    Friend WithEvents rButtonRepeat As RadioButton
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents systemClicker As Timer
End Class
