
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
        '
        '
        ' Example 1 (from zoom video)
        ' Data source:
        ' Dim numbers() As Integer = {0, 1, 2, 3, 4, 5, 6}
        '
        ' Query creation:
        '
        ' Dim evensQuery = From num In numbers Where num Mod 2 = 0 Select num
        '
        ' Query execution:
        '
        ' For Each number In evensQuery
        '   Console.WriteLine(number)
        ' Next
        '
        '
        ' Example 2
        ' Data source:
        ' Dim names As String() = {"Maro", "Mark", "Jake", "Ryan", "Kyle", "Jarret", "Ralphie"}
        '
        ' Query creation:
        '
        ' Dim namesLengthQuery = From localName In names Where localName.Length > 4 Select localName
        '
        ' Query execution:
        '
        ' For Each localName In namesLengthQuery
        '   Console.WriteLine(localName)
        ' Next
        '
        '
        ' Example 3
        ' Data source:
        ' Dim iAmExamples As String() = {"student", "developer", "learner", "enthrepenuer", "friend"}
        '
        ' Query creation:
        ' Dim iAmExamplesQuery = From example In iAmExamples Order By example Ascending
        '
        ' Query execution
        ' For Each example In iAmExamplesQuery
        '   Console.WriteLine("I am a " & example)
        ' Next
    End Sub
End Class
