
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

        Dim planeArray As Airplane() = {}
        Dim planeDataArray As String() = IO.File.ReadAllLines("Airplane.txt")

        Array.Resize(planeArray, planeDataArray.Length)

        For index = 0 To planeArray.Count - 1 Step 1
            Dim localAirplane As New Airplane
            Dim planeStr() As String = planeDataArray(index).Split(",")

            localAirplane.model = planeStr(0)
            localAirplane.firstFlightYear = CInt(planeStr(1))
            localAirplane.seatCount = CInt(planeStr(2))
            localAirplane.sector = CInt(planeStr(3))
            localAirplane.fuelBurnRate = CDbl(planeStr(4))
            localAirplane.fuelPerSeat = CDbl(planeStr(5))

            planeArray(index) = localAirplane
        Next

        Dim query = From plane In planeArray
                    Where plane.model.Contains(planeName)

        Return query.Count
    End Function

    ' Calculates round trip fuel by doubling sector (fuel one way)
    Function RoundTripFuel(ByVal sector As Integer) As Integer
        Return (sector * 2)
    End Function

    ' Calculates a decimal value that calculates the average amount between two values.
    Function CalculateAverages(ByVal dividend As Double, ByVal divisor As Integer) As Double
        Return Math.Round(dividend / divisor, 1)
    End Function

    ' Updates input that is stored for airplane name.
    Sub GetInput()
        input = InputBox("Enter the Airplane Model", "Airplane Data")
    End Sub

    ' Updates chart displaying models with fuel per gallon/seat
    Sub DisplayComputeFuel()
        Dim planeArray As Airplane() = {}
        Dim planeDataArray As String() = IO.File.ReadAllLines("Airplane.txt")

        Array.Resize(planeArray, planeDataArray.Length)

        For index = 0 To planeArray.Count - 1 Step 1
            Dim localAirplane As New Airplane
            Dim planeStr() As String = planeDataArray(index).Split(",")

            localAirplane.model = planeStr(0)
            localAirplane.firstFlightYear = CInt(planeStr(1))
            localAirplane.seatCount = CInt(planeStr(2))
            localAirplane.sector = CInt(planeStr(3))
            localAirplane.fuelBurnRate = CDbl(planeStr(4))
            localAirplane.fuelPerSeat = CDbl(planeStr(5))

            planeArray(index) = localAirplane
        Next

        Dim planeDictionary As New Dictionary(Of String, Double)
        Dim planeAmountDictionary As New Dictionary(Of String, Integer)

        For index = 0 To planeArray.Count - 1 Step 1
            Dim localPlane As Airplane = planeArray(index)
            Dim name As String = localPlane.model.Split("-")(0)

            If planeDictionary.ContainsKey(name) Then
                Dim currentFuel As Double = planeDictionary.Item(name) + localPlane.fuelPerSeat
                Dim planeCount As Integer = planeAmountDictionary.Item(name) + 1

                planeDictionary.Item(name) = currentFuel
                planeAmountDictionary.Item(name) = planeCount

                Continue For
            End If

            planeDictionary.Add(name, localPlane.fuelPerSeat)
            planeAmountDictionary.Add(name, 1)
        Next

        Dim query = From planeName As String In planeDictionary.Keys.ToList
                    Let fuelPerSeat = CalculateAverages(planeDictionary.Item(planeName), planeAmountDictionary.Item(planeName))
                    Order By fuelPerSeat Descending
                    Select planeName, fuelPerSeat

        dataGridFuel.DataSource = Nothing
        dataGridFuel.Rows.Clear()

        dataGridFuel.RowHeadersVisible = False

        dataGridFuel.DataSource = query.ToList
        dataGridFuel.CurrentCell = Nothing

        dataGridFuel.Columns(0).HeaderText = "Model"
        dataGridFuel.Columns("fuelPerSeat").HeaderText = "Fuel per gallon/seat"

    End Sub

    ' Updates airplane details displayed from entering a model.
    Sub DisplayAirplaneDetails()
        Dim planeArray As Airplane() = {}
        Dim planeDataArray As String() = IO.File.ReadAllLines("Airplane.txt")

        Array.Resize(planeArray, planeDataArray.Length)

        For index = 0 To planeArray.Count - 1 Step 1
            Dim localAirplane As New Airplane
            Dim planeStr() As String = planeDataArray(index).Split(",")

            localAirplane.model = planeStr(0)
            localAirplane.firstFlightYear = CInt(planeStr(1))
            localAirplane.seatCount = CInt(planeStr(2))
            localAirplane.sector = CInt(planeStr(3))
            localAirplane.fuelBurnRate = CDbl(planeStr(4))
            localAirplane.fuelPerSeat = CDbl(planeStr(5))

            planeArray(index) = localAirplane
        Next

        input = ""

        While input = ""
            GetInput()
        End While

        Dim valid As Boolean = False

        For index = 0 To planeArray.Count - 1 Step 1
            Dim localAirplane As Airplane = planeArray(index)
            If localAirplane.model.Contains(input) Then
                valid = True
                Exit For
            End If
        Next

        If Not valid Then
            MessageBox.Show(“There is No known ” & input & “ Airplane Model”)
            Return
        End If

        Dim planeCount As Integer = NumberOfPlane(input)
        Dim avgSeats As Double = 0D
        Dim sector As Integer = 0
        Dim fuelBurn As Double = 0D
        Dim fuelPerSeat As Double = 0D
        Dim totalRoundTrip As Integer = 0

        For index = 0 To planeArray.Count - 1 Step 1
            Dim localAirplane As Airplane = planeArray(index)

            If localAirplane.model.Contains(input) Then
                avgSeats += localAirplane.seatCount
                sector += localAirplane.sector
                fuelBurn += localAirplane.fuelBurnRate
                fuelPerSeat += localAirplane.fuelPerSeat
                totalRoundTrip += RoundTripFuel(localAirplane.sector)
            End If
        Next

        avgSeats = CalculateAverages(avgSeats, planeCount)
        sector = CalculateAverages(sector, planeCount)
        fuelBurn = CalculateAverages(fuelBurn, planeCount)
        fuelPerSeat = CalculateAverages(fuelPerSeat, planeCount)

        lblAirplaneModel.Text = input
        lblNumberOfSeats.Text = CStr(avgSeats)
        lblSector.Text = sector.ToString("N0")
        lblFuelBurn.Text = Math.Round(fuelBurn, 1)
        lblFuelPerSeat.Text = CStr(fuelPerSeat)
        lblRoundTripFuel.Text = totalRoundTrip.ToString("N0")

    End Sub
End Class