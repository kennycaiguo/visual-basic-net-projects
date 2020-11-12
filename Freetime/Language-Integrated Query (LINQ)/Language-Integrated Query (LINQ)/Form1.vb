' Created by kyematzen.com
' Date completed on Nov 11. 2020

' What is a query?
'
' It is an expression that retrieves data from a data source.
' Quieres are expressed in a dedicated query language.
'
' LINQ simplify by offering a consistent model for working with data across various kinds of data sources and formats.
'
' Three Stages of a Query Operation:
' 1. Obtain the data source or source.s
' 2. Create the query.
' 3. Execute the query.
'
' Query creation example:
'
' From var In arrayName Where [condition on var] Select var
'
' Immediate vs. Deferred
' In deferred execution of quieres, the query definition is stored in a query variable for later execution
'
' In immediate execution, the query is executed at the time of its definition.
'
' Distinct (at end) - removes duplications
'
' Let variableName = method(var)
' Select variableName 
'
' Order By var Ascending
'
' listBox.DataSource = queryName.ToList - fills list box with values returned
' listBox.SelectedItem = Nothing - highlighting eliminated.
'
Public Class frmLINQ
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Data source
        Dim numbers() As Integer = {0, 1, 2, 3, 4, 5, 6}

        ' Query creation

        Dim evensQuery = From num In numbers Where num Mod 2 = 0 Select num

        ' Query execution
        For Each number In evensQuery
            Console.WriteLine(number)
        Next
    End Sub
End Class
