
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

    ' Used for what flight is selected.
    Public Shared fare As String = ""

    ' Flight cache for origin to destination.
    Public Shared flightCache() As String

    ' Index for what flight is currently selected.
    Public Shared index As Integer = 0

    ' Used to keep who is currently in the reservation management.
    Public Shared reservation As String

    ' Loads origin flights on startup of application
    Private Sub frmLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Shows the origin flight city names in list box origin.
        showOriginFlights()

        ' Checks if reservation file exists.
        If Not IO.File.Exists("reservations.txt") Then
            ' Creates empty reservations file if it doesn't exist.
            IO.File.Create("reservations.txt")
        End If
    End Sub

    ' Generates passenger name record id.
    Function generatePNR() As String
        ' Grabs the file length of reservations and increases it by one.
        Dim idNumber As String = CStr(grabResFile().Length + 1)

        ' Adds one to the starting value as 0 would've made it sound like it is unpopular.
        Return 100 + idNumber
    End Function

    ' Grabs air fare file.
    Function grabAirfareFile() As String()
        ' Reads all lines of Airfare.txt
        Return IO.File.ReadAllLines("Airfare.txt")
    End Function

    ' Grabs reservations file.
    Function grabResFile() As String()
        ' Reads all lines of reservations.txt
        Return IO.File.ReadAllLines("reservations.txt")
    End Function

    ' Function to ask for input of what the user would like to be added to their flight management as a comment.
    Function GetInput() As String
        Return InputBox("Enter special comments to be added.", "RCSJ Airline Inc.", "")
    End Function

    ' Checks if the passenger name record id is valid inside of the file.
    Function IsPNRValid() As Boolean

        ' Grabs the reservation file.
        Dim resFile As String() = grabResFile()

        ' Creates a query that loops through all liens and skips the lines that have the word None, and will then split the line by colons to grab the passenger's last name and check if it is equal to the one in lookup name,
        ' and finally will split by a hash tag and check if the stuff grabbed is the id from the line.
        Dim lookupQuery = From localLine As String In resFile
                          Where Not localLine.Equals("None")
                          Let localLineSplit As String() = localLine.Split(":")
                          Where localLineSplit(0) = txtBoxLookupName.Text
                          Where localLineSplit(1).Split("#")(0).Equals(txtBoxLookupPNR.Text)
                          Select localLine

        ' Checks if the query found one that matched the request.
        If (lookupQuery.Count = 1) Then
            ' Updates the reservation cache to what was grabbed from the file.
            reservation = lookupQuery.ToList.ToArray()(0)
            Return True
        End If

        Return False
    End Function

    ' Called when a user wants to add a comment to their flight management file.
    Private Sub addComment(ByRef comment)

        ' Grabs the reservation file.
        Dim resFile As String() = grabResFile()

        ' Splits information from reservation format to grab specific information stored.
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

        ' Splits the comments into a array spaced by spaces.
        Dim commentsToBeAdded As String() = comment.Split(" ")

        ' Connects previously comments with the new comments added and converts to a list.
        Dim newComments As String() = comments.Concat(commentsToBeAdded).ToArray()

        ' Creates a format for the new information that will be utilized.
        Dim format As String = lastName & ":" & PNR & "#" & String.Join(",", newComments) & ":" & origin & "," & destination & ";" & seatCount & ":" & cost

        ' Loops through the file and checks for reservation and will update the reservation.
        For index As Integer = 0 To resFile.Length - 1 Step 1
            If (resFile(index).Equals(reservation)) Then
                resFile(index) = format
                Exit For
            End If
        Next

        ' Updates resservation cache to new format into memory.
        reservation = format

        ' Writes information to the file.
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

    ' Deletes reservation from file.
    Private Sub deleteReservation()
        ' Grabs file's data int ostring array.
        Dim resFile As String() = grabResFile()

        ' Loops through string array and checks if the grabbed index of the string array is the reservation.
        ' If it is, set it to None, and quit the for loop.
        For index As Integer = 0 To resFile.Length - 1 Step 1
            If (resFile(index).Equals(reservation)) Then
                resFile(index) = "None"
                Exit For
            End If
        Next

        ' Sets reservation to empty.
        reservation = ""

        ' Clears the reservation that is displayed.
        clearDisplayReservation()

        ' Writes changes to file.

        IO.File.WriteAllLines("reservations.txt", resFile)
    End Sub

    ' Displays the reservation after provided last name and pnr.
    Private Sub displayReserveration()

        Dim passengerName As String = ""
        Dim passengerNameSplit As String() = txtBoxPassengerName.Text.Split(" ")

        ' Checks if passenger name has a last name.
        If passengerNameSplit.Length > 1 Then
            ' Updates passengerName to last name.
            passengerName = passengerNameSplit(passengerNameSplit.Length - 1)
        Else
            MessageBox.Show("You need to provide a last name in your name.", "RCSJ Airline Inc.")
            Return
        End If

        ' Generates a random passenger name record.
        Dim pnr As String = generatePNR()

        ' Grabs origin city from list box origin
        Dim origin As String = listBoxOrigin.SelectedItem

        ' Grabs destination city from list box destination.
        Dim destination As String = listBoxDestination.SelectedItem

        ' Converts text box seat count to a integer.
        Dim seatCount As Integer = CInt(txtBoxSeatCount.Text)

        ' Converts label cost to a double and back into a string.
        Dim totalCost As String = CStr(CDbl(lblCost.Text))

        ' Updates label's text for passenger name record with the generated passenger name record number.
        lblPNR.Text = "PNR: " & pnr

        ' Creates format for file to be storing data.
        Dim format As String = passengerName & ":" & pnr & "#:" & origin & "," & destination & ";" & seatCount & ":" & totalCost

        ' Clears the list boxes.
        listBoxOrigin.Items.Clear()
        listBoxDestination.Items.Clear()

        ' Empties the flight cache.
        flightCache = Nothing

        ' Adds origin flights 
        showOriginFlights()

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

    ' Restarts the process of airline.
    Private Sub restartProcess()
        ' Clears cities from both list boxes.
        listBoxOrigin.Items.Clear()
        listBoxDestination.Items.Clear()

        ' Empties flight cache.
        flightCache = Nothing

        ' 
        showOriginFlights()

        lblTime.Text = ""
        lblFare.Text = ""

        clearReservationStatus()

        lblPNR.Text = "PNR: "

        lblOrigin.Text = "Origin: None"
        lblDestination.Text = "Destination: None"
        lblTotalCost.Text = "Total Cost: $0.00"

        resetSelection()

        rButtonOneWay.Visible = True
        rButtonOneWay.Checked = True
        rButtonRoundTrip.Visible = True
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
    End Sub

    ' Lists all destination flights that are coming from origin.
    Private Sub showToFlights()

        ' Grabs the airfare file's individual lines.
        Dim airfareFile As String() = grabAirfareFile()

        ' Creates a query that grabs all of the destination flight names that have a origin name of what is selected from the list box.
        Dim destinationQuery = From line As String In airfareFile
                               Let lineSplit As String() = line.Split(",")
                               Where lineSplit(0) = listBoxOrigin.SelectedItem
                               Select lineSplit(1)

        ' Converts query into a list, and removes any duplicates, before turning back into a list.
        Dim destinationArray As String() = destinationQuery.ToList.Distinct.ToArray

        ' Clears list box.
        listBoxDestination.Items.Clear()

        ' Adds all items from destination array into destination list box.
        For index As Integer = 0 To destinationArray.Length - 1 Step 1
            listBoxDestination.Items.Add(destinationArray(index))
        Next
    End Sub

    ' Adds the origin flights to the list box to choose from.
    Private Sub showOriginFlights()

        ' Grabs the airfare file's individual lines.
        Dim airfareFile As String() = grabAirfareFile()

        ' Creates a query that grabs all the origin names from the beginning of each line.
        Dim originQuery = From line As String In airfareFile
                          Let lineSplit As String() = line.Split(",")
                          Select lineSplit(0)

        ' Converts query into a list, and removes any duplicates, before turning back into a list.
        Dim originArray As String() = originQuery.ToList.Distinct.ToArray

        ' Clears list box.
        listBoxOrigin.Items.Clear()

        ' Adds all items from origin array into origin list box.
        For index As Integer = 0 To originArray.Length - 1 Step 1
            listBoxOrigin.Items.Add(originArray(index))
        Next
    End Sub

    ' Updates the fare pricing dependent if round trip is selected.
    Private Sub updateFare(ByRef cost As String, ByRef discount As String)
        Dim fare As Double = CDbl(cost)

        ' Checks if trip is one way or round.
        If Not rButtonOneWay.Checked Then
            ' Multiplies value by two for round trip price.
            fare *= 2

            ' Converts linesplit(4) into a double (discount for round trip), and divides it by 100 to convert into decimal, subtracts it by 1 to get discounted total, and multiply by fare.
            fare = (fare * (1 - CDbl(discount) / 100))
        End If

        ' Converts to string and adds currency symbol based on system settings.
        lblFare.Text = fare.ToString("c2")
    End Sub

    ' Fires when a origin city has been selected by the passenger.
    Private Sub listBoxOrigin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxOrigin.SelectedIndexChanged
        If Not listBoxOrigin.SelectedIndex = -1 AndAlso Not listBoxOrigin.Items.Count = 1 Then

            ' Grabs origin from list box.
            Dim origin As String = listBoxOrigin.SelectedItem

            ' Clears list box.
            listBoxOrigin.Items.Clear()

            ' Adds origin back to list box.
            listBoxOrigin.Items.Add(origin)

            listBoxOrigin.SetSelected(0, True)
            ' Shows flights for destination going from location origin.
            showToFlights()

            ' Sets button restart to not visible. 
            btnRestart.Visible = True

            ' Update the origin in the reservation stats.
            lblOrigin.Text = "Origin: " & origin

        End If
    End Sub

    ' Fires when a destination city has been selected by the passenger.
    Private Sub listBoxDestination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxDestination.SelectedIndexChanged
        If Not listBoxDestination.SelectedIndex = -1 AndAlso Not listBoxDestination.Items.Count = 1 Then

            ' Disables radio buttons for changing if trip is one way or round trip for false information.
            rButtonOneWay.Visible = False
            rButtonRoundTrip.Visible = False

            ' Grabs destination from list box.
            Dim destination As String = listBoxDestination.SelectedItem

            ' Clars list box.
            listBoxDestination.Items.Clear()

            ' Adds destination back to list box.
            listBoxDestination.Items.Add(destination)

            ' Sets destination as selected.
            listBoxDestination.SetSelected(0, True)

            ' List flights that are from those two locations with the time and fare price.
            showFlights()

            ' Update the destination in the reserveration stats.
            lblDestination.Text = "Destination: " & destination
        ElseIf listBoxDestination.Items.Count = 1 Then
            showFlights()

            lblDestination.Text = "Destination: " & listBoxDestination.SelectedItem
        End If
    End Sub

    ' When button is clicked will restart the entire reserve process.
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        restartProcess()
    End Sub

    ' Checks if a flight is selected before updating to another one.
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

    ' 
    Private Sub btnACom_Click(sender As Object, e As EventArgs) Handles btnACom.Click
        Dim input As String = GetInput()

        If Not input = "" Then
            addComment(input)
            MessageBox.Show("Added comment: " & input, "RCSJ Airline Inc.")
        Else
            MessageBox.Show("You must add information to your special comment in order for it to be added", "RCSJ Airline Inc.")
        End If
    End Sub

    ' Updates the reservation cache of the user selected to nothing, and clears what is displayed in the reservation management.
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        reservation = ""
        clearDisplayReservation()
    End Sub

    ' A timer that runs every 100 milliseconds and will update the costs.
    Private Sub timerSystem_Tick(sender As Object, e As EventArgs) Handles timerSystem.Tick

        ' Checks if a fare is selected, and if a passenger name has been entered, and if the value inside of the seat count text box is a number.
        If Not lblFare.Text = "" AndAlso Not txtBoxPassengerName.Text = "" AndAlso IsNumeric(txtBoxSeatCount.Text) Then
            ' Converts the fare text into a cost.
            Dim cost As Double = CDbl(lblFare.Text)

            ' Converts the string for seat count in text box into a integer into the variable seats.
            Dim seats As Integer = CInt(txtBoxSeatCount.Text)

            ' Calculates the final cost by multiplying the cost and seats and converting it into a string with the currency formatting.
            Dim finalCost As String = (cost * seats).ToString("C0")

            ' Updates finalCot variable for the two labels below.
            lblCost.Text = finalCost
            lblTotalCost.Text = "Total Cost: " & finalCost
        End If
    End Sub
    ' Fires whenever the seat count is edited.
    Private Sub txtBoxSeatCount_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSeatCount.TextChanged
        ' Default seat count and can not go under this amount.
        Dim seatCount As Integer = 1

        ' Checks if the text box for seat count is empty, and if the value inside is a number.
        If Not txtBoxSeatCount.Text = "" AndAlso IsNumeric(txtBoxSeatCount.Text) Then
            ' Converts the string for seat count in text box into the a integer into the variable seatCount.
            seatCount = CInt(txtBoxSeatCount.Text)

            ' Checks if the entered value is a 0, and will update it to a 1 as it is the minimum
            If seatCount = 0 Then
                seatCount = 1
                txtBoxSeatCount.Text = "1"
            End If

            ' Checks if the entered value is greater than 287, and will update it to 287 as it is the maximum if any are found higher.
            If seatCount > 287 Then
                seatCount = 287
                txtBoxSeatCount.Text = "287"
            End If
        Else
            lblCost.Text = "$0.00"
        End If

        ' Updates the seat count.
        lblSeatCount.Text = "Seats: " & seatCount
    End Sub

    ' Checks if a passenger name record is filled, before clearing the resevation status.
    Private Sub btnClearStatus_Click(sender As Object, e As EventArgs) Handles btnClearStatus.Click
        If Not lblPNR.Text = "PNR: " Then
            clearReservationStatus()
        End If
    End Sub
End Class