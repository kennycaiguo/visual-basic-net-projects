<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAirline
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAirline))
        Me.groupBoxReservation = New System.Windows.Forms.GroupBox()
        Me.lblReservation2 = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnInfoClear = New System.Windows.Forms.Button()
        Me.btnInfoNext = New System.Windows.Forms.Button()
        Me.btnInfoSelect = New System.Windows.Forms.Button()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxSeatCount = New System.Windows.Forms.TextBox()
        Me.txtBoxPassengerName = New System.Windows.Forms.TextBox()
        Me.lblNameSeats = New System.Windows.Forms.Label()
        Me.lblFare = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listBoxDestination = New System.Windows.Forms.ListBox()
        Me.listBoxOrigin = New System.Windows.Forms.ListBox()
        Me.lblReservation = New System.Windows.Forms.Label()
        Me.rButtonRoundTrip = New System.Windows.Forms.RadioButton()
        Me.rButtonOneWay = New System.Windows.Forms.RadioButton()
        Me.lblPNR = New System.Windows.Forms.Label()
        Me.groupBoxReservationStatus = New System.Windows.Forms.GroupBox()
        Me.btnClearStatus = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblSeatCount = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblOrigin = New System.Windows.Forms.Label()
        Me.groupBoxReservationLookup = New System.Windows.Forms.GroupBox()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.txtBoxLookupPNR = New System.Windows.Forms.TextBox()
        Me.txtBoxLookupName = New System.Windows.Forms.TextBox()
        Me.lblNamePNR = New System.Windows.Forms.Label()
        Me.groupBoxReservationManagement = New System.Windows.Forms.GroupBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnACom = New System.Windows.Forms.Button()
        Me.btnCReserv = New System.Windows.Forms.Button()
        Me.lblManagementTotalCost = New System.Windows.Forms.Label()
        Me.lblManagementSeatCount = New System.Windows.Forms.Label()
        Me.lblManagementDestination = New System.Windows.Forms.Label()
        Me.lblManagementOrigin = New System.Windows.Forms.Label()
        Me.lblManagementPNR = New System.Windows.Forms.Label()
        Me.timerSystem = New System.Windows.Forms.Timer(Me.components)
        Me.groupBoxReservation.SuspendLayout()
        Me.groupBoxReservationStatus.SuspendLayout()
        Me.groupBoxReservationLookup.SuspendLayout()
        Me.groupBoxReservationManagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBoxReservation
        '
        Me.groupBoxReservation.Controls.Add(Me.lblReservation2)
        Me.groupBoxReservation.Controls.Add(Me.btnRestart)
        Me.groupBoxReservation.Controls.Add(Me.btnInfoClear)
        Me.groupBoxReservation.Controls.Add(Me.btnInfoNext)
        Me.groupBoxReservation.Controls.Add(Me.btnInfoSelect)
        Me.groupBoxReservation.Controls.Add(Me.btnReserve)
        Me.groupBoxReservation.Controls.Add(Me.lblCost)
        Me.groupBoxReservation.Controls.Add(Me.Label3)
        Me.groupBoxReservation.Controls.Add(Me.txtBoxSeatCount)
        Me.groupBoxReservation.Controls.Add(Me.txtBoxPassengerName)
        Me.groupBoxReservation.Controls.Add(Me.lblNameSeats)
        Me.groupBoxReservation.Controls.Add(Me.lblFare)
        Me.groupBoxReservation.Controls.Add(Me.lblTime)
        Me.groupBoxReservation.Controls.Add(Me.Label1)
        Me.groupBoxReservation.Controls.Add(Me.listBoxDestination)
        Me.groupBoxReservation.Controls.Add(Me.listBoxOrigin)
        Me.groupBoxReservation.Controls.Add(Me.lblReservation)
        Me.groupBoxReservation.Controls.Add(Me.rButtonRoundTrip)
        Me.groupBoxReservation.Controls.Add(Me.rButtonOneWay)
        Me.groupBoxReservation.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxReservation.Name = "groupBoxReservation"
        Me.groupBoxReservation.Size = New System.Drawing.Size(265, 482)
        Me.groupBoxReservation.TabIndex = 1
        Me.groupBoxReservation.TabStop = False
        Me.groupBoxReservation.Text = "Reservation"
        '
        'lblReservation2
        '
        Me.lblReservation2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lblReservation2.ForeColor = System.Drawing.Color.Red
        Me.lblReservation2.Location = New System.Drawing.Point(141, 39)
        Me.lblReservation2.Name = "lblReservation2"
        Me.lblReservation2.Size = New System.Drawing.Size(105, 23)
        Me.lblReservation2.TabIndex = 18
        Me.lblReservation2.Text = "DESTINATION"
        Me.lblReservation2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(93, 230)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 23)
        Me.btnRestart.TabIndex = 17
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        Me.btnRestart.Visible = False
        '
        'btnInfoClear
        '
        Me.btnInfoClear.Location = New System.Drawing.Point(174, 303)
        Me.btnInfoClear.Name = "btnInfoClear"
        Me.btnInfoClear.Size = New System.Drawing.Size(75, 23)
        Me.btnInfoClear.TabIndex = 10
        Me.btnInfoClear.Text = "Clear"
        Me.btnInfoClear.UseVisualStyleBackColor = True
        '
        'btnInfoNext
        '
        Me.btnInfoNext.Location = New System.Drawing.Point(93, 303)
        Me.btnInfoNext.Name = "btnInfoNext"
        Me.btnInfoNext.Size = New System.Drawing.Size(75, 23)
        Me.btnInfoNext.TabIndex = 9
        Me.btnInfoNext.Text = "Next"
        Me.btnInfoNext.UseVisualStyleBackColor = True
        '
        'btnInfoSelect
        '
        Me.btnInfoSelect.Location = New System.Drawing.Point(12, 303)
        Me.btnInfoSelect.Name = "btnInfoSelect"
        Me.btnInfoSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnInfoSelect.TabIndex = 8
        Me.btnInfoSelect.Text = "Select"
        Me.btnInfoSelect.UseVisualStyleBackColor = True
        '
        'btnReserve
        '
        Me.btnReserve.Location = New System.Drawing.Point(93, 446)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(75, 23)
        Me.btnReserve.TabIndex = 16
        Me.btnReserve.Text = "Reserve"
        Me.btnReserve.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.Location = New System.Drawing.Point(9, 420)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(243, 23)
        Me.lblCost.TabIndex = 15
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(4, 397)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "                           COST  "
        '
        'txtBoxSeatCount
        '
        Me.txtBoxSeatCount.Location = New System.Drawing.Point(146, 361)
        Me.txtBoxSeatCount.Name = "txtBoxSeatCount"
        Me.txtBoxSeatCount.Size = New System.Drawing.Size(106, 20)
        Me.txtBoxSeatCount.TabIndex = 13
        '
        'txtBoxPassengerName
        '
        Me.txtBoxPassengerName.Location = New System.Drawing.Point(9, 361)
        Me.txtBoxPassengerName.Name = "txtBoxPassengerName"
        Me.txtBoxPassengerName.Size = New System.Drawing.Size(105, 20)
        Me.txtBoxPassengerName.TabIndex = 12
        '
        'lblNameSeats
        '
        Me.lblNameSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lblNameSeats.ForeColor = System.Drawing.Color.Red
        Me.lblNameSeats.Location = New System.Drawing.Point(2, 335)
        Me.lblNameSeats.Name = "lblNameSeats"
        Me.lblNameSeats.Size = New System.Drawing.Size(253, 23)
        Me.lblNameSeats.TabIndex = 11
        Me.lblNameSeats.Text = "          NAME                        SEATS"
        '
        'lblFare
        '
        Me.lblFare.Location = New System.Drawing.Point(134, 277)
        Me.lblFare.Name = "lblFare"
        Me.lblFare.Size = New System.Drawing.Size(115, 23)
        Me.lblFare.TabIndex = 7
        Me.lblFare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Location = New System.Drawing.Point(2, 277)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(121, 23)
        Me.lblTime.TabIndex = 6
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(4, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "          TIME                         FARE"
        '
        'listBoxDestination
        '
        Me.listBoxDestination.FormattingEnabled = True
        Me.listBoxDestination.Location = New System.Drawing.Point(135, 65)
        Me.listBoxDestination.Name = "listBoxDestination"
        Me.listBoxDestination.Size = New System.Drawing.Size(120, 160)
        Me.listBoxDestination.TabIndex = 4
        '
        'listBoxOrigin
        '
        Me.listBoxOrigin.FormattingEnabled = True
        Me.listBoxOrigin.Location = New System.Drawing.Point(12, 65)
        Me.listBoxOrigin.Name = "listBoxOrigin"
        Me.listBoxOrigin.Size = New System.Drawing.Size(120, 160)
        Me.listBoxOrigin.TabIndex = 3
        '
        'lblReservation
        '
        Me.lblReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lblReservation.ForeColor = System.Drawing.Color.Red
        Me.lblReservation.Location = New System.Drawing.Point(18, 39)
        Me.lblReservation.Name = "lblReservation"
        Me.lblReservation.Size = New System.Drawing.Size(105, 23)
        Me.lblReservation.TabIndex = 2
        Me.lblReservation.Text = "ORIGIN"
        Me.lblReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rButtonRoundTrip
        '
        Me.rButtonRoundTrip.AutoSize = True
        Me.rButtonRoundTrip.Location = New System.Drawing.Point(177, 19)
        Me.rButtonRoundTrip.Name = "rButtonRoundTrip"
        Me.rButtonRoundTrip.Size = New System.Drawing.Size(78, 17)
        Me.rButtonRoundTrip.TabIndex = 1
        Me.rButtonRoundTrip.TabStop = True
        Me.rButtonRoundTrip.Text = "Round Trip"
        Me.rButtonRoundTrip.UseVisualStyleBackColor = True
        '
        'rButtonOneWay
        '
        Me.rButtonOneWay.AutoSize = True
        Me.rButtonOneWay.Location = New System.Drawing.Point(7, 19)
        Me.rButtonOneWay.Name = "rButtonOneWay"
        Me.rButtonOneWay.Size = New System.Drawing.Size(70, 17)
        Me.rButtonOneWay.TabIndex = 0
        Me.rButtonOneWay.TabStop = True
        Me.rButtonOneWay.Text = "One Way"
        Me.rButtonOneWay.UseVisualStyleBackColor = True
        '
        'lblPNR
        '
        Me.lblPNR.AutoSize = True
        Me.lblPNR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNR.Location = New System.Drawing.Point(7, 20)
        Me.lblPNR.Name = "lblPNR"
        Me.lblPNR.Size = New System.Drawing.Size(41, 13)
        Me.lblPNR.TabIndex = 0
        Me.lblPNR.Text = "PNR: "
        '
        'groupBoxReservationStatus
        '
        Me.groupBoxReservationStatus.Controls.Add(Me.btnClearStatus)
        Me.groupBoxReservationStatus.Controls.Add(Me.lblTotalCost)
        Me.groupBoxReservationStatus.Controls.Add(Me.lblSeatCount)
        Me.groupBoxReservationStatus.Controls.Add(Me.lblDestination)
        Me.groupBoxReservationStatus.Controls.Add(Me.lblOrigin)
        Me.groupBoxReservationStatus.Controls.Add(Me.lblPNR)
        Me.groupBoxReservationStatus.Location = New System.Drawing.Point(12, 500)
        Me.groupBoxReservationStatus.Name = "groupBoxReservationStatus"
        Me.groupBoxReservationStatus.Size = New System.Drawing.Size(265, 161)
        Me.groupBoxReservationStatus.TabIndex = 2
        Me.groupBoxReservationStatus.TabStop = False
        Me.groupBoxReservationStatus.Text = "Reservation Status"
        '
        'btnClearStatus
        '
        Me.btnClearStatus.Location = New System.Drawing.Point(93, 132)
        Me.btnClearStatus.Name = "btnClearStatus"
        Me.btnClearStatus.Size = New System.Drawing.Size(75, 23)
        Me.btnClearStatus.TabIndex = 5
        Me.btnClearStatus.Text = "Clear"
        Me.btnClearStatus.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(7, 113)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(105, 13)
        Me.lblTotalCost.TabIndex = 4
        Me.lblTotalCost.Text = "Total Cost: $0.00"
        '
        'lblSeatCount
        '
        Me.lblSeatCount.AutoSize = True
        Me.lblSeatCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatCount.Location = New System.Drawing.Point(7, 89)
        Me.lblSeatCount.Name = "lblSeatCount"
        Me.lblSeatCount.Size = New System.Drawing.Size(54, 13)
        Me.lblSeatCount.TabIndex = 3
        Me.lblSeatCount.Text = "Seats: 1"
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.Location = New System.Drawing.Point(6, 66)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(109, 13)
        Me.lblDestination.TabIndex = 2
        Me.lblDestination.Text = "Destination: None"
        '
        'lblOrigin
        '
        Me.lblOrigin.AutoSize = True
        Me.lblOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigin.Location = New System.Drawing.Point(6, 43)
        Me.lblOrigin.Name = "lblOrigin"
        Me.lblOrigin.Size = New System.Drawing.Size(78, 13)
        Me.lblOrigin.TabIndex = 1
        Me.lblOrigin.Text = "Origin: None"
        '
        'groupBoxReservationLookup
        '
        Me.groupBoxReservationLookup.Controls.Add(Me.btnRetrieve)
        Me.groupBoxReservationLookup.Controls.Add(Me.txtBoxLookupPNR)
        Me.groupBoxReservationLookup.Controls.Add(Me.txtBoxLookupName)
        Me.groupBoxReservationLookup.Controls.Add(Me.lblNamePNR)
        Me.groupBoxReservationLookup.Location = New System.Drawing.Point(283, 12)
        Me.groupBoxReservationLookup.Name = "groupBoxReservationLookup"
        Me.groupBoxReservationLookup.Size = New System.Drawing.Size(265, 123)
        Me.groupBoxReservationLookup.TabIndex = 3
        Me.groupBoxReservationLookup.TabStop = False
        Me.groupBoxReservationLookup.Text = "Reservation Lookup"
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(86, 91)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(75, 23)
        Me.btnRetrieve.TabIndex = 17
        Me.btnRetrieve.Text = "Retrieve"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'txtBoxLookupPNR
        '
        Me.txtBoxLookupPNR.Location = New System.Drawing.Point(131, 65)
        Me.txtBoxLookupPNR.Name = "txtBoxLookupPNR"
        Me.txtBoxLookupPNR.Size = New System.Drawing.Size(119, 20)
        Me.txtBoxLookupPNR.TabIndex = 19
        '
        'txtBoxLookupName
        '
        Me.txtBoxLookupName.Location = New System.Drawing.Point(6, 65)
        Me.txtBoxLookupName.Name = "txtBoxLookupName"
        Me.txtBoxLookupName.Size = New System.Drawing.Size(108, 20)
        Me.txtBoxLookupName.TabIndex = 18
        '
        'lblNamePNR
        '
        Me.lblNamePNR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lblNamePNR.ForeColor = System.Drawing.Color.Red
        Me.lblNamePNR.Location = New System.Drawing.Point(-3, 39)
        Me.lblNamePNR.Name = "lblNamePNR"
        Me.lblNamePNR.Size = New System.Drawing.Size(253, 23)
        Me.lblNamePNR.TabIndex = 17
        Me.lblNamePNR.Text = "      LAST NAME                     PNR"
        '
        'groupBoxReservationManagement
        '
        Me.groupBoxReservationManagement.Controls.Add(Me.btnLogout)
        Me.groupBoxReservationManagement.Controls.Add(Me.btnACom)
        Me.groupBoxReservationManagement.Controls.Add(Me.btnCReserv)
        Me.groupBoxReservationManagement.Controls.Add(Me.lblManagementTotalCost)
        Me.groupBoxReservationManagement.Controls.Add(Me.lblManagementSeatCount)
        Me.groupBoxReservationManagement.Controls.Add(Me.lblManagementDestination)
        Me.groupBoxReservationManagement.Controls.Add(Me.lblManagementOrigin)
        Me.groupBoxReservationManagement.Controls.Add(Me.lblManagementPNR)
        Me.groupBoxReservationManagement.Location = New System.Drawing.Point(283, 141)
        Me.groupBoxReservationManagement.Name = "groupBoxReservationManagement"
        Me.groupBoxReservationManagement.Size = New System.Drawing.Size(265, 197)
        Me.groupBoxReservationManagement.TabIndex = 5
        Me.groupBoxReservationManagement.TabStop = False
        Me.groupBoxReservationManagement.Text = "Reservation Management"
        Me.groupBoxReservationManagement.Visible = False
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(184, 160)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 22
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnACom
        '
        Me.btnACom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnACom.Location = New System.Drawing.Point(86, 160)
        Me.btnACom.Name = "btnACom"
        Me.btnACom.Size = New System.Drawing.Size(92, 23)
        Me.btnACom.TabIndex = 21
        Me.btnACom.Text = "Add Comments"
        Me.btnACom.UseVisualStyleBackColor = True
        '
        'btnCReserv
        '
        Me.btnCReserv.Location = New System.Drawing.Point(6, 160)
        Me.btnCReserv.Name = "btnCReserv"
        Me.btnCReserv.Size = New System.Drawing.Size(75, 23)
        Me.btnCReserv.TabIndex = 20
        Me.btnCReserv.Text = "Cancel"
        Me.btnCReserv.UseVisualStyleBackColor = True
        '
        'lblManagementTotalCost
        '
        Me.lblManagementTotalCost.AutoSize = True
        Me.lblManagementTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManagementTotalCost.Location = New System.Drawing.Point(5, 135)
        Me.lblManagementTotalCost.Name = "lblManagementTotalCost"
        Me.lblManagementTotalCost.Size = New System.Drawing.Size(105, 13)
        Me.lblManagementTotalCost.TabIndex = 4
        Me.lblManagementTotalCost.Text = "Total Cost: $0.00"
        '
        'lblManagementSeatCount
        '
        Me.lblManagementSeatCount.AutoSize = True
        Me.lblManagementSeatCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManagementSeatCount.Location = New System.Drawing.Point(5, 106)
        Me.lblManagementSeatCount.Name = "lblManagementSeatCount"
        Me.lblManagementSeatCount.Size = New System.Drawing.Size(54, 13)
        Me.lblManagementSeatCount.TabIndex = 3
        Me.lblManagementSeatCount.Text = "Seats: 1"
        '
        'lblManagementDestination
        '
        Me.lblManagementDestination.AutoSize = True
        Me.lblManagementDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManagementDestination.Location = New System.Drawing.Point(7, 74)
        Me.lblManagementDestination.Name = "lblManagementDestination"
        Me.lblManagementDestination.Size = New System.Drawing.Size(109, 13)
        Me.lblManagementDestination.TabIndex = 2
        Me.lblManagementDestination.Text = "Destination: None"
        '
        'lblManagementOrigin
        '
        Me.lblManagementOrigin.AutoSize = True
        Me.lblManagementOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManagementOrigin.Location = New System.Drawing.Point(7, 46)
        Me.lblManagementOrigin.Name = "lblManagementOrigin"
        Me.lblManagementOrigin.Size = New System.Drawing.Size(78, 13)
        Me.lblManagementOrigin.TabIndex = 1
        Me.lblManagementOrigin.Text = "Origin: None"
        '
        'lblManagementPNR
        '
        Me.lblManagementPNR.AutoSize = True
        Me.lblManagementPNR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManagementPNR.Location = New System.Drawing.Point(7, 16)
        Me.lblManagementPNR.Name = "lblManagementPNR"
        Me.lblManagementPNR.Size = New System.Drawing.Size(37, 13)
        Me.lblManagementPNR.TabIndex = 0
        Me.lblManagementPNR.Text = "PNR:"
        '
        'timerSystem
        '
        Me.timerSystem.Enabled = True
        '
        'frmAirline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 663)
        Me.Controls.Add(Me.groupBoxReservationManagement)
        Me.Controls.Add(Me.groupBoxReservationLookup)
        Me.Controls.Add(Me.groupBoxReservationStatus)
        Me.Controls.Add(Me.groupBoxReservation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAirline"
        Me.Text = "RCSJ Airline Inc."
        Me.groupBoxReservation.ResumeLayout(False)
        Me.groupBoxReservation.PerformLayout()
        Me.groupBoxReservationStatus.ResumeLayout(False)
        Me.groupBoxReservationStatus.PerformLayout()
        Me.groupBoxReservationLookup.ResumeLayout(False)
        Me.groupBoxReservationLookup.PerformLayout()
        Me.groupBoxReservationManagement.ResumeLayout(False)
        Me.groupBoxReservationManagement.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBoxReservation As GroupBox
    Friend WithEvents lblReservation As Label
    Friend WithEvents rButtonRoundTrip As RadioButton
    Friend WithEvents rButtonOneWay As RadioButton
    Friend WithEvents lblCost As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBoxSeatCount As TextBox
    Friend WithEvents txtBoxPassengerName As TextBox
    Friend WithEvents lblNameSeats As Label
    Friend WithEvents lblFare As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents listBoxOrigin As ListBox
    Friend WithEvents btnInfoClear As Button
    Friend WithEvents btnInfoNext As Button
    Friend WithEvents btnInfoSelect As Button
    Friend WithEvents btnReserve As Button
    Friend WithEvents lblPNR As Label
    Friend WithEvents groupBoxReservationStatus As GroupBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblSeatCount As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblOrigin As Label
    Friend WithEvents groupBoxReservationLookup As GroupBox
    Friend WithEvents btnRetrieve As Button
    Friend WithEvents txtBoxLookupPNR As TextBox
    Friend WithEvents txtBoxLookupName As TextBox
    Friend WithEvents lblNamePNR As Label
    Friend WithEvents groupBoxReservationManagement As GroupBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnACom As Button
    Friend WithEvents btnCReserv As Button
    Friend WithEvents lblManagementTotalCost As Label
    Friend WithEvents lblManagementSeatCount As Label
    Friend WithEvents lblManagementDestination As Label
    Friend WithEvents lblManagementOrigin As Label
    Friend WithEvents lblManagementPNR As Label
    Friend WithEvents timerSystem As Timer
    Friend WithEvents btnRestart As Button
    Friend WithEvents listBoxDestination As ListBox
    Friend WithEvents lblReservation2 As Label
    Friend WithEvents btnClearStatus As Button
End Class
