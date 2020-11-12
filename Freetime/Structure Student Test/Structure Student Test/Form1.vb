﻿' Created by kyematzen.com
' Date completed on Nov 11. 2020

' Custom object for storing individual student information.
Public Structure Student
    Dim firstName As String
    Dim lastName As String
    Dim age As Integer
    Dim graduationYear As Decimal
    Dim gradePointAverage As Double
End Structure

' Main form class
Public Class frmStructureTest

    ' Localized variable for keeping track if database was grabbed.
    Public Shared database As Boolean = False

    ' List of student objects used for storing information for all students.
    Public Shared studentsList As New List(Of Student)

    ' Runs checks before adding student into studentsList.
    Private Sub btnAddStudent(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' Steps:
        ' 1. Is there a first name provided?
        ' 2. Is there a last name provided?
        ' 3. Is there a age selected?
        ' 4. Is there a graduation year selected?
        ' 5. Is there a GPA selected?      ' Step 1:

        If txtBoxFirstName.Text = "" Then
            Return
        End If

        ' Step 2:

        If txtBoxLastName.Text = "" Then
            Return
        End If

        ' Step 3:

        If Not rButtonAge15.Checked And Not rButtonAge16.Checked And Not rButtonAge17.Checked And Not rButtonAge18.Checked Then
            Return
        End If

        ' Step 4:

        If Not rButtonGradYear21.Checked And Not rButtonGradYear22.Checked And Not rButtonGradYear23.Checked And Not rButtonGradYear24.Checked Then
            Return
        End If

        ' Step 5:

        If Not rButtonGPA1.Checked And Not rButtonGPA2.Checked And Not rButtonGPA3.Checked And Not rButtonGPA4.Checked Then
            Return
        End If

        ' Determines age dependent on radio button checked.
        Dim age As Integer = 18

        If rButtonAge15.Checked Then
            age = 15
        ElseIf rButtonAge16.Checked Then
            age = 16
        ElseIf rButtonAge17.Checked Then
            age = 17
        End If

        ' Determines graduation year dependent on radio button checked.
        Dim gradYear As Integer = 2024

        If rButtonGradYear21.Checked Then
            gradYear = 2021
        ElseIf rButtonGradYear22.Checked Then
            gradYear = 2022
        ElseIf rButtonGradYear23.Checked Then
            gradYear = 2023
        End If

        ' Determines gpa dependent on radio button checked.
        Dim gpa As Decimal = 4D

        If rButtonGPA1.Checked Then
            gpa = 1D
        ElseIf rButtonGPA2.Checked Then
            gpa = 2D
        ElseIf rButtonGPA3.Checked Then
            gpa = 3D
        End If

        addStudent(txtBoxFirstName.Text, txtBoxLastName.Text, age, gradYear, gpa)

        txtBoxFirstName.Text = ""
        txtBoxLastName.Text = ""

        For Each radioButton As RadioButton In groupBoxAge.Controls
            radioButton.Checked = False
        Next

        For Each radioButton As RadioButton In groupBoxGradYear.Controls
            radioButton.Checked = False
        Next

        For Each radioButton As RadioButton In groupBoxGPA.Controls
            radioButton.Checked = False
        Next
    End Sub

    Sub addStudent(ByRef firstName As String, ByRef lastName As String, ByRef age As Integer, ByRef gradYear As Integer, ByRef gpa As Decimal)
        Dim student As Student

        student.firstName = firstName
        student.lastName = lastName
        student.age = age
        Student.graduationYear = gradYear
        student.gradePointAverage = gpa

        studentsList.Add(student)

    End Sub

    ' Clears results from GUI
    Sub clearResults()
        listBoxResults.Items.Clear()
    End Sub

    ' Adds student result to GUI
    Sub addResult(ByRef student As Student)
        addResult(student.firstName & " " & student.lastName & " Age " & student.age & " GPA " & student.gradePointAverage & " Graduation " & student.graduationYear)
    End Sub

    ' Adds result to GUI
    Sub addResult(ByRef result As String)
        listBoxResults.Items.Add(result)
    End Sub

    ' Runs when the search engine is unable to find any results.
    Sub noResultsFound()
        clearResults()

        addResult("No search results found.")
    End Sub

    ' Updates database information sorting objects based on names.
    Private Sub txtBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSearch.TextChanged
        If studentsList.Count = 0 Then
            Return
        End If

        Dim localStudentsList = studentsList.ToArray.OrderBy(Function(s) s.firstName)

        ' Steps:
        '
        ' 1. Check if search bar is empty.
        ' 1.1 If empty, show all students after sorting by first name.
        '
        ' 2. Determine output of students dependent on common phrase
        '
        ' 2.1 Check if common phrase starts with "gpa"
        ' 2.1.1 Remove anything else other than decimal number.
        ' 2.1.1.1 If decimal is found, find GPAs that are greater than or equal to requested GPA.
        '
        ' 2.2 Check if common phrase starts with "age"
        ' 2.2.1 Remove anything else other than number.
        ' 2.2.1.1 If number is valid age, find students that are at that age.
        '
        ' 2.3 Check if common phrase starts with "graduation year", or "grad year"
        ' 2.3.1 Remove anything else other than graduation year.
        ' 2.3.1.1 If graduation year is found, find students with that graduation year.
        '
        ' 2.4 If none of the common phrases were found, check first/last names.
        ' 2.4.1 If there are first names, show results of
        '
        ' Students with first name of Result:
        ' Kyle Matzen (other info)
        ' Next Student...
        '
        ' 2.4.2 If there are last names with result, show results of
        '
        ' Students with last name of Result:
        ' Matzen Kyle (other info)
        ' Next Student...
        '
        ' 2.4.3 If no results, return "No search results found."
        '

        ' Localized variable for search.
        Dim search As String = txtBoxSearch.Text.ToLower

        ' Step 1:
        ' Space Checker v2 (Nov 11. 2020)
        If txtBoxSearch.Text.Trim.Length = 0 Then
            If Not listBoxResults.Items.Count = 0 AndAlso Not listBoxResults.Items(0).Equals("No search results found.") Then
                Return
            End If

            ' Step 1.1:
            clearResults()

            For Each student In localStudentsList
                addResult(student)
            Next

            Return
        End If

        ' Step 2.1:
        If search.Contains("gpa") Then

            If IsNumeric(System.Text.RegularExpressions.Regex.Replace(search, "[^.0-9]", "")) Then

                ' Step 2.1.1:
                Dim gpa As Decimal = CDec(System.Text.RegularExpressions.Regex.Replace(search, "[^.0-9]", ""))

                If gpa < 1.0 Or gpa > 4.0 Then
                    noResultsFound()
                    Return
                End If

                clearResults()

                For Each student In localStudentsList
                    ' Step 2.1.1.1:
                    If student.gradePointAverage >= gpa Then
                        addResult(student)
                    End If
                Next

                Return
            End If

        ElseIf search.Contains("age") Then ' Step 2.2:
            If IsNumeric(System.Text.RegularExpressions.Regex.Replace(search, "[^0-9]", "")) Then
                ' Step 2.2.1:
                Dim age As Integer = CInt(System.Text.RegularExpressions.Regex.Replace(search, "[^.0-9]", ""))

                ' Step 2.2.1.1:
                If age < 16 Or age > 18 Then
                    noResultsFound()
                    Return
                End If

                clearResults()

                For Each student In localStudentsList
                    If student.age >= age Then
                        addResult(student)
                    End If
                Next

                Return
            End If
        ElseIf search.Contains("graduation year") Then ' Step 2.3:

            If IsNumeric(System.Text.RegularExpressions.Regex.Replace(search, "[^0-9]", "")) Then
                ' Step 2.3.1:
                Dim year As Integer = CInt(System.Text.RegularExpressions.Regex.Replace(search, "[^.0-9]", ""))

                ' Step 2.3.1.1:
                If year < 2021 Or year > 2024 Then
                    noResultsFound()
                    Return
                End If

                clearResults()

                For Each student In localStudentsList
                    If student.graduationYear >= year Then
                        addResult(student)
                    End If
                Next

                Return
            End If

        Else ' Step 2.4:

            Dim firstNameResults As New List(Of Student)
            Dim lastNameResults As New List(Of Student)

            For Each student In localStudentsList
                If student.firstName.ToLower.Equals(search) Then
                    firstNameResults.Add(student)
                End If

                If student.lastName.ToLower.Equals(search) Then
                    lastNameResults.Add(student)
                End If
            Next

            If firstNameResults.Count > 0 Or lastNameResults.Count > 0 Then
                ' Step 2.4.1:
                If firstNameResults.Count > 0 Then
                    clearResults()

                    addResult("Students with first name of " & txtBoxSearch.Text & ":")
                    addResult("")

                    For Each student In firstNameResults
                        addResult(student)
                    Next

                End If

                ' Step 2.4.2:
                If lastNameResults.Count > 0 Then
                    If lastNameResults.Count > 0 Then
                        addResult("")
                    Else
                        clearResults()
                    End If

                    ' Orders students by last name name.
                    localStudentsList = studentsList.ToArray.OrderBy(Function(s) s.lastName)

                    addResult("Students with last name of " & txtBoxSearch.Text & ":")
                    addResult("")

                    For Each student In lastNameResults
                        addResult(student)
                    Next
                End If

                Return
            End If

        End If

        noResultsFound()
    End Sub

    ' Loads database information if not loaded already.
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        ' Grabs all lines for file database.txt.
        Dim students As String() = IO.File.ReadAllLines("database.txt")

        ' Loops through each student in database file.
        For Each student In students
            ' Needed when splitting between name and info.
            If Not student.Contains(",") Then
                Continue For
            End If

            Dim studentSplit As String() = student.Split(",")

            Dim name As String() = studentSplit(0).Split(" ")
            Dim info As String() = studentSplit(1).Split(" ")

            ' Checks if the line's length are correct for what the database requires
            If Not name.Length = 2 AndAlso Not info.Length = 4 Then
                Continue For
            End If

            ' Checks if the info for age, year, and gpa are numbers
            If Not IsNumeric(info(0)) AndAlso Not IsNumeric(info(1)) AndAlso Not IsNumeric(info(2)) Then
                Continue For
            End If

            ' Adds student into studentsList database
            addStudent(name(0), name(1), CInt(info(0)), CInt(info(1)), CDec(info(2)))
        Next

        database = True

        For Each student In studentsList
            addResult(student)
        Next

        listBoxResults.Update()
    End Sub
End Class