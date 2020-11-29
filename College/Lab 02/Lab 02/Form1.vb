
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

Structure Airplane
    Dim model As String
    Dim firstFlightYear As Integer
    Dim seatCount As Integer
    Dim sector As Integer
    Dim fuelBurnRate As Double
    Dim fuelPerSeat As Double
End Structure

Public Class frmAirplaneData

    ' Publicly stored value for input
    Public Shared input As String = ""

    ' Fires a function that displays airplane fuel chart when button is pressed.
    Private Sub btnComputeFuel_Click(sender As Object, e As EventArgs) Handles btnComputeFuel.Click
        ' Updates chart displaying models with fuel per gallon/seat
        DisplayComputeFuel()
    End Sub

    ' Fires a function that displays airplane details when button is pressed.
    Private Sub btnAirplaneDetails_Click(sender As Object, e As EventArgs) Handles btnAirplaneDetails.Click
        ' Updates airplane details displayed from entering a model.
        DisplayAirplaneDetails()
    End Sub

    ' Calculates the amount of a specific plane
    Function NumberOfPlane(ByVal planeName As String) As Integer

        ' Creates empty array of Airplane objects (structures)
        Dim planeArray As Airplane() = {}
        ' Creates array with each line from text file Airplane.
        Dim planeDataArray As String() = IO.File.ReadAllLines("Airplane.txt")

        ' Resizes empty array to size of planeDataArray.
        Array.Resize(planeArray, planeDataArray.Length)

        ' Loops through all lines of empty array planeArray counting by 1
        For index = 0 To planeArray.Count - 1 Step 1
            ' Creates a localized local Airplane object (structure)
            Dim localAirplane As New Airplane

            ' Splits airplane data on index line of planeDataArray by a comma.
            Dim planeStr() As String = planeDataArray(index).Split(",")

            ' Grabs data that is split into file.
            localAirplane.model = planeStr(0)
            localAirplane.firstFlightYear = CInt(planeStr(1))
            localAirplane.seatCount = CInt(planeStr(2))
            localAirplane.sector = CInt(planeStr(3))
            localAirplane.fuelBurnRate = CDbl(planeStr(4))
            localAirplane.fuelPerSeat = CDbl(planeStr(5))

            ' Updates object at index in planeArray to localized local Airplane object (structure) that has data.
            planeArray(index) = localAirplane
        Next

        ' Loops through all planes and only adds the planes that start with planeName
        Dim query = From plane In planeArray
                    Where plane.model.StartsWith(planeName)

        ' Returns the amount of planes in query.
        Return query.Count
    End Function

    ' Calculates round trip fuel by doubling sector (fuel one way)
    Function RoundTripFuel(ByVal sector As Integer) As Integer
        ' Returns round trip fuel by multiplying by 2.
        Return (sector * 2)
    End Function

    ' Calculates a decimal value that calculates the average amount between two values.
    Function CalculateAverages(ByVal dividend As Double, ByVal divisor As Integer) As Double
        ' First divides (dividend by divisor), then rounds to first decimal if needed.
        Return Math.Round(dividend / divisor, 1)
    End Function

    ' Updates input that is stored for airplane name.
    Sub GetInput()
        input = InputBox("Enter the Airplane Model", "Airplane Data")
    End Sub

    ' Updates chart displaying models with fuel per gallon/seat
    Sub DisplayComputeFuel()

        ' Creates empty array of Airplane objects (structures)
        Dim planeArray As Airplane() = {}
        ' Creates array with each line from text file Airplane.
        Dim planeDataArray As String() = IO.File.ReadAllLines("Airplane.txt")

        ' Resizes empty array to size of planeDataArray.
        Array.Resize(planeArray, planeDataArray.Length)

        ' Loops through all lines of empty array planeArray counting by 1
        For index = 0 To planeArray.Count - 1 Step 1
            ' Creates a localized local Airplane object (structure)
            Dim localAirplane As New Airplane

            ' Splits airplane data on index line of planeDataArray by a comma.
            Dim planeStr() As String = planeDataArray(index).Split(",")

            ' Grabs data that is split into file.
            localAirplane.model = planeStr(0)
            localAirplane.firstFlightYear = CInt(planeStr(1))
            localAirplane.seatCount = CInt(planeStr(2))
            localAirplane.sector = CInt(planeStr(3))
            localAirplane.fuelBurnRate = CDbl(planeStr(4))
            localAirplane.fuelPerSeat = CDbl(planeStr(5))

            ' Updates object at index in planeArray to localized local Airplane object (structure) that has data.
            planeArray(index) = localAirplane
        Next

        ' Creates plane dictionary keeping count of fuel per seat for a type of plane combined.
        Dim planeDictionary As New Dictionary(Of String, Double)

        ' Creates plane dictionary keeping count of a specific plane.
        Dim planeAmountDictionary As New Dictionary(Of String, Integer)

        ' Loops through all lines of plane object (structure) array planeArray counting by 1
        For index = 0 To planeArray.Count - 1 Step 1
            ' Creates a localized variable of plane object in planeArray at index line.
            Dim localPlane As Airplane = planeArray(index)

            ' Splits name of localPlane model by a dash to get the model number.
            Dim name As String = localPlane.model.Split("-")(0).Substring(0, 4)

            ' Checks if the name exists in the dictionary yet.
            If planeDictionary.ContainsKey(name) Then
                ' If it is in the dictionary, grab current fuel and add fuel per seat from localPlane
                Dim currentFuel As Double = planeDictionary.Item(name) + localPlane.fuelPerSeat

                ' Increases plane count by 1.
                Dim planeCount As Integer = planeAmountDictionary.Item(name) + 1

                ' Update dictionaries of plane with new fuel and count data.
                planeDictionary.Item(name) = currentFuel
                planeAmountDictionary.Item(name) = planeCount

                ' Continues for loop and skips the adding of the plane to dictionary and reseting data.
                Continue For
            End If

            ' Adds plane to dictionary with it's fuel per seat.
            planeDictionary.Add(name, localPlane.fuelPerSeat)

            ' Adds plane amount to dictionary set to 1.
            planeAmountDictionary.Add(name, 1)
        Next

        ' 1. Loops through all plane names in planeDictionary.
        ' 2. Calculates the average fuel per seat of each plane by dividing their fuel from planeDictionary and the amount of plane.
        ' 3. Orders planes corresponding to the fuelPerSeat in descending order.
        ' 4. Selects what data we want grabbed for dataGridFuel.
        Dim query = From planeName As String In planeDictionary.Keys.ToList
                    Let fuelPerSeat = CalculateAverages(planeDictionary.Item(planeName), planeAmountDictionary.Item(planeName))
                    Order By fuelPerSeat Descending
                    Select planeName, fuelPerSeat

        ' Resets data source of chart if previously used.
        dataGridFuel.DataSource = Nothing

        ' Clears rows of data.
        dataGridFuel.Rows.Clear()

        ' Sets row headers to be disabled.
        dataGridFuel.RowHeadersVisible = False

        ' Updates data source to new query as a list.
        dataGridFuel.DataSource = query.ToList

        ' Sets currentCell to Nothing
        dataGridFuel.CurrentCell = Nothing

        ' Updates column names to the corresponding ones from Lab 02.pdf.
        dataGridFuel.Columns("planeName").HeaderText = "Model"
        dataGridFuel.Columns("fuelPerSeat").HeaderText = "Fuel per gallon/seat"

    End Sub

    ' Updates airplane details displayed from entering a model.
    Sub DisplayAirplaneDetails()

        ' Creates empty array of Airplane objects (structures)
        Dim planeArray As Airplane() = {}
        ' Creates array with each line from text file Airplane.
        Dim planeDataArray As String() = IO.File.ReadAllLines("Airplane.txt")

        ' Resizes empty array to size of planeDataArray.
        Array.Resize(planeArray, planeDataArray.Length)

        ' Loops through all lines of empty array planeArray counting by 1
        For index = 0 To planeArray.Count - 1 Step 1
            ' Creates a localized local Airplane object (structure)
            Dim localAirplane As New Airplane

            ' Splits airplane data on index line of planeDataArray by a comma.
            Dim planeStr() As String = planeDataArray(index).Split(",")

            ' Grabs data that is split into file.
            localAirplane.model = planeStr(0)
            localAirplane.firstFlightYear = CInt(planeStr(1))
            localAirplane.seatCount = CInt(planeStr(2))
            localAirplane.sector = CInt(planeStr(3))
            localAirplane.fuelBurnRate = CDbl(planeStr(4))
            localAirplane.fuelPerSeat = CDbl(planeStr(5))

            ' Updates object at index in planeArray to localized local Airplane object (structure) that has data.
            planeArray(index) = localAirplane
        Next

        ' Sets current input to empty.
        input = ""

        ' Runs a loop while input is empty.
        While input = ""
            ' Runs sub GetInput()
            GetInput()
        End While

        ' Creates a localized boolean that checks if a plane is valid.
        Dim valid As Boolean = False

        ' Loops through all lines of plane object (structure) array planeArray counting by 1
        For index = 0 To planeArray.Count - 1 Step 1
            Dim localAirplane As Airplane = planeArray(index)
            If localAirplane.model.Contains(input) Then
                valid = True
                Exit For
            End If
        Next

        ' If there are no planes of this type.
        If Not valid Then
            MessageBox.Show(“There is No known ” & input & “ Airplane Model”)
            Return
        End If

        ' Grabs amount of this plane.
        Dim planeCount As Integer = NumberOfPlane(input)
        Dim avgSeats As Double = 0D
        Dim sector As Integer = 0
        Dim fuelBurn As Double = 0D
        Dim fuelPerSeat As Double = 0D
        Dim totalRoundTrip As Integer = 0

        ' Loops through all lines of plane object (structure) array planeArray counting by 1
        For index = 0 To planeArray.Count - 1 Step 1
            Dim localAirplane As Airplane = planeArray(index)

            If localAirplane.model.StartsWith(input) Then
                avgSeats += localAirplane.seatCount
                sector += localAirplane.sector
                fuelBurn += localAirplane.fuelBurnRate
                fuelPerSeat += localAirplane.fuelPerSeat
                totalRoundTrip += RoundTripFuel(localAirplane.sector)
            End If
        Next

        ' Averages out all values by using CalculateAverages
        avgSeats = CalculateAverages(avgSeats, planeCount)
        sector = CalculateAverages(sector, planeCount)
        fuelBurn = CalculateAverages(fuelBurn, planeCount)
        fuelPerSeat = CalculateAverages(fuelPerSeat, planeCount)

        ' Updates all values to label texts, and adds commas if needed.
        lblAirplaneModel.Text = input
        lblNumberOfSeats.Text = CStr(avgSeats)
        lblSector.Text = sector.ToString("N0")
        lblFuelBurn.Text = Math.Round(fuelBurn, 1)
        lblFuelPerSeat.Text = CStr(fuelPerSeat)
        lblRoundTripFuel.Text = totalRoundTrip.ToString("N0")

    End Sub
End Class