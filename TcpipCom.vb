Friend Module TcpipCom
    Public WithEvents Server As UNOLibs.Net.ServerClass
    Public Client As New UNOLibs.Net.ClientClass
    Public serverPort As String = "8099"
    Public clientIPArray(5) As String
    Public clientIPArrayPointer As Integer = 0
    Public clientPort As String = "8098"
    Public Sub OnIncomingMessage(ByVal Args As UNOLibs.Net.ServerClass.InMessEvArgs) Handles Server.IncomingMessage
        Dim senderIP As String = Args.senderIP
        Dim senderData As String = Args.message
        writeDebug("INBOUND IP: " + senderIP + "  -  " + senderData)
        tcpipHandler(senderData, senderIP)
    End Sub
    Public Sub startTCPIPServer()
        'START TCPIP SERVER
        Server = New UNOLibs.Net.ServerClass(serverPort, True, "C:\")
        For x = 0 To 5
            clientIPArray(x) = ""
        Next
    End Sub
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'TCPIP HANDLERS
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    Public Sub tcpipHandler(senderData, senderIP)
        Dim dataArray() As String
        dataArray = senderData.Split("*")
        senderData = dataArray(0)
        Select Case senderData
            Case "0" 'SUBSCRIBE CLIENT WE CAN HAVE UP TO 6 CLIENTS 
                If clientIPArrayPointer = 5 Then
                    'WE ARE OUT OF CLIENT SLOTS, START AT ZERO
                    clientIPArrayPointer = 0
                End If
                clientIPArray(clientIPArrayPointer) = senderIP
                clientIPArrayPointer = clientIPArrayPointer + 1
                'RUN ON SUBSCRIBE (SEND CURRENT RELEVANT SYSTEM INFORMATION)
                'CONSTRUCT A BIG PACKET WITH ALL THE CURRENT DATA
                'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                'CLIENT ACTIONS
                'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Case "1" 'ALL LASERS ON
                allLasersOn(0)
            Case "2" 'ALL LASERS OFF
                allLasersOff(0)
            Case "3" 'All RELAYS ON
                relaysOn(0)
            Case "4" 'ALL RELAYS OFF
                relaysOff(0)
            Case "5" 'ALL BUTTON LIGHTS ON
                buttonLightOn(0)
            Case "6" 'ALL BUTTON LIGHTS OFF
                buttonLightOff(0)
            Case "7" 'STANDBY MODE
                setSystemMode(0)
            Case "8" 'ATTRACT MODE
                setSystemMode(1)
            Case "9" 'ALIGN MODE
                setSystemMode(3)
            Case "10" 'SYSTEM ON
                onOFFSet(1)
            Case "11" 'SYSTEM OFF
                onOFFSet(0)
            Case "12" 'MANUAL ALIGN MODE
                setSystemMode(4)
            Case "13" 'GET SENSOR STATUS
                UpdateSensorStatus()
            Case "14" 'RESET INI SETTINGS
                startupInit()
            Case "20" 'START GAME
                startGame(dataArray(1), dataArray(2))
            Case "30" 'SET LASER COLOR
                setLaserColor = CInt(dataArray(1))
            Case "31" 'LASER COLOR ASSIGN MODE
                setSystemMode(5)
            Case "50" 'SEND SYSTEM MODE
                tcpipSendMessage("1*" + CStr(systemMode))
            Case "51" 'SEND ON OFF
                tcpipSendMessage("2*" + CStr(onOff))
            Case "52" 'SEND SIZE OF SENSOR ARRAY
                tcpipSendMessage("11*" + CStr(UBound(sensorConfigStack)))
            Case "53" 'TIME (MINS) SINCE LAST ALIGNED SENSORS
                tcpipSendMessage("14*" + CStr(alignmentLastMin))
            Case "54" 'SYSTEM UP TIME
                tcpipSendMessage("15*" + CStr(systemClock.Elapsed.Hours) + "*" + CStr(systemClock.Elapsed.Minutes))
            Case "55" 'SENSOR ALIGNMENT STATUS
                tcpipSendMessage("16*" + CStr(alignmentStatus))
                'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                'SUBCRIPTION DATA SENT TO CLIENT
                'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            Case "255" 'UNREGISTER CLIENT
                For x = 0 To 5
                    If clientIPArray(x) = senderIP Then
                        clientIPArray(x) = ""
                    End If
                Next
            Case Else
                'BAIL
        End Select
    End Sub
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'CLIENT MESSAGES
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    Public Sub tcpipSendMessage(clientMessage)
        For x = 0 To 5
            clientIP = clientIPArray(x)
            If clientIP <> "" Then
                Try
                    Client.SendMessage(clientIP, clientPort, clientMessage)
                Catch
                    writeDebug("CLIENT IP SEND FAILED")
                End Try
            End If
        Next
    End Sub
    Public Sub onClientSubscribe()
        'systemMode


    End Sub
End Module
