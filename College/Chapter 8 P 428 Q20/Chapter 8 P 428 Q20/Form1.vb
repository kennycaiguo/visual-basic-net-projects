Public Class frmCowboys
    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click
        Dim cowboyFile As String() = IO.File.ReadAllLines("C:\Users\kyleo\Desktop\Cowboy.txt")

        For index = 0 To cowboyFile.Count - 1 Step 1
            Dim localLine = cowboyFile(index)

            If (localLine.StartsWith("Saddle")) Then
                Dim lineSplit = localLine.Split(",")
                Dim amount As Double = CDbl(lineSplit(1))

                cowboyFile(index) = "Saddle," & (amount * 0.8)
                Exit For
            End If
        Next

        IO.File.WriteAllLines("C:\Users\kyleo\Desktop\Cowboy.txt", cowboyFile)
    End Sub
End Class
