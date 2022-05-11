Imports System.IO
Imports System
Imports System.Text
Imports System.Threading
Imports System.IO.Ports
Imports Mommo.Data
Imports MPOST

Friend Module SystemGlobal
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'STOP WATCHES - TIMERS
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    Public systemClock As New Stopwatch 'SYSTEM CLOCK (TIME SINCE STARTED)
    Public gameClock As New Stopwatch 'GAME CLOCK
    Public xbeeOutboundClock As New Stopwatch 'CLOCK TO MEASURE TIME DIFFERENCES IN SENDING PACKETS

    'STOP WATCHES TIME MONITORS
    Public alignmentLastMin As Integer = 0
    Public hazeLastMin As Integer = 0
    Public hazeStartMin As Integer = 0
    '//////////////////////////////////////////////////////////////

    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'SERIAL PORT SETTINGS
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    Public SerialPortBCNumber As String
    Public SerialPortXbeeNumber As String
    Public SerialPortBillReaderNumber As String
    Public SerialPortSensorNumber As String
    '//////////////////////////////////////////////////////////////

    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'THREADS AND FORM DELEGATES
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    Public threadSystemMode As Thread
    Public threadOutboundXbee As Thread
    Public threadTCPIPServer As Thread

    'FORM DELEGATES
    Friend formConsole As ConsoleScreen
    Friend formScoreboard As ScoreboardScreen
    Friend formAttractScreen As tscreenInsertPaymentScreen
    '//////////////////////////////////////////////////////////////

    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'SYSTEM STACKS
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'WE ARE STORING EVERYTHING AS A INTEGER (CONVERT TO PROCESS IF NECESSARY)
    Public globalConfigStack
    Public towerConfigStack
    Public laserConfigStack
    Public sensorConfigStack
    Public relayConfigStack
    Public buttonConfigStack
    'GAME STACK
    Public gameStack
    'GLOBALS FOR STACK STATE
    Public laserColNames(5) As String
    Public sensorColNames(4) As String
    '/////////////////////////////////////////////////////////////

    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'SYSTEM MODES
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    Public systemMode As Integer = 0
    Public onOff As Integer = 1 '0=OFF, 1=ON
    Public gameType As Integer = 0
    Public pseOnOff As Integer = 0
    Public standbyFlag As Integer = 0 'EVERYTHING HAS BEEN TURNED OFF
    Public xbeeRetries As Integer = 5 'HOW MANY TIMES WE RESEND THE PACKET IF IT FAILS OR THERE IS NO RESPONSE
    Public xbeeRetryTiming As Integer = 200 'HOW MANY MS WE WAIT BEFORE RETRYING THE PACKET
    Public printScorecard As Integer = 0
    'HAZE
    Public hazeTower As Integer
    Public hazeRelay As Integer
    Public hazeInterval As Integer
    Public hazeLength As Integer
    Public hazeOnOff As Integer = 0
    Public hazeStartUp As Integer = 1
    '/////////////////////////////////////////////////////////////

    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'GAME AND SCORE VARIABLES
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    Public gameRunning As Integer = 0 '0=NO, 1=YES
    Public gameDate
    Public gameTime 'AMOUNT OF TIME AVAILABLE FOR THE GAME
    Public gameDifficulity As Integer = 3
    Public gameTimeRemaining 'TIME REMAINING FOR THE GAME
    Public gamePlayer As String = ""
    Public gamePlayerNumber As Integer = 0
    Public gameScore
    Public gameButtonsPressed As Integer = 0
    Public gameTurnButton As Integer = 0
    Public gameBeamsBroken As Integer = 0
    Public gameBeamsBrokenRed As Integer = 0
    Public gameBeamsBrokenGreen As Integer = 0
    Public gameBeamsBrokenBlue As Integer = 0
    Public gamePlayerLevel
    Public gamePSE As Integer = 0 '0=OFF, 1 = ON
    Public gameExited As Integer = 0

    Public gameDifficulityLabels(3)

    Public lasersAligned As Integer = 0
    Public sensorsDisabled As Integer = 0
    Public sensorsOn As Integer = 0
    '/////////////////////////////////////////////////////////////

    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'DEBUG
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'DEBUG FILE PATH
    Public debugFilePath As String
    Public debugFlag As Integer = 0 '0=OFF, 1=ON TO SCREEN, 2=ON TO FILE
    '/////////////////////////////////////////////////////////////
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'BAR CODES
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    Public barcodeGameCredit As String
    '/////////////////////////////////////////////////////////////

    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'OPERATIONAL DATA
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'INI FILE LOCATION
    Friend objIniFile As New IniFile("c:\MazerLazer\MazerLazer.ini")
    'GLOBAL VARIABLES
    Public towerCount As Integer
    Public AttractScreenPhotoCount As Integer
    Public OneGamePrice As Integer
    Public ThreeGamePrice As Integer
    Public CameraURL As String
    Public sensorThreshold As Integer
    'SOUND
    Public soundBackgroundTower
    Public soundEffectTowers
    'LASER DATA
    Public laserCount As Integer = 0
    Public laserCountRed As Integer = 0
    Public laserCountGreen As Integer = 0
    Public laserCountBlue As Integer = 0
    Public laserCountDisabled As Integer = 0
    'PLAYER LEVEL DATA
    Public playerLevels
    Public playerLevelPoints

    Public setLaserColor As Integer = 9 '9=DEACTIVATED
    '/////////////////////////////////////////////////////////////

    'MANAGE BILL ENTRY
    Public currentBalance As Integer = 0 'CURRENT BALANCE IN BILL COLLECTOR
    Public currentBalanceChange As Integer = 0 'IF 0 THEN NO CHANGE IF 1 THEN CHANGE
    Public transactionType As Integer = 0 '0=CASH, 1=TICKET, 2=ADMIN TICKET

    'START FLAGS
    Public closeAttractFormFlag As Integer = 0
    Public mazeEntered As Integer = 0

    Public checksumProcessStack As New List(Of Integer)
    Public dataProcessStack As New List(Of String)
    Public checksumOutboundStack As New List(Of Integer)

    'CHECK PACKET ID FOR XBEE
    Public pIDLast As Integer

    'ALIGNMENT PROGRESS BAR
    Public alignmentProgress As Integer
    Public alignmentStatus As Integer = 0


    Public stackArray() As String 'FOR PROCESSING INBOUND SERIAL DATA
    Public stackList As New List(Of String) 'FOR PROCESSING INBOUND SERIAL DATA

    Public ticketPrintCount As Integer = 2

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max + 1)
    End Function
    Public Sub startupInit()
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'GET INI Parameters
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'DEBUG PATH
        debugFilePath = objIniFile.GetString("STARTUP", "DebugFilePath", "(none)")
        writeDebug("SYSTEM STARTUP")
        writeDebug("SYSTEM INIT START")
        'DOMINO
        dominoServer = objIniFile.GetString("DOMINO", "Server", "(none)")
        dominoDatabase = objIniFile.GetString("DOMINO", "DatabasePath", "(none)")
        dominoPassword = objIniFile.GetString("DOMINO", "UserPswd", "(none)")
        playerDatabasePath = objIniFile.GetString("DOMINO", "PlayerDatabasePath", "(none)")

        writeDebug("INI FILE ACCESS COMPLETE")

        'GET ACCESS TO DOMINO DATABASE
        writeDebug("DOMINO INIT START")
        dominoInit()
        writeDebug("DOMINO INIT END")
        writeDebug("DOMINO DATA ACCESS START")
        Dim configDocument As Domino.NotesDocument
        configDocument = ndDatabase.GetProfileDocument("config")
        dominoTowerView = ndDatabase.GetView("viewTower")
        dominoGameView = ndDatabase.GetView("viewGame")
        dominoGameDocument = dominoGameView.GetDocumentByKey("Maze")
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'GET CONFIGURATION FROM DOMINO
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'TOWER COUNT
        dominoObject = configDocument.GetItemValue("configTowerCount")
        towerCount = CInt(dominoObject(0))
        'ATTRACT SCREEN PHOTO COUNT
        dominoObject = configDocument.GetItemValue("configAttractScreenPhotoCount")
        AttractScreenPhotoCount = CInt(dominoObject(0))
        'ONE GAME PRICE
        dominoObject = configDocument.GetItemValue("configOneGamePrice")
        OneGamePrice = CInt(dominoObject(0))
        'THREE GAME PRICE
        dominoObject = configDocument.GetItemValue("configThreeGamePrice")
        ThreeGamePrice = CInt(dominoObject(0))
        'SERIAL PORTS
        dominoObject = configDocument.GetItemValue("configSerialPortBC")
        SerialPortBCNumber = dominoObject(0)
        dominoObject = configDocument.GetItemValue("configSerialPortXBee")
        SerialPortXbeeNumber = dominoObject(0)
        dominoObject = configDocument.GetItemValue("configSerialPortBillReader")
        SerialPortBillReaderNumber = dominoObject(0)
        dominoObject = configDocument.GetItemValue("configSerialPortSensor")
        SerialPortSensorNumber = dominoObject(0)
        'CAMERA
        dominoObject = configDocument.GetItemValue("configCameraURL")
        CameraURL = dominoObject(0)

        'SENSOR THRESHOLD
        dominoObject = configDocument.GetItemValue("configSensorThreshold")
        sensorThreshold = CInt(dominoObject(0))
        'TOWER SOUND
        dominoObject = configDocument.GetItemValue("configSoundBackgroundTower")
        soundBackgroundTower = CInt(dominoObject(0))
        dominoObject = configDocument.GetItemValue("configSoundEffectTowers")
        soundEffectTowers = dominoObject
        'DEBUG MODE
        dominoObject = configDocument.GetItemValue("configDebugMode")
        'debugFlag = CInt(dominoObject(0))
        'PLAYER LEVELS
        dominoObject = configDocument.GetItemValue("configPlayerLevels")
        playerLevels = dominoObject
        'PLAYER LEVEL POINTS
        dominoObject = configDocument.GetItemValue("configPlayerLevelPoints")
        playerLevelPoints = dominoObject
        'PSE WARNING ENABLED DISABLED
        dominoObject = configDocument.GetItemValue("configPSEWarning")
        pseOnOff = CInt(dominoObject(0))

        'HAZE VARIABLES
        dominoObject = configDocument.GetItemValue("configHazerTower")
        hazeTower = CInt(dominoObject(0))
        dominoObject = configDocument.GetItemValue("configHazerRelay")
        hazeRelay = CInt(dominoObject(0))
        dominoObject = configDocument.GetItemValue("configHazerInterval")
        hazeInterval = CInt(dominoObject(0))
        dominoObject = configDocument.GetItemValue("configHazerLength")
        hazeLength = CInt(dominoObject(0))

        'BARCODE CODE FOR GAME CREDIT (i.e. PARTY MODE)
        dominoObject = configDocument.GetItemValue("configBCodeGameCredit")
        barcodeGameCredit = (dominoObject(0))
        writeDebug("DOMINO DATA ACCESS END")
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'POPULATE CONFIG STACKS
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'LASER STACK
        'COLUMN NAMES FOR LASER STACK STATUS DISPLAY
        laserColNames(0) = "Tower"
        laserColNames(1) = "ID"
        laserColNames(2) = "ST"
        laserColNames(3) = "S-ID"
        laserColNames(4) = "Color"
        laserColNames(5) = "Status"

        towerPosition = 1
        towerProgression = 0
        laserProgression = 0
        ReDim laserConfigStack((CInt(towerCount) * 6) - 1, 5) 'towerid, laserid , sensor tower id, sensor id, color, status
        For x = 0 To (CInt(towerCount) * 6) - 1
            'GET TOWER DOMINO DOCUMENT
            towerID = "100" + CStr(towerPosition)
            towerDocument = dominoTowerView.GetDocumentByKey(towerID)
            towerField = "towerLaserColor" + CStr(laserProgression)
            dominoObject = towerDocument.GetItemValue(towerField)
            laserColor = CInt(dominoObject(0))
            laserConfigStack(x, 0) = towerPosition
            laserConfigStack(x, 1) = laserProgression
            laserConfigStack(x, 2) = 0 'Sensor Tower ID
            laserConfigStack(x, 3) = 0 'Sensor ID
            laserConfigStack(x, 4) = laserColor
            laserConfigStack(x, 5) = 0
            towerProgression = towerProgression + 1
            If towerProgression = 6 Then
                towerProgression = 0
                laserProgression = 0
                towerPosition = towerPosition + 1
            Else
                laserProgression = laserProgression + 1
            End If
        Next

        'SENSOR STACK
        sensorColNames(0) = "Tower"
        sensorColNames(1) = "ID"
        sensorColNames(2) = "LT"
        sensorColNames(3) = "L-ID"
        sensorColNames(4) = "Status"
        towerPosition = 1
        towerProgression = 0
        sensorProgression = 0

        ReDim sensorConfigStack((CInt(towerCount) * 6) - 1, 4) 'towerid, sensorid , laser tower id, laser id, status
        For x = 0 To (CInt(towerCount) * 6) - 1
            'GET TOWER DOMINO DOCUMENT
            towerID = "100" + CStr(towerPosition)
            towerDocument = dominoTowerView.GetDocumentByKey(towerID)
            towerField = "towerSensorStatus" + CStr(sensorProgression)
            dominoObject = towerDocument.GetItemValue(towerField)
            sensorStatus = CInt(dominoObject(0))

            sensorConfigStack(x, 0) = towerPosition
            sensorConfigStack(x, 1) = sensorProgression
            sensorConfigStack(x, 2) = 0
            sensorConfigStack(x, 3) = 0
            sensorConfigStack(x, 4) = sensorStatus

            towerProgression = towerProgression + 1
            If towerProgression = 6 Then
                towerProgression = 0
                sensorProgression = 0
                towerPosition = towerPosition + 1
            Else
                sensorProgression = sensorProgression + 1
            End If
        Next

        'TOWER STACK
        ReDim towerConfigStack(CInt(towerCount) - 1, 8)
        For x = 0 To (CInt(towerCount) - 1)
            towerConfigStack(x, 0) = objIniFile.GetString("TOWER" & CStr(x + 1), "tower_id", "(none)")
            towerConfigStack(x, 1) = objIniFile.GetString("TOWER" & CStr(x + 1), "status", "(none)")
            towerConfigStack(x, 2) = objIniFile.GetString("TOWER" & CStr(x + 1), "music_enabled", "(none)")
            towerConfigStack(x, 3) = objIniFile.GetString("TOWER" & CStr(x + 1), "button_attached", "(none)")
        Next

        'RELAY STACK
        ReDim relayConfigStack(CInt(towerCount) - 1, 8)
        For x = 0 To (CInt(towerCount) - 1)
            relayConfigStack(x, 0) = objIniFile.GetString("TOWER" & CStr(x + 1), "relay1", "(none)")
            relayConfigStack(x, 1) = objIniFile.GetString("TOWER" & CStr(x + 1), "relay2", "(none)")
        Next
        'BUTTON STACK
        ReDim buttonConfigStack(CInt(towerCount) - 1, 2)
        For x = 0 To (CInt(towerCount) - 1)
            'GET TOWER DOMINO DOCUMENT
            towerID = "100" + CStr(x + 1)
            towerDocument = dominoTowerView.GetDocumentByKey(towerID)
            towerField = "towerButton"
            dominoObject = towerDocument.GetItemValue(towerField)
            towerButton = CInt(dominoObject(0))
            buttonConfigStack(x, 0) = CInt(x + 1) 'TOWER ID
            buttonConfigStack(x, 1) = CInt(towerButton) 'ENABLED, DISABLED, TURN
            buttonConfigStack(x, 2) = 0 'PRESSED
        Next
        'INITALIZE XBEE OUTGOING STACK
        For x = 0 To 255
            xbeeOutGoingStack(x, 0) = 0 'PACKET ARRAY
            xbeeOutGoingStack(x, 1) = 0 'PACKET LENGTH
            'STATUS
            Select Case x
                Case 0
                    xbeeOutGoingStack(x, 2) = 4 'STATUS BLOCKED
                Case 17
                    xbeeOutGoingStack(x, 2) = 4 'STATUS BLOCKED
                Case 19
                    xbeeOutGoingStack(x, 2) = 4 'STATUS BLOCKED
                Case 254
                    xbeeOutGoingStack(x, 2) = 4 'STATUS BLOCKED
                Case 255
                    xbeeOutGoingStack(x, 2) = 4 'STATUS BLOCKED
                Case Else
                    xbeeOutGoingStack(x, 2) = 0 'STATUS
            End Select

            xbeeOutGoingStack(x, 3) = 0 'TIME SENT
            xbeeOutGoingStack(x, 4) = 0 'RETRIES
        Next
        'GET LASER COUNT WITH COLOR
        '0 = RED, 1=GREEN, 2=BLUE, 3=DISABLED
        writeDebug("DOMINO LASER COUNT START")
        getLaserCount()
        writeDebug("DOMINO LASER COUNT END")

        'GAME DIFFICULITIY LABELS
        gameDifficulityLabels(0) = "LAME"
        gameDifficulityLabels(1) = "FUN"
        gameDifficulityLabels(2) = "WICKED"
        gameDifficulityLabels(3) = "INSANE"

        writeDebug("SYSTEM INIT END")
    End Sub
    Public Sub setSystemMode(sMode As Integer)
        standbyFlag = 0
        systemMode = sMode
        tcpipSendMessage("1*" + CStr(systemMode))
    End Sub

    Public Sub threadExecutionSystemMode()
        'SYSTEM MODES: 0=SHUTDOWN/SUSPEND, 1=ATTRACT, 2=PLAY, 3=AUTO ALIGN, 4 = MANUAL ALIGN
        'ON OFF 1=ON 2=OFF
        Do
            If systemMode = 0 Then 'SHUTDOWN
                If standbyFlag = 0 Then
                    resetSensors(0)
                    Thread.Sleep(300)
                    updateSensors() 'UPDATES THE SENSOR STATE AFTER ALIGNMENT
                    Thread.Sleep(400)
                    monitorSensorsOff(0)
                    Thread.Sleep(100)
                    allLasersOff(0)
                    allLasersOff(0)
                    allLasersOff(0)
                    allLasersOff(0)

                    relaysOffExceptHaze()
                    buttonLightOff(0)
                    'setSensorThreshold(0)
                    standbyFlag = 1
                End If
            ElseIf systemMode = 1 Then
                standbyFlag = 0
                attract()
            ElseIf systemMode = 2 Then
                'PLAY MODE
                standbyFlag = 0
                gameMazeExecution()
            ElseIf systemMode = 3 Then
                'ALIGN MODE
                standbyFlag = 0
                alignment()
            ElseIf systemMode = 4 Then 'MANUAL ALIGN
                If standbyFlag = 0 Then
                    allLasersOn(0) 'TURN ON ALL LASERS
                    standbyFlag = 1 'USE STANDBY FLAG TO KEEP US FROM TURNING THE LASERS ON OVER AND OVER AGAIN
                End If
                'GET STATUS OF LASERS EVERY SECOND AND IF A REMOTE CONSOLE
                'IS CONNECTED, SEND STATUS
                'Dim sensorUpdateClock As Stopwatch = Stopwatch.StartNew() 'GAME CLOCK STARTED
                UpdateSensorStatus()
                Thread.Sleep(500)
            ElseIf systemMode = 5 Then 'DETERMINE LASER COLORS
                standbyFlag = 0
                x = 1
                y = 0
                'TURN ON FIRST LASER
                For x = 1 To towerCount
                    'GET TOWER DOMINO DOCUMENT
                    towerID = "100" + CStr(x)
                    dominoTowerDocument = dominoTowerView.GetDocumentByKey(towerID)
                    For y = 0 To 5
                        laserOn(x, y)
                        Do
                            If setLaserColor <> 9 Then
                                towerField = "towerLaserColor" + CStr(y)
                                dominoTowerDocument.ReplaceItemValue(towerField, setLaserColor)
                                dominoTowerDocument.Save(False, True)
                                setLaserColor = 9
                                Exit Do
                            End If
                        Loop
                        laserOff(x, y)
                    Next
                Next
                setSystemMode(0)
            End If
            If alignmentStatus = 0 Then
                alignmentLastMin = 0
            Else
                alignmentLastMin = systemClock.Elapsed.Minutes - alignmentLastMin
            End If
            If onOff = 1 Then
                'SYSTEM IS ON
                'HAZE TIMER PROCESS
                If hazeStartUp = 1 Then
                    'START HAZE AT STARTUP
                    If hazeOnOff = 0 Then 'WE ARE CURRENTLY NOT HAZING
                        'START HAZING
                        relayOn(hazeTower, hazeRelay)
                        hazeStartMin = systemClock.Elapsed.Minutes
                        hazeOnOff = 1
                        hazeStartUp = 0
                    End If
                End If
                If CInt(systemClock.Elapsed.Minutes) - hazeLastMin >= hazeInterval Then
                    If hazeOnOff = 0 Then 'WE ARE CURRENTLY NOT HAZING
                        'START HAZING
                        writeDebug("HAZE STARTED")
                        relayOn(hazeTower, hazeRelay)
                        hazeStartMin = systemClock.Elapsed.Minutes
                        hazeOnOff = 1
                    End If
                End If
                If CInt(systemClock.Elapsed.Minutes) - hazeStartMin >= hazeLength Then
                    'STOP HAZING
                    If hazeOnOff = 1 Then
                        relayOff(hazeTower, hazeRelay)
                        hazeLastMin = systemClock.Elapsed.Minutes
                        writeDebug("HAZE ENDED")
                        hazeOnOff = 0
                    End If
                End If
            End If
            Thread.Sleep(50)
        Loop
    End Sub
    Public Sub attract()
        standbyFlag = 0
        'relaysOn(0)
        buttonLightOn(0)
        'ATTRACT MODE
        laserPointer = 0
        'TURN ON THAT LASER
        laserPointer = GetRandom(0, UBound(laserConfigStack))
        laserOn(laserConfigStack(laserPointer, 0), laserConfigStack(laserPointer, 1))
        laserPointer = GetRandom(0, UBound(laserConfigStack))
        laserOn(laserConfigStack(laserPointer, 0), laserConfigStack(laserPointer, 1))
        laserPointer = GetRandom(0, UBound(laserConfigStack))
        laserOn(laserConfigStack(laserPointer, 0), laserConfigStack(laserPointer, 1))

        'RANDOM WAIT
        Thread.Sleep(GetRandom(0, 200))
        'TURN OFF THAT LASER
        laserPointer = GetRandom(0, UBound(laserConfigStack))
        laserOff(laserConfigStack(laserPointer, 0), laserConfigStack(laserPointer, 1))
        laserPointer = GetRandom(0, UBound(laserConfigStack))
        laserOff(laserConfigStack(laserPointer, 0), laserConfigStack(laserPointer, 1))
        laserPointer = GetRandom(0, UBound(laserConfigStack))
        laserOff(laserConfigStack(laserPointer, 0), laserConfigStack(laserPointer, 1))
        lastMS = systemClock.ElapsedMilliseconds
        'RANDOM WAIT
        Thread.Sleep(GetRandom(0, 200))
    End Sub
    Public Sub alignment()
        alignmentProgress = 0
        alignmentStatus = 0
        tcpipSendMessage("13*" + CStr(alignmentStatus))
        tcpipSendMessage("12*" + CStr(alignmentProgress))
        'Alignment Mode
        'CLEAR CURRENT ALIGNMENT
        For x = 0 To UBound(sensorConfigStack)
            laserConfigStack(x, 2) = 0
            laserConfigStack(x, 3) = 0
            sensorConfigStack(x, 2) = 0
            sensorConfigStack(x, 3) = 0
        Next

        'TURN ON EACH LASER INDIVIDUALLY, CHECK THE STATUS OF EVERY SENSOR
        'ASSIGN THE LASERS TO A SENSOR
        allLasersOff(0) 'ALL LASERS OFF
        Thread.Sleep(500) 'MAKE SURE THEY ARE OFF
        'STEP 2, TURN ON EACH LASER, ONE BY ONE
        For x = 0 To UBound(laserConfigStack)
            towerid = laserConfigStack(x, 0)
            laserid = laserConfigStack(x, 1)
            laserOn(towerid, laserid)
            Thread.Sleep(800)
            'CHECK SENSORS
            'ONLY ONE SHOULD BE ON OR WE HAVE A BIG PROBLEM
            'REQUEST SENSOR STATUS FROM TOWERS
            'CHECK THE STATUS OF THE SENSORS
            updateSensors()
            Thread.Sleep(400) 'WAIT A MINUTE FOR THEM TO CATCH UP
            For v = 0 To UBound(sensorConfigStack)
                If sensorConfigStack(v, 4) = "1" Then
                    'WE HAVE THE ONE THAT IS ON
                    sensorTower = sensorConfigStack(v, 0)
                    sensorID = sensorConfigStack(v, 1)
                    sensorConfigStack(v, 2) = towerid
                    sensorConfigStack(v, 3) = laserid
                    laserConfigStack(x, 2) = sensorTower
                    laserConfigStack(x, 3) = sensorID
                    Exit For
                End If
            Next
            laserOff(towerid, laserid)
            Thread.Sleep(300)
            alignmentProgress = x
            tcpipSendMessage("12*" + CStr(alignmentProgress))
        Next
        allLasersOff(0)
        setSystemMode(0)
        alignmentStatus = 1
        tcpipSendMessage("13*" + CStr(alignmentStatus))
        alignmentLastMin = 0
        'mainClock.Elapsed.Minutes
        tcpipSendMessage("14*" + CStr(alignmentLastMin))
        UpdateSensorStatus()
    End Sub
    Public Sub sensorPollingExecution()
        Do
            If systemMode = 2 Then
                'ONLY IN GAME MODE
                updateSensors()
                Thread.Sleep(SensorPollingInterval)
            End If
        Loop
    End Sub
    Public Sub onOFFSet(value As Integer)
        onOff = value
        tcpipSendMessage("2*" + CStr(onOff))
    End Sub
    Public Sub UpdateSensorStatus()
        updateSensors()
        Dim y As Integer
        Dim z As Integer
        Dim x As Integer
        Dim w As Integer
        For w = 0 To UBound(sensorConfigStack)
            If sensorConfigStack(w, 4) = "1" Then
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
        tcpipSendMessage("3*" + CStr(lasersAligned))
        tcpipSendMessage("4*" + CStr(sensorsDisabled))
        tcpipSendMessage("5*" + CStr(sensorsOn))

        For x = 0 To UBound(sensorConfigStack)
            tcpipSendMessage("10*" + CStr(x) + "*" + CStr(sensorConfigStack(x, 0)) + "*" + CStr(sensorConfigStack(x, 1)) + "*" + CStr(sensorConfigStack(x, 2)) + "*" + CStr(sensorConfigStack(x, 3)) + "*" + CStr(sensorConfigStack(x, 4)))
        Next
    End Sub
    Public Sub startGame(gameTypeVal, gameDiffVal)
        gameType = CInt(gameTypeVal)
        gameDifficulity = CInt(gameDiffVal)
        setSystemMode(2)
    End Sub
End Module
