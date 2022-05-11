Imports System.Threading

Friend Module gameMaze
    Public gameLaserCount As Integer = 0
    Public Sub gameMazeExecution()
        gameRunning = 1
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'SETUP GAME
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        countdownPlayedFlag = 0 'FLAG TO DETERMINE IF WE HAVE PLAYED THE COUNTDOWN
        Dim turnFlag As Integer = 0
        'LASER COUNT
        dominoObject = dominoGameDocument.GetItemValue("gameLaserCount" + CStr(gameDifficulity))
        gameLaserCount = CInt(dominoObject(0))
        'GAME TIME
        dominoObject = dominoGameDocument.GetItemValue("gameTime" + CStr(gameDifficulity))
        gameTime = CInt(dominoObject(0))
        gameLastTimeUpdated = gameTime
        'STARTING SCORE
        dominoObject = dominoGameDocument.GetItemValue("gameStartingScore" + CStr(gameDifficulity))
        gameScoreStarting = CInt(dominoObject(0))
        'SCORE LOST PER SECOND
        dominoObject = dominoGameDocument.GetItemValue("gamePointsLostPerSecond")
        gameScoreLostPerSecond = CInt(dominoObject(0))
        'SCORE FOR POINTS LEFT OVER
        dominoObject = dominoGameDocument.GetItemValue("gamePointsTimeRemaining")
        gameScoreRemainingTime = CInt(dominoObject(0))
        'BUTTON POINTS
        dominoObject = dominoGameDocument.GetItemValue("gameButtonPoints" + CStr(gameDifficulity))
        gameButtonPoints = CInt(dominoObject(0))
        'BUTTON TIME
        dominoObject = dominoGameDocument.GetItemValue("gameButtonTime" + CStr(gameDifficulity))
        gameButtonTime = CInt(dominoObject(0))
        'TURN BUTTON POINTS
        dominoObject = dominoGameDocument.GetItemValue("gameTurnPoints" + CStr(gameDifficulity))
        gameTurnPoints = CInt(dominoObject(0))
        'TURN BUTTON TIME
        dominoObject = dominoGameDocument.GetItemValue("gameTurnTime" + CStr(gameDifficulity))
        gameTurnTime = CInt(dominoObject(0))

        'XXXXXXXXXXXXXXX
        'POINTS FOR LASERS WITH TIME LOSS
        'XXXXXXXXXXXXXX
        'RED LASER POINTS
        dominoObject = dominoGameDocument.GetItemValue("gameScoreBreakRed" + CStr(gameDifficulity))
        gameScoreBreakRed = CInt(dominoObject(0))
        'GREEN LASER POINTS
        dominoObject = dominoGameDocument.GetItemValue("gameScoreBreakGreen" + CStr(gameDifficulity))
        gameScoreBreakGreen = CInt(dominoObject(0))
        'BLUE LASER POINTS
        dominoObject = dominoGameDocument.GetItemValue("gameScoreBreakBlue" + CStr(gameDifficulity))
        gameScoreBreakBlue = CInt(dominoObject(0))
        'RED LASER TIME
        dominoObject = dominoGameDocument.GetItemValue("gameTimeBreakRed" + CStr(gameDifficulity))
        gameTimeBreakRed = CInt(dominoObject(0))
        'GREEN LASER TIME
        dominoObject = dominoGameDocument.GetItemValue("gameTimeBreakGreen" + CStr(gameDifficulity))
        gameTimeBreakGreen = CInt(dominoObject(0))
        'BLUE LASER TIME
        dominoObject = dominoGameDocument.GetItemValue("gameTimeBreakBlue" + CStr(gameDifficulity))
        gameTimeBreakBlue = CInt(dominoObject(0))
        'XXXXXXXXXXXXXXX
        'SOUND
        'XXXXXXXXXXXXXX
        'BACKGROUND SOUNDS
        dominoObject = dominoGameDocument.GetItemValue("gameSoundBackground" + CStr(gameDifficulity))
        gameSoundBackground = dominoObject
        'BREAK SOUNDS
        dominoObject = dominoGameDocument.GetItemValue("gameSoundBreak" + CStr(gameDifficulity))
        gameSoundBreak = dominoObject
        'COUNTDOWN SOUNDS
        dominoObject = dominoGameDocument.GetItemValue("gameSoundCountdown" + CStr(gameDifficulity))
        gameSoundCountdown = dominoObject
        'TURN SOUNDS
        dominoObject = dominoGameDocument.GetItemValue("gameSoundTurn" + CStr(gameDifficulity))
        gameSoundTurn = dominoObject
        'BUTTON SOUNDS
        dominoObject = dominoGameDocument.GetItemValue("gameSoundButton" + CStr(gameDifficulity))
        gameSoundButton = dominoObject
        'START SOUNDS
        dominoObject = dominoGameDocument.GetItemValue("gameSoundStart" + CStr(gameDifficulity))
        gameSoundStart = dominoObject
        'END SOUNDS
        dominoObject = dominoGameDocument.GetItemValue("gameSoundEnd" + CStr(gameDifficulity))
        gameSoundEnd = dominoObject

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'START GAME
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        gameScore = gameScoreStarting
        gameButtonsPressed = 0
        gameTurnButton = 0
        Dim gameTimeAdded As Integer = 0 'TIME ADDED BY BUTTONS

        'RESET BUTTON ARRAY (GET RID OF THE 3s)
        For y = 0 To UBound(buttonConfigStack)
            buttonConfigStack(y, 2) = 0
        Next

        'START GAME CLOCK
        gameClock.Reset()
        gameClock.Start()


        'HOW MANY LASERS ARE IN THIS GAME?
        If lasersAligned < gameLaserCount Then
            gameLaserCount = lasersAligned
        End If
        ReDim gameStack(gameLaserCount - 1, 5)
        'AT THIS POINT WE HAVE A STACK THAT IS EMPTY
        'FOR THE GAME

        'WHAT WE NEED TO DO I GO THROUGH
        'THE LIST OF ALIGNED LASERS
        'RANDOMLY PICK SOME
        'AND FILL THE STACK WITH SOME


        'CREATE GAME STACK
        Dim laserCheckArray(500) 'TO KEEP TRACK IF WE HAVE USED THIS LASER BEFORE

        y = 0
        z = 0
        assignedLasers = 0
        Do
            For x = 0 To UBound(sensorConfigStack)
                If sensorConfigStack(x, 2) = 0 Then
                    'NOT AN ALIGNED LASER
                Else
                    laserSeed = GetRandom(0, 1)
                    If laserSeed = 1 Then
                        'HAVE WE USED THIS LASER BEFORE?
                        If laserCheckArray(x) = 1 Then
                            'WE HAVE USED THIS BEFORE
                        Else
                            gameStack(y, 0) = sensorConfigStack(x, 0)
                            gameStack(y, 1) = sensorConfigStack(x, 1)
                            gameStack(y, 2) = sensorConfigStack(x, 2)
                            gameStack(y, 3) = sensorConfigStack(x, 3)
                            gameStack(y, 4) = 1
                            gameStack(y, 5) = 0
                            y = y + 1
                            laserCheckArray(x) = 1
                            assignedLasers = assignedLasers + 1
                            If assignedLasers = gameLaserCount Then
                                Exit For
                            End If
                        End If
                    End If
                End If
            Next
        Loop Until assignedLasers = gameLaserCount

        'TURN ON BUTTONS
        gameMazeTurnOnLasers()
        buttonLightOn(0)

        'TURN ON SENSORS
        gameMazeEnableSensors()

        'BACKGROUND MUSIC
        Dim soundRandomSeed As Integer
        soundRandomSeed = GetRandom(0, UBound(gameSoundBackground))
        playMusic(soundBackgroundTower, CInt(gameSoundBackground(soundRandomSeed)))

        gameBeamsBrokenRed = 0
        gameBeamsBrokenGreen = 0
        gameBeamsBrokenBlue = 0

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        'RUN GAME LOOP
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        Do
            For x = 0 To UBound(gameStack)
                'CHECK FOR A CHANGE FLAG
                If gameStack(x, 5) = 1 Then
                    'BEAM HAS BEEN BROKEN
                    laserOff(gameStack(x, 2), gameStack(x, 3))
                    laserOff(gameStack(x, 2), gameStack(x, 3))
                    laserOff(gameStack(x, 2), gameStack(x, 3))
                    writeDebug("Laser: " + CStr(gameStack(x, 2)) + "-" + CStr(gameStack(x, 3)))
                    gameStack(x, 4) = 0
                    gameStack(x, 5) = 0
                    'BEAM BROKEN
                    'PLAY SOUND
                    soundRandomSeed = GetRandom(0, UBound(gameSoundBreak))
                    playMusic(soundTower, CInt(gameSoundBreak(soundRandomSeed)))
                    'SUBTRACT FROM SCORE
                    'DETERMINE WHAT KIND OF LASER IS BROKEN
                    'USE LASER STACK
                    arrayPointer = ((gameStack(x, 2) - 1) * 6) + gameStack(x, 3)
                    laserColor = laserConfigStack(arrayPointer, 4)

                    If laserColor = 0 Then
                        'RED
                        gameScore = gameScore - gameScoreBreakRed
                        gameBeamsBrokenRed = gameBeamsBrokenRed + 1
                        gameTimeAdded = gameTimeAdded - gameTimeBreakRed
                        gameTimeRemaining = gameTime - gameClock.Elapsed.Seconds + gameTimeAdded
                        gameLastTimeUpdated = gameTimeRemaining
                    ElseIf laserColor = 1 Then
                        'GREEN
                        gameScore = gameScore - gameScoreBreakGreen
                        gameBeamsBrokenGreen = gameBeamsBrokenGreen + 1
                        gameTimeAdded = gameTimeAdded - gameTimeBreakGreen
                        gameTimeRemaining = gameTime - gameClock.Elapsed.Seconds + gameTimeAdded
                        gameLastTimeUpdated = gameTimeRemaining
                    ElseIf laserColor = 2 Then
                        'BLUE
                        gameScore = gameScore - gameScoreBreakBlue
                        gameBeamsBrokenBlue = gameBeamsBrokenBlue + 1
                        gameTimeAdded = gameTimeAdded - gameTimeBreakBlue
                        gameTimeRemaining = gameTime - gameClock.Elapsed.Seconds + gameTimeAdded
                        gameLastTimeUpdated = gameTimeRemaining
                    End If
                    'SUBTRACT TIME
                End If
            Next

            For y = 0 To UBound(buttonConfigStack)
                buttonCheck = buttonConfigStack(y, 2)
                If buttonCheck = 1 Then
                    'CHECK TO SEE IF IT IS A TURN BUTTON
                    If buttonConfigStack(y, 1) = 2 Then 'IS TURN BUTTON
                        'CHANGE SCORE
                        gameTurnButton = 1
                        gameScore = gameScore + gameTurnPoints
                        'CHANGE ARRAY VALUE
                        buttonConfigStack(y, 2) = 3 '3 IS THE VALUE FOR DISABLED DURING GAME
                        'TURN OFF BUTTON
                        buttonLightOff(y + 1)
                        'PLAY SOUND
                        soundRandomSeed = GetRandom(0, UBound(gameSoundTurn))
                        playMusic(soundTower, CInt(gameSoundTurn(soundRandomSeed)))

                        resetGameStack()
                        Thread.Sleep(500)
                        gameMazeTurnOnLasers()
                        'Thread.Sleep(1000)
                        gameMazeEnableSensors()


                        'RESET BUTTON ARRAY (GET RID OF THE 3s)
                        For z = 0 To UBound(buttonConfigStack)
                            If buttonConfigStack(z, 1) = 2 Then
                                'DO NOT RESET THE TURN BUTTON
                            Else
                                buttonConfigStack(z, 2) = 0
                                'TURN BUTTONS BACK ON
                                buttonLightOn(z + 1)
                            End If
                        Next
                    Else 'NORMAL BUTTON
                        'CHANGE SCORE
                        gameButtonsPressed = gameButtonsPressed + 1
                        gameScore = gameScore + gameButtonPoints
                        'CHANGE TIME
                        gameTimeAdded = gameTimeAdded + gameButtonTime
                        gameTimeRemaining = gameTime - gameClock.Elapsed.Seconds + gameTimeAdded
                        gameLastTimeUpdated = gameTimeRemaining
                        'CHANGE ARRAY VALUE
                        buttonConfigStack(y, 2) = 3 '3 IS THE VALUE FOR DISABLED DURING GAME
                        'TURN OFF BUTTON
                        buttonLightOff(y + 1)
                        'PLAY SOUND
                        soundRandomSeed = GetRandom(0, UBound(gameSoundButton))
                        playMusic(soundTower, CInt(gameSoundButton(soundRandomSeed)))
                    End If
                End If
            Next
            gameTimeRemaining = gameTime - gameClock.Elapsed.Seconds + gameTimeAdded
            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            'ONE SECOND TICK
            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            'SEND UPDATE TO CONSOLE
            If gameLastTimeUpdated > gameTimeRemaining Then
                gameScore = CInt(gameScore) - CInt(gameScoreLostPerSecond)
                gameBeamsBroken = gameBeamsBrokenRed + gameBeamsBrokenGreen + gameBeamsBrokenBlue
                tcpipSendMessage("20*" + CStr(gameTimeRemaining) + "*" + CStr(gameDifficulity) + "*" + CStr(laserCount) + "*" + _
                                 CStr(gameScore) + "*" + CStr(gameBeamsBroken) + "*" + CStr(gameBeamsBrokenRed) + "*" + CStr(gameBeamsBrokenGreen) + "*" + _
                                 CStr(gameBeamsBrokenBlue) + "*" + CStr(gameButtonsPressed) + "*" + CStr(gameTurnButton))
                gameLastTimeUpdated = gameTimeRemaining
            End If


            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            'RESTART BACKGROUND MUSIC
            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            If gameTimeRemaining > 10 Then
                If countdownPlayedFlag = 1 Then
                    soundRandomSeed = GetRandom(0, UBound(gameSoundBackground))
                    playMusic(soundBackgroundTower, CInt(gameSoundBackground(soundRandomSeed)))
                    countdownPlayedFlag = 0
                End If
            End If

            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            '10 SECONDS REMAINING
            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            If gameTimeRemaining = 10 Then
                If countdownPlayedFlag = 0 Then
                    soundRandomSeed = GetRandom(0, UBound(gameSoundCountdown))
                    playMusic(soundBackgroundTower, CInt(gameSoundCountdown(soundRandomSeed)))
                    countdownPlayedFlag = 1
                End If
            End If
            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            'END GAME ROUTINE
            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
            gameAllLasersBroken = 1
            For z = 0 To UBound(gameStack)
                If gameStack(z, 4) = 1 Then
                    gameAllLasersBroken = 0
                    Exit For
                End If
            Next
            If gameAllLasersBroken = 1 Then
                gameExited = 1
            End If

            If gameTimeRemaining <= 0 Or gameExited = 1 Then 'OR GAME EXIT
                gameScore = gameScore + (gameTimeRemaining * gameScoreRemainingTime)
                setSystemMode(0)
                allLasersOff(0)
                Thread.Sleep(2000)
                'GAME IS OVER
                'PLAY GAME OVER MUSIC
                If UBound(gameSoundEnd) = 0 Then
                    soundRandomSeed = 0
                Else
                    soundRandomSeed = GetRandom(0, UBound(gameSoundEnd))
                End If
                playMusic(soundBackgroundTower, CInt(gameSoundEnd(soundRandomSeed)))
                'COMPUTER PLAYER LEVEL
                computePlayerLevel()
                Thread.Sleep(500)
                'PRINT SCORECARD
                printScorecard = 1
                'SAVE GAME TO DATABASE
                createGamePlayRecord()
                gameRunning = 0
            End If
            Thread.Sleep(5)
        Loop Until systemMode = 0
    End Sub
    Public Sub gameMazeTurnOnLasers()
        For x = 0 To UBound(gameStack)
            laserOn(gameStack(x, 2), gameStack(x, 3))
        Next
    End Sub

    Public Sub gameMazeEnableSensors()
        resetSensors(0)
        resetSensors(0)
        resetSensors(0)
        Thread.Sleep(300)
        updateSensors() 'UPDATES THE SENSOR STATE AFTER ALIGNMENT
        Thread.Sleep(400)
        monitorSensorsOn(0)
        Thread.Sleep(100)
    End Sub

    Public Sub createGamePlayRecord()
        Dim gamePlayDoc As Domino.NotesDocument
        gamePlayDoc = ndDatabase.CreateDocument

        gamePlayDoc.ReplaceItemValue("form", "gamePlay")
        gamePlayDoc.ReplaceItemValue("gamePlayScore", gameScore)
        gamePlayDoc.ReplaceItemValue("gamePlayPlayer", gamePlayer)
        gamePlayDoc.ReplaceItemValue("gamePlayButtonsPressed", gameButtonsPressed)
        gamePlayDoc.ReplaceItemValue("gamePlayTurnButtonPressed", gameTurnButton)
        gamePlayDoc.ReplaceItemValue("gamePlayPlayerLevel", gamePlayerLevel)
        gamePlayDoc.ReplaceItemValue("gamePlayBeamsBroken", gameBeamsBroken)
        gamePlayDoc.ReplaceItemValue("gamePlayRedBroken", gameBeamsBrokenRed)
        gamePlayDoc.ReplaceItemValue("gamePlayGreenBroken", gameBeamsBrokenGreen)
        gamePlayDoc.ReplaceItemValue("gamePlayBlueBroken", gameBeamsBrokenBlue)
        gamePlayDoc.ReplaceItemValue("gamePlayDifficulity", gameDifficulity)
        gamePlayDoc.ReplaceItemValue("gamePlayTimeRemaining", gameTimeRemaining)
        gamePlayDoc.ReplaceItemValue("gamePlayDifficulityLabel", gameDifficulityLabels(gameDifficulity))

        gamePlayDoc.ComputeWithForm(True, False)
        gamePlayDoc.Save(True, False)

    End Sub
    Public Sub computePlayerLevel()
        For x = 0 To UBound(playerLevels)
            If gameScore >= CInt(playerLevelPoints(x)) Then
                gamePlayerLevel = playerLevels(x)
                Exit For
            End If
        Next
        If gamePlayerLevel = "" Then
            gamePlayerLevel = playerLevels(UBound(playerLevels))
        End If
    End Sub
    Public Function soundTower()
        Dim soundEffectTower As Integer = 0
        If UBound(soundEffectTowers) = 0 Then
            soundBkTower = soundEffectTowers(0)
        Else
            soundRandomSeed = GetRandom(0, UBound(soundEffectTowers))
            soundEffectTower = soundEffectTowers(soundRandomSeed)
        End If
        soundTower = CInt(soundEffectTower)
    End Function

    Public Sub resetGameStack()
        'HOW MANY LASERS ARE IN THIS GAME?
        If lasersAligned < gameLaserCount Then
            gameLaserCount = lasersAligned
        End If
        ReDim gameStack(gameLaserCount - 1, 5)

        'CREATE GAME STACK
        Dim laserCheckArray(500) 'TO KEEP TRACK IF WE HAVE USED THIS LASER BEFORE

        y = 0
        z = 0
        assignedLasers = 0
        Do
            For x = 0 To UBound(sensorConfigStack)
                If sensorConfigStack(x, 2) = 0 Then
                    'NOT AN ALIGNED LASER
                Else
                    laserSeed = GetRandom(0, 1)
                    If laserSeed = 1 Then
                        'HAVE WE USED THIS LASER BEFORE?
                        If laserCheckArray(x) = 1 Then
                            'WE HAVE USED THIS BEFORE
                        Else
                            gameStack(y, 0) = sensorConfigStack(x, 0)
                            gameStack(y, 1) = sensorConfigStack(x, 1)
                            gameStack(y, 2) = sensorConfigStack(x, 2)
                            gameStack(y, 3) = sensorConfigStack(x, 3)
                            gameStack(y, 4) = 1
                            gameStack(y, 5) = 0
                            y = y + 1
                            laserCheckArray(x) = 1
                            assignedLasers = assignedLasers + 1
                            If assignedLasers = gameLaserCount Then
                                Exit For
                            End If
                        End If
                    End If
                End If
            Next
        Loop Until assignedLasers = gameLaserCount
    End Sub
End Module
