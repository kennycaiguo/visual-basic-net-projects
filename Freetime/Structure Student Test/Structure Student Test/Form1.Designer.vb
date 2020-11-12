<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStructureTest
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
        Me.lblStudentInfo = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblGradYear = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.listBoxResults = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.groupBoxGradYear = New System.Windows.Forms.GroupBox()
        Me.rButtonGradYear24 = New System.Windows.Forms.RadioButton()
        Me.rButtonGradYear23 = New System.Windows.Forms.RadioButton()
        Me.rButtonGradYear22 = New System.Windows.Forms.RadioButton()
        Me.rButtonGradYear21 = New System.Windows.Forms.RadioButton()
        Me.groupBoxAge = New System.Windows.Forms.GroupBox()
        Me.rButtonAge18 = New System.Windows.Forms.RadioButton()
        Me.rButtonAge17 = New System.Windows.Forms.RadioButton()
        Me.rButtonAge16 = New System.Windows.Forms.RadioButton()
        Me.rButtonAge15 = New System.Windows.Forms.RadioButton()
        Me.txtBoxFirstName = New System.Windows.Forms.TextBox()
        Me.txtBoxLastName = New System.Windows.Forms.TextBox()
        Me.groupBoxGPA = New System.Windows.Forms.GroupBox()
        Me.rButtonGPA4 = New System.Windows.Forms.RadioButton()
        Me.rButtonGPA2 = New System.Windows.Forms.RadioButton()
        Me.rButtonGPA3 = New System.Windows.Forms.RadioButton()
        Me.rButtonGPA1 = New System.Windows.Forms.RadioButton()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtBoxSearch = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.groupBoxGradYear.SuspendLayout()
        Me.groupBoxAge.SuspendLayout()
        Me.groupBoxGPA.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStudentInfo
        '
        Me.lblStudentInfo.AutoSize = True
        Me.lblStudentInfo.Location = New System.Drawing.Point(13, 13)
        Me.lblStudentInfo.Name = "lblStudentInfo"
        Me.lblStudentInfo.Size = New System.Drawing.Size(99, 13)
        Me.lblStudentInfo.TabIndex = 0
        Me.lblStudentInfo.Text = "Student Information"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(13, 39)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(146, 40)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(13, 80)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age:"
        '
        'lblGradYear
        '
        Me.lblGradYear.AutoSize = True
        Me.lblGradYear.Location = New System.Drawing.Point(146, 85)
        Me.lblGradYear.Name = "lblGradYear"
        Me.lblGradYear.Size = New System.Drawing.Size(87, 13)
        Me.lblGradYear.TabIndex = 4
        Me.lblGradYear.Text = "Graduation Year:"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(12, 243)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(45, 13)
        Me.lblResults.TabIndex = 7
        Me.lblResults.Text = "Results:"
        '
        'listBoxResults
        '
        Me.listBoxResults.FormattingEnabled = True
        Me.listBoxResults.Location = New System.Drawing.Point(16, 259)
        Me.listBoxResults.Name = "listBoxResults"
        Me.listBoxResults.Size = New System.Drawing.Size(376, 147)
        Me.listBoxResults.TabIndex = 8
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(297, 157)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add Student"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Location = New System.Drawing.Point(327, 40)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(32, 13)
        Me.lblGPA.TabIndex = 10
        Me.lblGPA.Text = "GPA:"
        '
        'groupBoxGradYear
        '
        Me.groupBoxGradYear.Controls.Add(Me.rButtonGradYear24)
        Me.groupBoxGradYear.Controls.Add(Me.rButtonGradYear23)
        Me.groupBoxGradYear.Controls.Add(Me.rButtonGradYear22)
        Me.groupBoxGradYear.Controls.Add(Me.rButtonGradYear21)
        Me.groupBoxGradYear.Location = New System.Drawing.Point(149, 96)
        Me.groupBoxGradYear.Name = "groupBoxGradYear"
        Me.groupBoxGradYear.Size = New System.Drawing.Size(140, 55)
        Me.groupBoxGradYear.TabIndex = 13
        Me.groupBoxGradYear.TabStop = False
        '
        'rButtonGradYear24
        '
        Me.rButtonGradYear24.AutoSize = True
        Me.rButtonGradYear24.Location = New System.Drawing.Point(85, 29)
        Me.rButtonGradYear24.Name = "rButtonGradYear24"
        Me.rButtonGradYear24.Size = New System.Drawing.Size(49, 17)
        Me.rButtonGradYear24.TabIndex = 3
        Me.rButtonGradYear24.TabStop = True
        Me.rButtonGradYear24.Text = "2024"
        Me.rButtonGradYear24.UseVisualStyleBackColor = True
        '
        'rButtonGradYear23
        '
        Me.rButtonGradYear23.AutoSize = True
        Me.rButtonGradYear23.Location = New System.Drawing.Point(9, 29)
        Me.rButtonGradYear23.Name = "rButtonGradYear23"
        Me.rButtonGradYear23.Size = New System.Drawing.Size(49, 17)
        Me.rButtonGradYear23.TabIndex = 2
        Me.rButtonGradYear23.TabStop = True
        Me.rButtonGradYear23.Text = "2023"
        Me.rButtonGradYear23.UseVisualStyleBackColor = True
        '
        'rButtonGradYear22
        '
        Me.rButtonGradYear22.AutoSize = True
        Me.rButtonGradYear22.Location = New System.Drawing.Point(85, 11)
        Me.rButtonGradYear22.Name = "rButtonGradYear22"
        Me.rButtonGradYear22.Size = New System.Drawing.Size(49, 17)
        Me.rButtonGradYear22.TabIndex = 1
        Me.rButtonGradYear22.TabStop = True
        Me.rButtonGradYear22.Text = "2022"
        Me.rButtonGradYear22.UseVisualStyleBackColor = True
        '
        'rButtonGradYear21
        '
        Me.rButtonGradYear21.AutoSize = True
        Me.rButtonGradYear21.Location = New System.Drawing.Point(9, 11)
        Me.rButtonGradYear21.Name = "rButtonGradYear21"
        Me.rButtonGradYear21.Size = New System.Drawing.Size(49, 17)
        Me.rButtonGradYear21.TabIndex = 0
        Me.rButtonGradYear21.TabStop = True
        Me.rButtonGradYear21.Text = "2021"
        Me.rButtonGradYear21.UseVisualStyleBackColor = True
        '
        'groupBoxAge
        '
        Me.groupBoxAge.Controls.Add(Me.rButtonAge18)
        Me.groupBoxAge.Controls.Add(Me.rButtonAge17)
        Me.groupBoxAge.Controls.Add(Me.rButtonAge16)
        Me.groupBoxAge.Controls.Add(Me.rButtonAge15)
        Me.groupBoxAge.Location = New System.Drawing.Point(16, 96)
        Me.groupBoxAge.Name = "groupBoxAge"
        Me.groupBoxAge.Size = New System.Drawing.Size(96, 55)
        Me.groupBoxAge.TabIndex = 13
        Me.groupBoxAge.TabStop = False
        '
        'rButtonAge18
        '
        Me.rButtonAge18.AutoSize = True
        Me.rButtonAge18.Location = New System.Drawing.Point(54, 32)
        Me.rButtonAge18.Name = "rButtonAge18"
        Me.rButtonAge18.Size = New System.Drawing.Size(37, 17)
        Me.rButtonAge18.TabIndex = 3
        Me.rButtonAge18.TabStop = True
        Me.rButtonAge18.Text = "18"
        Me.rButtonAge18.UseVisualStyleBackColor = True
        '
        'rButtonAge17
        '
        Me.rButtonAge17.AutoSize = True
        Me.rButtonAge17.Location = New System.Drawing.Point(7, 34)
        Me.rButtonAge17.Name = "rButtonAge17"
        Me.rButtonAge17.Size = New System.Drawing.Size(37, 17)
        Me.rButtonAge17.TabIndex = 2
        Me.rButtonAge17.TabStop = True
        Me.rButtonAge17.Text = "17"
        Me.rButtonAge17.UseVisualStyleBackColor = True
        '
        'rButtonAge16
        '
        Me.rButtonAge16.AutoSize = True
        Me.rButtonAge16.Location = New System.Drawing.Point(54, 11)
        Me.rButtonAge16.Name = "rButtonAge16"
        Me.rButtonAge16.Size = New System.Drawing.Size(37, 17)
        Me.rButtonAge16.TabIndex = 1
        Me.rButtonAge16.TabStop = True
        Me.rButtonAge16.Text = "16"
        Me.rButtonAge16.UseVisualStyleBackColor = True
        '
        'rButtonAge15
        '
        Me.rButtonAge15.AutoSize = True
        Me.rButtonAge15.Location = New System.Drawing.Point(7, 11)
        Me.rButtonAge15.Name = "rButtonAge15"
        Me.rButtonAge15.Size = New System.Drawing.Size(37, 17)
        Me.rButtonAge15.TabIndex = 0
        Me.rButtonAge15.TabStop = True
        Me.rButtonAge15.Text = "15"
        Me.rButtonAge15.UseVisualStyleBackColor = True
        '
        'txtBoxFirstName
        '
        Me.txtBoxFirstName.Location = New System.Drawing.Point(16, 55)
        Me.txtBoxFirstName.Name = "txtBoxFirstName"
        Me.txtBoxFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxFirstName.TabIndex = 14
        '
        'txtBoxLastName
        '
        Me.txtBoxLastName.Location = New System.Drawing.Point(149, 56)
        Me.txtBoxLastName.Name = "txtBoxLastName"
        Me.txtBoxLastName.Size = New System.Drawing.Size(140, 20)
        Me.txtBoxLastName.TabIndex = 15
        '
        'groupBoxGPA
        '
        Me.groupBoxGPA.Controls.Add(Me.rButtonGPA4)
        Me.groupBoxGPA.Controls.Add(Me.rButtonGPA2)
        Me.groupBoxGPA.Controls.Add(Me.rButtonGPA3)
        Me.groupBoxGPA.Controls.Add(Me.rButtonGPA1)
        Me.groupBoxGPA.Location = New System.Drawing.Point(330, 56)
        Me.groupBoxGPA.Name = "groupBoxGPA"
        Me.groupBoxGPA.Size = New System.Drawing.Size(58, 95)
        Me.groupBoxGPA.TabIndex = 14
        Me.groupBoxGPA.TabStop = False
        '
        'rButtonGPA4
        '
        Me.rButtonGPA4.AutoSize = True
        Me.rButtonGPA4.Location = New System.Drawing.Point(9, 65)
        Me.rButtonGPA4.Name = "rButtonGPA4"
        Me.rButtonGPA4.Size = New System.Drawing.Size(40, 17)
        Me.rButtonGPA4.TabIndex = 3
        Me.rButtonGPA4.TabStop = True
        Me.rButtonGPA4.Text = "4.0"
        Me.rButtonGPA4.UseVisualStyleBackColor = True
        '
        'rButtonGPA2
        '
        Me.rButtonGPA2.AutoSize = True
        Me.rButtonGPA2.Location = New System.Drawing.Point(9, 29)
        Me.rButtonGPA2.Name = "rButtonGPA2"
        Me.rButtonGPA2.Size = New System.Drawing.Size(40, 17)
        Me.rButtonGPA2.TabIndex = 2
        Me.rButtonGPA2.TabStop = True
        Me.rButtonGPA2.Text = "2.0"
        Me.rButtonGPA2.UseVisualStyleBackColor = True
        '
        'rButtonGPA3
        '
        Me.rButtonGPA3.AutoSize = True
        Me.rButtonGPA3.Location = New System.Drawing.Point(9, 48)
        Me.rButtonGPA3.Name = "rButtonGPA3"
        Me.rButtonGPA3.Size = New System.Drawing.Size(40, 17)
        Me.rButtonGPA3.TabIndex = 1
        Me.rButtonGPA3.TabStop = True
        Me.rButtonGPA3.Text = "3.0"
        Me.rButtonGPA3.UseVisualStyleBackColor = True
        '
        'rButtonGPA1
        '
        Me.rButtonGPA1.AutoSize = True
        Me.rButtonGPA1.Location = New System.Drawing.Point(9, 11)
        Me.rButtonGPA1.Name = "rButtonGPA1"
        Me.rButtonGPA1.Size = New System.Drawing.Size(40, 17)
        Me.rButtonGPA1.TabIndex = 0
        Me.rButtonGPA1.TabStop = True
        Me.rButtonGPA1.Text = "1.0"
        Me.rButtonGPA1.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(13, 194)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(44, 13)
        Me.lblSearch.TabIndex = 16
        Me.lblSearch.Text = "Search:"
        '
        'txtBoxSearch
        '
        Me.txtBoxSearch.Location = New System.Drawing.Point(16, 210)
        Me.txtBoxSearch.Name = "txtBoxSearch"
        Me.txtBoxSearch.Size = New System.Drawing.Size(375, 20)
        Me.txtBoxSearch.TabIndex = 17
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(15, 157)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(91, 23)
        Me.btnLoad.TabIndex = 18
        Me.btnLoad.Text = "Load Students"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'frmStructureTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 420)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtBoxSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.groupBoxGPA)
        Me.Controls.Add(Me.txtBoxLastName)
        Me.Controls.Add(Me.txtBoxFirstName)
        Me.Controls.Add(Me.groupBoxAge)
        Me.Controls.Add(Me.groupBoxGradYear)
        Me.Controls.Add(Me.lblGPA)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.listBoxResults)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblGradYear)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblStudentInfo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStructureTest"
        Me.Text = "Student Structure Testing"
        Me.groupBoxGradYear.ResumeLayout(False)
        Me.groupBoxGradYear.PerformLayout()
        Me.groupBoxAge.ResumeLayout(False)
        Me.groupBoxAge.PerformLayout()
        Me.groupBoxGPA.ResumeLayout(False)
        Me.groupBoxGPA.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStudentInfo As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblGradYear As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents listBoxResults As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblGPA As Label
    Friend WithEvents groupBoxGradYear As GroupBox
    Friend WithEvents groupBoxAge As GroupBox
    Friend WithEvents txtBoxFirstName As TextBox
    Friend WithEvents txtBoxLastName As TextBox
    Friend WithEvents rButtonGradYear24 As RadioButton
    Friend WithEvents rButtonGradYear23 As RadioButton
    Friend WithEvents rButtonGradYear22 As RadioButton
    Friend WithEvents rButtonGradYear21 As RadioButton
    Friend WithEvents rButtonAge18 As RadioButton
    Friend WithEvents rButtonAge17 As RadioButton
    Friend WithEvents rButtonAge16 As RadioButton
    Friend WithEvents rButtonAge15 As RadioButton
    Friend WithEvents groupBoxGPA As GroupBox
    Friend WithEvents rButtonGPA4 As RadioButton
    Friend WithEvents rButtonGPA2 As RadioButton
    Friend WithEvents rButtonGPA3 As RadioButton
    Friend WithEvents rButtonGPA1 As RadioButton
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtBoxSearch As TextBox
    Friend WithEvents btnLoad As Button
End Class
