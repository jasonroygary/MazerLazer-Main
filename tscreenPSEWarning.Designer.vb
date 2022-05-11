<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tscreenPSEWarning
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tscreenPSEWarning))
        Me.buttonPSEOff = New System.Windows.Forms.Button()
        Me.buttonPSEON = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timerBlinkWarning = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonPSEOff
        '
        Me.buttonPSEOff.BackColor = System.Drawing.Color.DarkOrange
        Me.buttonPSEOff.Font = New System.Drawing.Font("Square721 BT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPSEOff.Location = New System.Drawing.Point(727, 93)
        Me.buttonPSEOff.Name = "buttonPSEOff"
        Me.buttonPSEOff.Size = New System.Drawing.Size(269, 388)
        Me.buttonPSEOff.TabIndex = 1
        Me.buttonPSEOff.Text = "Agree and Continue"
        Me.buttonPSEOff.UseVisualStyleBackColor = False
        '
        'buttonPSEON
        '
        Me.buttonPSEON.BackColor = System.Drawing.Color.SlateGray
        Me.buttonPSEON.Font = New System.Drawing.Font("Square721 BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPSEON.ForeColor = System.Drawing.Color.White
        Me.buttonPSEON.Location = New System.Drawing.Point(727, 529)
        Me.buttonPSEON.Name = "buttonPSEON"
        Me.buttonPSEON.Size = New System.Drawing.Size(269, 119)
        Me.buttonPSEON.TabIndex = 2
        Me.buttonPSEON.Text = "Less Intense Experience"
        Me.buttonPSEON.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(683, 555)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Quartz MS", 54.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(375, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 88)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "WARNING"
        '
        'timerBlinkWarning
        '
        Me.timerBlinkWarning.Interval = 1000
        '
        'tscreenPSEWarning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.buttonPSEON)
        Me.Controls.Add(Me.buttonPSEOff)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tscreenPSEWarning"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PSEWarning"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonPSEOff As System.Windows.Forms.Button
    Friend WithEvents buttonPSEON As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents timerBlinkWarning As System.Windows.Forms.Timer
End Class
