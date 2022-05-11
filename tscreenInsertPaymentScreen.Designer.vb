<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tscreenInsertPaymentScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tscreenInsertPaymentScreen))
        Me.labelMazer = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.labelThreeGamePrice = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.labelOneGamePrice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBoxAttractScreen = New System.Windows.Forms.PictureBox()
        Me.PhotoTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.label111 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.labelCurrentCredit = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.labelNeededCredit = New System.Windows.Forms.Label()
        Me.timerCheckCurrentCredit = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.timerBlinkInsertBills = New System.Windows.Forms.Timer(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.labelLazer = New System.Windows.Forms.Label()
        Me.timerAttractMode = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxAttractScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelMazer
        '
        Me.labelMazer.AutoSize = True
        Me.labelMazer.BackColor = System.Drawing.Color.Transparent
        Me.labelMazer.Font = New System.Drawing.Font("Quartz MS", 110.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMazer.ForeColor = System.Drawing.Color.White
        Me.labelMazer.Location = New System.Drawing.Point(0, -23)
        Me.labelMazer.Name = "labelMazer"
        Me.labelMazer.Size = New System.Drawing.Size(579, 177)
        Me.labelMazer.TabIndex = 1
        Me.labelMazer.Text = "Mazer"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.labelThreeGamePrice)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.labelOneGamePrice)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 492)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 179)
        Me.Panel1.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(321, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 44)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = ".00"
        Me.Label8.Visible = False
        '
        'labelThreeGamePrice
        '
        Me.labelThreeGamePrice.AutoSize = True
        Me.labelThreeGamePrice.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelThreeGamePrice.ForeColor = System.Drawing.Color.White
        Me.labelThreeGamePrice.Location = New System.Drawing.Point(294, 21)
        Me.labelThreeGamePrice.Name = "labelThreeGamePrice"
        Me.labelThreeGamePrice.Size = New System.Drawing.Size(44, 44)
        Me.labelThreeGamePrice.TabIndex = 7
        Me.labelThreeGamePrice.Text = "5"
        Me.labelThreeGamePrice.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(265, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 44)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "$"
        Me.Label10.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(321, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 44)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = ".00"
        '
        'labelOneGamePrice
        '
        Me.labelOneGamePrice.AutoSize = True
        Me.labelOneGamePrice.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelOneGamePrice.ForeColor = System.Drawing.Color.White
        Me.labelOneGamePrice.Location = New System.Drawing.Point(294, 99)
        Me.labelOneGamePrice.Name = "labelOneGamePrice"
        Me.labelOneGamePrice.Size = New System.Drawing.Size(44, 44)
        Me.labelOneGamePrice.TabIndex = 4
        Me.labelOneGamePrice.Text = "2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Quartz MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(519, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 33)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(265, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 44)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "$"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 44)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Three Trips"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 44)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "One Trip"
        '
        'PictureBoxAttractScreen
        '
        Me.PictureBoxAttractScreen.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxAttractScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxAttractScreen.ImageLocation = "c:\mazerlazer\attractscreenphotos\1.jpg"
        Me.PictureBoxAttractScreen.Location = New System.Drawing.Point(480, 149)
        Me.PictureBoxAttractScreen.Name = "PictureBoxAttractScreen"
        Me.PictureBoxAttractScreen.Size = New System.Drawing.Size(516, 390)
        Me.PictureBoxAttractScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxAttractScreen.TabIndex = 3
        Me.PictureBoxAttractScreen.TabStop = False
        '
        'PhotoTimer
        '
        Me.PhotoTimer.Enabled = True
        Me.PhotoTimer.Interval = 1750
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Quartz MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(169, 682)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(705, 77)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Insert $5 or $1 Bill"
        '
        'label111
        '
        Me.label111.AutoSize = True
        Me.label111.BackColor = System.Drawing.Color.Transparent
        Me.label111.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label111.ForeColor = System.Drawing.Color.White
        Me.label111.Location = New System.Drawing.Point(490, 551)
        Me.label111.Name = "label111"
        Me.label111.Size = New System.Drawing.Size(348, 44)
        Me.label111.TabIndex = 10
        Me.label111.Text = "Current Credit: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(492, 602)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(309, 44)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Needed Credit:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(830, 551)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 44)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "$"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(830, 602)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 44)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "$"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(892, 551)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 44)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = ".00"
        '
        'labelCurrentCredit
        '
        Me.labelCurrentCredit.AutoSize = True
        Me.labelCurrentCredit.BackColor = System.Drawing.Color.Transparent
        Me.labelCurrentCredit.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCurrentCredit.ForeColor = System.Drawing.Color.White
        Me.labelCurrentCredit.Location = New System.Drawing.Point(865, 551)
        Me.labelCurrentCredit.Name = "labelCurrentCredit"
        Me.labelCurrentCredit.Size = New System.Drawing.Size(44, 44)
        Me.labelCurrentCredit.TabIndex = 9
        Me.labelCurrentCredit.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(892, 602)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 44)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = ".00"
        '
        'labelNeededCredit
        '
        Me.labelNeededCredit.AutoSize = True
        Me.labelNeededCredit.BackColor = System.Drawing.Color.Transparent
        Me.labelNeededCredit.Font = New System.Drawing.Font("Quartz MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNeededCredit.ForeColor = System.Drawing.Color.White
        Me.labelNeededCredit.Location = New System.Drawing.Point(865, 602)
        Me.labelNeededCredit.Name = "labelNeededCredit"
        Me.labelNeededCredit.Size = New System.Drawing.Size(44, 44)
        Me.labelNeededCredit.TabIndex = 13
        Me.labelNeededCredit.Text = "2"
        '
        'timerCheckCurrentCredit
        '
        Me.timerCheckCurrentCredit.Enabled = True
        Me.timerCheckCurrentCredit.Interval = 250
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Mazer_Lazer_System_Software.My.Resources.Resources.insertPaymentBubble_v2
        Me.PictureBox1.Location = New System.Drawing.Point(3, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(473, 331)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'timerBlinkInsertBills
        '
        Me.timerBlinkInsertBills.Enabled = True
        Me.timerBlinkInsertBills.Interval = 750
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Quartz MS", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(154, 682)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(670, 77)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Scan Ticket Below"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 736)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "$1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'labelLazer
        '
        Me.labelLazer.AutoSize = True
        Me.labelLazer.BackColor = System.Drawing.Color.Transparent
        Me.labelLazer.Font = New System.Drawing.Font("Quartz MS", 110.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLazer.ForeColor = System.Drawing.Color.White
        Me.labelLazer.Location = New System.Drawing.Point(535, -23)
        Me.labelLazer.Name = "labelLazer"
        Me.labelLazer.Size = New System.Drawing.Size(515, 177)
        Me.labelLazer.TabIndex = 22
        Me.labelLazer.Text = "Lazer"
        '
        'timerAttractMode
        '
        Me.timerAttractMode.Enabled = True
        Me.timerAttractMode.Interval = 20000
        '
        'tscreenInsertPaymentScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.labelNeededCredit)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.labelCurrentCredit)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label111)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBoxAttractScreen)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labelMazer)
        Me.Controls.Add(Me.labelLazer)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tscreenInsertPaymentScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TouchScreen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxAttractScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelMazer As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents labelOneGamePrice As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents labelThreeGamePrice As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxAttractScreen As System.Windows.Forms.PictureBox
    Friend WithEvents PhotoTimer As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents label111 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents labelCurrentCredit As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents labelNeededCredit As System.Windows.Forms.Label
    Friend WithEvents timerCheckCurrentCredit As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents timerBlinkInsertBills As System.Windows.Forms.Timer
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents labelLazer As System.Windows.Forms.Label
    Friend WithEvents timerAttractMode As System.Windows.Forms.Timer
End Class
