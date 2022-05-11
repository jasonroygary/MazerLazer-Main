Imports System.IO
Imports System
Imports System.Text
Imports System.Threading
Imports System.IO.Ports
Imports Mommo.Data
Friend Module Communications
    'Public WithEvents SerialPortXBee As SerialPort = New System.IO.Ports.SerialPort("COM" & SerialPortXbeeNumber, 57600, Parity.None, 8, StopBits.One)
    Public WithEvents SerialPortXBee As SerialPort = New System.IO.Ports.SerialPort("COM19", 57600, Parity.None, 8, StopBits.One)

    Public WithEvents SerialPortBC As SerialPort = New System.IO.Ports.SerialPort("COM20", 9600, Parity.Even, 7, StopBits.One)
    Public WithEvents SerialPortSensor As SerialPort = New System.IO.Ports.SerialPort("COM21", 9600, Parity.None, 8, StopBits.One)

    Dim dataReceived As String = "" 'STRING THAT HAS SERIAL BUFFER IN IT CONCAT WITH INCOMMING DATA
    Dim bufferProcessingArray(0) As String
    Dim bcdataReceived As String = ""

    Public Sub SerialPortSensor_DataReceived() Handles SerialPortSensor.DataReceived
        'SOMEONE HAS ENTERED THE MAZE

        mazeEntered = 1
    End Sub

    Public Sub SerialPortBC_DataReceived() Handles SerialPortBC.DataReceived
        Dim processFlag As Integer = 0
        Dim y As Integer
        Dim Count As Integer = SerialPortBC.BytesToRead
        Dim Buffer(0 To Count - 1) As Byte
        Dim Text2Display As String = ""
        'SerialPortBC.Read(Buffer, 0, Count)
        Dim bytesAvailable As Integer = 0
        bytesAvailable = SerialPortBC.BytesToRead
        If bytesAvailable >= 10 Then
            SerialPortBC.Read(Buffer, 0, Count)
            For y = 0 To Buffer.GetUpperBound(0) - 1
                bcdataReceived += Buffer(y).ToString("X2") & " "
            Next
            bcdataReceived = HexToString(bcdataReceived)
            If bcdataReceived = "LHTWJJL001" Then
                closeAttractFormFlag = 1

            End If
        End If
    End Sub

    Public Sub SerialPort_DataReceived() Handles SerialPortXBee.DataReceived
        'WE RECEIVED BYTES FROM THE XBEE RADIO
        'EVERYTHING WE GET WILL BE THE COMPLETE BYTE
        'BUT, WE MAY NOT GET IT ALL AT ONCE
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'PUT INBOUND BYTES IN ARRAY
        'AND CLEAN OUT ESCAPE CHARACTERS
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        Dim y As Integer
        Dim Count As Integer = SerialPortXBee.BytesToRead
        Dim dataReceivedTemp As String = ""
        Dim Buffer(0 To Count - 1) As Byte
        SerialPortXBee.Read(Buffer, 0, Count)
        For y = 0 To Buffer.GetUpperBound(0)
            dataReceivedTemp += Buffer(y).ToString("X2") & " "
        Next
        dataReceived = dataReceived + dataReceivedTemp
        'DATA IS IN STRING
        'GET RID OF THE ESCAPE CHARACTERS
        If InStr(dataReceived, "7D 33") Then
            dataReceived = dataReceived.Replace("7D 33", "13")
        End If
        'GET RID OF THE ESCAPE CHARACTERS
        If InStr(dataReceived, "7D 31") Then
            dataReceived = dataReceived.Replace("7D 31", "11")
        End If
        If dataReceived = "" Then
            Exit Sub
        End If
        'CHECK FOR 7D AT THE END OF THE STRING
        'IF WE FIND IT, BAIL FOR THIS EVENT LOOP
        writeDebug("LAST BYTE: " + Right(dataReceived, 3))
        If Right(dataReceived, 3) = "7D " Then
            dataReceived = dataReceived
            Exit Sub
        End If
        'PUT DATA RECEIVED IN AN ARRAY
        Dim tempDataArray() As String
        dataReceived = dataReceived.Trim
        tempDataArray = dataReceived.Split(" ")
        'WRITE DEBUG FOR RAW DATA
        writeDebug("DATA RECEIVED: " + dataReceived)
        'CLEAN OUT DATA RECEIVED
        dataReceived = ""
        'ADD TEMP ARRAY ONTO END OF BUFFERPROCESSINGARRAY
        Dim tempDataArrayBound As Integer = 0
        Dim bufferProcessingArrayBound As Integer = 0
        tempDataArrayBound = UBound(tempDataArray)
        bufferProcessingArrayBound = UBound(bufferProcessingArray)
        Dim resetBound As Integer = 0
        If bufferProcessingArrayBound = 0 Then
            If bufferProcessingArray(0) = "" Then
                resetBound = tempDataArrayBound
            Else
                resetBound = bufferProcessingArrayBound + tempDataArrayBound + 1
            End If
        Else
            resetBound = bufferProcessingArrayBound + tempDataArrayBound + 1
        End If
        'KEEPS ARRAY THE PERFECT SIZE FOR THE BYTE CONTENT
        ReDim Preserve bufferProcessingArray(resetBound)
        'PUT BYTES IN ARRAY
        For x = 0 To tempDataArrayBound
            If bufferProcessingArrayBound = 0 Then
                If resetBound = tempDataArrayBound Then
                    bufferProcessingArray(bufferProcessingArrayBound + x) = tempDataArray(x)
                Else
                    bufferProcessingArray(bufferProcessingArrayBound + x + 1) = tempDataArray(x)
                End If
            Else
                bufferProcessingArray(bufferProcessingArrayBound + x + 1) = tempDataArray(x)
            End If
        Next
        bufferProcessingArrayBound = UBound(bufferProcessingArray)

        '//////////////////////////////////////////////////////////////////
        If debugFlag = 1 Then
            Debug.Write("ARRAY CONTENTS: ")
            'PRINT OUT THE ARRAY
            For x = 0 To bufferProcessingArrayBound
                Debug.Write(CStr(bufferProcessingArray(x)))
                Debug.Write(" ")
            Next
            Debug.WriteLine("")
        End If

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'MAKE SURE START BYTE IS IN THE (0) POSITION
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'A CHECKSUM PACKET IS 7 BYTES
        '7E SHOULD ALWAYS BE IN THE (0) POSITION
        'IF IT IS NOT WE NEED TO LOOK FOR IT
        'FIND IT
        'AND DELETE EVERYTHING BEFORE IT AS IT IS NOW USELESS

        If bufferProcessingArray(0) = "7E" Then
            'WE ARE FINE
        Else
            writeDebug("START BYTE NOT FOUND AT START OF ARRAY")
            Dim startPosition As Integer = 9999
            For x = 0 To bufferProcessingArrayBound
                'FIND THE FIRST 7E
                If bufferProcessingArray(x) = "7E" Then
                    startPosition = x
                    Exit For
                End If
            Next
            'COPY EXISTING ARRAY TO TEMP ARRAY
            'THEN MOVE BACK
            If startPosition = 9999 Then
                'WE DID NOT FIND A START BYTE
                'CLEAR THE ARRAY AND BAIL
                ReDim bufferProcessingArray(0)
                bufferProcessingArrayBound = 0
                writeDebug("FAILED TO FIND START BYTE IN ARRAY - ARRAY CLEARED")
                Exit Sub
            Else
                tempRealignArray = bufferProcessingArray
                ReDim bufferProcessingArray(bufferProcessingArrayBound - startPosition)
                bufferProcessingArrayBound = UBound(bufferProcessingArray)
                For x = 0 To bufferProcessingArrayBound
                    bufferProcessingArray(x) = tempRealignArray(x + startPosition)
                Next
                writeDebug("CORRECTED START POSITION IN ARRAY")
            End If
        End If
        If bufferProcessingArrayBound < 6 Then
            'I DO NOT HAVE ENOUGH BYTES - WAIT FOR THE NEXT COMM EVENT
            Exit Sub
        End If
        'FINISHED MAKING START BYTE IN THE (0) POSITION IF NECESSARY
        '//////////////////////////////////////////////////////////////////

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'LOOP AND PROCESS BYTES INTO PACKETS
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'HOW MANY 7E START BYTES DO I HAVE?
        Dim startByteCount As Integer = 0 'NUMBER OF START BYTES
        For x = 0 To bufferProcessingArrayBound
            If bufferProcessingArray(x) = "7E" Then
                startByteCount = startByteCount + 1
            End If
        Next
        For x = 1 To startByteCount
            If bufferProcessingArrayBound < 6 Then
                'I DO NOT HAVE ENOUGH BYTES - WAIT FOR THE NEXT COMM EVENT
                Exit Sub
            End If
            'GENERIC BYTES IN BOTH PACKET TYPES
            lengthByte1 = bufferProcessingArray(1)
            lengthByte2 = bufferProcessingArray(2)
            apiIdentifier = bufferProcessingArray(3)
            apiFrameID = bufferProcessingArray(4)
            If lengthByte2 = "03" Then 'CHECKSUM PACKET
                statusByte = bufferProcessingArray(5)
                Debug.WriteLine("STATUS BYTE: " + CStr(statusByte))
                If statusByte = "01" Then
                    writeDebug("STATUS FAILED STATUS BYTE: " + CStr(apiFrameID))
                End If
                checksumByte = bufferProcessingArray(6)
                'PROCESS CHECKSUM PACKET
                processPacketChecksum(apiFrameID, statusByte)
                'REMOVE PACKET FROM ARRAY
                For z = 0 To (bufferProcessingArrayBound - 7)
                    bufferProcessingArray(z) = bufferProcessingArray(z + 7)
                Next
                ReDim Preserve bufferProcessingArray(bufferProcessingArrayBound - 7)
                bufferProcessingArrayBound = UBound(bufferProcessingArray)
                If debugFlag = 1 Then
                    Debug.Write("ARRAY CONTENTS: ")
                    'PRINT OUT THE ARRAY
                    For q = 0 To bufferProcessingArrayBound
                        Debug.Write(CStr(bufferProcessingArray(q)))
                        Debug.Write(" ")
                    Next
                    Debug.WriteLine("")
                End If
            Else 'DATA PACKET
                If bufferProcessingArrayBound >= 15 Then
                    'WE HAVE A FULL DATA PACKET
                    addressByte1 = bufferProcessingArray(4)
                    addressByte2 = bufferProcessingArray(5)
                    rssiByte = bufferProcessingArray(6)
                    commandCodeByte = bufferProcessingArray(8)
                    data1Byte = bufferProcessingArray(9)
                    data2Byte = bufferProcessingArray(10)
                    data3Byte = bufferProcessingArray(11)
                    data4Byte = bufferProcessingArray(12)
                    data5Byte = bufferProcessingArray(13)
                    data6Byte = bufferProcessingArray(14)
                    checksumByte = bufferProcessingArray(15)
                    processPacketData(addressByte1, addressByte2, rssiByte, commandCodeByte, data1Byte, data2Byte, data3Byte, data4Byte, data5Byte, data6Byte)
                    'REMOVE PACKET FROM ARRAY
                    For z = 0 To (bufferProcessingArrayBound - 16)
                        bufferProcessingArray(z) = bufferProcessingArray(z + 16)
                    Next
                    ReDim Preserve bufferProcessingArray(bufferProcessingArrayBound - 16)
                    bufferProcessingArrayBound = UBound(bufferProcessingArray)
                    If debugFlag = 1 Then
                        Debug.Write("ARRAY CONTENTS: ")
                        'PRINT OUT THE ARRAY
                        For q = 0 To bufferProcessingArrayBound
                            Debug.Write(CStr(bufferProcessingArray(q)))
                            Debug.Write(" ")
                        Next
                        Debug.WriteLine("")
                    End If
                Else
                    'WE HAVE A FRAGMENT
                    'WAIT FOR NEXT LOOP
                    writeDebug("WAITING FOR NEXT LOOP IN MULTIPLE START BYTE DATA")
                    Exit Sub
                End If
            End If

        Next 'END FOR LOOP OF START BYTES
    End Sub
    Public Sub allLasersOn(ByVal tower As Integer) 'IF TOWER =0 THEN ALL TOWERS
        If tower = 0 Then
            s = 1
            f = towerCount
        Else
            s = tower
            f = tower
        End If
        For z = s To f
            towerIDByte = "100" & CStr(z)
            queueXbeePacket(towerIDByte, "45", "000", "000", "000", "000", "000", "000")
        Next
        'SET STATUS OF LASERS
        For x = 0 To UBound(laserConfigStack)
            laserConfigStack(x, 5) = 0
        Next

    End Sub

    Public Sub allLasersOff(ByVal tower As Integer) 'IF TOWER =0 THEN ALL TOWERS
        If tower = 0 Then
            s = 1
            f = towerCount
        Else
            s = tower
            f = tower
        End If
        For z = s To f
            towerIDByte = "100" & CStr(z)
            queueXbeePacket(towerIDByte, "46", "000", "000", "000", "000", "000", "000")
        Next
        'SET STATUS OF LASERS
        For x = 0 To UBound(laserConfigStack)
            laserConfigStack(x, 5) = 0
        Next
    End Sub
    Public Sub monitorSensorsOn(ByVal tower As Integer)
        If tower = 0 Then
            s = 1
            f = towerCount
        Else
            s = tower
            f = tower
        End If
        For z = s To f
            towerIDByte = "100" & CStr(z)
            queueXbeePacket(towerIDByte, "23", "001", "000", "000", "000", "000", "000")
        Next
    End Sub
    Public Sub monitorSensorsOff(ByVal tower As Integer)
        If tower = 0 Then
            s = 1
            f = towerCount
        Else
            s = tower
            f = tower
        End If
        For z = s To f
            towerIDByte = "100" & CStr(z)
            queueXbeePacket(towerIDByte, "23", "000", "006", "006", "006", "006", "006")
        Next
    End Sub
    Public Sub resetSensors(ByVal tower As Integer)

        If tower = 0 Then
            s = 1
            f = towerCount
        Else
            s = tower
            f = tower
        End If
        For z = s To f
            towerIDByte = "100" & CStr(z)
            queueXbeePacket(towerIDByte, "25", "000", "000", "000", "000", "000", "000")
        Next
    End Sub

    Public Sub laserOn(ByVal tower As Integer, ByVal laser As Integer)
        towerIDByte = "100" & CStr(tower)
        laserByte = "00" + CStr(laser)
        queueXbeePacket(towerIDByte, "47", laserByte, "006", "006", "006", "006", "006")
        'SET STATUS OF LASERS
        laserConfigStack(((tower - 1) * 6) + laser, 5) = 0
    End Sub
    Public Sub laserOff(ByVal tower As Integer, ByVal laser As Integer)
        towerIDByte = "100" & CStr(tower)
        laserByte = "00" + CStr(laser)
        queueXbeePacket(towerIDByte, "48", laserByte, "006", "006", "006", "006", "006")
        laserConfigStack(((tower - 1) * 6) + laser, 5) = 0
    End Sub
    Public Sub updateSensors()
        For z = 1 To towerCount
            towerIDByte = "100" & CStr(z)
            queueXbeePacket(towerIDByte, "22", "000", "000", "000", "000", "000", "000")
        Next
    End Sub
    Public Sub towerInteruptMode(ByVal mode As Integer) '0=OFF, 1=ON
        For z = 1 To towerCount
            towerIDByte = "100" & CStr(z)
            modeByte = "00" & CStr(mode)
            queueXbeePacket(towerIDByte, "23", modeByte, "000", "000", "000", "000", "000")
        Next
    End Sub
    Public Sub relaysOn(ByVal tower As Integer)
        If tower = 0 Then
            s = 1
            f = towerCount
        Else
            s = tower
            f = tower
        End If
        For z = s To f
            towerIDByte = "100" & CStr(z)
            queueXbeePacket(towerIDByte, "30", "000", "000", "000", "000", "000", "000")
        Next
    End Sub
    Public Sub relaysOff(ByVal tower As Integer)
        If tower = 0 Then
            s = 1
            f = towerCount
        Else
            s = tower
            f = tower
        End If
        For z = s To f
            towerIDByte = "100" & CStr(z)
            queueXbeePacket(towerIDByte, "31", "000", "000", "000", "000", "000", "000")
        Next
    End Sub
    Public Sub relayOn(ByVal tower As Integer, ByVal relay As Integer)
        towerIDByte = "100" & CStr(tower)
        relayByte = "00" & CStr(relay)
        queueXbeePacket(towerIDByte, "32", relayByte, "000", "000", "000", "000", "000")

    End Sub
    Public Sub relayOff(ByVal tower As Integer, ByVal relay As Integer)
        towerIDByte = "100" & CStr(tower)
        relayByte = "00" & CStr(relay)
        queueXbeePacket(towerIDByte, "33", relayByte, "000", "000", "000", "000", "000")
    End Sub
    Public Sub playMusic(ByVal tower As Integer, ByVal sound As Integer)
        towerIDByte = "100" & CStr(tower)
        relayByte = "00" & CStr(sound)
        queueXbeePacket(towerIDByte, "35", relayByte, "000", "000", "000", "000", "000")
    End Sub
    Public Sub stopMusic(ByVal tower As Integer)
        If tower = 0 Then
            s = 1
            f = towerCount
        Else
            s = tower
            f = tower
        End If
        For z = s To f
            towerIDByte = "100" & CStr(tower)
            queueXbeePacket(towerIDByte, "36", "000", "000", "000", "000", "000", "000")
        Next
    End Sub
    Public Sub buttonLightOn(ByVal tower As Integer)
        If tower = 0 Then
            s = 1
            f = towerCount
        Else
            s = tower
            f = tower
        End If
        For z = s To f
            towerIDByte = "100" & CStr(z)
            queueXbeePacket(towerIDByte, "40", "001", "000", "000", "000", "000", "000")
        Next
    End Sub
    Public Sub buttonLightOff(ByVal tower As Integer)
        If tower = 0 Then
            s = 1
            f = towerCount
        Else
            s = tower
            f = tower
        End If
        For z = s To f
            towerIDByte = "100" & CStr(z)
            queueXbeePacket(towerIDByte, "40", "000", "000", "000", "000", "000", "000")
        Next
    End Sub
    Public Sub setSensorThreshold(tower)
        If tower = 0 Then
            s = 1
            f = towerCount
        Else
            s = tower
            f = tower
        End If
        For z = s To f
            towerIDByte = "100" & CStr(z)
            queueXbeePacket(towerIDByte, "21", CStr(sensorThreshold), "000", "000", "000", "000", "000")
        Next
    End Sub
    Public Sub setSensorDelay(tower)
        If tower = 0 Then
            s = 1
            f = towerCount
        Else
            s = tower
            f = tower
        End If
        For z = s To f
            towerIDByte = "100" & CStr(z)
            queueXbeePacket(towerIDByte, "20", "000", "001", "000", "000", "000", "000")
        Next
    End Sub
    Private Sub MessageBox(ByVal Text2Display As String)
        Throw New NotImplementedException
    End Sub
    Public Function HexToString(ByVal HexToStr As String) As String
        Dim strTemp As String
        Dim strReturn As String
        Dim I As Long
        For I = 1 To Len(HexToStr) Step 3
            strTemp = Chr(Val("&H" & Mid(HexToStr, I, 2)))
            strReturn = strReturn & strTemp
        Next I
        HexToString = strReturn
    End Function
    Sub sendBarCodeData(barcodeString)
        Try
            SerialPortBC.Write(barcodeString)
        Catch
            writeDebug("BARCODE READER SEND FAILURE")
        End Try
    End Sub
    Public Sub relaysOffExceptHaze()
        For z = 1 To towerCount
            For y = 1 To 2
                towerIDByte = "100" & CStr(z)
                relayByte = "00" & CStr(y)
                If z = hazeTower And y = hazeRelay Then
                    'DO NOT TURN OFF HAZER
                Else
                    queueXbeePacket(towerIDByte, "33", relayByte, "000", "000", "000", "000", "000")
                End If
            Next
        Next
    End Sub
End Module
