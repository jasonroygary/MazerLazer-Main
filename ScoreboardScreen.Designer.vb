<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreboardScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScoreboardScreen))
        Me.AxXCast1 = New AxXCASTLib.AxXCast()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.labelTime = New System.Windows.Forms.Label()
        Me.labelScore = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.labelDifficulity = New System.Windows.Forms.Label()
        Me.labelBeamsBroken = New System.Windows.Forms.Label()
        Me.labelRedBeams = New System.Windows.Forms.Label()
        Me.labelGreenBeams = New System.Windows.Forms.Label()
        Me.labelBlueBeams = New System.Windows.Forms.Label()
        Me.labelBonusButtons = New System.Windows.Forms.Label()
        Me.timerUpdateScore = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AxXCast1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxXCast1
        '
        Me.AxXCast1.Enabled = True
        Me.AxXCast1.Location = New System.Drawing.Point(22, 89)
        Me.AxXCast1.Name = "AxXCast1"
        Me.AxXCast1.OcxState = CType(resources.GetObject("AxXCast1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxXCast1.Size = New System.Drawing.Size(756, 599)
        Me.AxXCast1.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1366, 768)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.White
        Me.RectangleShape2.BorderWidth = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(850, 226)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(486, 470)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(24, 1034)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1282, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1367, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 78)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Time Remaining"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Quartz MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1367, 465)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 77)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "35 Seconds"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Quartz MS", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(784, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(564, 96)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SCORE BOARD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Square721 BT", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1367, 621)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(493, 78)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Beams Broken"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Square721 BT", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1367, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(498, 78)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Current Score"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Quartz MS", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1364, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(317, 96)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "10,350"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Quartz MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1384, 699)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 77)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "4"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Square721 BT", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1384, 828)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(396, 78)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Game Level"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Quartz MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1384, 906)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(253, 77)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "INSANE"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(22, 665)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(756, 40)
        Me.Button2.TabIndex = 12
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Square721 BT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(854, 239)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(198, 59)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "SCORE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Square721 BT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(854, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 59)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "TIME"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Square721 BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(857, 433)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(291, 40)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "BEAMS BROKEN"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Square721 BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(903, 489)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(220, 40)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "RED BEAMS"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Square721 BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(857, 648)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(311, 40)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "BONUS BUTTONS"
        '
        'labelTime
        '
        Me.labelTime.AutoSize = True
        Me.labelTime.BackColor = System.Drawing.Color.Transparent
        Me.labelTime.Font = New System.Drawing.Font("Square721 BT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTime.ForeColor = System.Drawing.Color.White
        Me.labelTime.Location = New System.Drawing.Point(1127, 322)
        Me.labelTime.Name = "labelTime"
        Me.labelTime.Size = New System.Drawing.Size(91, 59)
        Me.labelTime.TabIndex = 18
        Me.labelTime.Text = "30"
        '
        'labelScore
        '
        Me.labelScore.AutoSize = True
        Me.labelScore.BackColor = System.Drawing.Color.Transparent
        Me.labelScore.Font = New System.Drawing.Font("Square721 BT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelScore.ForeColor = System.Drawing.Color.White
        Me.labelScore.Location = New System.Drawing.Point(1127, 239)
        Me.labelScore.Name = "labelScore"
        Me.labelScore.Size = New System.Drawing.Size(207, 59)
        Me.labelScore.TabIndex = 19
        Me.labelScore.Text = "13,524"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Square721 BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(903, 538)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(266, 40)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "GREEN BEAMS"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Square721 BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(903, 589)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(240, 40)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "BLUE BEAMS"
        '
        'labelDifficulity
        '
        Me.labelDifficulity.AutoSize = True
        Me.labelDifficulity.BackColor = System.Drawing.Color.Transparent
        Me.labelDifficulity.Font = New System.Drawing.Font("Square721 BT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDifficulity.ForeColor = System.Drawing.Color.White
        Me.labelDifficulity.Location = New System.Drawing.Point(982, 121)
        Me.labelDifficulity.Name = "labelDifficulity"
        Me.labelDifficulity.Size = New System.Drawing.Size(215, 59)
        Me.labelDifficulity.TabIndex = 22
        Me.labelDifficulity.Text = "INSANE"
        '
        'labelBeamsBroken
        '
        Me.labelBeamsBroken.AutoSize = True
        Me.labelBeamsBroken.BackColor = System.Drawing.Color.Transparent
        Me.labelBeamsBroken.Font = New System.Drawing.Font("Square721 BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBeamsBroken.ForeColor = System.Drawing.Color.White
        Me.labelBeamsBroken.Location = New System.Drawing.Point(1240, 433)
        Me.labelBeamsBroken.Name = "labelBeamsBroken"
        Me.labelBeamsBroken.Size = New System.Drawing.Size(63, 40)
        Me.labelBeamsBroken.TabIndex = 23
        Me.labelBeamsBroken.Text = "12"
        '
        'labelRedBeams
        '
        Me.labelRedBeams.AutoSize = True
        Me.labelRedBeams.BackColor = System.Drawing.Color.Transparent
        Me.labelRedBeams.Font = New System.Drawing.Font("Square721 BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRedBeams.ForeColor = System.Drawing.Color.White
        Me.labelRedBeams.Location = New System.Drawing.Point(1240, 489)
        Me.labelRedBeams.Name = "labelRedBeams"
        Me.labelRedBeams.Size = New System.Drawing.Size(63, 40)
        Me.labelRedBeams.TabIndex = 24
        Me.labelRedBeams.Text = "04"
        '
        'labelGreenBeams
        '
        Me.labelGreenBeams.AutoSize = True
        Me.labelGreenBeams.BackColor = System.Drawing.Color.Transparent
        Me.labelGreenBeams.Font = New System.Drawing.Font("Square721 BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGreenBeams.ForeColor = System.Drawing.Color.White
        Me.labelGreenBeams.Location = New System.Drawing.Point(1240, 538)
        Me.labelGreenBeams.Name = "labelGreenBeams"
        Me.labelGreenBeams.Size = New System.Drawing.Size(63, 40)
        Me.labelGreenBeams.TabIndex = 25
        Me.labelGreenBeams.Text = "04"
        '
        'labelBlueBeams
        '
        Me.labelBlueBeams.AutoSize = True
        Me.labelBlueBeams.BackColor = System.Drawing.Color.Transparent
        Me.labelBlueBeams.Font = New System.Drawing.Font("Square721 BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBlueBeams.ForeColor = System.Drawing.Color.White
        Me.labelBlueBeams.Location = New System.Drawing.Point(1240, 589)
        Me.labelBlueBeams.Name = "labelBlueBeams"
        Me.labelBlueBeams.Size = New System.Drawing.Size(63, 40)
        Me.labelBlueBeams.TabIndex = 26
        Me.labelBlueBeams.Text = "04"
        '
        'labelBonusButtons
        '
        Me.labelBonusButtons.AutoSize = True
        Me.labelBonusButtons.BackColor = System.Drawing.Color.Transparent
        Me.labelBonusButtons.Font = New System.Drawing.Font("Square721 BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBonusButtons.ForeColor = System.Drawing.Color.White
        Me.labelBonusButtons.Location = New System.Drawing.Point(1240, 648)
        Me.labelBonusButtons.Name = "labelBonusButtons"
        Me.labelBonusButtons.Size = New System.Drawing.Size(63, 40)
        Me.labelBonusButtons.TabIndex = 27
        Me.labelBonusButtons.Text = "04"
        '
        'timerUpdateScore
        '
        Me.timerUpdateScore.Enabled = True
        '
        'ScoreboardScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mazer_Lazer_System_Software.My.Resources.Resources.laser2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.labelBonusButtons)
        Me.Controls.Add(Me.labelBlueBeams)
        Me.Controls.Add(Me.labelGreenBeams)
        Me.Controls.Add(Me.labelRedBeams)
        Me.Controls.Add(Me.labelBeamsBroken)
        Me.Controls.Add(Me.labelDifficulity)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.labelScore)
        Me.Controls.Add(Me.labelTime)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AxXCast1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScoreboardScreen"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "ScoreboardScreen"
        CType(Me.AxXCast1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxXCast1 As AxXCASTLib.AxXCast
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents labelTime As System.Windows.Forms.Label
    Friend WithEvents labelScore As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents labelDifficulity As System.Windows.Forms.Label
    Friend WithEvents labelBeamsBroken As System.Windows.Forms.Label
    Friend WithEvents labelRedBeams As System.Windows.Forms.Label
    Friend WithEvents labelGreenBeams As System.Windows.Forms.Label
    Friend WithEvents labelBlueBeams As System.Windows.Forms.Label
    Friend WithEvents labelBonusButtons As System.Windows.Forms.Label
    Friend WithEvents timerUpdateScore As System.Windows.Forms.Timer
End Class
