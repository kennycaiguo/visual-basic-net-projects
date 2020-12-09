
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

Public Class frmAirline

    Public Shared fare As String = ""
    Public Shared flightCache() As String
    Public Shared index As Integer = 0
    Public Shared cachedCities As Integer() = {-1, -1}
    Public Shared reservation As String

    ' Loads origin flights on startup of application
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        showOriginFlights()

        If Not IO.File.Exists("reservations.txt") Then
            IO.File.Create("reservations.txt")
        End If
    End Sub

    Function generatePNR() As String
        Dim idNumber As String = CStr(grabResFile().Length + 1)

        Return 100 + idNumber
    End Function

    ' Grabs air fare file.
    Function grabAirfareFile() As String()
        Return IO.File.ReadAllLines("Airfare.txt")
    End Function

    ' Grabs reservations file.
    Function grabResFile() As String()
        Return IO.File.ReadAllLines("reservations.txt")
    End Function

    Function GetInput() As String
        Return InputBox("Enter special comments to be added.", "RCSJ Airline Inc.", "")
    End Function

    Function IsPNRValid() As Boolean

        Dim resFile As String() = grabResFile()

        Dim lookupQuery = From localLine As String In resFile
                          Where Not localLine.Equals("None")
                          Let localLineSplit As String() = localLine.Split(":")
                          Where localLineSplit(0) = txtBoxLookupName.Text
                          Where localLineSplit(1).Split("#")(0).Equals(txtBoxLookupPNR.Text)
                          Select localLine

        If (lookupQuery.Count = 1) Then
            reservation = lookupQuery.ToList.ToArray()(0)
            Return True
        End If

        Return False
    End Function

    Private Sub addComment(ByRef comment)
        Dim resFile As String() = grabResFile()

        Dim localLineSplit As String() = reservation.Split(":")
        Dim cities As String() = localLineSplit(2).Split(";")
        Dim cityNames As String() = cities(0).Split(",")

        Dim lastName As String = localLineSplit(0)
        Dim PNR As String = localLineSplit(1).Split("#")(0)
        Dim origin As String = cityNames(0)
        Dim destination As String = cityNames(1)
        Dim seatCount As String = cities(1)
        Dim cost As String = localLineSplit(3)

        Dim firstSplit As String() = reservation.Split(":")
        Dim secondSplit As String() = firstSplit(1).Split("#")

        Dim comments As String() = secondSplit(1).Split(",")

        For index As Integer = 0 To comments.Length - 1 Step 1
            Console.WriteLine(comments(index))
        Next

        Dim commentsToBeAdded As String() = comment.Split(" ")

        Dim newComments As String() = comments.Concat(commentsToBeAdded).ToArray()

        Dim format As String = lastName & ":" & PNR & "#" & String.Join(",", newComments) & ":" & origin & "," & destination & ";" & seatCount & ":" & cost

        For index As Integer = 0 To resFile.Length - 1 Step 1
            If (resFile(index).Equals(reservation)) Then
                resFile(index) = format
                Exit For
            End If
        Next

        reservation = format

        IO.File.WriteAllLines("reservations.txt", resFile)
    End Sub

    ' Checks if flight cache is valid, and if fare is declared.
    Private Sub checkFareSelection()
        If flightCache IsNot Nothing Then
            If fare = "" Then
                fare = flightCache(index)

                btnInfoNext.Visible = False
                btnInfoSelect.Visible = False

                btnInfoClear.Location = New Point(93, 303)
            Else
                MessageBox.Show("There is already a flight selected, please clear selected to change..", "RCSJ Airline Inc.")
            End If
        End If
    End Sub

    Private Sub clearDisplayReservation()
        lblManagementPNR.Text = "PNR: "
        lblManagementOrigin.Text = "Origin: None"
        lblManagementDestination.Text = "Destination: None"
        lblManagementSeatCount.Text = "Seats: 1"
        lblManagementTotalCost.Text = "Total Cost: $0.00"

        groupBoxReservationManagement.Visible = False
    End Sub

    Private Sub clearInformation()
        If fare = "" Then
            MessageBox.Show("There is no selected flight to clear.", "RCSJ Airline Inc.")
        Else
            resetSelection()
        End If
    End Sub

    Private Sub clearReservationStatus()
        lblPNR.Text = "PNR: "

        lblOrigin.Text = "Origin: None"
        lblDestination.Text = "Destination: None"
        lblTotalCost.Text = "Total Cost: $0.00"
    End Sub

    Private Sub showReservation()
        groupBoxReservationManagement.Visible = True

        Dim localLineSplit As String() = reservation.Split(":")
        Dim cities As String() = localLineSplit(2).Split(";")
        Dim cityNames As String() = cities(0).Split(",")

        lblManagementPNR.Text = "PNR: " & localLineSplit(1).Split("#")(0)
        lblManagementOrigin.Text = "Origin: " & cityNames(0)
        lblManagementDestination.Text = "Destination: " & cityNames(1)
        lblManagementSeatCount.Text = "Seats: " & cities(1)
        lblManagementTotalCost.Text = "Total Cost: " & CDbl(localLineSplit(3)).ToString("c2")

        txtBoxLookupName.Text = ""
        txtBoxLookupPNR.Text = ""
    End Sub

    Private Sub deleteReservation()
        Dim resFile As String() = grabResFile()

        For index As Integer = 0 To resFile.Length - 1 Step 1
            If (resFile(index).Equals(reservation)) Then
                resFile(index) = "None"
                Exit For
            End If
        Next

        reservation = ""

        clearDisplayReservation()

        IO.File.WriteAllLines("reservations.txt", resFile)
    End Sub

    Private Sub displayReserveration()
        Dim passengerName As String = ""
        Dim passengerNameSplit As String() = txtBoxPassengerName.Text.Split(" ")

        If passengerNameSplit.Length > 1 Then
            passengerName = passengerNameSplit(1)
        Else
            MessageBox.Show("You need to provide a last name in your name.", "RCSJ Airline Inc.")
            Return
        End If

        Dim pnr As String = generatePNR()
        Dim origin As String = listBoxOrigin.SelectedItem
        Dim destination As String = listBoxDestination.SelectedItem
        Dim seatCount As Integer = CInt(txtBoxSeatCount.Text)
        Dim totalCost As String = CStr(CDbl(lblCost.Text))

        lblPNR.Text = "PNR: " & pnr

        Dim format As String = ""

        format += passengerName & ":" & pnr & "#:" & origin & "," & destination & ";" & seatCount & ":" & totalCost

        listBoxDestination.ClearSelected()
        listBoxOrigin.ClearSelected()

        listBoxOrigin.Items.Clear()
        listBoxDestination.Items.Clear()
        showOriginFlights()

        flightCache = Nothing

        lblTime.Text = ""
        lblFare.Text = ""

        txtBoxPassengerName.Text = ""
        txtBoxSeatCount.Text = ""

        resetSelection()

        Dim resFile As String() = grabResFile()

        Array.Resize(resFile, resFile.Length + 1)

        resFile(resFile.Length - 1) = format

        IO.File.WriteAllLines("reservations.txt", resFile)
    End Sub

    ' Resets clear button back to original location, re-enables next & info buttons, and clears time/fare text.
    Private Sub resetSelection()
        fare = ""

        btnInfoClear.Location = New Point(174, 303)

        btnInfoNext.Visible = True
        btnInfoSelect.Visible = True
    End Sub

    ' Updates flightCache for selecting what flight for passenger, and updates index.
    Private Sub showFlights()
        ' Sets index to 0 to prevent out of bounds array issues.
        index = 0

        Dim airfareFile As String() = grabAirfareFile()
        Dim destinationQuery = From localLine As String In airfareFile
                               Let localLineSplit As String() = localLine.Split(",")
                               Where localLineSplit(0) = listBoxOrigin.SelectedItem
                               Where localLineSplit(1) = listBoxDestination.SelectedItem
                               Select localLine

        flightCache = destinationQuery.ToList.ToArray

        Dim line As String = flightCache(index)
        Dim linesplit As String() = line.Split(",")

        lblTime.Text = linesplit(2)

        updateFare(linesplit(3), linesplit(4))

        Console.WriteLine("got here?")
    End Sub

    ' Lists all destination flights that are coming from origin.
    Private Sub showToFlights()
        Dim airfareFile As String() = grabAirfareFile()

        Dim destinationQuery = From line As String In airfareFile
                               Let lineSplit As String() = line.Split(",")
                               Where lineSplit(0) = listBoxOrigin.SelectedItem
                               Select lineSplit(1)

        Dim destinationArray As String() = destinationQuery.ToList.Distinct.ToArray

        listBoxDestination.Items.Clear()

        For index As Integer = 0 To destinationArray.Length - 1 Step 1
            listBoxDestination.Items.Add(destinationArray(index))
        Next
    End Sub

    Private Sub showOriginFlights()
        Dim airfareFile As String() = grabAirfareFile()
        Dim originQuery = From line As String In airfareFile
                          Let lineSplit As String() = line.Split(",")
                          Select lineSplit(0)

        Dim originArray As String() = originQuery.ToList.Distinct.ToArray

        listBoxOrigin.Items.Clear()

        For index As Integer = 0 To originArray.Length - 1 Step 1
            listBoxOrigin.Items.Add(originArray(index))
        Next
    End Sub

    Private Sub updateFare(ByRef cost As String, ByRef discount As String)
        Dim fare As Double = CDbl(cost)

        ' Checks if trip is one way or round.
        If Not rButtonOneWay.Checked Then
            ' Multiplies value by two for round trip price.
            fare *= 2

            ' Converts linesplit(4) into a double (discount for round trip), and divides it by 100 to convert into decimal, subtracts it by 1 to get discounted total, and multiply by fare.
            fare = (fare * (1 - CDbl(discount) / 100))
        End If

        lblFare.Text = fare.ToString("c2")
    End Sub

    ' Fires when a origin city has been selected by the passenger.
    Private Sub listBoxOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxOrigin.SelectedIndexChanged
        If Not listBoxOrigin.SelectedIndex = -1 AndAlso Not listBoxOrigin.Items.Count = 1 Then
            Dim origin As String = listBoxOrigin.SelectedItem

            listBoxOrigin.Items.Clear()

            listBoxOrigin.Items.Add(origin)

            listBoxOrigin.SetSelected(0, True)

            showToFlights()

            btnRestart.Visible = True

            lblOrigin.Text = "Origin: " & origin
        End If
    End Sub

    ' Fires when a destination city has been selected by the passenger.
    Private Sub listBoxDestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxDestination.SelectedIndexChanged
        If Not listBoxDestination.SelectedIndex = -1 AndAlso Not listBoxDestination.Items.Count = 1 Then
            Dim destination As String = listBoxDestination.SelectedItem

            listBoxDestination.Items.Clear()

            listBoxDestination.Items.Add(destination)

            listBoxDestination.SetSelected(0, True)

            showFlights()

            lblDestination.Text = "Destination: " & destination
        End If
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        listBoxDestination.ClearSelected()
        listBoxOrigin.ClearSelected()

        listBoxOrigin.Items.Clear()
        listBoxDestination.Items.Clear()
        showOriginFlights()

        flightCache = Nothing

        lblTime.Text = ""
        lblFare.Text = ""

        clearReservationStatus()

        lblPNR.Text = "PNR: "

        lblOrigin.Text = "Origin: None"
        lblDestination.Text = "Destination: None"
        lblTotalCost.Text = "Total Cost: $0.00"

        resetSelection()
    End Sub

    Private Sub btnInfoSelect_Click(sender As Object, e As EventArgs) Handles btnInfoSelect.Click
        checkFareSelection()
    End Sub

    Private Sub btnInfoNext_Click(sender As Object, e As EventArgs) Handles btnInfoNext.Click
        If fare = "" AndAlso Not lblTime.Text = "" Then
            If index + 1 < flightCache.Length - 1 Then
                index += 1
            Else
                index = 0
            End If

            Dim line As String = flightCache(index)
            Dim linesplit As String() = line.Split(",")

            lblTime.Text = linesplit(2)

            updateFare(linesplit(3), linesplit(4))
        End If
    End Sub

    Private Sub btnInfoClear_Click(sender As Object, e As EventArgs) Handles btnInfoClear.Click
        clearInformation()
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        If Not fare = "" AndAlso Not txtBoxPassengerName.Text = "" AndAlso Not txtBoxSeatCount.Text = "" AndAlso IsNumeric(txtBoxSeatCount.Text) Then
            displayReserveration()
        End If
    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        If IsPNRValid() Then
            showReservation()
        Else
            MessageBox.Show("We're sorry, but your last name or passenger name record is invalid", "RCSJ Airline Inc.")
        End If
    End Sub

    Private Sub btnCReserv_Click(sender As Object, e As EventArgs) Handles btnCReserv.Click
        deleteReservation()
    End Sub

    Private Sub btnACom_Click(sender As Object, e As EventArgs) Handles btnACom.Click
        Dim input As String = GetInput()

        If Not input = "" Then
            addComment(input)
            MessageBox.Show("Added comment: " & input, "RCSJ Airline Inc.")
        Else
            MessageBox.Show("You must add information to your special comment in order for it to be added", "RCSJ Airline Inc.")
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        reservation = ""
        clearDisplayReservation()
    End Sub

    Private Sub timerSystem_Tick(sender As Object, e As EventArgs) Handles timerSystem.Tick

        If Not lblFare.Text = "" AndAlso Not txtBoxPassengerName.Text = "" AndAlso IsNumeric(txtBoxSeatCount.Text) Then
            Dim cost As Double = CDbl(lblFare.Text)
            Dim seats As Integer = CInt(txtBoxSeatCount.Text)
            Dim finalCost As String = (cost * seats).ToString("C0")

            lblCost.Text = finalCost
            lblTotalCost.Text = "Total Cost: " & finalCost
        End If
    End Sub

    Private Sub txtBoxSeatCount_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSeatCount.TextChanged
        Dim seatCount As Integer = 1

        If Not txtBoxSeatCount.Text = "" AndAlso IsNumeric(txtBoxSeatCount.Text) Then
            seatCount = CInt(txtBoxSeatCount.Text)

            If seatCount = 0 Then
                seatCount = 1
                txtBoxSeatCount.Text = "1"
            End If

            If seatCount > 287 Then
                seatCount = 287
                txtBoxSeatCount.Text = "287"
            End If
        Else
            lblCost.Text = "$0.00"
            'lblTotalCost.Text = "Total Cost: $0.00"
        End If

        lblSeatCount.Text = "Seats: " & seatCount
    End Sub

    Private Sub btnClearStatus_Click(sender As Object, e As EventArgs) Handles btnClearStatus.Click
        If Not lblPNR.Text = "PNR: " Then
            clearReservationStatus()
        End If
    End Sub
End Class