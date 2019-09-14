<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrayHover
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrayHover))
        Me.AirStateLabel = New System.Windows.Forms.Label()
        Me.AirDetailLabel = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AirStateLabel
        '
        Me.AirStateLabel.BackColor = System.Drawing.Color.Transparent
        Me.AirStateLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AirStateLabel.Font = New System.Drawing.Font("나눔스퀘어 ExtraBold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AirStateLabel.ForeColor = System.Drawing.Color.White
        Me.AirStateLabel.Location = New System.Drawing.Point(56, 25)
        Me.AirStateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AirStateLabel.Name = "AirStateLabel"
        Me.AirStateLabel.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.AirStateLabel.Size = New System.Drawing.Size(126, 29)
        Me.AirStateLabel.TabIndex = 8
        Me.AirStateLabel.Text = "로드 중"
        Me.AirStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AirDetailLabel
        '
        Me.AirDetailLabel.BackColor = System.Drawing.Color.Transparent
        Me.AirDetailLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AirDetailLabel.Font = New System.Drawing.Font("나눔스퀘어 Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AirDetailLabel.ForeColor = System.Drawing.Color.White
        Me.AirDetailLabel.Location = New System.Drawing.Point(6, 54)
        Me.AirDetailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AirDetailLabel.Name = "AirDetailLabel"
        Me.AirDetailLabel.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.AirDetailLabel.Size = New System.Drawing.Size(176, 31)
        Me.AirDetailLabel.TabIndex = 9
        Me.AirDetailLabel.Text = "미세/초미세: 15/15 (㎍/㎥)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1일 12:27:00"
        Me.AirDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.monZi.My.Resources.Resources.dash_back
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.monZi.My.Resources.Resources.dash_1
        Me.PictureBox2.Location = New System.Drawing.Point(6, 7)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.AirStateLabel)
        Me.MainPanel.Controls.Add(Me.TitleLabel)
        Me.MainPanel.Controls.Add(Me.PictureBox2)
        Me.MainPanel.Controls.Add(Me.AirDetailLabel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MainPanel.Size = New System.Drawing.Size(188, 92)
        Me.MainPanel.TabIndex = 12
        '
        'TitleLabel
        '
        Me.TitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleLabel.Font = New System.Drawing.Font("나눔스퀘어 Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(56, 7)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Padding = New System.Windows.Forms.Padding(6, 1, 0, 0)
        Me.TitleLabel.Size = New System.Drawing.Size(126, 18)
        Me.TitleLabel.TabIndex = 10
        Me.TitleLabel.Text = "monZi"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TrayHover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(188, 92)
        Me.Controls.Add(Me.MainPanel)
        Me.Font = New System.Drawing.Font("나눔스퀘어", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TrayHover"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "TrayHover"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AirStateLabel As Label
    Friend WithEvents AirDetailLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MainPanel As Panel
    Friend WithEvents TitleLabel As Label
End Class
