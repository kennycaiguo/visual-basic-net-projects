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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBoxColor = New System.Windows.Forms.GroupBox()
        Me.rButtonColorRandom = New System.Windows.Forms.RadioButton()
        Me.rButtonColorAqua = New System.Windows.Forms.RadioButton()
        Me.rButtonColorBlack = New System.Windows.Forms.RadioButton()
        Me.rButtonColorYellow = New System.Windows.Forms.RadioButton()
        Me.rButtonColorPink = New System.Windows.Forms.RadioButton()
        Me.rButtonColorOrange = New System.Windows.Forms.RadioButton()
        Me.rButtonColorPurple = New System.Windows.Forms.RadioButton()
        Me.rButtonColorGreen = New System.Windows.Forms.RadioButton()
        Me.rButtonColorBlue = New System.Windows.Forms.RadioButton()
        Me.rButtonColorRed = New System.Windows.Forms.RadioButton()
        Me.groupBoxLanguage = New System.Windows.Forms.GroupBox()
        Me.rButtonLanguageIndonesian = New System.Windows.Forms.RadioButton()
        Me.rButtonLanguagePortuguese = New System.Windows.Forms.RadioButton()
        Me.rButtonLanguageRussian = New System.Windows.Forms.RadioButton()
        Me.rButtonLanguageBengali = New System.Windows.Forms.RadioButton()
        Me.rButtonLanguageArabic = New System.Windows.Forms.RadioButton()
        Me.rButtonLanguageFrench = New System.Windows.Forms.RadioButton()
        Me.rButtonLanguageSpanish = New System.Windows.Forms.RadioButton()
        Me.rButtonLanguageHindi = New System.Windows.Forms.RadioButton()
        Me.rButtonLanguageMandarin = New System.Windows.Forms.RadioButton()
        Me.rButtonLanguageEnglish = New System.Windows.Forms.RadioButton()
        Me.animateText = New System.Windows.Forms.Timer(Me.components)
        Me.lblHello = New System.Windows.Forms.Label()
        Me.groupBoxAnimation = New System.Windows.Forms.GroupBox()
        Me.rButtonAnimationFalse = New System.Windows.Forms.RadioButton()
        Me.rButtonAnimationTrue = New System.Windows.Forms.RadioButton()
        Me.animateColor = New System.Windows.Forms.Timer(Me.components)
        Me.groupBoxColor.SuspendLayout()
        Me.groupBoxLanguage.SuspendLayout()
        Me.groupBoxAnimation.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBoxColor
        '
        Me.groupBoxColor.Controls.Add(Me.rButtonColorRandom)
        Me.groupBoxColor.Controls.Add(Me.rButtonColorAqua)
        Me.groupBoxColor.Controls.Add(Me.rButtonColorBlack)
        Me.groupBoxColor.Controls.Add(Me.rButtonColorYellow)
        Me.groupBoxColor.Controls.Add(Me.rButtonColorPink)
        Me.groupBoxColor.Controls.Add(Me.rButtonColorOrange)
        Me.groupBoxColor.Controls.Add(Me.rButtonColorPurple)
        Me.groupBoxColor.Controls.Add(Me.rButtonColorGreen)
        Me.groupBoxColor.Controls.Add(Me.rButtonColorBlue)
        Me.groupBoxColor.Controls.Add(Me.rButtonColorRed)
        Me.groupBoxColor.Location = New System.Drawing.Point(13, 13)
        Me.groupBoxColor.Name = "groupBoxColor"
        Me.groupBoxColor.Size = New System.Drawing.Size(83, 258)
        Me.groupBoxColor.TabIndex = 0
        Me.groupBoxColor.TabStop = False
        Me.groupBoxColor.Text = "Color"
        '
        'rButtonColorRandom
        '
        Me.rButtonColorRandom.AutoSize = True
        Me.rButtonColorRandom.Location = New System.Drawing.Point(6, 226)
        Me.rButtonColorRandom.Name = "rButtonColorRandom"
        Me.rButtonColorRandom.Size = New System.Drawing.Size(65, 17)
        Me.rButtonColorRandom.TabIndex = 12
        Me.rButtonColorRandom.Text = "Random"
        Me.rButtonColorRandom.UseVisualStyleBackColor = True
        '
        'rButtonColorAqua
        '
        Me.rButtonColorAqua.AutoSize = True
        Me.rButtonColorAqua.Location = New System.Drawing.Point(6, 203)
        Me.rButtonColorAqua.Name = "rButtonColorAqua"
        Me.rButtonColorAqua.Size = New System.Drawing.Size(50, 17)
        Me.rButtonColorAqua.TabIndex = 11
        Me.rButtonColorAqua.Text = "Aqua"
        Me.rButtonColorAqua.UseVisualStyleBackColor = True
        '
        'rButtonColorBlack
        '
        Me.rButtonColorBlack.AutoSize = True
        Me.rButtonColorBlack.Checked = True
        Me.rButtonColorBlack.Location = New System.Drawing.Point(6, 180)
        Me.rButtonColorBlack.Name = "rButtonColorBlack"
        Me.rButtonColorBlack.Size = New System.Drawing.Size(52, 17)
        Me.rButtonColorBlack.TabIndex = 10
        Me.rButtonColorBlack.TabStop = True
        Me.rButtonColorBlack.Text = "Black"
        Me.rButtonColorBlack.UseVisualStyleBackColor = True
        '
        'rButtonColorYellow
        '
        Me.rButtonColorYellow.AutoSize = True
        Me.rButtonColorYellow.Location = New System.Drawing.Point(6, 157)
        Me.rButtonColorYellow.Name = "rButtonColorYellow"
        Me.rButtonColorYellow.Size = New System.Drawing.Size(56, 17)
        Me.rButtonColorYellow.TabIndex = 9
        Me.rButtonColorYellow.Text = "Yellow"
        Me.rButtonColorYellow.UseVisualStyleBackColor = True
        '
        'rButtonColorPink
        '
        Me.rButtonColorPink.AutoSize = True
        Me.rButtonColorPink.Location = New System.Drawing.Point(6, 134)
        Me.rButtonColorPink.Name = "rButtonColorPink"
        Me.rButtonColorPink.Size = New System.Drawing.Size(46, 17)
        Me.rButtonColorPink.TabIndex = 8
        Me.rButtonColorPink.Text = "Pink"
        Me.rButtonColorPink.UseVisualStyleBackColor = True
        '
        'rButtonColorOrange
        '
        Me.rButtonColorOrange.AutoSize = True
        Me.rButtonColorOrange.Location = New System.Drawing.Point(6, 111)
        Me.rButtonColorOrange.Name = "rButtonColorOrange"
        Me.rButtonColorOrange.Size = New System.Drawing.Size(60, 17)
        Me.rButtonColorOrange.TabIndex = 7
        Me.rButtonColorOrange.Text = "Orange"
        Me.rButtonColorOrange.UseVisualStyleBackColor = True
        '
        'rButtonColorPurple
        '
        Me.rButtonColorPurple.AutoSize = True
        Me.rButtonColorPurple.Location = New System.Drawing.Point(6, 88)
        Me.rButtonColorPurple.Name = "rButtonColorPurple"
        Me.rButtonColorPurple.Size = New System.Drawing.Size(55, 17)
        Me.rButtonColorPurple.TabIndex = 6
        Me.rButtonColorPurple.Text = "Purple"
        Me.rButtonColorPurple.UseVisualStyleBackColor = True
        '
        'rButtonColorGreen
        '
        Me.rButtonColorGreen.AutoSize = True
        Me.rButtonColorGreen.Location = New System.Drawing.Point(6, 65)
        Me.rButtonColorGreen.Name = "rButtonColorGreen"
        Me.rButtonColorGreen.Size = New System.Drawing.Size(54, 17)
        Me.rButtonColorGreen.TabIndex = 5
        Me.rButtonColorGreen.Text = "Green"
        Me.rButtonColorGreen.UseVisualStyleBackColor = True
        '
        'rButtonColorBlue
        '
        Me.rButtonColorBlue.AutoSize = True
        Me.rButtonColorBlue.Location = New System.Drawing.Point(6, 42)
        Me.rButtonColorBlue.Name = "rButtonColorBlue"
        Me.rButtonColorBlue.Size = New System.Drawing.Size(46, 17)
        Me.rButtonColorBlue.TabIndex = 4
        Me.rButtonColorBlue.Text = "Blue"
        Me.rButtonColorBlue.UseVisualStyleBackColor = True
        '
        'rButtonColorRed
        '
        Me.rButtonColorRed.AutoSize = True
        Me.rButtonColorRed.Location = New System.Drawing.Point(6, 19)
        Me.rButtonColorRed.Name = "rButtonColorRed"
        Me.rButtonColorRed.Size = New System.Drawing.Size(45, 17)
        Me.rButtonColorRed.TabIndex = 3
        Me.rButtonColorRed.Text = "Red"
        Me.rButtonColorRed.UseVisualStyleBackColor = True
        '
        'groupBoxLanguage
        '
        Me.groupBoxLanguage.Controls.Add(Me.rButtonLanguageIndonesian)
        Me.groupBoxLanguage.Controls.Add(Me.rButtonLanguagePortuguese)
        Me.groupBoxLanguage.Controls.Add(Me.rButtonLanguageRussian)
        Me.groupBoxLanguage.Controls.Add(Me.rButtonLanguageBengali)
        Me.groupBoxLanguage.Controls.Add(Me.rButtonLanguageArabic)
        Me.groupBoxLanguage.Controls.Add(Me.rButtonLanguageFrench)
        Me.groupBoxLanguage.Controls.Add(Me.rButtonLanguageSpanish)
        Me.groupBoxLanguage.Controls.Add(Me.rButtonLanguageHindi)
        Me.groupBoxLanguage.Controls.Add(Me.rButtonLanguageMandarin)
        Me.groupBoxLanguage.Controls.Add(Me.rButtonLanguageEnglish)
        Me.groupBoxLanguage.Location = New System.Drawing.Point(102, 13)
        Me.groupBoxLanguage.Name = "groupBoxLanguage"
        Me.groupBoxLanguage.Size = New System.Drawing.Size(83, 258)
        Me.groupBoxLanguage.TabIndex = 1
        Me.groupBoxLanguage.TabStop = False
        Me.groupBoxLanguage.Text = "Language"
        '
        'rButtonLanguageIndonesian
        '
        Me.rButtonLanguageIndonesian.AutoSize = True
        Me.rButtonLanguageIndonesian.Location = New System.Drawing.Point(6, 226)
        Me.rButtonLanguageIndonesian.Name = "rButtonLanguageIndonesian"
        Me.rButtonLanguageIndonesian.Size = New System.Drawing.Size(75, 17)
        Me.rButtonLanguageIndonesian.TabIndex = 9
        Me.rButtonLanguageIndonesian.Text = "Indonesan"
        Me.rButtonLanguageIndonesian.UseVisualStyleBackColor = True
        '
        'rButtonLanguagePortuguese
        '
        Me.rButtonLanguagePortuguese.AutoSize = True
        Me.rButtonLanguagePortuguese.Location = New System.Drawing.Point(6, 203)
        Me.rButtonLanguagePortuguese.Name = "rButtonLanguagePortuguese"
        Me.rButtonLanguagePortuguese.Size = New System.Drawing.Size(79, 17)
        Me.rButtonLanguagePortuguese.TabIndex = 8
        Me.rButtonLanguagePortuguese.Text = "Portuguese"
        Me.rButtonLanguagePortuguese.UseVisualStyleBackColor = True
        '
        'rButtonLanguageRussian
        '
        Me.rButtonLanguageRussian.AutoSize = True
        Me.rButtonLanguageRussian.Location = New System.Drawing.Point(6, 180)
        Me.rButtonLanguageRussian.Name = "rButtonLanguageRussian"
        Me.rButtonLanguageRussian.Size = New System.Drawing.Size(63, 17)
        Me.rButtonLanguageRussian.TabIndex = 7
        Me.rButtonLanguageRussian.Text = "Russian"
        Me.rButtonLanguageRussian.UseVisualStyleBackColor = True
        '
        'rButtonLanguageBengali
        '
        Me.rButtonLanguageBengali.AutoSize = True
        Me.rButtonLanguageBengali.Location = New System.Drawing.Point(6, 157)
        Me.rButtonLanguageBengali.Name = "rButtonLanguageBengali"
        Me.rButtonLanguageBengali.Size = New System.Drawing.Size(60, 17)
        Me.rButtonLanguageBengali.TabIndex = 6
        Me.rButtonLanguageBengali.Text = "Bengali"
        Me.rButtonLanguageBengali.UseVisualStyleBackColor = True
        '
        'rButtonLanguageArabic
        '
        Me.rButtonLanguageArabic.AutoSize = True
        Me.rButtonLanguageArabic.Location = New System.Drawing.Point(6, 134)
        Me.rButtonLanguageArabic.Name = "rButtonLanguageArabic"
        Me.rButtonLanguageArabic.Size = New System.Drawing.Size(55, 17)
        Me.rButtonLanguageArabic.TabIndex = 5
        Me.rButtonLanguageArabic.Text = "Arabic"
        Me.rButtonLanguageArabic.UseVisualStyleBackColor = True
        '
        'rButtonLanguageFrench
        '
        Me.rButtonLanguageFrench.AutoSize = True
        Me.rButtonLanguageFrench.Location = New System.Drawing.Point(6, 111)
        Me.rButtonLanguageFrench.Name = "rButtonLanguageFrench"
        Me.rButtonLanguageFrench.Size = New System.Drawing.Size(58, 17)
        Me.rButtonLanguageFrench.TabIndex = 4
        Me.rButtonLanguageFrench.Text = "French"
        Me.rButtonLanguageFrench.UseVisualStyleBackColor = True
        '
        'rButtonLanguageSpanish
        '
        Me.rButtonLanguageSpanish.AutoSize = True
        Me.rButtonLanguageSpanish.Location = New System.Drawing.Point(6, 88)
        Me.rButtonLanguageSpanish.Name = "rButtonLanguageSpanish"
        Me.rButtonLanguageSpanish.Size = New System.Drawing.Size(63, 17)
        Me.rButtonLanguageSpanish.TabIndex = 3
        Me.rButtonLanguageSpanish.Text = "Spanish"
        Me.rButtonLanguageSpanish.UseVisualStyleBackColor = True
        '
        'rButtonLanguageHindi
        '
        Me.rButtonLanguageHindi.AutoSize = True
        Me.rButtonLanguageHindi.Location = New System.Drawing.Point(6, 65)
        Me.rButtonLanguageHindi.Name = "rButtonLanguageHindi"
        Me.rButtonLanguageHindi.Size = New System.Drawing.Size(49, 17)
        Me.rButtonLanguageHindi.TabIndex = 2
        Me.rButtonLanguageHindi.Text = "Hindi"
        Me.rButtonLanguageHindi.UseVisualStyleBackColor = True
        '
        'rButtonLanguageMandarin
        '
        Me.rButtonLanguageMandarin.AutoSize = True
        Me.rButtonLanguageMandarin.Location = New System.Drawing.Point(6, 42)
        Me.rButtonLanguageMandarin.Name = "rButtonLanguageMandarin"
        Me.rButtonLanguageMandarin.Size = New System.Drawing.Size(69, 17)
        Me.rButtonLanguageMandarin.TabIndex = 1
        Me.rButtonLanguageMandarin.Text = "Mandarin"
        Me.rButtonLanguageMandarin.UseVisualStyleBackColor = True
        '
        'rButtonLanguageEnglish
        '
        Me.rButtonLanguageEnglish.AutoSize = True
        Me.rButtonLanguageEnglish.Checked = True
        Me.rButtonLanguageEnglish.Location = New System.Drawing.Point(6, 19)
        Me.rButtonLanguageEnglish.Name = "rButtonLanguageEnglish"
        Me.rButtonLanguageEnglish.Size = New System.Drawing.Size(59, 17)
        Me.rButtonLanguageEnglish.TabIndex = 0
        Me.rButtonLanguageEnglish.TabStop = True
        Me.rButtonLanguageEnglish.Text = "English"
        Me.rButtonLanguageEnglish.UseVisualStyleBackColor = True
        '
        'animateText
        '
        Me.animateText.Enabled = True
        Me.animateText.Interval = 50
        '
        'lblHello
        '
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.lblHello.Location = New System.Drawing.Point(191, 124)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(541, 86)
        Me.lblHello.TabIndex = 11
        Me.lblHello.Text = "Hello"
        Me.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'groupBoxAnimation
        '
        Me.groupBoxAnimation.Controls.Add(Me.rButtonAnimationFalse)
        Me.groupBoxAnimation.Controls.Add(Me.rButtonAnimationTrue)
        Me.groupBoxAnimation.Location = New System.Drawing.Point(198, 13)
        Me.groupBoxAnimation.Name = "groupBoxAnimation"
        Me.groupBoxAnimation.Size = New System.Drawing.Size(83, 68)
        Me.groupBoxAnimation.TabIndex = 10
        Me.groupBoxAnimation.TabStop = False
        Me.groupBoxAnimation.Text = "Animation"
        '
        'rButtonAnimationFalse
        '
        Me.rButtonAnimationFalse.AutoSize = True
        Me.rButtonAnimationFalse.Checked = True
        Me.rButtonAnimationFalse.Location = New System.Drawing.Point(6, 42)
        Me.rButtonAnimationFalse.Name = "rButtonAnimationFalse"
        Me.rButtonAnimationFalse.Size = New System.Drawing.Size(50, 17)
        Me.rButtonAnimationFalse.TabIndex = 1
        Me.rButtonAnimationFalse.TabStop = True
        Me.rButtonAnimationFalse.Text = "False"
        Me.rButtonAnimationFalse.UseVisualStyleBackColor = True
        '
        'rButtonAnimationTrue
        '
        Me.rButtonAnimationTrue.AutoSize = True
        Me.rButtonAnimationTrue.Location = New System.Drawing.Point(6, 19)
        Me.rButtonAnimationTrue.Name = "rButtonAnimationTrue"
        Me.rButtonAnimationTrue.Size = New System.Drawing.Size(47, 17)
        Me.rButtonAnimationTrue.TabIndex = 0
        Me.rButtonAnimationTrue.Text = "True"
        Me.rButtonAnimationTrue.UseVisualStyleBackColor = True
        '
        'animateColor
        '
        Me.animateColor.Enabled = True
        Me.animateColor.Interval = 150
        Me.animateColor.Tag = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 296)
        Me.Controls.Add(Me.groupBoxAnimation)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.groupBoxLanguage)
        Me.Controls.Add(Me.groupBoxColor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Hello (with Animation)"
        Me.groupBoxColor.ResumeLayout(False)
        Me.groupBoxColor.PerformLayout()
        Me.groupBoxLanguage.ResumeLayout(False)
        Me.groupBoxLanguage.PerformLayout()
        Me.groupBoxAnimation.ResumeLayout(False)
        Me.groupBoxAnimation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBoxColor As GroupBox
    Friend WithEvents rButtonColorRandom As RadioButton
    Friend WithEvents rButtonColorAqua As RadioButton
    Friend WithEvents rButtonColorBlack As RadioButton
    Friend WithEvents rButtonColorYellow As RadioButton
    Friend WithEvents rButtonColorPink As RadioButton
    Friend WithEvents rButtonColorOrange As RadioButton
    Friend WithEvents rButtonColorPurple As RadioButton
    Friend WithEvents rButtonColorGreen As RadioButton
    Friend WithEvents rButtonColorBlue As RadioButton
    Friend WithEvents rButtonColorRed As RadioButton
    Friend WithEvents groupBoxLanguage As GroupBox
    Friend WithEvents rButtonLanguageHindi As RadioButton
    Friend WithEvents rButtonLanguageMandarin As RadioButton
    Friend WithEvents rButtonLanguageEnglish As RadioButton
    Friend WithEvents animateText As Timer
    Friend WithEvents rButtonLanguageIndonesian As RadioButton
    Friend WithEvents rButtonLanguagePortuguese As RadioButton
    Friend WithEvents rButtonLanguageRussian As RadioButton
    Friend WithEvents rButtonLanguageBengali As RadioButton
    Friend WithEvents rButtonLanguageArabic As RadioButton
    Friend WithEvents rButtonLanguageFrench As RadioButton
    Friend WithEvents rButtonLanguageSpanish As RadioButton
    Friend WithEvents lblHello As Label
    Friend WithEvents groupBoxAnimation As GroupBox
    Friend WithEvents rButtonAnimationFalse As RadioButton
    Friend WithEvents rButtonAnimationTrue As RadioButton
    Friend WithEvents animateColor As Timer
End Class
