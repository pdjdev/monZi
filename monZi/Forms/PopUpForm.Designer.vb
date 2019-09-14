<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUpForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopUpForm))
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.OptBT = New System.Windows.Forms.PictureBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CloseBT = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AirDetailLabel = New System.Windows.Forms.Label()
        Me.AirStateLabel = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.AirCommentLabel = New System.Windows.Forms.Label()
        Me.AniTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FirstWaitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TopPanel.SuspendLayout()
        CType(Me.OptBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.OptBT)
        Me.TopPanel.Controls.Add(Me.TitleLabel)
        Me.TopPanel.Controls.Add(Me.CloseBT)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.TopPanel.Size = New System.Drawing.Size(374, 30)
        Me.TopPanel.TabIndex = 6
        '
        'OptBT
        '
        Me.OptBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.OptBT.Image = Global.monZi.My.Resources.Resources.opticon
        Me.OptBT.Location = New System.Drawing.Point(280, 0)
        Me.OptBT.Margin = New System.Windows.Forms.Padding(2)
        Me.OptBT.Name = "OptBT"
        Me.OptBT.Size = New System.Drawing.Size(47, 30)
        Me.OptBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OptBT.TabIndex = 6
        Me.OptBT.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.Font = New System.Drawing.Font("나눔스퀘어", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(5, 0)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(322, 30)
        Me.TitleLabel.TabIndex = 5
        Me.TitleLabel.Text = "실시간 대기 알림"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CloseBT
        '
        Me.CloseBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseBT.Image = Global.monZi.My.Resources.Resources.closeicon
        Me.CloseBT.Location = New System.Drawing.Point(327, 0)
        Me.CloseBT.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(47, 30)
        Me.CloseBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseBT.TabIndex = 3
        Me.CloseBT.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.monZi.My.Resources.Resources.icon
        Me.PictureBox2.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(81, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'AirDetailLabel
        '
        Me.AirDetailLabel.BackColor = System.Drawing.Color.Transparent
        Me.AirDetailLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AirDetailLabel.Font = New System.Drawing.Font("나눔스퀘어 Bold", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AirDetailLabel.ForeColor = System.Drawing.Color.White
        Me.AirDetailLabel.Location = New System.Drawing.Point(93, 66)
        Me.AirDetailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AirDetailLabel.Name = "AirDetailLabel"
        Me.AirDetailLabel.Padding = New System.Windows.Forms.Padding(11, 1, 0, 0)
        Me.AirDetailLabel.Size = New System.Drawing.Size(269, 31)
        Me.AirDetailLabel.TabIndex = 9
        Me.AirDetailLabel.Text = "pm10: 15 ㎍/㎥  |  pm10: 15 ㎍/㎥" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "마지막 측정: 2018-06-23 20:00 "
        '
        'AirStateLabel
        '
        Me.AirStateLabel.BackColor = System.Drawing.Color.Transparent
        Me.AirStateLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AirStateLabel.Font = New System.Drawing.Font("나눔스퀘어 ExtraBold", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AirStateLabel.ForeColor = System.Drawing.Color.White
        Me.AirStateLabel.Location = New System.Drawing.Point(93, 25)
        Me.AirStateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AirStateLabel.Name = "AirStateLabel"
        Me.AirStateLabel.Padding = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.AirStateLabel.Size = New System.Drawing.Size(269, 41)
        Me.AirStateLabel.TabIndex = 8
        Me.AirStateLabel.Text = "로드 중"
        Me.AirStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.AirStateLabel)
        Me.MainPanel.Controls.Add(Me.AirCommentLabel)
        Me.MainPanel.Controls.Add(Me.AirDetailLabel)
        Me.MainPanel.Controls.Add(Me.PictureBox2)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 30)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(12, 0, 12, 15)
        Me.MainPanel.Size = New System.Drawing.Size(374, 112)
        Me.MainPanel.TabIndex = 10
        '
        'AirCommentLabel
        '
        Me.AirCommentLabel.BackColor = System.Drawing.Color.Transparent
        Me.AirCommentLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AirCommentLabel.Font = New System.Drawing.Font("나눔스퀘어", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AirCommentLabel.ForeColor = System.Drawing.Color.White
        Me.AirCommentLabel.Location = New System.Drawing.Point(93, 0)
        Me.AirCommentLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AirCommentLabel.Name = "AirCommentLabel"
        Me.AirCommentLabel.Padding = New System.Windows.Forms.Padding(11, 0, 0, 0)
        Me.AirCommentLabel.Size = New System.Drawing.Size(269, 25)
        Me.AirCommentLabel.TabIndex = 10
        Me.AirCommentLabel.Text = "잠시만 기다려 주세요"
        Me.AirCommentLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'AniTimer
        '
        Me.AniTimer.Interval = 20
        '
        'FirstWaitTimer
        '
        Me.FirstWaitTimer.Enabled = True
        Me.FirstWaitTimer.Interval = 5000
        '
        'PopUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(374, 142)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PopUpForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PopUpForm"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.TopPanel.ResumeLayout(False)
        CType(Me.OptBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents CloseBT As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AirDetailLabel As Label
    Friend WithEvents AirStateLabel As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents AirCommentLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents OptBT As PictureBox
    Friend WithEvents AniTimer As Timer
    Friend WithEvents FirstWaitTimer As Timer
End Class
