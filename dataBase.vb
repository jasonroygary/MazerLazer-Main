Imports Domino
Friend Module dataBase
    Public ndSession As New Domino.NotesSession
    Public ndDatabase As Domino.NotesDatabase
    Public gameDatabaseDoc As Domino.NotesDocument
    Public playerView As Domino.NotesView
    Public playerDoc As Domino.NotesDocument
    Public ticketDoc As Domino.NotesDocument
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    'DOMINO VARS
    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    Public dominoServer As String
    Public dominoDatabase As String
    Public playerDatabasePath As String
    Public dominoPassword As String
    Public dominoTowerView As Domino.NotesView
    Public dominoGameView As Domino.NotesView
    Public dominoGameDocument As Domino.NotesDocument
    Public dominoTowerDocument As Domino.NotesDocument
    Public playerDatabase As Domino.NotesDatabase
    '/////////////////////////////////////////////////////////////

    Public Sub dominoInit()
        Try
            ndSession.Initialize(dominoPassword)
            ndDatabase = ndSession.GetDatabase(dominoServer, dominoDatabase)
            playerDatabase = ndSession.GetDatabase(dominoServer, playerDatabasePath)
            playerView = playerDatabase.GetView("playerbyID2")
        Catch ex As Exception
            'ALREADY OPEN
        End Try
    End Sub
    'READ HIGH SCORE VIEW

    Public Sub getPlayerDoc(userID)
        playerDoc = playerView.GetDocumentByKey(userID, True)
    End Sub
    'GET LASER COUNT
    Public Sub getLaserCount()
        'GET LASER COUNT WITH COLOR
        '0 = RED, 1=GREEN, 2=BLUE, 3=DISABLED
        dominoTowerDocument = dominoTowerView.GetFirstDocument
        Do
            dominoObject = dominoTowerDocument.GetItemValue("towerRedLaserCount")
            laserCountRed = laserCountRed + CInt(dominoObject(0))
            dominoObject = dominoTowerDocument.GetItemValue("towerGreenLaserCount")
            laserCountGreen = laserCountGreen + CInt(dominoObject(0))
            dominoObject = dominoTowerDocument.GetItemValue("towerBlueLaserCount")
            laserCountBlue = laserCountBlue + CInt(dominoObject(0))
            dominoObject = dominoTowerDocument.GetItemValue("towerDisabledLaserCount")
            laserCountDisabled = laserCountDisabled + CInt(dominoObject(0))
            dominoObject = dominoTowerDocument.GetItemValue("towerLaserCount")
            laserCount = laserCount + CInt(dominoObject(0))

            dominoTowerDocument = dominoTowerView.GetNextDocument(dominoTowerDocument)
        Loop Until dominoTowerDocument Is Nothing
    End Sub
    Public Sub createTicket()
        ticketDoc = ndDatabase.CreateDocument
        ticketDoc.ReplaceItemValue("form", "ticketRecord")
        ticketDoc.ComputeWithForm(True, False)
        ticketDoc.Save(True, False)
    End Sub

End Module
