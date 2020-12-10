
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

        ' Returns false if the last name and passenger name record id couldn't be found.
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
        ' Checks if the flight cache is empty.
        If flightCache IsNot Nothing Then
            ' Checks if a flight was selected.
            If fare = "" Then
                ' Updates the flight to what is in the flight cache for index.
                fare = flightCache(index)

                ' Disables the visibility for the next flight, or selecting a flight.
                btnInfoNext.Visible = False
                btnInfoSelect.Visible = False

                ' Moves the clear button into the middle for design.
                btnInfoClear.Location = New Point(93, 303)
            Else
                ' Sends a message box letting the passenger know they need to clear their seleciton before trying to select a new flight.
                MessageBox.Show("There is already a flight selected, please clear selected to change..", "RCSJ Airline Inc.")
            End If
        End If
    End Sub

    ' Clears the displayed reservation for the nexdt passenger.
    Private Sub clearDisplayReservation()
        lblManagementPNR.Text = "PNR: "
        lblManagementOrigin.Text = "Origin: None"
        lblManagementDestination.Text = "Destination: None"
        lblManagementSeatCount.Text = "Seats: 1"
        lblManagementTotalCost.Text = "Total Cost: $0.00"

        ' Makes the group box not visible for the reservation management.
        groupBoxReservationManagement.Visible = False
    End Sub

    ' Clears the information of the fare for a flight change.
    Private Sub clearInformation()
        If fare = "" Then
            ' Sends a message box that there isn't a flight selected. 
            MessageBox.Show("There is no selected flight to clear.", "RCSJ Airline Inc.")
        Else
            ' Resets the selection.
            resetSelection()
        End If
    End Sub

    ' Clears the reservation status to not allow the next passenger to see the information. 
    Private Sub clearReservationStatus()
        lblPNR.Text = "PNR: "

        lblOrigin.Text = "Origin: None"
        lblDestination.Text = "Destination: None"
        lblTotalCost.Text = "Total Cost: $0.00"
    End Sub

    ' Shows the reservation of the passenger's flight.
    Private Sub showReservation()

        ' Makes the group box visible for the reservation management.
        groupBoxReservationManagement.Visible = True

        ' Splits the reservation data by three different criterias.
        Dim localLineSplit As String() = reservation.Split(":")
        Dim cities As String() = localLineSplit(2).Split(";")
        Dim cityNames As String() = cities(0).Split(",")

        ' Updates the labels with the new information.
        lblManagementPNR.Text = "PNR: " & localLineSplit(1).Split("#")(0)
        lblManagementOrigin.Text = "Origin: " & cityNames(0)
        lblManagementDestination.Text = "Destination: " & cityNames(1)
        lblManagementSeatCount.Text = "Seats: " & cities(1)
        lblManagementTotalCost.Text = "Total Cost: " & CDbl(localLineSplit(3)).ToString("c2")

        ' Clears both of the text boxes for reservation lookup.
        txtBoxLookupName.Text = ""
        txtBoxLookupPNR.Text = ""
    End Sub

    ' Deletes reservation from file.
    Private Sub deleteReservation()
        ' Grabs file's data into string array.
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
            ' Sends a message box that a last name must be provided.
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

        ' Clears the labels for time and fare.
        lblTime.Text = ""
        lblFare.Text = ""

        ' Clears the passenger's name and seat count.
        txtBoxPassengerName.Text = ""
        txtBoxSeatCount.Text = ""

        ' Resets the selection.
        resetSelection()

        ' Grabs the file's data into string array.
        Dim resFile As String() = grabResFile()

        ' Resizes the string array to allow one more add to it.
        Array.Resize(resFile, resFile.Length + 1)

        ' Updates the end of the file to add the new flight.
        resFile(resFile.Length - 1) = format

        ' Writes the information into file stored
        IO.File.WriteAllLines("reservations.txt", resFile)
    End Sub

    ' Resets clear button back to original location, re-enables next & info buttons, and clears time/fare text.
    Private Sub resetSelection()
        ' Sets current selected flight to empty.
        fare = ""

        ' Moves clear information button back to original position.
        btnInfoClear.Location = New Point(174, 303)

        ' Sets the information next and select buttons to visible.
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

        ' Shows the orign flights for the names.
        showOriginFlights()

        ' Sets labels for time and fare to empty.
        lblTime.Text = ""
        lblFare.Text = ""

        ' Clears the reservation status.
        clearReservationStatus()

        ' Sets the passenger name record to empty.
        lblPNR.Text = "PNR: "

        ' Sets the origin to none.
        lblOrigin.Text = "Origin: None"

        ' Sets the destination to none.
        lblDestination.Text = "Destination: None"

        ' Sets the total cost to $0.00.
        lblTotalCost.Text = "Total Cost: $0.00"

        ' Resets the selection
        resetSelection()

        ' Allows the one way and round trip to be visible and make one way checked on default.
        rButtonOneWay.Visible = True
        rButtonOneWay.Checked = True
        rButtonRoundTrip.Visible = True
    End Sub

    ' Updates flightCache for selecting what flight for passenger, and updates index.
    Private Sub showFlights()
        ' Sets index to 0 to prevent out of bounds array issues.
        index = 0

        ' Grabs file's data into string array.
        Dim airfareFile As String() = grabAirfareFile()

        ' Creates a query that splits by a comma, and grabs the origin and destination of each line.
        Dim destinationQuery = From localLine As String In airfareFile
                               Let localLineSplit As String() = localLine.Split(",")
                               Where localLineSplit(0) = listBoxOrigin.SelectedItem
                               Where localLineSplit(1) = listBoxDestination.SelectedItem
                               Select localLine

        ' Updates the flight change after converting the destination query into a list and then into a array.
        flightCache = destinationQuery.ToList.ToArray

        ' Grabs the flight cache's index.
        Dim line As String = flightCache(index)

        ' Splits line by a comma.
        Dim linesplit As String() = line.Split(",")

        ' Updates time label to the third position of the array.
        lblTime.Text = linesplit(2)

        ' Updates the fare with the parameters using the third and forth position of the array.
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
        ' Restarts the process.
        restartProcess()
    End Sub

    ' Checks if a flight is selected before updating to another one.
    Private Sub btnInfoSelect_Click(sender As Object, e As EventArgs) Handles btnInfoSelect.Click
        ' Clears the fare selection.
        checkFareSelection()
    End Sub

    ' Allows passenger to skip onto the next flight if there are multiple for the origin to destination.
    Private Sub btnInfoNext_Click(sender As Object, e As EventArgs) Handles btnInfoNext.Click
        ' Chewcks if the fare is empty, and checks if a time is provided.
        If fare = "" AndAlso Not lblTime.Text = "" Then
            ' Checks if the index value + 1 is less than the flight cache length.
            If index + 1 < flightCache.Length - 1 Then
                ' Increases index by 1
                index += 1
            Else
                ' Sets index to 0 to restart flight cache at the beginning.
                index = 0
            End If

            ' Grabs the specific line in the flight cache for the flight.
            Dim line As String = flightCache(index)

            ' Splits the line information by the commas.
            Dim linesplit As String() = line.Split(",")

            ' Grabs the time for the flight from the array.
            lblTime.Text = linesplit(2)

            ' Grabs the one way price, and grabs the discount price for round trip.
            updateFare(linesplit(3), linesplit(4))
        End If
    End Sub

    ' Fires when a passenger would like to clear the currently selected flight.
    Private Sub btnInfoClear_Click(sender As Object, e As EventArgs) Handles btnInfoClear.Click
        ' Fires sub method to clear flight information from selected flight to allow change.
        clearInformation()
    End Sub

    ' Fires when a  passenger would like to reserve flight for the information that they selected.
    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        ' Checks if a flight is selected, checks if the passenger name was provided, checks if the seat count was provided and if the seat count is a valid number.
        If Not fare = "" AndAlso Not txtBoxPassengerName.Text = "" AndAlso Not txtBoxSeatCount.Text = "" AndAlso IsNumeric(txtBoxSeatCount.Text) Then
            ' Fires sub method to display reserveration.
            displayReserveration()
        End If
    End Sub

    ' Fires when a passenger would like to look up their information.
    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        ' Checks if the passenger name record is valid.
        If IsPNRValid() Then
            ' If the passenger name record is valid, it'll show the reservation management for that specific flight.
            showReservation()
        Else
            ' Shows a message box explaining that at least one of the two text boxes do not contain the correct information.
            MessageBox.Show("We're sorry, but your last name or passenger name record is invalid", "RCSJ Airline Inc.")
        End If
    End Sub

    ' Deletes the reservation data that is stored.
    Private Sub btnCReserv_Click(sender As Object, e As EventArgs) Handles btnCReserv.Click
        deleteReservation()
    End Sub

    ' Fires when a passenger would like to add special comments to their flight.
    Private Sub btnACom_Click(sender As Object, e As EventArgs) Handles btnACom.Click
        ' Asks the passenger what they'd like to be added as a special comment to their flight management information on file.
        Dim input As String = GetInput()

        ' Checks if the input they entered is empty.
        If Not input = "" Then
            ' Shows message that the comment was successfully added into the file.
            MessageBox.Show("Added comment: " & input, "RCSJ Airline Inc.")

            ' Executes method that would add comment into file.
            addComment(input)
        Else
            ' Shows a message stating that if someone would like a comment to be shown they'll need to provide what will be shown.
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
            ' Sets the cost of flight to nothing.
            lblCost.Text = "$0.00"
        End If

        ' Updates the seat count.
        lblSeatCount.Text = "Seats: " & seatCount
    End Sub

    ' Checks if a passenger name record is filled, before clearing the resevation status.
    Private Sub btnClearStatus_Click(sender As Object, e As EventArgs) Handles btnClearStatus.Click
        If Not lblPNR.Text = "PNR: " Then
            ' Clears the reservation status to make sure another passenger wouldn't see it.
            clearReservationStatus()
        End If
    End Sub
End Class