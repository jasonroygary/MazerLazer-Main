Friend Module PacketProcessing
    Sub processPacketChecksum(apiFrameID, statusByte)
        'MATCH UP WITH EXISTING SENT PACKET
        Dim pID As Integer
        pID = Val("&h" & apiFrameID)

        If xbeeOutGoingStack(pID, 2) = 0 Then ' EMPTY
            'DO NOTHING
        ElseIf xbeeOutGoingStack(pID, 2) = 1 Then 'TO SEND
            'DO NOTHING
        ElseIf xbeeOutGoingStack(pID, 2) = 4 Then 'DISABLED
            'DO NOTHING
        Else 'IT IS EITHER A SENT PACKET OR A SENT AND FAILED PACKET
            If statusByte = "01" Then
                'WE HAVE A FAILURE CHECKSUM PACKET
                xbeeOutGoingStack(pID, 2) = 3
                writeDebug("CHECKSUM PACKET STATUS FAILED")
            Else
                'CONFIRMATION CHECKSUM PACKET
                'CLEAR THE SLOT IN THE STACK
                writeDebug("CHECKSUM PACKET ID MATCH (" + CStr(apiFrameID) + ") STATUS(" + CStr(statusByte) + ")")
                For y = 0 To 4
                    xbeeOutGoingStack(pID, y) = 0
                Next
            End If
        End If
        writeDebug("CHECKSUM PACKET ID (" + CStr(apiFrameID) + ") STATUS(" + CStr(statusByte) + ")")
    End Sub

    Sub processPacketData(addressByte1, addressByte2, rssiByte, commandCodeByte, data1Byte, data2Byte, data3Byte, data4Byte, data5Byte, data6Byte)
        writeDebug("DATA PACKET FROM: " + addressByte1 + addressByte2 + " RSSI: " + rssiByte + " -- " + "CC(" + commandCodeByte + ") " + data1Byte + "-" + data2Byte + "-" + data3Byte + "-" + data4Byte + "-" + data5Byte + "-" + data6Byte)
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'DO SOMETHING WITH THE PACKET
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        Dim towerID As Integer
        towerID = CInt(Microsoft.VisualBasic.Right(addressByte2, 1))
        Select Case commandCodeByte
            Case "14" 'SENSOR STATUS
                writeDebug("Case 14")
                Dim sensorArrayPosition As Integer
                sensorArrayPosition = (towerID - 1) * 6
                sensorConfigStack(sensorArrayPosition + 0, 4) = CInt(data1Byte)
                sensorConfigStack(sensorArrayPosition + 1, 4) = CInt(data2Byte)
                sensorConfigStack(sensorArrayPosition + 2, 4) = CInt(data3Byte)
                sensorConfigStack(sensorArrayPosition + 3, 4) = CInt(data4Byte)
                sensorConfigStack(sensorArrayPosition + 4, 4) = CInt(data5Byte)
                sensorConfigStack(sensorArrayPosition + 5, 4) = CInt(data6Byte)
                writeDebug("SYSTEM MODE: " + CStr(systemMode))
                If systemMode = 2 Then 'GAME MODE
                    writeDebug("SYSTEM MODE")
                    'SEARCH THROUGH THE GAME STACK AND FLAG CHANGES
                    For x = 0 To UBound(gameStack)
                        writeDebug(CStr(gameStack(x, 0)) + "-" + CStr(towerID))
                        If gameStack(x, 0) = towerID Then
                            'IT IS THE SAME TOWER
                            'GO THROUGH THE SENSOR STATUS ON THAT TOWER
                            'IF SOMETHING IS OFF THAT SHOULD BE ON
                            'SET CHANGE FLAG
                            For y = sensorArrayPosition To sensorArrayPosition + 5
                                If sensorConfigStack(y, 4) = 0 Then
                                    'SOMETHING IS OFF
                                    If sensorConfigStack(y, 1) = gameStack(x, 1) Then
                                        'SAME SENSOR
                                        If gameStack(x, 4) = 1 Then 'SHOULD BE ON
                                            'BEAM IS BROKEN
                                            writeDebug("Beam Broken")
                                            gameStack(x, 5) = 1
                                        End If
                                    End If
                                End If
                            Next

                        End If

                    Next
                End If


            Case "1E" 'BUTTON PRESSED
                If buttonConfigStack(addressByte2 - 1, 2) = 3 Then
                    'BUTTON HAS ALREADY BEEN PRESSED
                Else
                    buttonConfigStack(addressByte2 - 1, 2) = 1 'PRESSED
                    writeDebug("BUTTON PRESSED: " + CStr(addressByte2))
                End If

            Case Else
                'EVERYTHING ELSE

        End Select

    End Sub

End Module
