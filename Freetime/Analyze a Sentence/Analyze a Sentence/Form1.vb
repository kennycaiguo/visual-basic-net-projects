' Created by kyematzen.com
' Date completed on Nov 10. 2020
'
' Project sources:
' Alphabet Checker (Nov 10. 2020)
' Space Checker (Nov 10. 2020)
' Vowels Counter (Nov 10. 2020)
'
' Example sentence:
' This sentence contains nine words, eighteen syllables, and sixty-five letters.
'
Public Class frmAnalyze
    ' Local string optimized for performance, performance, and reliability

    Public Shared alphabetArray As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

    ' Optimized version of chapter 6.3 List Boxes and Loops Q46 P273
    Private Sub analyzeSentence(sender As Object, e As EventArgs) Handles timerAnalyze.Tick

        ' Creates instance of text entered.
        Dim text = txtBoxSentence.Text

        ' Checks if text entered is empty.
        If text = "" Then
            updateCount(0, 0, 0)
            Return
        End If

        ' Spaces checker copied from Quasi-Palindrome (Nov 10. 2020)
        ' Checks If entered text is spaces only.

        Dim spacesIndex As Integer = 0

        ' Loops through each character in text.
        For Each localCharacter In text
            ' Checks if the character is a space.
            If localCharacter = " " Then
                spacesIndex += 1
            Else Exit For
            End If
        Next

        ' Cancels if the amount of spaces equals the length of the word entered.
        If spacesIndex > 1 Then
            ' Updates text in form.
            updateCount(0, 0, 0)
            Return
        End If

        ' Alphabet checker (Nov 10. 2020)
        ' Calculates the total amount of letters in text.

        Dim lettersIndex As Integer = 0

        ' Loops through each character in text.

        For Each localCharacter As String In text
            localCharacter = localCharacter.ToUpper()

            ' If localCharacter capitalized is a letter inside of the array add 1 to lettersIndex
            If alphabetArray.Contains(localCharacter) Then
                lettersIndex += 1
            End If
        Next

        ' Splits words by spaces in between to count the amount of "sentences" words.
        Dim sentences As String() = text.Split(" ")
        Dim sentencesCount = sentences.Count - 1

        ' Vowels counter copied from Count Total Vowels (Oct 25. 2020)
        ' Counts total vowels.
        Dim vowelsCount As Integer = 0

        For Each character In text
            If character = "a" Or character = "e" Or character = "i" Or character = "o" Or character = "u" Then
                vowelsCount += 1
            End If
        Next

        ' Updates text in form.
        updateCount(sentencesCount, lettersIndex, vowelsCount)
    End Sub

    ' Function used to optimize code and reduce duplication.
    Sub updateCount(ByRef wordCount As Integer, ByRef lettersCount As Integer, ByRef vowelCount As Integer)
        lblWords.Text = "Words: " & wordCount
        lblLetters.Text = "Letters: " & lettersCount
        lblVowels.Text = "Vowels: " & vowelCount
    End Sub
End Class
