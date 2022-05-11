<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tscreenGetTicketBelow
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timerBlinkArrow = New System.Windows.Forms.Timer(Me.components)
        Me.timerGoToNextScreen = New System.Windows.Forms.Timer(Me.components)
        Me.timerPrintTickets = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Mazer_Lazer_System_Software.My.Resources.Resources.TicketBelow_Arrow2
        Me.PictureBox1.Location = New System.Drawing.Point(265, 238)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(534, 480)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Quartz MS", 80.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-15, -6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1045, 129)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "GET TICKET BELOW"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Quartz MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(908, 58)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "USE TICKETS FOR ADDITIONAL GAMES"
        '
        'timerBlinkArrow
        '
        Me.timerBlinkArrow.Enabled = True
        Me.timerBlinkArrow.Interval = 400
        '
        'timerGoToNextScreen
        '
        Me.timerGoToNextScreen.Enabled = True
        Me.timerGoToNextScreen.Interval = 8000
        '
        'timerPrintTickets
        '
        Me.timerPrintTickets.Enabled = True
        Me.timerPrintTickets.Interval = 600
        '
        'tscreenGetTicketBelow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mazer_Lazer_System_Software.My.Resources.Resources.lasers
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tscreenGetTicketBelow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "tscreenGetTicketBelow"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents timerBlinkArrow As System.Windows.Forms.Timer
    Friend WithEvents timerGoToNextScreen As System.Windows.Forms.Timer
    Friend WithEvents timerPrintTickets As System.Windows.Forms.Timer
End Class
