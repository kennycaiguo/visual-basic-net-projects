Public Class Form1

    Public Shared randomColor As Boolean = False
    ' Keeps a local variable of hello text when doing the animation making sure that the length doesn't go invalid.
    Public Shared helloText As String = "Hello"
    ' Keeps a local index of how far it has gotten when using Substring on helloText local variable.
    ' Whether or not the animation is enabled or not.
    Public Shared animation As Boolean = True
    Public Shared animationIndex As Integer = 0
    ' Whether or not the animation will add text and remove text.
    Public Shared animationForward As Boolean = False

    ' Function that updates the color of the text and updates the text itself to the correct language for greeting someone.
    Function updateText(ByVal language As String) As String
        helloText = language
        lblHello.Text = language
    End Function

    Private Sub resetAnimation()
        animationIndex = 0
    End Sub

    ' Timer that animates the text itself to slowly go back to one letter till back at it's normal state. 
    Private Sub animateHelloText(sender As Object, e As EventArgs) Handles animateText.Tick

        If animation Then
            If animationForward Then
                If animationIndex <= helloText.Length Then
                    lblHello.Text = helloText.Substring(0, animationIndex)
                    animationIndex += 1
                Else
                    animationIndex = helloText.Length
                    animationForward = False
                    Return
                End If
            ElseIf Not animationForward Then
                If animationIndex = -1 Then
                    animationForward = True
                    animationIndex = 0
                    Return
                End If

                ' Finish opposite text going Hello, Hell, Hel, He, H

                lblHello.Text = helloText.Substring(0, animationIndex)

                animationIndex -= 1
            End If
        End If
    End Sub

    ' Timer that animates the color of the text itself
    Private Sub animateColor_Tick(sender As Object, e As EventArgs) Handles animateColor.Tick
        If randomColor Then
            Dim randomValue = CInt(Math.Floor(9 - 1 + 1) * Rnd()) + 1

            Select Case randomValue
                Case 1
                    lblHello.ForeColor = Color.Red
                Case 2
                    lblHello.ForeColor = Color.Blue
                Case 3
                    lblHello.ForeColor = Color.Green
                Case 4
                    lblHello.ForeColor = Color.Purple
                Case 5
                    lblHello.ForeColor = Color.Orange
                Case 6
                    lblHello.ForeColor = Color.Pink
                Case 7
                    lblHello.ForeColor = Color.Yellow
                Case 8
                    lblHello.ForeColor = Color.Black
                Case Else
                    lblHello.ForeColor = Color.Aqua
            End Select
        End If
    End Sub

    ' Colors (each will update the color dependent on their type, unless it's random, where it'll randomly update the color)

    Private Sub rButtonColorRed_Checked(sender As Object, e As EventArgs) Handles rButtonColorRed.CheckedChanged
        randomColor = False
        lblHello.ForeColor = Color.Red
    End Sub

    Private Sub rButtonColorBlue_Checked(sender As Object, e As EventArgs) Handles rButtonColorBlue.CheckedChanged
        randomColor = False
        lblHello.ForeColor = Color.Blue
    End Sub

    Private Sub rButtonColorGreen_Checked(sender As Object, e As EventArgs) Handles rButtonColorGreen.CheckedChanged
        randomColor = False
        lblHello.ForeColor = Color.Green
    End Sub

    Private Sub rButtonColorPurple_Checked(sender As Object, e As EventArgs) Handles rButtonColorPurple.CheckedChanged
        randomColor = False
        lblHello.ForeColor = Color.Purple
    End Sub

    Private Sub rButtonColorOrange_Checked(sender As Object, e As EventArgs) Handles rButtonColorOrange.CheckedChanged
        randomColor = False
        lblHello.ForeColor = Color.Orange
    End Sub

    Private Sub rButtonColorPink_Checked(sender As Object, e As EventArgs) Handles rButtonColorPink.CheckedChanged
        randomColor = False
        lblHello.ForeColor = Color.Pink
    End Sub

    Private Sub rButtonColorYellow_Checked(sender As Object, e As EventArgs) Handles rButtonColorYellow.CheckedChanged
        randomColor = False
        lblHello.ForeColor = Color.Yellow
    End Sub

    Private Sub rButtonColorBlack_Checked(sender As Object, e As EventArgs) Handles rButtonColorBlack.CheckedChanged
        randomColor = False
        lblHello.ForeColor = Color.Black
    End Sub

    Private Sub rButtonColorAqua_Checked(sender As Object, e As EventArgs) Handles rButtonColorAqua.CheckedChanged
        randomColor = False
        lblHello.ForeColor = Color.Aqua
    End Sub

    Private Sub rButtonColorRandom_Checked(sender As Object, e As EventArgs) Handles rButtonColorRandom.CheckedChanged
        randomColor = True
    End Sub

    ' Languages (each will fire updateText wth the parameter of their language greeting of English Hello)

    Private Sub rButtonLanguageEnglish_Checked(sender As Object, e As EventArgs) Handles rButtonLanguageEnglish.CheckedChanged
        resetAnimation()
        updateText("Hello")
    End Sub

    Private Sub rButtonLanguageMandarin_Checked(sender As Object, e As EventArgs) Handles rButtonLanguageMandarin.CheckedChanged
        resetAnimation()
        updateText("Nǐ hǎo")
    End Sub

    Private Sub rButtonLanguageHindi_Checked(sender As Object, e As EventArgs) Handles rButtonLanguageHindi.CheckedChanged
        resetAnimation()
        updateText("Namaste")
    End Sub

    Private Sub rButtonLanguageSpanish_Checked(sender As Object, e As EventArgs) Handles rButtonLanguageSpanish.CheckedChanged
        resetAnimation()
        updateText("Hola")
    End Sub

    Private Sub rButtonLanguageFrench_Checked(sender As Object, e As EventArgs) Handles rButtonLanguageFrench.CheckedChanged
        resetAnimation()
        updateText("Bonjour")
    End Sub

    Private Sub rButtonLanguageArabic_Checked(sender As Object, e As EventArgs) Handles rButtonLanguageArabic.CheckedChanged
        resetAnimation()
        updateText("Marhabaan")
    End Sub

    Private Sub rButtonLanguageBengali_Checked(sender As Object, e As EventArgs) Handles rButtonLanguageBengali.CheckedChanged
        resetAnimation()
        updateText("Hyālō")
    End Sub

    Private Sub rButtonLanguageRussian_Checked(sender As Object, e As EventArgs) Handles rButtonLanguageRussian.CheckedChanged
        resetAnimation()
        updateText("Zdravstvuyte")
    End Sub

    Private Sub rButtonLanguagePortuguese_Checked(sender As Object, e As EventArgs) Handles rButtonLanguagePortuguese.CheckedChanged
        resetAnimation()
        updateText("Olá")
    End Sub

    Private Sub rButtonLanguageIndonesian_Checked(sender As Object, e As EventArgs) Handles rButtonLanguageIndonesian.CheckedChanged
        resetAnimation()
        updateText("Halo")
    End Sub

    ' Animation (toggles whether or not animation of text will play)
    ' * animation does not include disabling random color (only text updating animation)

    Private Sub rButtonAnimationTrue_Checked(sender As Object, e As EventArgs) Handles rButtonAnimationTrue.CheckedChanged
        animation = True
        resetAnimation()
    End Sub

    Private Sub rButtonAnimationFalse_Checked(sender As Object, e As EventArgs) Handles rButtonAnimationFalse.CheckedChanged
        animation = False
        lblHello.Text = helloText
    End Sub
End Class
