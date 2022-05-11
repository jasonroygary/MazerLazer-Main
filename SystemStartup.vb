Imports System
Imports System.Text
Imports System.Threading
Imports System.IO.Ports
Imports System.Xml
Imports System.IO
Imports System.Xml.XPath
Imports Mommo.Data

Public Class SystemStartup
    Private Sub SystemStartup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        UpdateUX()
        'ScoreboardScreenActivate()
        setSystemMode(3) 'ALIGN SYSTEM
    End Sub
    Private Sub UpdateUX()
        textLaserCount.Text = CStr(laserCount)
        textLaserCountRed.Text = CStr(laserCountRed)
        textLaserCountGreen.Text = CStr(laserCountGreen)
        textLaserCountBlue.Text = CStr(laserCountBlue)
        textLaserCountDisabled.Text = CStr(laserCountDisabled)
        AlignmentProgressBar.Value = alignmentProgress
        If alignmentStatus = 1 Then
            timerUX.Enabled = False
            tscreenInsertPaymentScreen.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub timerStartAlignment_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerStartAlignment.Tick
        'alignment()
        'timerStartAlignment.Enabled = False
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

    Private Sub timerUX_Tick(sender As System.Object, e As System.EventArgs) Handles timerUX.Tick
        UpdateUX()
    End Sub
End Class