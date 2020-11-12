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

Public Class frmStructureTest

    ' Localized variable used for debugging
    Public Shared debug As Boolean = False

    ' List of student objects used for storing information for all students.
    Public Shared studentsList As New List(Of Student)

    ' Cached student count.
    Public Shared cachedStudentCount As Integer = 0

    ' Runs checks before adding student into studentsList.
    Private Sub btnAddStudent(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' Steps:
        ' 1. Is there a first name provided?
        ' 2. Is there a last name provided?
        ' 3. Is there a age selected?
        ' 4. Is there a graduation year selected?
        ' 5. Is there a GPA selected?

        ' Step 1:

        If txtBoxFirstName.Text = "" Then
            logDebug("[S] No first name is entered.")
            Return
        End If

        ' Step 2:

        If txtBoxLastName.Text = "" Then
            logDebug("[S] No last name is entered.")
            Return
        End If

        ' Step 3:

        If Not rButtonAge15.Checked And Not rButtonAge16.Checked And Not rButtonAge17.Checked And Not rButtonAge18.Checked Then
            logDebug("[S] No age is selected.")
            Return
        End If

        ' Step 4:

        If Not rButtonGradYear21.Checked And Not rButtonGradYear22.Checked And Not rButtonGradYear23.Checked And Not rButtonGradYear24.Checked Then
            logDebug("[S] No graduation year is selected.")
            Return
        End If

        ' Step 5:

        If Not rButtonGPA1.Checked And Not rButtonGPA2.Checked And Not rButtonGPA3.Checked And Not rButtonGPA4.Checked Then
            logDebug("[S] No gpa is selected.")
            Return
        End If

        Dim age As Integer = 0

        If rButtonAge15.Checked Then
            age = 15
        ElseIf rButtonAge16.Checked Then
            age = 16
        ElseIf rButtonAge17.Checked Then
            age = 17
        Else
            age = 18
        End If

        Dim gradYear As Integer = DateTime.Now.Year

        If rButtonGradYear21.Checked Then
            gradYear = 2021
        ElseIf rButtonGradYear22.Checked Then
            gradYear = 2022
        ElseIf rButtonGradYear23.Checked Then
            gradYear = 2023
        Else
            gradYear = 2024
        End If

        Dim gpa As Decimal = 0.0D

        If rButtonGPA1.Checked Then
            gpa = 1D
        ElseIf rButtonGPA2.Checked Then
            gpa = 2D
        ElseIf rButtonGPA3.Checked Then
            gpa = 3D
        Else
            gpa = 4D
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

    ' Clears debug console every 3s if there are more than 10 lines.
    Private Sub timerDebugClear(sender As Object, e As EventArgs) Handles timerDebugClearing.Tick

        If listBoxDebugInformation.Items.Count >= 30 Then
            If Not timerDebugClearing.Interval = 1 Then
                timerDebugClearing.Interval = 1
            End If

            listBoxDebugInformation.Items.RemoveAt(0)
            listBoxDebugInformation.Update()
        Else
            timerDebugClearing.Interval = 3000
        End If

    End Sub

    ' Logs information into a local console of the program.
    Sub logDebug(ByRef info As String)
        Dim consoleSize As Integer = listBoxDebugInformation.Items.Count

        ' Checks if the previous message is the same, before adding to prevent spam.
        If consoleSize > 0 AndAlso listBoxDebugInformation.Items(consoleSize - 1).ToString.Contains(info) Then
            Return
        End If

        listBoxDebugInformation.Items.Add(DateTime.Now.ToShortTimeString & ": " & info)
    End Sub

    ' Updates database information sorting objects based on names.
    Private Sub timerSearch_Tick(sender As Object, e As EventArgs) Handles timerSearch.Tick
        If studentsList.Count = 0 Then
            logDebug("No entries found.")
            Return
        End If

        ' Steps:
        '
        ' 1. Check if search bar is empty.
        ' 1.1 If empty, show all students after sorting by first name.
        '
        ' 2. Determine output of students dependent on common phrase
        '
        ' 2.1 Check if common phrase starts with "gpa"
        ' 2.1.1 Remove anything else other than decimal number.
        ' 2.1.1.1 If no decimal is found, return "No results found".
        ' 2.1.1.2 If decimal is found, find GPAs that are greater than or equal to requested GPA.
        '
        ' 2.2 Check if common phrase starts with "age"
        ' 2.2.1 Remove anything else other than number.
        ' 2.2.1.1 If no number is found, return "No results found".
        ' 2.2.1.2 If number is valid age, find students that are at that age.
        '
        ' 2.3 Check if common phrase starts with "graduation year", or "grad year"
        ' 2.3.1 Remove anything else other than graduation year.
        ' 2.3.1.1 If no graduation year is found, return "No results found".
        ' 2.3.1.2 If graduation year is found, find students with that graduation year.
        '
        '
        ' 2.4 If none of the common phrases were found, check first/last names.
        ' 2.4.1 If there are first names but no last names with result, return in a format of
        '
        ' Students with first name of Result:
        ' Kyle Matzen (other info)
        '
        ' 2.4.2 If there are first names and last names with result, return in a format of
        '
        ' Students with first name of Result:
        ' Kyle Matzen (other info)
        '
        ' Students with last name of Result:
        ' Matzen Kyle (other info)
        '
        ' 2.4.3 If there are last names but no first names with result, return in a format of
        ' 
        ' Students with last name of Result:
        ' Matzen Kyle (other info)
        '
        ' 2.4.4 If there are no first/last names with result, return "No results found."


        ' Localized variable for search.
        Dim search As String = txtBoxSearch.Text.ToLower

        ' Step 1:
        ' Space Checker v2 (Nov 11. 2020)
        If txtBoxSearch.Text.Trim.Length = 0 Then
            If cachedStudentCount = studentsList.Count Then
                If Not listBoxResults.Items.Count = 0 AndAlso Not listBoxResults.Items(0).Equals("No search results found.") Then
                    Return
                End If
            End If

            ' Step 1.1:
            clearResults()

            Dim localStudentsList = studentsList.ToArray.OrderBy(Function(s) s.firstName)

            logDebug("Cleared results, and sorted by first names.")

            For Each student In localStudentsList
                addResult(student.firstName & " " & student.lastName & " Age " & student.age & " GPA " & student.gradePointAverage & " Graduation " & student.graduationYear)
            Next

            cachedStudentCount = localStudentsList.Count

            Return
        End If

        ' Step 2.1:
        If search.Contains("gpa") Then

            If IsNumeric(System.Text.RegularExpressions.Regex.Replace(search, "[^.0-9]", "")) Then

                Dim gpa As Decimal = CDec(System.Text.RegularExpressions.Regex.Replace(search, "[^.0-9]", ""))

                If gpa < 1.0 Or gpa > 4.0 Then
                    noResultsFound()
                    Return
                End If

                clearResults()

                Dim localStudentsList = studentsList.ToArray.OrderBy(Function(s) s.gradePointAverage)
                localStudentsList = localStudentsList.ToArray.OrderBy(Function(s) s.firstName)

                logDebug("Cleared results, and sorted by GPA.")

                For Each student In localStudentsList
                    If student.gradePointAverage >= gpa Then
                        addResult(student.firstName & " " & student.lastName & " Age " & student.age & " GPA " & student.gradePointAverage & " Graduation " & student.graduationYear)
                    End If
                Next

                cachedStudentCount = localStudentsList.Count
                Return
            End If

        ElseIf search.Contains("age") Then ' Step 2.2:
            If IsNumeric(System.Text.RegularExpressions.Regex.Replace(search, "[^0-9]", "")) Then
                Dim age As Integer = CInt(System.Text.RegularExpressions.Regex.Replace(search, "[^.0-9]", ""))

                If age < 16 Or age > 18 Then
                    noResultsFound()
                    Return
                End If

                clearResults()

                Dim localStudentsList = studentsList.ToArray.OrderBy(Function(s) s.age)
                localStudentsList = localStudentsList.ToArray.OrderBy(Function(s) s.firstName)

                logDebug("Cleared results, and sorted by age.")

                For Each student In localStudentsList
                    If student.age >= age Then
                        addResult(student.firstName & " " & student.lastName & " Age " & student.age & " GPA " & student.gradePointAverage & " Graduation " & student.graduationYear)
                    End If
                Next

                cachedStudentCount = localStudentsList.Count
                Return
            End If
        ElseIf search.Contains("graduation year") Or search.Contains("grad year") Then ' Step 2.3:

            If IsNumeric(System.Text.RegularExpressions.Regex.Replace(search, "[^0-9]", "")) Then
                Dim year As Integer = CInt(System.Text.RegularExpressions.Regex.Replace(search, "[^.0-9]", ""))

                If year < 2021 Or year > 2024 Then
                    noResultsFound()
                    Return
                End If

                clearResults()

                Dim localStudentsList = studentsList.ToArray.OrderBy(Function(s) s.graduationYear)
                localStudentsList = localStudentsList.ToArray.OrderBy(Function(s) s.firstName)

                logDebug("Cleared results, and sorted by graduation year.")

                For Each student In localStudentsList
                    If student.graduationYear >= year Then
                        addResult(student.firstName & " " & student.lastName & " Age " & student.age & " GPA " & student.gradePointAverage & " Graduation " & student.graduationYear)
                    End If
                Next

                cachedStudentCount = localStudentsList.Count
                Return
            End If

        Else ' Step 2.4:
            logDebug("search isn't a common phrase check if first name/last name.")
        End If

        noResultsFound()
    End Sub

    Sub addStudent(ByRef firstName As String, ByRef lastName As String, ByRef age As Integer, ByRef gradYear As Integer, ByRef gpa As Decimal)
        Dim student As Student

        student.firstName = firstName
        student.lastName = lastName
        student.age = age
        Student.graduationYear = gradYear
        student.gradePointAverage = gpa

        studentsList.Add(student)

        logDebug("Student " & student.firstName & " " & student.lastName & " added to database.")
    End Sub

    Sub clearResults()
        listBoxResults.Items.Clear()
    End Sub

    Sub addResult(ByRef result As String)
        listBoxResults.Items.Add(result)
    End Sub

    Sub noResultsFound()
        clearResults()

        addResult("No search results found.")
    End Sub

    Private Sub frmStructureTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addStudent("Ethan", "Magyar", 18, 2021, 4D)
        addStudent("Kyle", "Matzen", 18, 2021, 3D)
        addStudent("Jacob", "Cobb", 17, 2022, 4D)
        addStudent("Mark", "Bassily", 18, 2021, 3D)
        addStudent("Nicole", "Ziegler", 17, 2021, 4D)
        addStudent("Taylor", "Fisher", 17, 2021, 4D)
        addStudent("Juliana", "Mik", 17, 2021, 4D)
        addStudent("Devon", "Eastlack", 17, 2021, 4D)
        addStudent("Adriana", "Palumbo", 17, 2021, 4D)
    End Sub
End Class