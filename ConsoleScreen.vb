Imports System
Imports System.Text
Imports System.Threading
Imports System.IO.Ports
Imports System.Xml
Imports System.IO
Imports System.Xml.XPath
Imports Mommo.Data

Public Class ConsoleScreen
    Private processSerialData As Thread
    Public Delegate Sub SetControlTextInvoker(ByVal ctl As Control, ByVal text As String, ByVal replace As Boolean) 'Delegate for setting text from serial thread
    Public Delegate Sub SetAlignProgressInvoker(ByVal val As Integer) 'Delegate for progress bars

    Public Delegate Sub updateTextInvoker(ByVal ctlText As String)
    Public delupdateTextInvoker As New updateTextInvoker(AddressOf updateText)

    Private Delegate Sub SetControlGridInvoker(ByVal ctl As Control)

    Private processAlignment As Thread
    Private processAttract As Thread
    Private processSensorPolling As Thread

    '/////////////////////////////////////////////////////////////
    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'STARTUP
        'GET INI SETTINGS
        startupInit()

        'START SYSTEM CLOCK
        systemClock.Start()

        'START XBEE TRANSACTION CLOCK
        xbeeOutboundClock.Start()

        'START XBEE OUTBOUND THREAD
        threadOutboundXbee = New Thread(AddressOf threadProcessXbeeOutgoingStack)
        threadOutboundXbee.IsBackground = True
        threadOutboundXbee.Start()

        'START MAIN THREAD     
        threadSystemMode = New Thread(AddressOf threadExecutionSystemMode)
        threadSystemMode.IsBackground = True
        threadSystemMode.Start()

        'START TCPIP SERVER THREAD
        threadTCPIPServer = New Thread(AddressOf startTCPIPServer)
        threadTCPIPServer.IsBackground = True
        threadTCPIPServer.Start()

        'OPEN SERIAL PORTS
        'XBEE
        With SerialPortXBee
            .PortName = SerialPortXbeeNumber
            Try
                .Open()
            Catch
                writeDebug("UNABLE TO OPEN XBEE SERIAL PORT")
            End Try
            .BaudRate = 57600
            .DtrEnable = True
            .RtsEnable = True
            'enable the oncomm event for every reveived character
            '.ReceivedBytesThreshold = 0
        End With
        systemMode = 0 'PUT SYSTEM IN STANDBY
        onOff = 1 'TURN SYSTEM ON
        'START BARCODE READER PORT
        With SerialPortBC
            .PortName = SerialPortBCNumber
            Try
                .Open()
            Catch
                writeDebug("UNABLE TO OPEN BAR CODE SERIAL PORT")
            End Try
        End With
        With SerialPortSensor
            .PortName = SerialPortSensorNumber
            Try
                .Open()
            Catch
                writeDebug("UNABLE TO OPEN SENSOR SERIAL PORT")
            End Try
        End With

        'TURN ON BARCODE READER
        sendBarCodeData("LON" & vbCr)
        'SET SYSTEM SENSOR THRESHOLD
        'setSensorThreshold(0)
        AlignmentProgressBar.Minimum = 0
        AlignmentProgressBar.Maximum = UBound(laserConfigStack)
        setSystemMode(0)
        DataGridView1.DataSource = New ArrayDataView(sensorConfigStack, sensorColNames)
    End Sub
    Private Sub updateDataGrids(ByVal ctl As Control)
        If ctl.InvokeRequired Then
            ctl.Invoke(New SetControlGridInvoker(AddressOf updateDataGrids), _
                       ctl)
        Else
            ctl.Refresh()
        End If
    End Sub
    Public Sub updateText(ByVal ctlText As String)
        formConsole.tbRawComm.Text = "EAT ME" + vbNewLine
    End Sub
    Public Sub SetControlText(ByVal ctl As Control, ByVal text As String, ByVal replace As Boolean)
        If ctl.InvokeRequired Then
            ctl.Invoke(New SetControlTextInvoker(AddressOf SetControlText), ctl, text, replace)
        Else
            If replace = True Then
                ctl.Text = text
            Else
                ctl.Text = text + ctl.Text
            End If
        End If
    End Sub
    Public Sub SetAlignProgressBar(ByVal val As Integer)
        If AlignmentProgressBar.InvokeRequired Then
            AlignmentProgressBar.Invoke(New SetAlignProgressInvoker(AddressOf SetAlignProgressBar), val)
        Else
            AlignmentProgressBar.Value = val
        End If
    End Sub


    Private Sub ScoreboardScreenActivate()
        Dim screens() As Screen = Screen.AllScreens
        ' Get the current screen and its location in the list of screens
        Dim currentScreen As Screen = Screen.FromControl(Me)
        Dim currentScreenIndex As Integer = Array.IndexOf(screens, currentScreen)

        ' Get the index of the next screen
        Dim nextScreenIndex As Integer = currentScreenIndex + 1
        If nextScreenIndex = screens.Length Then
            nextScreenIndex = 0
        End If

        ' Get the location of the window relative to the top-left corner of the current screen
        Dim locationInScreenCoordinates As New Point()
        locationInScreenCoordinates.X = Location.X - currentScreen.Bounds.X
        locationInScreenCoordinates.Y = Location.Y - currentScreen.Bounds.Y

        ' Get the location of an equivalent point on the next screen
        Dim nextScreen As Screen = screens(nextScreenIndex)
        Dim newLocation As New Point()
        newLocation.X = nextScreen.Bounds.X + locationInScreenCoordinates.X
        newLocation.Y = nextScreen.Bounds.Y + locationInScreenCoordinates.Y

        ' If the window falls outside the bounds of the next screen, move the window so that it
        ' falls within the bounds of the screen.
        If Not nextScreen.Bounds.Contains(newLocation) Then
            If nextScreen.Bounds.Right < newLocation.X Then
                newLocation.X = nextScreen.Bounds.Right - Width
            ElseIf newLocation.X < nextScreen.Bounds.Left Then
                newLocation.X = nextScreen.Bounds.Left
            End If

            If newLocation.Y < nextScreen.Bounds.Top Then
                newLocation.Y = nextScreen.Bounds.Top
            ElseIf nextScreen.Bounds.Bottom < newLocation.Y Then
                newLocation.Y = nextScreen.Bounds.Bottom - Height
            End If
        End If

        ' If the window is larger than the screen, make it fit.
        If Width > nextScreen.Bounds.Width Then
            Width = nextScreen.Bounds.Width
        End If

        If Height > nextScreen.Bounds.Height Then
            Height = nextScreen.Bounds.Height
        End If

        ScoreboardScreen.Show()
        ScoreboardScreen.Location = newLocation
        ScoreboardScreen.MaximizeBox = False

        ScoreboardScreen.MinimizeBox = False
        ScoreboardScreen.TopMost = True
        ScoreboardScreen.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        ScoreboardScreen.WindowState = System.Windows.Forms.FormWindowState.Maximized
        'Me.Location = newLocation
    End Sub

    Private Sub UpdateUX()
        'DataGridView1.Refresh()
        'DataGridView2.Refresh()
        Dim y As Integer
        Dim z As Integer
        Dim x As Integer
        Dim w As Integer
        updateListViews()
        For w = 0 To UBound(sensorConfigStack)
            If sensorConfigStack(w, 3) = "1" Then
                y = y + 1
            End If
            If sensorConfigStack(w, 3) = "4" Then
                x = x + 1
            End If
            If sensorConfigStack(w, 2) = 0 Then
            Else
                If sensorConfigStack(w, 2) <> 0 Then
                    z = z + 1
                End If
            End If
        Next
        lasersAligned = CStr(z)
        sensorsDisabled = CStr(x)
        sensorsOn = CStr(y)

        'SEND TO REMOTE CONSOLE


        textSensorsOn.Text = CStr(y)
        textLasersAligned.Text = CStr(z)
        textSensorsDisabled.Text = CStr(x)
       
        AlignmentProgressBar.Value = alignmentProgress
    End Sub
    
    Private Sub ShowArrayInListView(ByVal listView, ByVal dataArray)

        listView.Items.Clear()

        For y As Integer = dataArray.GetLowerBound(1) To dataArray.GetUpperBound(1)
            Dim lvi As New ListViewItem

            For x As Integer = dataArray.GetLowerBound(0) To dataArray.GetUpperBound(0)
                If x = 0 Then
                    lvi.Text = dataArray(x, y)
                Else
                    lvi.SubItems.Add(dataArray(x, y))
                End If
            Next
            listView.Items.Add(lvi)
        Next
    End Sub

    Private Sub timerUpdateSensors_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerUpdateSensors.Tick
        If sensorMode = 0 Then
            updateSensors()
        End If
    End Sub

    Private Sub updateListViews()
        'listViewLasers.Columns.Add("Tower", 50, HorizontalAlignment.Left)
        'listViewLasers.Columns.Add("Laser", 50, HorizontalAlignment.Left)
        'listViewLasers.Columns.Add("ST", 50, HorizontalAlignment.Left)
        'listViewLasers.Columns.Add("S-ID", 50, HorizontalAlignment.Left)
        'listViewLasers.Columns.Add("Color", 50, HorizontalAlignment.Left)
        'listViewLasers.Columns.Add("Status", 50, HorizontalAlignment.Left)

        listViewSensors.View = View.Details
        listViewSensors.Clear()

        listViewSensors.Columns.Add("Tower", 50, HorizontalAlignment.Left)
        listViewSensors.Columns.Add("Sensor", 50, HorizontalAlignment.Left)
        listViewSensors.Columns.Add("LT", 60, HorizontalAlignment.Left)
        listViewSensors.Columns.Add("L-ID", 60, HorizontalAlignment.Left)
        listViewSensors.Columns.Add("Status", 50, HorizontalAlignment.Left)

        Dim lSingleItemS As ListViewItem

        For x = 0 To UBound(sensorConfigStack)
            lSingleItemS = listViewSensors.Items.Add(CStr(sensorConfigStack(x, 0)), x)
            lSingleItemS.SubItems.Add(CStr(sensorConfigStack(x, 1)))
            lSingleItemS.SubItems.Add(CStr(sensorConfigStack(x, 2)))
            lSingleItemS.SubItems.Add(CStr(sensorConfigStack(x, 3)))
            lSingleItemS.SubItems.Add(CStr(sensorConfigStack(x, 4)))
        Next
    End Sub

    Private Sub buttonEnableSensorPolling_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TURNS OFF POLLING MODE
        'ENABLES INTERUPT MODE
        'SETS MODALITY 
        sensorMode = 1
        towerInteruptMode(1)
    End Sub


    Private Sub buttonDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonDebug.Click
        If debugFlag = 0 Then
            debugFlag = 1
        Else
            debugFlag = 0
        End If
    End Sub

    Private Sub buttonAlignSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAlignSystem.Click
        setSystemMode(3)
    End Sub

    Private Sub buttonAllLasersOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAllLasersOn.Click
        allLasersOn(0)
    End Sub

    Private Sub buttonAllLasersOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAllLasersOff.Click
        allLasersOff(0)
    End Sub

    Private Sub buttonAllRelaysOn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAllRelaysOn.Click
        relaysOn(0)
    End Sub

    Private Sub buttonAllRelaysOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAllRelaysOff.Click
        relaysOff(0)
    End Sub

    Private Sub buttonUpdateSensors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonUpdateSensors.Click
        updateSensors()
        UpdateUX()
    End Sub

    Private Sub buttonPlayMazeInsane_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonPlayMazeInsane.Click
        gameDifficulity = 3
        gameType = 0
        setSystemMode(2)
    End Sub

    
    Public Sub attractMode()
        Do
            If systemMode = 1 Then
                laserPointer = 0
                'TURN ON THAT LASER
                laserPointer = GetRandom(0, UBound(laserConfigStack) + 1)
                laserOn(laserConfigStack(laserPointer, 0), laserConfigStack(laserPointer, 1))
                laserPointer = GetRandom(0, UBound(laserConfigStack) + 1)
                laserOn(laserConfigStack(laserPointer, 0), laserConfigStack(laserPointer, 1))
                laserPointer = GetRandom(0, UBound(laserConfigStack) + 1)
                laserOn(laserConfigStack(laserPointer, 0), laserConfigStack(laserPointer, 1))

                'RANDOM WAIT
                Thread.Sleep(GetRandom(0, 200))
                'TURN OFF THAT LASER
                laserPointer = GetRandom(0, UBound(laserConfigStack) + 1)
                laserOff(laserConfigStack(laserPointer, 0), laserConfigStack(laserPointer, 1))
                laserPointer = GetRandom(0, UBound(laserConfigStack) + 1)
                laserOff(laserConfigStack(laserPointer, 0), laserConfigStack(laserPointer, 1))
                laserPointer = GetRandom(0, UBound(laserConfigStack) + 1)
                laserOff(laserConfigStack(laserPointer, 0), laserConfigStack(laserPointer, 1))
                'RANDOM WAIT
                Thread.Sleep(GetRandom(0, 200))
            End If
        Loop
    End Sub

    Private Sub buttonStandbyMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonStandbyMode.Click
        setSystemMode(0)
    End Sub

    Private Sub buttonInteruptMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sensorMode = 1
        towerInteruptMode(1)
    End Sub

    Private Sub buttonCompPolling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sensorMode = 0
        towerInteruptMode(0)
    End Sub

    Private Sub buttonSensorManMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sensorMode = 2
        towerInteruptMode(0)
    End Sub

    Private Sub buttonAttractMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAttractMode.Click
        setSystemMode(1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BillReader.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        tscreenInsertPaymentScreen.Show()
    End Sub
    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
    Private Sub timerUpdateUX_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerUpdateUX.Tick
        If printScorecard = 1 Then
            Scorecard.Show()
            printScorecard = 0
        End If
        UpdateUX()
    End Sub

    Private Sub buttonOpenPorts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GET INI SETTINGS
        startupInit()
        'OPEN SERIAL PORTS
        With SerialPortXBee
            .PortName = SerialPortXbeeNumber
            .Open()
            .BaudRate = 57600
            .DtrEnable = True
            .RtsEnable = True
            'enable the oncomm event for every reveived character
            '.ReceivedBytesThreshold = 0
        End With
        systemMode = 0
        'SYSTEM MODES: 0=ALIGNMENT, 1=ATTRACT, 2=PLAY, 3=SHUTDOWN
        'START BARCODE READER PORT
        '  With SerialPortBC
        '.PortName = SerialPortBCNumber
        '.Open()
        'End With
        'With SerialPortSensor
        ' .PortName = SerialPortSensorNumber
        '.Open()
        'End With
        ''TURN ON BARCODE READER
        'SerialPortBC.Write("LON" & vbCr)
        AlignmentProgressBar.Minimum = 0
        AlignmentProgressBar.Maximum = UBound(laserConfigStack)
    End Sub

    Private Sub buttonPlayMazeLame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonPlayMazeLame.Click
        gameDifficulity = 0
        gameType = 0
        setSystemMode(2)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'TURN ON ALL BUTTON LIGHTS
        buttonLightOn(0)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        buttonLightOff(0)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        resetSensors(0)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        tscreenPlayerID.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Scorecard.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        setSensorDelay(0)
    End Sub

    Private Sub buttonPlayMazeWicked_Click(sender As System.Object, e As System.EventArgs) Handles buttonPlayMazeWicked.Click
        gameDifficulity = 2
        gameType = 0
        setSystemMode(2)
    End Sub

    Private Sub buttonPlayMazeProfessional_Click(sender As System.Object, e As System.EventArgs) Handles buttonPlayMazeProfessional.Click
        gameDifficulity = 1
        gameType = 0
        setSystemMode(2)
    End Sub
End Class