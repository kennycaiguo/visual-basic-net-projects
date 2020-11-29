<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirplaneData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnComputeFuel = New System.Windows.Forms.Button()
        Me.dataGridFuel = New System.Windows.Forms.DataGridView()
        Me.btnAirplaneDetails = New System.Windows.Forms.Button()
        Me.lblAirplaneModelDesign = New System.Windows.Forms.Label()
        Me.lblNumberOfSeatsDesign = New System.Windows.Forms.Label()
        Me.lblSectorDesign = New System.Windows.Forms.Label()
        Me.lblFuelBurnDesign = New System.Windows.Forms.Label()
        Me.lblFuelPerSeatDesign = New System.Windows.Forms.Label()
        Me.lblRoundTripFuelDesign = New System.Windows.Forms.Label()
        Me.lblAirplaneModel = New System.Windows.Forms.Label()
        Me.lblNumberOfSeats = New System.Windows.Forms.Label()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.lblFuelBurn = New System.Windows.Forms.Label()
        Me.lblFuelPerSeat = New System.Windows.Forms.Label()
        Me.lblRoundTripFuel = New System.Windows.Forms.Label()
        CType(Me.dataGridFuel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnComputeFuel
        '
        Me.btnComputeFuel.Location = New System.Drawing.Point(67, 10)
        Me.btnComputeFuel.Name = "btnComputeFuel"
        Me.btnComputeFuel.Size = New System.Drawing.Size(95, 23)
        Me.btnComputeFuel.TabIndex = 0
        Me.btnComputeFuel.Text = "Compute Fuel"
        Me.btnComputeFuel.UseVisualStyleBackColor = True
        '
        'dataGridFuel
        '
        Me.dataGridFuel.AllowUserToResizeColumns = False
        Me.dataGridFuel.AllowUserToResizeRows = False
        Me.dataGridFuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridFuel.Location = New System.Drawing.Point(13, 36)
        Me.dataGridFuel.Name = "dataGridFuel"
        Me.dataGridFuel.ReadOnly = True
        Me.dataGridFuel.Size = New System.Drawing.Size(203, 190)
        Me.dataGridFuel.TabIndex = 1
        '
        'btnAirplaneDetails
        '
        Me.btnAirplaneDetails.Location = New System.Drawing.Point(292, 10)
        Me.btnAirplaneDetails.Name = "btnAirplaneDetails"
        Me.btnAirplaneDetails.Size = New System.Drawing.Size(95, 23)
        Me.btnAirplaneDetails.TabIndex = 2
        Me.btnAirplaneDetails.Text = "Airplane Details"
        Me.btnAirplaneDetails.UseVisualStyleBackColor = True
        '
        'lblAirplaneModelDesign
        '
        Me.lblAirplaneModelDesign.AutoSize = True
        Me.lblAirplaneModelDesign.Location = New System.Drawing.Point(222, 73)
        Me.lblAirplaneModelDesign.Name = "lblAirplaneModelDesign"
        Me.lblAirplaneModelDesign.Size = New System.Drawing.Size(80, 13)
        Me.lblAirplaneModelDesign.TabIndex = 3
        Me.lblAirplaneModelDesign.Text = "Airplane Model:"
        '
        'lblNumberOfSeatsDesign
        '
        Me.lblNumberOfSeatsDesign.AutoSize = True
        Me.lblNumberOfSeatsDesign.Location = New System.Drawing.Point(222, 97)
        Me.lblNumberOfSeatsDesign.Name = "lblNumberOfSeatsDesign"
        Me.lblNumberOfSeatsDesign.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberOfSeatsDesign.TabIndex = 4
        Me.lblNumberOfSeatsDesign.Text = "Number of Seats:"
        '
        'lblSectorDesign
        '
        Me.lblSectorDesign.AutoSize = True
        Me.lblSectorDesign.Location = New System.Drawing.Point(222, 121)
        Me.lblSectorDesign.Name = "lblSectorDesign"
        Me.lblSectorDesign.Size = New System.Drawing.Size(41, 13)
        Me.lblSectorDesign.TabIndex = 5
        Me.lblSectorDesign.Text = "Sector:"
        '
        'lblFuelBurnDesign
        '
        Me.lblFuelBurnDesign.AutoSize = True
        Me.lblFuelBurnDesign.Location = New System.Drawing.Point(222, 146)
        Me.lblFuelBurnDesign.Name = "lblFuelBurnDesign"
        Me.lblFuelBurnDesign.Size = New System.Drawing.Size(55, 13)
        Me.lblFuelBurnDesign.TabIndex = 6
        Me.lblFuelBurnDesign.Text = "Fuel Burn:"
        '
        'lblFuelPerSeatDesign
        '
        Me.lblFuelPerSeatDesign.AutoSize = True
        Me.lblFuelPerSeatDesign.Location = New System.Drawing.Point(222, 171)
        Me.lblFuelPerSeatDesign.Name = "lblFuelPerSeatDesign"
        Me.lblFuelPerSeatDesign.Size = New System.Drawing.Size(74, 13)
        Me.lblFuelPerSeatDesign.TabIndex = 7
        Me.lblFuelPerSeatDesign.Text = "Fuel Per Seat:"
        '
        'lblRoundTripFuelDesign
        '
        Me.lblRoundTripFuelDesign.AutoSize = True
        Me.lblRoundTripFuelDesign.Location = New System.Drawing.Point(222, 193)
        Me.lblRoundTripFuelDesign.Name = "lblRoundTripFuelDesign"
        Me.lblRoundTripFuelDesign.Size = New System.Drawing.Size(113, 13)
        Me.lblRoundTripFuelDesign.TabIndex = 8
        Me.lblRoundTripFuelDesign.Text = "Total Round Trip Fuel:"
        '
        'lblAirplaneModel
        '
        Me.lblAirplaneModel.Location = New System.Drawing.Point(338, 73)
        Me.lblAirplaneModel.Name = "lblAirplaneModel"
        Me.lblAirplaneModel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblAirplaneModel.Size = New System.Drawing.Size(99, 13)
        Me.lblAirplaneModel.TabIndex = 9
        '
        'lblNumberOfSeats
        '
        Me.lblNumberOfSeats.Location = New System.Drawing.Point(338, 97)
        Me.lblNumberOfSeats.Name = "lblNumberOfSeats"
        Me.lblNumberOfSeats.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNumberOfSeats.Size = New System.Drawing.Size(99, 13)
        Me.lblNumberOfSeats.TabIndex = 10
        '
        'lblSector
        '
        Me.lblSector.Location = New System.Drawing.Point(338, 121)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSector.Size = New System.Drawing.Size(99, 13)
        Me.lblSector.TabIndex = 11
        '
        'lblFuelBurn
        '
        Me.lblFuelBurn.Location = New System.Drawing.Point(338, 146)
        Me.lblFuelBurn.Name = "lblFuelBurn"
        Me.lblFuelBurn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFuelBurn.Size = New System.Drawing.Size(99, 13)
        Me.lblFuelBurn.TabIndex = 12
        '
        'lblFuelPerSeat
        '
        Me.lblFuelPerSeat.Location = New System.Drawing.Point(338, 171)
        Me.lblFuelPerSeat.Name = "lblFuelPerSeat"
        Me.lblFuelPerSeat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFuelPerSeat.Size = New System.Drawing.Size(99, 13)
        Me.lblFuelPerSeat.TabIndex = 13
        '
        'lblRoundTripFuel
        '
        Me.lblRoundTripFuel.Location = New System.Drawing.Point(341, 193)
        Me.lblRoundTripFuel.Name = "lblRoundTripFuel"
        Me.lblRoundTripFuel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblRoundTripFuel.Size = New System.Drawing.Size(96, 13)
        Me.lblRoundTripFuel.TabIndex = 14
        '
        'frmAirplaneData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 234)
        Me.Controls.Add(Me.lblRoundTripFuel)
        Me.Controls.Add(Me.lblFuelPerSeat)
        Me.Controls.Add(Me.lblFuelBurn)
        Me.Controls.Add(Me.lblSector)
        Me.Controls.Add(Me.lblNumberOfSeats)
        Me.Controls.Add(Me.lblAirplaneModel)
        Me.Controls.Add(Me.lblRoundTripFuelDesign)
        Me.Controls.Add(Me.lblFuelPerSeatDesign)
        Me.Controls.Add(Me.lblFuelBurnDesign)
        Me.Controls.Add(Me.lblSectorDesign)
        Me.Controls.Add(Me.lblNumberOfSeatsDesign)
        Me.Controls.Add(Me.lblAirplaneModelDesign)
        Me.Controls.Add(Me.btnAirplaneDetails)
        Me.Controls.Add(Me.dataGridFuel)
        Me.Controls.Add(Me.btnComputeFuel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAirplaneData"
        Me.Text = "Airplane Data"
        CType(Me.dataGridFuel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnComputeFuel As Button
    Friend WithEvents dataGridFuel As DataGridView
    Friend WithEvents btnAirplaneDetails As Button
    Friend WithEvents lblAirplaneModelDesign As Label
    Friend WithEvents lblNumberOfSeatsDesign As Label
    Friend WithEvents lblSectorDesign As Label
    Friend WithEvents lblFuelBurnDesign As Label
    Friend WithEvents lblFuelPerSeatDesign As Label
    Friend WithEvents lblRoundTripFuelDesign As Label
    Friend WithEvents lblAirplaneModel As Label
    Friend WithEvents lblNumberOfSeats As Label
    Friend WithEvents lblSector As Label
    Friend WithEvents lblFuelBurn As Label
    Friend WithEvents lblFuelPerSeat As Label
    Friend WithEvents lblRoundTripFuel As Label
End Class
