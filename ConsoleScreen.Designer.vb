<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsoleScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.buttonAttractMode = New System.Windows.Forms.Button()
        Me.textSensorMode = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.textSensorsDisabled = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.textLasersAligned = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.textSensorsOn = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AlignmentProgressBar = New System.Windows.Forms.ProgressBar()
        Me.buttonStandbyMode = New System.Windows.Forms.Button()
        Me.buttonPlayMazeLame = New System.Windows.Forms.Button()
        Me.buttonPlayMazeProfessional = New System.Windows.Forms.Button()
        Me.buttonPlayMazeWicked = New System.Windows.Forms.Button()
        Me.buttonPlayMazeInsane = New System.Windows.Forms.Button()
        Me.buttonAllRelaysOff = New System.Windows.Forms.Button()
        Me.buttonAllRelaysOn = New System.Windows.Forms.Button()
        Me.buttonAllLasersOff = New System.Windows.Forms.Button()
        Me.buttonAllLasersOn = New System.Windows.Forms.Button()
        Me.buttonDebug = New System.Windows.Forms.Button()
        Me.buttonUpdateSensors = New System.Windows.Forms.Button()
        Me.buttonAlignSystem = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.listViewSensors = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbRawComm = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cPara6Txt = New System.Windows.Forms.TextBox()
        Me.cPara5Txt = New System.Windows.Forms.TextBox()
        Me.cPara4Txt = New System.Windows.Forms.TextBox()
        Me.cPara3Txt = New System.Windows.Forms.TextBox()
        Me.cPara2Txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cPara1Txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ccodeTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.manualSendAddTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timerUpdateUX = New System.Windows.Forms.Timer(Me.components)
        Me.timerUpdateSensors = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.AccessibleName = ""
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1020, 730)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button10)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.buttonAttractMode)
        Me.TabPage1.Controls.Add(Me.textSensorMode)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.textSensorsDisabled)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.textLasersAligned)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.textSensorsOn)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.AlignmentProgressBar)
        Me.TabPage1.Controls.Add(Me.buttonStandbyMode)
        Me.TabPage1.Controls.Add(Me.buttonPlayMazeLame)
        Me.TabPage1.Controls.Add(Me.buttonPlayMazeProfessional)
        Me.TabPage1.Controls.Add(Me.buttonPlayMazeWicked)
        Me.TabPage1.Controls.Add(Me.buttonPlayMazeInsane)
        Me.TabPage1.Controls.Add(Me.buttonAllRelaysOff)
        Me.TabPage1.Controls.Add(Me.buttonAllRelaysOn)
        Me.TabPage1.Controls.Add(Me.buttonAllLasersOff)
        Me.TabPage1.Controls.Add(Me.buttonAllLasersOn)
        Me.TabPage1.Controls.Add(Me.buttonDebug)
        Me.TabPage1.Controls.Add(Me.buttonUpdateSensors)
        Me.TabPage1.Controls.Add(Me.buttonAlignSystem)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.listViewSensors)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1012, 701)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Game Basics"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(601, 572)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 45
        Me.Button10.Text = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 35)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(311, 338)
        Me.DataGridView1.TabIndex = 44
        Me.DataGridView1.VirtualMode = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(601, 525)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 43
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(329, 572)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(91, 67)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = "Reset Sensors"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(122, 572)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(91, 67)
        Me.Button7.TabIndex = 41
        Me.Button7.Text = "All Button Lights Off"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(20, 572)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(91, 67)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "All Button Lights On"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(433, 484)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 67)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "TouchScreen"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(433, 572)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 67)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Bill Acceptor"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'buttonAttractMode
        '
        Me.buttonAttractMode.Location = New System.Drawing.Point(329, 484)
        Me.buttonAttractMode.Name = "buttonAttractMode"
        Me.buttonAttractMode.Size = New System.Drawing.Size(91, 67)
        Me.buttonAttractMode.TabIndex = 37
        Me.buttonAttractMode.Text = "Attract Mode"
        Me.buttonAttractMode.UseVisualStyleBackColor = True
        '
        'textSensorMode
        '
        Me.textSensorMode.AutoSize = True
        Me.textSensorMode.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSensorMode.Location = New System.Drawing.Point(851, 445)
        Me.textSensorMode.Name = "textSensorMode"
        Me.textSensorMode.Size = New System.Drawing.Size(60, 16)
        Me.textSensorMode.TabIndex = 36
        Me.textSensorMode.Text = "Manual"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(708, 445)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 16)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Sensor Mode:"
        '
        'textSensorsDisabled
        '
        Me.textSensorsDisabled.AutoSize = True
        Me.textSensorsDisabled.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSensorsDisabled.Location = New System.Drawing.Point(851, 367)
        Me.textSensorsDisabled.Name = "textSensorsDisabled"
        Me.textSensorsDisabled.Size = New System.Drawing.Size(17, 16)
        Me.textSensorsDisabled.TabIndex = 34
        Me.textSensorsDisabled.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(708, 367)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(137, 16)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Sensors Disabled:"
        '
        'textLasersAligned
        '
        Me.textLasersAligned.AutoSize = True
        Me.textLasersAligned.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textLasersAligned.Location = New System.Drawing.Point(851, 418)
        Me.textLasersAligned.Name = "textLasersAligned"
        Me.textLasersAligned.Size = New System.Drawing.Size(17, 16)
        Me.textLasersAligned.TabIndex = 32
        Me.textLasersAligned.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(708, 418)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 16)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Lasers Aligned:"
        '
        'textSensorsOn
        '
        Me.textSensorsOn.AutoSize = True
        Me.textSensorsOn.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSensorsOn.Location = New System.Drawing.Point(851, 392)
        Me.textSensorsOn.Name = "textSensorsOn"
        Me.textSensorsOn.Size = New System.Drawing.Size(17, 16)
        Me.textSensorsOn.TabIndex = 30
        Me.textSensorsOn.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(708, 392)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Sensors On:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(224, 572)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 67)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Play Sound"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AlignmentProgressBar
        '
        Me.AlignmentProgressBar.Location = New System.Drawing.Point(20, 660)
        Me.AlignmentProgressBar.Name = "AlignmentProgressBar"
        Me.AlignmentProgressBar.Size = New System.Drawing.Size(504, 32)
        Me.AlignmentProgressBar.TabIndex = 24
        '
        'buttonStandbyMode
        '
        Me.buttonStandbyMode.Location = New System.Drawing.Point(122, 486)
        Me.buttonStandbyMode.Name = "buttonStandbyMode"
        Me.buttonStandbyMode.Size = New System.Drawing.Size(91, 67)
        Me.buttonStandbyMode.TabIndex = 22
        Me.buttonStandbyMode.Text = "Standby Mode"
        Me.buttonStandbyMode.UseVisualStyleBackColor = True
        '
        'buttonPlayMazeLame
        '
        Me.buttonPlayMazeLame.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonPlayMazeLame.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPlayMazeLame.Location = New System.Drawing.Point(708, 269)
        Me.buttonPlayMazeLame.Name = "buttonPlayMazeLame"
        Me.buttonPlayMazeLame.Size = New System.Drawing.Size(256, 61)
        Me.buttonPlayMazeLame.TabIndex = 21
        Me.buttonPlayMazeLame.Text = "PLAY MAZE (LAME)"
        Me.buttonPlayMazeLame.UseVisualStyleBackColor = False
        '
        'buttonPlayMazeProfessional
        '
        Me.buttonPlayMazeProfessional.BackColor = System.Drawing.Color.Yellow
        Me.buttonPlayMazeProfessional.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPlayMazeProfessional.Location = New System.Drawing.Point(708, 191)
        Me.buttonPlayMazeProfessional.Name = "buttonPlayMazeProfessional"
        Me.buttonPlayMazeProfessional.Size = New System.Drawing.Size(256, 61)
        Me.buttonPlayMazeProfessional.TabIndex = 20
        Me.buttonPlayMazeProfessional.Text = "PLAY MAZE (FUN)"
        Me.buttonPlayMazeProfessional.UseVisualStyleBackColor = False
        '
        'buttonPlayMazeWicked
        '
        Me.buttonPlayMazeWicked.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonPlayMazeWicked.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPlayMazeWicked.Location = New System.Drawing.Point(708, 111)
        Me.buttonPlayMazeWicked.Name = "buttonPlayMazeWicked"
        Me.buttonPlayMazeWicked.Size = New System.Drawing.Size(256, 61)
        Me.buttonPlayMazeWicked.TabIndex = 19
        Me.buttonPlayMazeWicked.Text = "PLAY MAZE (WICKED)"
        Me.buttonPlayMazeWicked.UseVisualStyleBackColor = False
        '
        'buttonPlayMazeInsane
        '
        Me.buttonPlayMazeInsane.BackColor = System.Drawing.Color.Red
        Me.buttonPlayMazeInsane.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPlayMazeInsane.Location = New System.Drawing.Point(708, 34)
        Me.buttonPlayMazeInsane.Name = "buttonPlayMazeInsane"
        Me.buttonPlayMazeInsane.Size = New System.Drawing.Size(256, 61)
        Me.buttonPlayMazeInsane.TabIndex = 18
        Me.buttonPlayMazeInsane.Text = "PLAY MAZE (INSANE)"
        Me.buttonPlayMazeInsane.UseVisualStyleBackColor = False
        '
        'buttonAllRelaysOff
        '
        Me.buttonAllRelaysOff.Location = New System.Drawing.Point(329, 393)
        Me.buttonAllRelaysOff.Name = "buttonAllRelaysOff"
        Me.buttonAllRelaysOff.Size = New System.Drawing.Size(91, 69)
        Me.buttonAllRelaysOff.TabIndex = 17
        Me.buttonAllRelaysOff.Text = "All Relays Off"
        Me.buttonAllRelaysOff.UseVisualStyleBackColor = True
        '
        'buttonAllRelaysOn
        '
        Me.buttonAllRelaysOn.Location = New System.Drawing.Point(224, 393)
        Me.buttonAllRelaysOn.Name = "buttonAllRelaysOn"
        Me.buttonAllRelaysOn.Size = New System.Drawing.Size(91, 69)
        Me.buttonAllRelaysOn.TabIndex = 16
        Me.buttonAllRelaysOn.Text = "All Relays On"
        Me.buttonAllRelaysOn.UseVisualStyleBackColor = True
        '
        'buttonAllLasersOff
        '
        Me.buttonAllLasersOff.Location = New System.Drawing.Point(122, 393)
        Me.buttonAllLasersOff.Name = "buttonAllLasersOff"
        Me.buttonAllLasersOff.Size = New System.Drawing.Size(91, 69)
        Me.buttonAllLasersOff.TabIndex = 15
        Me.buttonAllLasersOff.Text = "All Lasers Off"
        Me.buttonAllLasersOff.UseVisualStyleBackColor = True
        '
        'buttonAllLasersOn
        '
        Me.buttonAllLasersOn.Location = New System.Drawing.Point(20, 393)
        Me.buttonAllLasersOn.Name = "buttonAllLasersOn"
        Me.buttonAllLasersOn.Size = New System.Drawing.Size(91, 69)
        Me.buttonAllLasersOn.TabIndex = 14
        Me.buttonAllLasersOn.Text = "All Lasers On"
        Me.buttonAllLasersOn.UseVisualStyleBackColor = True
        '
        'buttonDebug
        '
        Me.buttonDebug.Location = New System.Drawing.Point(20, 486)
        Me.buttonDebug.Name = "buttonDebug"
        Me.buttonDebug.Size = New System.Drawing.Size(91, 67)
        Me.buttonDebug.TabIndex = 13
        Me.buttonDebug.Text = "Debug On/Off"
        Me.buttonDebug.UseVisualStyleBackColor = True
        '
        'buttonUpdateSensors
        '
        Me.buttonUpdateSensors.Location = New System.Drawing.Point(433, 393)
        Me.buttonUpdateSensors.Name = "buttonUpdateSensors"
        Me.buttonUpdateSensors.Size = New System.Drawing.Size(91, 67)
        Me.buttonUpdateSensors.TabIndex = 11
        Me.buttonUpdateSensors.Text = "Update Sensor Status"
        Me.buttonUpdateSensors.UseVisualStyleBackColor = True
        '
        'buttonAlignSystem
        '
        Me.buttonAlignSystem.Location = New System.Drawing.Point(224, 484)
        Me.buttonAlignSystem.Name = "buttonAlignSystem"
        Me.buttonAlignSystem.Size = New System.Drawing.Size(91, 69)
        Me.buttonAlignSystem.TabIndex = 10
        Me.buttonAlignSystem.Text = "Align System"
        Me.buttonAlignSystem.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(375, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 16)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Sensors"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Lasers"
        '
        'listViewSensors
        '
        Me.listViewSensors.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listViewSensors.GridLines = True
        Me.listViewSensors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listViewSensors.Location = New System.Drawing.Point(378, 35)
        Me.listViewSensors.Name = "listViewSensors"
        Me.listViewSensors.Size = New System.Drawing.Size(298, 338)
        Me.listViewSensors.TabIndex = 7
        Me.listViewSensors.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button4)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.tbRawComm)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.cPara6Txt)
        Me.TabPage4.Controls.Add(Me.cPara5Txt)
        Me.TabPage4.Controls.Add(Me.cPara4Txt)
        Me.TabPage4.Controls.Add(Me.cPara3Txt)
        Me.TabPage4.Controls.Add(Me.cPara2Txt)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.cPara1Txt)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.ccodeTxt)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.manualSendAddTxt)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1012, 701)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Manual Communications"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(313, 239)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 51)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Raw Communications"
        '
        'tbRawComm
        '
        Me.tbRawComm.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRawComm.Location = New System.Drawing.Point(6, 38)
        Me.tbRawComm.Multiline = True
        Me.tbRawComm.Name = "tbRawComm"
        Me.tbRawComm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbRawComm.Size = New System.Drawing.Size(291, 367)
        Me.tbRawComm.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(313, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 63)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "SEND"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(624, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "CPara6"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(564, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "CPara5"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(506, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "CPara4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "CPara3"
        '
        'cPara6Txt
        '
        Me.cPara6Txt.Location = New System.Drawing.Point(627, 107)
        Me.cPara6Txt.Name = "cPara6Txt"
        Me.cPara6Txt.Size = New System.Drawing.Size(38, 23)
        Me.cPara6Txt.TabIndex = 13
        Me.cPara6Txt.Text = "000"
        '
        'cPara5Txt
        '
        Me.cPara5Txt.Location = New System.Drawing.Point(567, 107)
        Me.cPara5Txt.Name = "cPara5Txt"
        Me.cPara5Txt.Size = New System.Drawing.Size(38, 23)
        Me.cPara5Txt.TabIndex = 12
        Me.cPara5Txt.Text = "000"
        '
        'cPara4Txt
        '
        Me.cPara4Txt.Location = New System.Drawing.Point(509, 107)
        Me.cPara4Txt.Name = "cPara4Txt"
        Me.cPara4Txt.Size = New System.Drawing.Size(38, 23)
        Me.cPara4Txt.TabIndex = 11
        Me.cPara4Txt.Text = "000"
        '
        'cPara3Txt
        '
        Me.cPara3Txt.Location = New System.Drawing.Point(452, 107)
        Me.cPara3Txt.Name = "cPara3Txt"
        Me.cPara3Txt.Size = New System.Drawing.Size(38, 23)
        Me.cPara3Txt.TabIndex = 10
        Me.cPara3Txt.Text = "000"
        '
        'cPara2Txt
        '
        Me.cPara2Txt.Location = New System.Drawing.Point(399, 107)
        Me.cPara2Txt.Name = "cPara2Txt"
        Me.cPara2Txt.Size = New System.Drawing.Size(38, 23)
        Me.cPara2Txt.TabIndex = 9
        Me.cPara2Txt.Text = "000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(396, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CPara2"
        '
        'cPara1Txt
        '
        Me.cPara1Txt.Location = New System.Drawing.Point(342, 107)
        Me.cPara1Txt.Name = "cPara1Txt"
        Me.cPara1Txt.Size = New System.Drawing.Size(41, 23)
        Me.cPara1Txt.TabIndex = 7
        Me.cPara1Txt.Text = "001"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CPara1"
        '
        'ccodeTxt
        '
        Me.ccodeTxt.Location = New System.Drawing.Point(306, 107)
        Me.ccodeTxt.Name = "ccodeTxt"
        Me.ccodeTxt.Size = New System.Drawing.Size(32, 23)
        Me.ccodeTxt.TabIndex = 5
        Me.ccodeTxt.Text = "60"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CC"
        '
        'manualSendAddTxt
        '
        Me.manualSendAddTxt.Location = New System.Drawing.Point(306, 54)
        Me.manualSendAddTxt.Name = "manualSendAddTxt"
        Me.manualSendAddTxt.Size = New System.Drawing.Size(59, 23)
        Me.manualSendAddTxt.TabIndex = 1
        Me.manualSendAddTxt.Text = "1002"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Xbee Address"
        '
        'timerUpdateUX
        '
        Me.timerUpdateUX.Enabled = True
        Me.timerUpdateUX.Interval = 1000
        '
        'timerUpdateSensors
        '
        Me.timerUpdateSensors.Interval = 600
        '
        'ConsoleScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Name = "ConsoleScreen"
        Me.Text = "Mazer Lazer System Software Console"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents manualSendAddTxt As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents cPara2Txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cPara1Txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ccodeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cPara6Txt As System.Windows.Forms.TextBox
    Friend WithEvents cPara5Txt As System.Windows.Forms.TextBox
    Friend WithEvents cPara4Txt As System.Windows.Forms.TextBox
    Friend WithEvents cPara3Txt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbRawComm As System.Windows.Forms.TextBox
    Friend WithEvents timerUpdateUX As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents timerUpdateSensors As System.Windows.Forms.Timer
    Friend WithEvents listViewSensors As System.Windows.Forms.ListView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents buttonUpdateSensors As System.Windows.Forms.Button
    Friend WithEvents buttonAlignSystem As System.Windows.Forms.Button
    Friend WithEvents buttonAllLasersOn As System.Windows.Forms.Button
    Friend WithEvents buttonDebug As System.Windows.Forms.Button
    Friend WithEvents buttonAllLasersOff As System.Windows.Forms.Button
    Friend WithEvents buttonAllRelaysOff As System.Windows.Forms.Button
    Friend WithEvents buttonAllRelaysOn As System.Windows.Forms.Button
    Friend WithEvents buttonPlayMazeInsane As System.Windows.Forms.Button
    Friend WithEvents buttonPlayMazeWicked As System.Windows.Forms.Button
    Friend WithEvents buttonPlayMazeLame As System.Windows.Forms.Button
    Friend WithEvents buttonPlayMazeProfessional As System.Windows.Forms.Button
    Friend WithEvents buttonStandbyMode As System.Windows.Forms.Button
    Friend WithEvents AlignmentProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents textSensorsOn As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents textLasersAligned As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents textSensorsDisabled As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents textSensorMode As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents buttonAttractMode As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button10 As System.Windows.Forms.Button

End Class
