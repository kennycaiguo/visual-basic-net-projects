Public Class frmAutoClickerSetup
    Dim currentStep As Integer = 0

    Private Sub frmAutoClickerSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblWelcomeSetup.Parent = setupBackground
        lblSetupGuide.Parent = setupBackground

        lblSetupType1.Parent = setupBackground
        lblSetupType2.Parent = setupBackground

        lblSetupType1.Parent = setupBackground
        lblSetupType2.Parent = setupBackground

        radioButtonFull.Parent = setupBackground
        radioButtonBeta.Parent = setupBackground
        radioButtonCustom.Parent = setupBackground

    End Sub

    Private Sub btnNextStep_Click(sender As Object, e As EventArgs) Handles btnNextStep.Click
        Select Case currentStep
            Case 0
                lblWelcomeSetup.Visible = False
                lblSetupGuide.Visible = False

                btnBack.Visible = True

                setupBackground.Image = Image.FromFile("Images/setup-background2.jpg")

                lblSetupType1.Visible = True
                lblSetupType2.Visible = True

                radioButtonFull.Visible = True
                radioButtonBeta.Visible = True
                radioButtonCustom.Visible = True

                lblFullDescription.Visible = True
                lblBetaDescription.Visible = True
                lblCustomDescription.Visible = True

                btnNextStep.Text = "Install"
            Case Else
                btnBack.Visible = False

                lblSetupType1.Visible = False
                lblSetupType2.Visible = False

                radioButtonFull.Visible = False
                radioButtonBeta.Visible = False
                radioButtonCustom.Visible = False

                lblFullDescription.Visible = False
                lblBetaDescription.Visible = False
                lblCustomDescription.Visible = False
        End Select

        currentStep += 1
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        setupBackground.Image = Image.FromFile("Images/setup-background.jpg")

        lblWelcomeSetup.Visible = True
        lblSetupGuide.Visible = True

        btnBack.Visible = False

        lblSetupType1.Visible = False
        lblSetupType2.Visible = False

        radioButtonFull.Visible = False
        radioButtonBeta.Visible = False
        radioButtonCustom.Visible = False

        lblFullDescription.Visible = False
        lblBetaDescription.Visible = False
        lblCustomDescription.Visible = False

        btnNextStep.Text = "Next >"

        currentStep -= 1
    End Sub
End Class
