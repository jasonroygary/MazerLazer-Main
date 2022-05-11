<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemStartup
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
        Me.AlignmentProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.systemVersion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timerStartAlignment = New System.Windows.Forms.Timer(Me.components)
        Me.textLaserCountDisabled = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.textLaserCountRed = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.textLaserCountBlue = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.textLaserCountGreen = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textLaserCount = New System.Windows.Forms.Label()
        Me.timerUX = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'AlignmentProgressBar
        '
        Me.AlignmentProgressBar.ForeColor = System.Drawing.Color.DarkOrange
        Me.AlignmentProgressBar.Location = New System.Drawing.Point(95, 283)
        Me.AlignmentProgressBar.Name = "AlignmentProgressBar"
        Me.AlignmentProgressBar.Size = New System.Drawing.Size(825, 175)
        Me.AlignmentProgressBar.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Square721 BT", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(222, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(624, 78)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "SYSTEM STARTUP"
        '
        'systemVersion
        '
        Me.systemVersion.AutoSize = True
        Me.systemVersion.Font = New System.Drawing.Font("Square721 BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.systemVersion.ForeColor = System.Drawing.Color.White
        Me.systemVersion.Location = New System.Drawing.Point(230, 143)
        Me.systemVersion.Name = "systemVersion"
        Me.systemVersion.Size = New System.Drawing.Size(300, 26)
        Me.systemVersion.TabIndex = 27
        Me.systemVersion.Text = "Version 1.0 (07/06/2011)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Square721 BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(230, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 26)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "On Our Own Games LLC"
        '
        'timerStartAlignment
        '
        Me.timerStartAlignment.Enabled = True
        '
        'textLaserCountDisabled
        '
        Me.textLaserCountDisabled.AutoSize = True
        Me.textLaserCountDisabled.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textLaserCountDisabled.ForeColor = System.Drawing.Color.White
        Me.textLaserCountDisabled.Location = New System.Drawing.Point(235, 630)
        Me.textLaserCountDisabled.Name = "textLaserCountDisabled"
        Me.textLaserCountDisabled.Size = New System.Drawing.Size(17, 16)
        Me.textLaserCountDisabled.TabIndex = 44
        Me.textLaserCountDisabled.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(92, 630)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 16)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Disabled Lasers:"
        '
        'textLaserCountRed
        '
        Me.textLaserCountRed.AutoSize = True
        Me.textLaserCountRed.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textLaserCountRed.ForeColor = System.Drawing.Color.White
        Me.textLaserCountRed.Location = New System.Drawing.Point(235, 551)
        Me.textLaserCountRed.Name = "textLaserCountRed"
        Me.textLaserCountRed.Size = New System.Drawing.Size(17, 16)
        Me.textLaserCountRed.TabIndex = 42
        Me.textLaserCountRed.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(92, 551)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 16)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Red Lasers:"
        '
        'textLaserCountBlue
        '
        Me.textLaserCountBlue.AutoSize = True
        Me.textLaserCountBlue.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textLaserCountBlue.ForeColor = System.Drawing.Color.White
        Me.textLaserCountBlue.Location = New System.Drawing.Point(235, 603)
        Me.textLaserCountBlue.Name = "textLaserCountBlue"
        Me.textLaserCountBlue.Size = New System.Drawing.Size(17, 16)
        Me.textLaserCountBlue.TabIndex = 40
        Me.textLaserCountBlue.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(92, 603)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 16)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Blue Lasers:"
        '
        'textLaserCountGreen
        '
        Me.textLaserCountGreen.AutoSize = True
        Me.textLaserCountGreen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textLaserCountGreen.ForeColor = System.Drawing.Color.White
        Me.textLaserCountGreen.Location = New System.Drawing.Point(235, 577)
        Me.textLaserCountGreen.Name = "textLaserCountGreen"
        Me.textLaserCountGreen.Size = New System.Drawing.Size(17, 16)
        Me.textLaserCountGreen.TabIndex = 38
        Me.textLaserCountGreen.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(92, 577)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 16)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Green Lasers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Square721 BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(230, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 26)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Mazer Lazer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(92, 523)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Total Lasers:"
        '
        'textLaserCount
        '
        Me.textLaserCount.AutoSize = True
        Me.textLaserCount.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textLaserCount.ForeColor = System.Drawing.Color.White
        Me.textLaserCount.Location = New System.Drawing.Point(235, 523)
        Me.textLaserCount.Name = "textLaserCount"
        Me.textLaserCount.Size = New System.Drawing.Size(17, 16)
        Me.textLaserCount.TabIndex = 47
        Me.textLaserCount.Text = "0"
        '
        'timerUX
        '
        Me.timerUX.Enabled = True
        '
        'SystemStartup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.textLaserCount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textLaserCountDisabled)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.textLaserCountRed)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.textLaserCountBlue)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.textLaserCountGreen)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.systemVersion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AlignmentProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SystemStartup"
        Me.Text = "SystemStartup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AlignmentProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents systemVersion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents timerStartAlignment As System.Windows.Forms.Timer
    Friend WithEvents textLaserCountDisabled As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents textLaserCountRed As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents textLaserCountBlue As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents textLaserCountGreen As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents textLaserCount As System.Windows.Forms.Label
    Friend WithEvents timerUX As System.Windows.Forms.Timer
End Class
