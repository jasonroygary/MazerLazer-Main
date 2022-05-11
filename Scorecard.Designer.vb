<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scorecard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scorecard))
        Me.labelBeamsBroken = New System.Windows.Forms.Label()
        Me.labelButtons = New System.Windows.Forms.Label()
        Me.labelDifficulity = New System.Windows.Forms.Label()
        Me.labelTime = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.labelScore = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.labelTurn = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.labelRed = New System.Windows.Forms.Label()
        Me.labelBlue = New System.Windows.Forms.Label()
        Me.labelGreen = New System.Windows.Forms.Label()
        Me.labelPlayerLevel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelBeamsBroken
        '
        Me.labelBeamsBroken.AutoSize = True
        Me.labelBeamsBroken.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBeamsBroken.Location = New System.Drawing.Point(168, 493)
        Me.labelBeamsBroken.Name = "labelBeamsBroken"
        Me.labelBeamsBroken.Size = New System.Drawing.Size(24, 23)
        Me.labelBeamsBroken.TabIndex = 28
        Me.labelBeamsBroken.Text = "4"
        '
        'labelButtons
        '
        Me.labelButtons.AutoSize = True
        Me.labelButtons.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelButtons.Location = New System.Drawing.Point(168, 427)
        Me.labelButtons.Name = "labelButtons"
        Me.labelButtons.Size = New System.Drawing.Size(24, 23)
        Me.labelButtons.TabIndex = 27
        Me.labelButtons.Text = "2"
        '
        'labelDifficulity
        '
        Me.labelDifficulity.AutoSize = True
        Me.labelDifficulity.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDifficulity.Location = New System.Drawing.Point(168, 358)
        Me.labelDifficulity.Name = "labelDifficulity"
        Me.labelDifficulity.Size = New System.Drawing.Size(90, 23)
        Me.labelDifficulity.TabIndex = 26
        Me.labelDifficulity.Text = "INSANE"
        '
        'labelTime
        '
        Me.labelTime.AutoSize = True
        Me.labelTime.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTime.Location = New System.Drawing.Point(168, 394)
        Me.labelTime.Name = "labelTime"
        Me.labelTime.Size = New System.Drawing.Size(38, 23)
        Me.labelTime.TabIndex = 25
        Me.labelTime.Text = "31"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 668)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(219, 23)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "lasertagorlando.com"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 23)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "LEVEL"
        '
        'labelScore
        '
        Me.labelScore.AutoSize = True
        Me.labelScore.Font = New System.Drawing.Font("Square721 BT", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelScore.Location = New System.Drawing.Point(120, 296)
        Me.labelScore.Name = "labelScore"
        Me.labelScore.Size = New System.Drawing.Size(131, 36)
        Me.labelScore.TabIndex = 22
        Me.labelScore.Text = "10,030"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 427)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 23)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "BUTTONS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 493)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "BROKEN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "TIME LEFT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Quartz MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 42)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "MAZER LAZER"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2500
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Square721 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 30)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "SCORE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mazer_Lazer_System_Software.My.Resources.Resources.woodsLogo
        Me.PictureBox1.Location = New System.Drawing.Point(32, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(4, 349)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(263, 305)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(281, 700)
        Me.ShapeContainer1.TabIndex = 29
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 5
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 16
        Me.LineShape2.X2 = 248
        Me.LineShape2.Y1 = 488
        Me.LineShape2.Y2 = 488
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 15
        Me.LineShape1.X2 = 247
        Me.LineShape1.Y1 = 593
        Me.LineShape1.Y2 = 593
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 516)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 23)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "RED"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 460)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(155, 23)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "TURN BUTTON"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 562)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 23)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "BLUE"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 539)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 23)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "GREEN"
        '
        'labelTurn
        '
        Me.labelTurn.AutoSize = True
        Me.labelTurn.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTurn.Location = New System.Drawing.Point(168, 460)
        Me.labelTurn.Name = "labelTurn"
        Me.labelTurn.Size = New System.Drawing.Size(24, 23)
        Me.labelTurn.TabIndex = 34
        Me.labelTurn.Text = "2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 600)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 23)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "YOU ARE:"
        '
        'labelRed
        '
        Me.labelRed.AutoSize = True
        Me.labelRed.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRed.Location = New System.Drawing.Point(168, 516)
        Me.labelRed.Name = "labelRed"
        Me.labelRed.Size = New System.Drawing.Size(24, 23)
        Me.labelRed.TabIndex = 36
        Me.labelRed.Text = "4"
        '
        'labelBlue
        '
        Me.labelBlue.AutoSize = True
        Me.labelBlue.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBlue.Location = New System.Drawing.Point(168, 562)
        Me.labelBlue.Name = "labelBlue"
        Me.labelBlue.Size = New System.Drawing.Size(24, 23)
        Me.labelBlue.TabIndex = 37
        Me.labelBlue.Text = "4"
        '
        'labelGreen
        '
        Me.labelGreen.AutoSize = True
        Me.labelGreen.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGreen.Location = New System.Drawing.Point(168, 539)
        Me.labelGreen.Name = "labelGreen"
        Me.labelGreen.Size = New System.Drawing.Size(24, 23)
        Me.labelGreen.TabIndex = 38
        Me.labelGreen.Text = "4"
        '
        'labelPlayerLevel
        '
        Me.labelPlayerLevel.AutoSize = True
        Me.labelPlayerLevel.Font = New System.Drawing.Font("Square721 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPlayerLevel.Location = New System.Drawing.Point(14, 623)
        Me.labelPlayerLevel.Name = "labelPlayerLevel"
        Me.labelPlayerLevel.Size = New System.Drawing.Size(65, 23)
        Me.labelPlayerLevel.TabIndex = 39
        Me.labelPlayerLevel.Text = "ELITE"
        '
        'Scorecard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(281, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.labelPlayerLevel)
        Me.Controls.Add(Me.labelGreen)
        Me.Controls.Add(Me.labelBlue)
        Me.Controls.Add(Me.labelRed)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.labelTurn)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.labelBeamsBroken)
        Me.Controls.Add(Me.labelButtons)
        Me.Controls.Add(Me.labelDifficulity)
        Me.Controls.Add(Me.labelTime)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.labelScore)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.No
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "Scorecard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scorecard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelBeamsBroken As System.Windows.Forms.Label
    Friend WithEvents labelButtons As System.Windows.Forms.Label
    Friend WithEvents labelDifficulity As System.Windows.Forms.Label
    Friend WithEvents labelTime As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents labelScore As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents labelTurn As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents labelGreen As System.Windows.Forms.Label
    Friend WithEvents labelBlue As System.Windows.Forms.Label
    Friend WithEvents labelRed As System.Windows.Forms.Label
    Friend WithEvents labelPlayerLevel As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
