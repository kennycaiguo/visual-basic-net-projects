<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoClickerSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoClickerSetup))
        Me.setupBackground = New System.Windows.Forms.PictureBox()
        Me.btnCancelSetup = New System.Windows.Forms.Button()
        Me.btnNextStep = New System.Windows.Forms.Button()
        Me.lblWelcomeSetup = New System.Windows.Forms.Label()
        Me.lblSetupGuide = New System.Windows.Forms.Label()
        Me.setupArt = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblSetupType1 = New System.Windows.Forms.Label()
        Me.lblSetupType2 = New System.Windows.Forms.Label()
        Me.radioButtonFull = New System.Windows.Forms.RadioButton()
        Me.radioButtonCustom = New System.Windows.Forms.RadioButton()
        Me.lblFullDescription = New System.Windows.Forms.Label()
        Me.lblCustomDescription = New System.Windows.Forms.Label()
        Me.radioButtonBeta = New System.Windows.Forms.RadioButton()
        Me.lblBetaDescription = New System.Windows.Forms.Label()
        CType(Me.setupBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setupArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'setupBackground
        '
        Me.setupBackground.ImageLocation = ""
        Me.setupBackground.InitialImage = CType(resources.GetObject("setupBackground.InitialImage"), System.Drawing.Image)
        Me.setupBackground.Location = New System.Drawing.Point(-1, 0)
        Me.setupBackground.Name = "setupBackground"
        Me.setupBackground.Size = New System.Drawing.Size(503, 349)
        Me.setupBackground.TabIndex = 0
        Me.setupBackground.TabStop = False
        '
        'btnCancelSetup
        '
        Me.btnCancelSetup.Location = New System.Drawing.Point(410, 312)
        Me.btnCancelSetup.Name = "btnCancelSetup"
        Me.btnCancelSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelSetup.TabIndex = 1
        Me.btnCancelSetup.Text = "Cancel"
        Me.btnCancelSetup.UseVisualStyleBackColor = True
        '
        'btnNextStep
        '
        Me.btnNextStep.Location = New System.Drawing.Point(321, 312)
        Me.btnNextStep.Name = "btnNextStep"
        Me.btnNextStep.Size = New System.Drawing.Size(77, 23)
        Me.btnNextStep.TabIndex = 2
        Me.btnNextStep.Text = "Next >"
        Me.btnNextStep.UseVisualStyleBackColor = True
        '
        'lblWelcomeSetup
        '
        Me.lblWelcomeSetup.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcomeSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcomeSetup.Location = New System.Drawing.Point(154, 9)
        Me.lblWelcomeSetup.Name = "lblWelcomeSetup"
        Me.lblWelcomeSetup.Size = New System.Drawing.Size(244, 23)
        Me.lblWelcomeSetup.TabIndex = 3
        Me.lblWelcomeSetup.Text = "Welcome to AutoClicker Setup"
        '
        'lblSetupGuide
        '
        Me.lblSetupGuide.AutoSize = True
        Me.lblSetupGuide.BackColor = System.Drawing.Color.Transparent
        Me.lblSetupGuide.Location = New System.Drawing.Point(154, 61)
        Me.lblSetupGuide.Name = "lblSetupGuide"
        Me.lblSetupGuide.Size = New System.Drawing.Size(282, 104)
        Me.lblSetupGuide.TabIndex = 4
        Me.lblSetupGuide.Text = resources.GetString("lblSetupGuide.Text")
        '
        'setupArt
        '
        Me.setupArt.ImageLocation = ""
        Me.setupArt.Location = New System.Drawing.Point(-1, 0)
        Me.setupArt.Name = "setupArt"
        Me.setupArt.Size = New System.Drawing.Size(136, 303)
        Me.setupArt.TabIndex = 5
        Me.setupArt.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(238, 312)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(77, 23)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "< Back"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.Visible = False
        '
        'lblSetupType1
        '
        Me.lblSetupType1.BackColor = System.Drawing.Color.Transparent
        Me.lblSetupType1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblSetupType1.Location = New System.Drawing.Point(154, 13)
        Me.lblSetupType1.Name = "lblSetupType1"
        Me.lblSetupType1.Size = New System.Drawing.Size(244, 16)
        Me.lblSetupType1.TabIndex = 8
        Me.lblSetupType1.Text = "AutoClicker Setup Wizard"
        Me.lblSetupType1.Visible = False
        '
        'lblSetupType2
        '
        Me.lblSetupType2.AutoSize = True
        Me.lblSetupType2.BackColor = System.Drawing.Color.Transparent
        Me.lblSetupType2.Location = New System.Drawing.Point(154, 29)
        Me.lblSetupType2.Name = "lblSetupType2"
        Me.lblSetupType2.Size = New System.Drawing.Size(157, 13)
        Me.lblSetupType2.TabIndex = 9
        Me.lblSetupType2.Text = "Please select type of installation"
        Me.lblSetupType2.Visible = False
        '
        'radioButtonFull
        '
        Me.radioButtonFull.AutoSize = True
        Me.radioButtonFull.BackColor = System.Drawing.Color.Transparent
        Me.radioButtonFull.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButtonFull.Location = New System.Drawing.Point(157, 127)
        Me.radioButtonFull.Name = "radioButtonFull"
        Me.radioButtonFull.Size = New System.Drawing.Size(140, 17)
        Me.radioButtonFull.TabIndex = 10
        Me.radioButtonFull.TabStop = True
        Me.radioButtonFull.Text = "&Full (Recommended)"
        Me.radioButtonFull.UseVisualStyleBackColor = False
        Me.radioButtonFull.Visible = False
        '
        'radioButtonCustom
        '
        Me.radioButtonCustom.AutoSize = True
        Me.radioButtonCustom.BackColor = System.Drawing.Color.Transparent
        Me.radioButtonCustom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButtonCustom.Location = New System.Drawing.Point(157, 182)
        Me.radioButtonCustom.Name = "radioButtonCustom"
        Me.radioButtonCustom.Size = New System.Drawing.Size(66, 17)
        Me.radioButtonCustom.TabIndex = 11
        Me.radioButtonCustom.TabStop = True
        Me.radioButtonCustom.Text = "&Custom"
        Me.radioButtonCustom.UseVisualStyleBackColor = False
        Me.radioButtonCustom.Visible = False
        '
        'lblFullDescription
        '
        Me.lblFullDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblFullDescription.Location = New System.Drawing.Point(154, 147)
        Me.lblFullDescription.Name = "lblFullDescription"
        Me.lblFullDescription.Size = New System.Drawing.Size(261, 32)
        Me.lblFullDescription.TabIndex = 12
        Me.lblFullDescription.Text = "Installs all components."
        Me.lblFullDescription.Visible = False
        '
        'lblCustomDescription
        '
        Me.lblCustomDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomDescription.Location = New System.Drawing.Point(154, 202)
        Me.lblCustomDescription.Name = "lblCustomDescription"
        Me.lblCustomDescription.Size = New System.Drawing.Size(258, 32)
        Me.lblCustomDescription.TabIndex = 13
        Me.lblCustomDescription.Text = "Select what components will be installed."
        Me.lblCustomDescription.Visible = False
        '
        'radioButtonBeta
        '
        Me.radioButtonBeta.AutoSize = True
        Me.radioButtonBeta.BackColor = System.Drawing.Color.Transparent
        Me.radioButtonBeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButtonBeta.Location = New System.Drawing.Point(157, 72)
        Me.radioButtonBeta.Name = "radioButtonBeta"
        Me.radioButtonBeta.Size = New System.Drawing.Size(51, 17)
        Me.radioButtonBeta.TabIndex = 14
        Me.radioButtonBeta.TabStop = True
        Me.radioButtonBeta.Text = "&Beta"
        Me.radioButtonBeta.UseVisualStyleBackColor = False
        Me.radioButtonBeta.Visible = False
        '
        'lblBetaDescription
        '
        Me.lblBetaDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblBetaDescription.Location = New System.Drawing.Point(154, 92)
        Me.lblBetaDescription.Name = "lblBetaDescription"
        Me.lblBetaDescription.Size = New System.Drawing.Size(261, 32)
        Me.lblBetaDescription.TabIndex = 15
        Me.lblBetaDescription.Text = "Installs all components, and experimental features."
        Me.lblBetaDescription.Visible = False
        '
        'frmAutoClickerSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 347)
        Me.Controls.Add(Me.lblBetaDescription)
        Me.Controls.Add(Me.radioButtonBeta)
        Me.Controls.Add(Me.lblCustomDescription)
        Me.Controls.Add(Me.lblFullDescription)
        Me.Controls.Add(Me.radioButtonCustom)
        Me.Controls.Add(Me.radioButtonFull)
        Me.Controls.Add(Me.lblSetupType2)
        Me.Controls.Add(Me.lblSetupType1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.setupArt)
        Me.Controls.Add(Me.lblSetupGuide)
        Me.Controls.Add(Me.lblWelcomeSetup)
        Me.Controls.Add(Me.btnNextStep)
        Me.Controls.Add(Me.btnCancelSetup)
        Me.Controls.Add(Me.setupBackground)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAutoClickerSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoClicker Setup"
        CType(Me.setupBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setupArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents setupBackground As PictureBox
    Friend WithEvents btnCancelSetup As Button
    Friend WithEvents btnNextStep As Button
    Friend WithEvents lblWelcomeSetup As Label
    Friend WithEvents lblSetupGuide As Label
    Friend WithEvents setupArt As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblSetupType1 As Label
    Friend WithEvents lblSetupType2 As Label
    Friend WithEvents radioButtonFull As RadioButton
    Friend WithEvents radioButtonCustom As RadioButton
    Friend WithEvents lblFullDescription As Label
    Friend WithEvents lblCustomDescription As Label
    Friend WithEvents radioButtonBeta As RadioButton
    Friend WithEvents lblBetaDescription As Label
End Class
