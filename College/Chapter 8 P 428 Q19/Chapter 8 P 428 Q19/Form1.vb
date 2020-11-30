Public Class frmCowboys
    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click
        Dim lines As String() = {"Colt Peacemaker,12.20", "Holster,2.00", "Levi Strauss jeans,1.35", "Saddle,40.00", "Stetson,10.00"}

        IO.File.WriteAllLines("C:\Users\kyleo\Desktop\Cowboy.txt", lines)
    End Sub
End Class
