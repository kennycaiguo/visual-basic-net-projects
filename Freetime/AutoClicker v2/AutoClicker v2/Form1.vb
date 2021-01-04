
' 
' Copyright 2020, Kye Matzen, http://kyematzen.com
' <p>
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the
' Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software,
' and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
' <p>
' The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
' <p>
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
' MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR
' ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
' THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
'

Public Class frmAutoClickerSetup
    Dim currentStep As Integer = 0

    Private Function GetImageFromURL(ByVal url As String) As Image

        Dim retVal As Image = Nothing

        Try
            If Not String.IsNullOrWhiteSpace(url) Then
                Dim req As Net.WebRequest = Net.WebRequest.Create(url.Trim)

                Using request As Net.WebResponse = req.GetResponse
                    Using stream As IO.Stream = request.GetResponseStream
                        retVal = New Bitmap(Image.FromStream(stream))
                    End Using
                End Using
            End If

        Catch ex As Exception
            Console.WriteLine(String.Format("An error occurred:{0}{0}{1}",
                                          vbCrLf, ex.Message),
                                          "Exception Thrown",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Warning)

        End Try

        Return retVal

    End Function

    Private Sub frmAutoClickerSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        setupBackground.Image = GetImageFromURL("https://i.imgur.com/FjptBEu.jpg")
        setupArt.Image = GetImageFromURL("https://i.imgur.com/mMyjUkN.jpeg")

        lblWelcomeSetup.Parent = setupBackground
        lblSetupGuide.Parent = setupBackground

        lblSetupType1.Parent = setupBackground
        lblSetupType2.Parent = setupBackground

        lblSetupType1.Parent = setupBackground
        lblSetupType2.Parent = setupBackground

        radioButtonBeta.Parent = setupBackground
        radioButtonFull.Parent = setupBackground
        radioButtonCustom.Parent = setupBackground

        lblBetaDescription.Parent = setupBackground
        lblFullDescription.Parent = setupBackground
        lblCustomDescription.Parent = setupBackground

    End Sub

    Private Sub btnNextStep_Click(sender As Object, e As EventArgs) Handles btnNextStep.Click
        Select Case currentStep
            Case 0
                lblWelcomeSetup.Visible = False
                lblSetupGuide.Visible = False

                btnBack.Visible = True

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
