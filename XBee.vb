
Imports System.Threading

Friend Module XBee
    Public xbeeOutGoingStack(255, 4)


    Public Function ChkSumGen(ByVal apiIdentifier() As Byte, ByVal apiAddress() As Byte, ByVal apiOption() As Byte, ByVal apiData() As Byte) As Byte
        Dim i As Integer
        Dim SumAll As Long
        Dim LastByte As Byte
        'WE HAVE TO JOIN THESE BYTE ARRAYS
        Dim data()
        ReDim data(UBound(apiData) + 5)
        data(0) = apiIdentifier(0)
        data(1) = apiIdentifier(1)
        data(2) = apiAddress(0)
        data(3) = apiAddress(1)
        data(4) = apiOption(0)
        For i = 5 To UBound(apiData) + 5
            data(i) = apiData(i - 5)
        Next
        i = 0

        'ByteCount = UBound(Data) - LBound(Data) + 1
        For i = LBound(data) To UBound(data)
            SumAll = SumAll + CLng(data(i))
        Next

        LastByte = CByte(SumAll Mod 256)
        ChkSumGen = &HFF - LastByte
        Return ChkSumGen
    End Function
    Public Function randomPacketID()
        Dim pID As Integer
        Dim random As New Random()
        pID = random.Next(1, 255)
        If pID = pIDLast Then
            pID = pID - 1
            If pID <= 0 Then
                pID = 123
            End If
        End If
        pIDLast = pID
        If pID = 17 Then
            pID = 16
        ElseIf pID = 19 Then
            pID = 16
        ElseIf pID = 19 Then

        ElseIf pID = 19 Then
        End If
        Return pID
    End Function

    Public Function PacketID()
        Dim pID As Integer = 0
        For x = 1 To 255 'WE IGNORE 0
            If xbeeOutGoingStack(x, 2) = 0 Then
                'AVAILABLE
                pID = x
                Exit For
            End If
        Next
        If pID = 0 Then
            'WE HAVE A LOCK, THERE ARE NO pID SLOTS AVAILABLE
            writeDebug("XBEE OUTGOING QUEUE LOCKED - NO SLOTS AVAILABLE")
        End If
        Return pID
    End Function

    Public Sub queueXbeePacket(ByVal sendAddress As String, ByVal cCode As String, ByVal cPara1 As String, ByVal cPara2 As String, ByVal cPara3 As String, ByVal cPara4 As String, ByVal cPara5 As String, ByVal cPara6 As String)
        Dim apiData() As Byte
        Dim byteArray() As Byte
        ReDim byteArray(6)
        byteArray(0) = CStr(cCode)
        byteArray(1) = CStr(cPara1)
        byteArray(2) = CStr(cPara2)
        byteArray(3) = CStr(cPara3)
        byteArray(4) = CStr(cPara4)
        byteArray(5) = CStr(cPara5)
        byteArray(6) = CStr(cPara6)
        apiData = byteArray

        Dim apiHeader(0) As Byte
        apiHeader(0) = &H7E

        Dim apiLength(1) As Byte
        'Set Lenght after data

        Dim apiIdentifier(1) As Byte
        apiIdentifier(0) = &H1

        'PACKET ID
        Dim pID As Integer
        pID = PacketID()

        apiIdentifier(1) = "&H" & CStr(Hex$(pID))
        'Call $Hex(RandomNumber(254, 1)

        Dim apiAddress(1) As Byte
        'apiAddress(0) = &H50
        apiAddress(0) = &H10
        'apiAddress(1) = &H1
        apiAddress(1) = &H0

        'TEST NEW FIND ADDRESS BY TEXT FIELD
        Dim addressFirstByte As String
        Dim addressSecondByte As String
        addressFirstByte = Left(sendAddress, 2)
        addressSecondByte = Right(sendAddress, 2)
        apiAddress(0) = "&H" & addressFirstByte
        apiAddress(1) = "&H" & addressSecondByte

        Dim apiOption(0) As Byte
        apiOption(0) = &H0

        apiLength(0) = &H0
        apiLength(1) = UBound(apiData) + 6

        Dim CheckSum As Byte
        CheckSum = ChkSumGen(apiIdentifier, apiAddress, apiOption, apiData)

        Dim apiCheckSum(0) As Byte
        apiCheckSum(0) = CheckSum '&HB8

        'NEED TO JOIN THESE ARRAYS
        Dim apiPacket() As Byte
        Dim i As Long
        apiPacket = apiHeader
        ReDim Preserve apiPacket(9 + UBound(apiData))
        apiPacket(0) = apiHeader(0)
        apiPacket(1) = apiLength(0)
        apiPacket(2) = apiLength(1)
        apiPacket(3) = apiIdentifier(0)
        apiPacket(4) = apiIdentifier(1)
        apiPacket(5) = apiAddress(0)
        apiPacket(6) = apiAddress(1)
        apiPacket(7) = apiOption(0)
        For i = 8 To UBound(apiData) + 8
            apiPacket(i) = apiData(i - 8)
        Next
        apiPacket(9 + UBound(apiData)) = apiCheckSum(0)
        'PUT IN STACK
        xbeeOutGoingStack(pID, 0) = apiPacket
        xbeeOutGoingStack(pID, 1) = apiPacket.Length
        xbeeOutGoingStack(pID, 2) = 1
        xbeeOutGoingStack(pID, 3) = xbeeOutboundClock.ElapsedMilliseconds
        xbeeOutGoingStack(pID, 4) = 0
    End Sub

    Public Function checkSumCalculateCheckSum(ByVal apiIdentifier, ByVal apiFrameID, ByVal statusByte)
        test1 = CInt("&H" & apiIdentifier) + CInt("&H" & apiFrameID) + CInt("&H" & statusByte)
        test2 = 255 - test1
        If test2 < 0 Then
            test2 = (test2 * -1) - 1
            test2 = 255 - test2
        End If
        test3 = Hex(test2)
        test4 = CStr(test3)
        checkSumTest = test4
        If Len(checkSumTest) = 1 Then
            checkSumTest = "0" & checkSumTest
        End If
        Return checkSumTest
    End Function

    Public Sub threadProcessXbeeOutgoingStack()
        Do
            'FIND PACKETS THAT NEED TO BE SENT
            For x = 1 To 255 'WE IGNORE 0
                If xbeeOutGoingStack(x, 2) = 1 Then 'WE HAVE NOT SENT THE PACKET
                    sendXbeePacket(x)
                ElseIf xbeeOutGoingStack(x, 2) = 2 Then 'WE ALREADY SENT IT BUT THERE IS NOT A CHECKSUM PACKET YET
                    'CHECK TIMING
                    If xbeeOutboundClock.ElapsedMilliseconds - xbeeOutGoingStack(x, 3) > xbeeRetryTiming Then
                        writeDebug("CURRENT TIME: " + CStr(xbeeOutboundClock.ElapsedMilliseconds))
                        writeDebug("XBEE PACKET RETRY LAST: " + CStr(xbeeOutGoingStack(x, 3)))
                        writeDebug("XBEE PACKET RETRY DIFFERENCE: " + CStr(xbeeOutboundClock.ElapsedMilliseconds - xbeeOutGoingStack(x, 3)))
                        'RETRY IS VALID, ENOUGH TIME HAS ELAPSED
                        'CHECK RETRIES
                        If xbeeOutGoingStack(x, 4) <= xbeeRetries Then
                            'SEND PACKET AGAIN
                            writeDebug("XBEE PACKET RETRY")
                            xbeeOutGoingStack(x, 4) = xbeeOutGoingStack(x, 4) + 1
                            sendXbeePacket(x)
                        Else
                            'WE HAVE EXCEEDED THE NUMBER OF RETRIES, THIS PACKET HAS FAILED TO BE TRANSMITTED
                            apiPacket = xbeeOutGoingStack(x, 0)
                            writeDebug("XBEE PACKET EXCEEDED RETRY LIMIT TO: " + CStr(apiPacket(5)) + " " + CStr(apiPacket(6)) + " ID: " + CStr(apiPacket(4)))
                            'CLEAR THE SLOT IN THE STACK
                            For y = 0 To 4
                                xbeeOutGoingStack(x, y) = 0
                            Next
                        End If
                    End If
                ElseIf xbeeOutGoingStack(x, 2) = 3 Then 'WE SENT IT, BUT IT FAILED WITH CHECKSUM REFERENCE TO FAILURE
                    If xbeeOutboundClock.ElapsedMilliseconds - xbeeOutGoingStack(x, 2) > xbeeRetryTiming Then
                        'RETRY IS VALID, ENOUGH TIME HAS ELAPSED
                        'CHECK RETRIES
                        If xbeeOutGoingStack(x, 4) <= xbeeRetries Then
                            'SEND PACKET AGAIN
                            xbeeOutGoingStack(x, 4) = xbeeOutGoingStack(x, 4) + 1
                            sendXbeePacket(x)
                        Else
                            'WE HAVE EXCEEDED THE NUMBER OF RETRIES, THIS PACKET HAS FAILED TO BE TRANSMITTED
                            apiPacket = xbeeOutGoingStack(x, 0)
                            writeDebug("XBEE PACKET EXCEEDED RETRY LIMIT TO: " + CStr(apiPacket(5)) + " " + CStr(apiPacket(6)) + " ID: " + CStr(apiPacket(4)))
                            'CLEAR THE SLOT IN THE STACK
                            For y = 0 To 4
                                xbeeOutGoingStack(x, y) = 0
                            Next
                        End If
                    End If
                End If
            Next
            Thread.Sleep(30)
        Loop
    End Sub

    Public Sub sendXbeePacket(x)
        If SerialPortXBee.IsOpen Then
            Try
                SerialPortXBee.Write(xbeeOutGoingStack(x, 0), 0, xbeeOutGoingStack(x, 1))
                xbeeOutGoingStack(x, 2) = 2 'STATUS TO SENT
                xbeeOutGoingStack(x, 3) = xbeeOutboundClock.ElapsedMilliseconds 'RESET SENT MS

                apiPacket = xbeeOutGoingStack(x, 0)
                cc = apiPacket(8)

                writeDebug("XBEE PACKET SENT TO: " + CStr(apiPacket(5)) + " " + CStr(apiPacket(6)) + " ID: " + CStr(apiPacket(4)) + " CC: " + CStr(cc))

            Catch
                For y = 0 To 4
                    xbeeOutGoingStack(x, y) = 0
                    writeDebug("XBEE SEND FAILURE")
                Next
            End Try

        Else
            writeDebug("XBEE SERIAL PORT CLOSED")
        End If
    End Sub
End Module