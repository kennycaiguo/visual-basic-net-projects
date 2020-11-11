' Created by kyematzen.com
' Date completed on Nov 10. 2020
Public Class frmSoundex
    Private Sub btnEncode_Click(sender As Object, e As EventArgs) Handles btnEncode.Click

        ' Begin encoding process:
        ' 1. Copy text box with code
        ' 2. Check if copied text box is empty.
        ' 3. Capitalize all characters for replacement.
        ' 4. Retains the first letter.
        ' 5. Removes occurrences of a,e,i,o,u, h, y, and w.
        ' 6. Replaces the letters that remain with numbers as followed in the book.
        ' 6.1 b,f, p, and v become 1
        ' 6.2 c,g,j,k,q,s,x, and z become 2
        ' 6.3 d and t both become3
        ' 6.4 l (that is, el) becomes 4
        ' 6.5 m and n becomes 5
        ' 6.6 r becomes 6
        ' 7. If result contains two adjacent identical digits, elimate the second of them.
        ' 8. Keep only first four characters, and if characters length less than 4 add zeros onto end.
        ' 9. Update encodedText to text box.

        ' Step 1:
        Dim code As String = txtBoxCode.Text

        ' Step 2:
        If code = "" Then Return

        ' Step 3:

        code = code.ToUpper()

        ' Step 4:
        Dim encodedText As String = code.Clone.Substring(0, 1)

        ' Step 5:

        code = code.Replace("A", "")
        code = code.Replace("E", "")
        code = code.Replace("I", "")
        code = code.Replace("O", "")
        code = code.Replace("U", "")
        code = code.Replace("H", "")
        code = code.Replace("Y", "")
        code = code.Replace("U", "")

        ' Step 6.1:

        code = code.Replace("B", "1")
        code = code.Replace("F", "1")
        code = code.Replace("P", "1")
        code = code.Replace("V", "1")

        ' Step 6.2:

        code = code.Replace("C", "2")
        code = code.Replace("G", "2")
        code = code.Replace("J", "2")
        code = code.Replace("K", "2")
        code = code.Replace("Q", "2")
        code = code.Replace("S", "2")
        code = code.Replace("X", "2")
        code = code.Replace("Z", "2")

        ' Step 6.3:

        code = code.Replace("D", "3")
        code = code.Replace("T", "3")

        ' Step 6.4:

        code = code.Replace("L", "4")

        ' Step 6.5:

        code = code.Replace("M", "5")
        code = code.Replace("N", "5")

        ' Step 6.6:

        code = code.Replace("R", "6")

        ' Step 7:

        ' Sets a index of 1 for starting position to be able to get value behind.
        Dim index As Integer = 1
        ' Sets final position of code to check for duplications.
        Dim codeCount As Integer = code.Count - 1

        ' While loop that will run until index > codeCount which is updated throughout the while loop.
        While index <= codeCount
            Dim c As Char = code(index - 1)
            Dim c2 As Char = code(index)

            ' If there is a duplication found.
            If c = c2 Then
                ' Remove the value at that index.
                code = code.Remove(index, 1)

                ' Remove 1 from the code size due to changing the size.
                codeCount -= 1
            End If

            ' Increases position by 1 to continue check for adjacent numbers.
            index += 1
        End While

        ' Step 8:

        ' Checks if the length is equal to four
        If code.Count > 3 Then
            ' If length is longer than four remove everything afterwards
            code = code.Substring(0, 3)
        ElseIf code.Count < 4 Then
            ' If length is less than four grab current size of code
            Dim currentSize = code.Count

            ' Run a loop to add 0's until currentSize = 3.
            While (currentSize < 3)

                code = code & "0"

                currentSize += 1
            End While
        End If

        ' Step 9:

        txtBoxEncoded.Text = encodedText & code
    End Sub
End Class
