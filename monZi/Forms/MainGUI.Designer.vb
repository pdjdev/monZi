<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainGUI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainGUI))
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.WidgetButton = New System.Windows.Forms.PictureBox()
        Me.HistoryButton = New System.Windows.Forms.PictureBox()
        Me.HideButton = New System.Windows.Forms.PictureBox()
        Me.ListButton = New System.Windows.Forms.PictureBox()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.BottomBT2_Panel = New System.Windows.Forms.Panel()
        Me.UpdateLabel = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.PictureBox()
        Me.BottomBT1_Panel = New System.Windows.Forms.Panel()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.LocationButton = New System.Windows.Forms.PictureBox()
        Me.StatePanel = New System.Windows.Forms.Panel()
        Me.AirStateLabel = New System.Windows.Forms.Label()
        Me.AirDetailLabel = New System.Windows.Forms.Label()
        Me.AirCommentLabel = New System.Windows.Forms.Label()
        Me.DashPanel = New System.Windows.Forms.Panel()
        Me.DashPic = New System.Windows.Forms.PictureBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.hideani = New System.Windows.Forms.Timer(Me.components)
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.MenuMainPanel = New System.Windows.Forms.Panel()
        Me.Menu_BT4 = New System.Windows.Forms.PictureBox()
        Me.Menu_BT3 = New System.Windows.Forms.PictureBox()
        Me.Menu_BT2 = New System.Windows.Forms.PictureBox()
        Me.Menu_BT1 = New System.Windows.Forms.PictureBox()
        Me.MenuTopPanel = New System.Windows.Forms.Panel()
        Me.CloseLabel = New System.Windows.Forms.Label()
        Me.MenuTitle = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.PictureBox()
        Me.ListButton2 = New System.Windows.Forms.PictureBox()
        Me.Transani = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorTrans = New System.Windows.Forms.Timer(Me.components)
        Me.TopPanel.SuspendLayout()
        CType(Me.WidgetButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HideButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomPanel.SuspendLayout()
        Me.BottomBT2_Panel.SuspendLayout()
        CType(Me.UpdateButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomBT1_Panel.SuspendLayout()
        CType(Me.LocationButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatePanel.SuspendLayout()
        Me.DashPanel.SuspendLayout()
        CType(Me.DashPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MenuPanel.SuspendLayout()
        Me.MenuMainPanel.SuspendLayout()
        CType(Me.Menu_BT4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_BT3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_BT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_BT1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuTopPanel.SuspendLayout()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.Transparent
        Me.TopPanel.Controls.Add(Me.TitleLabel)
        Me.TopPanel.Controls.Add(Me.WidgetButton)
        Me.TopPanel.Controls.Add(Me.HistoryButton)
        Me.TopPanel.Controls.Add(Me.HideButton)
        Me.TopPanel.Controls.Add(Me.ListButton)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(425, 35)
        Me.TopPanel.TabIndex = 0
        '
        'TitleLabel
        '
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.Font = New System.Drawing.Font("나눔스퀘어", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(35, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(285, 35)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "현재 대기"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WidgetButton
        '
        Me.WidgetButton.BackColor = System.Drawing.Color.Transparent
        Me.WidgetButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.WidgetButton.Image = Global.monZi.My.Resources.Resources.widget_1
        Me.WidgetButton.Location = New System.Drawing.Point(320, 0)
        Me.WidgetButton.Name = "WidgetButton"
        Me.WidgetButton.Size = New System.Drawing.Size(35, 35)
        Me.WidgetButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.WidgetButton.TabIndex = 7
        Me.WidgetButton.TabStop = False
        '
        'HistoryButton
        '
        Me.HistoryButton.BackColor = System.Drawing.Color.Transparent
        Me.HistoryButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.HistoryButton.Image = Global.monZi.My.Resources.Resources.hisicon
        Me.HistoryButton.Location = New System.Drawing.Point(355, 0)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(35, 35)
        Me.HistoryButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HistoryButton.TabIndex = 6
        Me.HistoryButton.TabStop = False
        '
        'HideButton
        '
        Me.HideButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.HideButton.Image = Global.monZi.My.Resources.Resources.hideicon
        Me.HideButton.Location = New System.Drawing.Point(390, 0)
        Me.HideButton.Name = "HideButton"
        Me.HideButton.Size = New System.Drawing.Size(35, 35)
        Me.HideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HideButton.TabIndex = 1
        Me.HideButton.TabStop = False
        '
        'ListButton
        '
        Me.ListButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListButton.Image = Global.monZi.My.Resources.Resources.listicon
        Me.ListButton.Location = New System.Drawing.Point(0, 0)
        Me.ListButton.Name = "ListButton"
        Me.ListButton.Size = New System.Drawing.Size(35, 35)
        Me.ListButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ListButton.TabIndex = 0
        Me.ListButton.TabStop = False
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BottomPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomPanel.Controls.Add(Me.BottomBT2_Panel)
        Me.BottomPanel.Controls.Add(Me.BottomBT1_Panel)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 175)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(425, 35)
        Me.BottomPanel.TabIndex = 1
        '
        'BottomBT2_Panel
        '
        Me.BottomBT2_Panel.BackColor = System.Drawing.Color.Transparent
        Me.BottomBT2_Panel.BackgroundImage = Global.monZi.My.Resources.Resources.shadow
        Me.BottomBT2_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomBT2_Panel.Controls.Add(Me.UpdateLabel)
        Me.BottomBT2_Panel.Controls.Add(Me.UpdateButton)
        Me.BottomBT2_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomBT2_Panel.Location = New System.Drawing.Point(293, 0)
        Me.BottomBT2_Panel.Name = "BottomBT2_Panel"
        Me.BottomBT2_Panel.Size = New System.Drawing.Size(132, 35)
        Me.BottomBT2_Panel.TabIndex = 4
        '
        'UpdateLabel
        '
        Me.UpdateLabel.BackColor = System.Drawing.Color.Transparent
        Me.UpdateLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdateLabel.Font = New System.Drawing.Font("맑은 고딕", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.UpdateLabel.Location = New System.Drawing.Point(0, 0)
        Me.UpdateLabel.Name = "UpdateLabel"
        Me.UpdateLabel.Size = New System.Drawing.Size(97, 35)
        Me.UpdateLabel.TabIndex = 4
        Me.UpdateLabel.Text = "업데이트" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "되지 않음"
        Me.UpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdateButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.UpdateButton.Image = Global.monZi.My.Resources.Resources.refreshico
        Me.UpdateButton.Location = New System.Drawing.Point(97, 0)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(35, 35)
        Me.UpdateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UpdateButton.TabIndex = 5
        Me.UpdateButton.TabStop = False
        '
        'BottomBT1_Panel
        '
        Me.BottomBT1_Panel.BackColor = System.Drawing.Color.Transparent
        Me.BottomBT1_Panel.BackgroundImage = Global.monZi.My.Resources.Resources.shadow
        Me.BottomBT1_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomBT1_Panel.Controls.Add(Me.LocationLabel)
        Me.BottomBT1_Panel.Controls.Add(Me.LocationButton)
        Me.BottomBT1_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BottomBT1_Panel.Location = New System.Drawing.Point(0, 0)
        Me.BottomBT1_Panel.Name = "BottomBT1_Panel"
        Me.BottomBT1_Panel.Size = New System.Drawing.Size(293, 35)
        Me.BottomBT1_Panel.TabIndex = 6
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoEllipsis = True
        Me.LocationLabel.BackColor = System.Drawing.Color.Transparent
        Me.LocationLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LocationLabel.Font = New System.Drawing.Font("나눔스퀘어", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LocationLabel.Location = New System.Drawing.Point(35, 0)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(268, 35)
        Me.LocationLabel.TabIndex = 3
        Me.LocationLabel.Text = "위치를 설정하세요"
        Me.LocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LocationButton
        '
        Me.LocationButton.BackColor = System.Drawing.Color.Transparent
        Me.LocationButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.LocationButton.Image = Global.monZi.My.Resources.Resources.locicon
        Me.LocationButton.Location = New System.Drawing.Point(0, 0)
        Me.LocationButton.Name = "LocationButton"
        Me.LocationButton.Size = New System.Drawing.Size(35, 35)
        Me.LocationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LocationButton.TabIndex = 1
        Me.LocationButton.TabStop = False
        '
        'StatePanel
        '
        Me.StatePanel.BackColor = System.Drawing.Color.Transparent
        Me.StatePanel.Controls.Add(Me.AirStateLabel)
        Me.StatePanel.Controls.Add(Me.AirDetailLabel)
        Me.StatePanel.Controls.Add(Me.AirCommentLabel)
        Me.StatePanel.Controls.Add(Me.DashPanel)
        Me.StatePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatePanel.Location = New System.Drawing.Point(0, 35)
        Me.StatePanel.Name = "StatePanel"
        Me.StatePanel.Size = New System.Drawing.Size(425, 140)
        Me.StatePanel.TabIndex = 2
        '
        'AirStateLabel
        '
        Me.AirStateLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AirStateLabel.Font = New System.Drawing.Font("나눔스퀘어 ExtraBold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AirStateLabel.Location = New System.Drawing.Point(155, 34)
        Me.AirStateLabel.Name = "AirStateLabel"
        Me.AirStateLabel.Size = New System.Drawing.Size(270, 56)
        Me.AirStateLabel.TabIndex = 1
        Me.AirStateLabel.Text = "로드 중"
        Me.AirStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AirDetailLabel
        '
        Me.AirDetailLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AirDetailLabel.Font = New System.Drawing.Font("나눔스퀘어 Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AirDetailLabel.Location = New System.Drawing.Point(155, 90)
        Me.AirDetailLabel.Name = "AirDetailLabel"
        Me.AirDetailLabel.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.AirDetailLabel.Size = New System.Drawing.Size(270, 50)
        Me.AirDetailLabel.TabIndex = 2
        Me.AirDetailLabel.Text = "미세먼지(pm10): 15 ㎍/㎥" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "초미세먼지(pm2.5): 15 ㎍/㎥" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AirCommentLabel
        '
        Me.AirCommentLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AirCommentLabel.Font = New System.Drawing.Font("나눔스퀘어", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AirCommentLabel.Location = New System.Drawing.Point(155, 0)
        Me.AirCommentLabel.Name = "AirCommentLabel"
        Me.AirCommentLabel.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.AirCommentLabel.Size = New System.Drawing.Size(270, 34)
        Me.AirCommentLabel.TabIndex = 3
        Me.AirCommentLabel.Text = "잠시만 기다려 주세요"
        Me.AirCommentLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'DashPanel
        '
        Me.DashPanel.Controls.Add(Me.DashPic)
        Me.DashPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.DashPanel.Location = New System.Drawing.Point(0, 0)
        Me.DashPanel.Name = "DashPanel"
        Me.DashPanel.Padding = New System.Windows.Forms.Padding(15, 0, 5, 5)
        Me.DashPanel.Size = New System.Drawing.Size(155, 140)
        Me.DashPanel.TabIndex = 0
        '
        'DashPic
        '
        Me.DashPic.BackgroundImage = Global.monZi.My.Resources.Resources.dash_back
        Me.DashPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DashPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashPic.Location = New System.Drawing.Point(15, 0)
        Me.DashPic.Name = "DashPic"
        Me.DashPic.Size = New System.Drawing.Size(135, 135)
        Me.DashPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DashPic.TabIndex = 0
        Me.DashPic.TabStop = False
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.StatePanel)
        Me.MainPanel.Controls.Add(Me.TopPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(425, 175)
        Me.MainPanel.TabIndex = 4
        '
        'hideani
        '
        Me.hideani.Interval = 10
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuPanel.Controls.Add(Me.MenuMainPanel)
        Me.MenuPanel.Controls.Add(Me.MenuTopPanel)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(425, 10)
        Me.MenuPanel.TabIndex = 4
        '
        'MenuMainPanel
        '
        Me.MenuMainPanel.Controls.Add(Me.Menu_BT4)
        Me.MenuMainPanel.Controls.Add(Me.Menu_BT3)
        Me.MenuMainPanel.Controls.Add(Me.Menu_BT2)
        Me.MenuMainPanel.Controls.Add(Me.Menu_BT1)
        Me.MenuMainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuMainPanel.Location = New System.Drawing.Point(0, 35)
        Me.MenuMainPanel.Name = "MenuMainPanel"
        Me.MenuMainPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.MenuMainPanel.Size = New System.Drawing.Size(425, 0)
        Me.MenuMainPanel.TabIndex = 3
        '
        'Menu_BT4
        '
        Me.Menu_BT4.Image = Global.monZi.My.Resources.Resources.menu_4
        Me.Menu_BT4.Location = New System.Drawing.Point(215, 72)
        Me.Menu_BT4.Name = "Menu_BT4"
        Me.Menu_BT4.Size = New System.Drawing.Size(202, 59)
        Me.Menu_BT4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Menu_BT4.TabIndex = 5
        Me.Menu_BT4.TabStop = False
        '
        'Menu_BT3
        '
        Me.Menu_BT3.Image = Global.monZi.My.Resources.Resources.menu_3
        Me.Menu_BT3.Location = New System.Drawing.Point(8, 72)
        Me.Menu_BT3.Name = "Menu_BT3"
        Me.Menu_BT3.Size = New System.Drawing.Size(202, 59)
        Me.Menu_BT3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Menu_BT3.TabIndex = 4
        Me.Menu_BT3.TabStop = False
        '
        'Menu_BT2
        '
        Me.Menu_BT2.Image = Global.monZi.My.Resources.Resources.menu_2
        Me.Menu_BT2.Location = New System.Drawing.Point(215, 8)
        Me.Menu_BT2.Name = "Menu_BT2"
        Me.Menu_BT2.Size = New System.Drawing.Size(202, 59)
        Me.Menu_BT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Menu_BT2.TabIndex = 3
        Me.Menu_BT2.TabStop = False
        '
        'Menu_BT1
        '
        Me.Menu_BT1.Image = Global.monZi.My.Resources.Resources.menu_1
        Me.Menu_BT1.Location = New System.Drawing.Point(8, 8)
        Me.Menu_BT1.Name = "Menu_BT1"
        Me.Menu_BT1.Size = New System.Drawing.Size(202, 59)
        Me.Menu_BT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Menu_BT1.TabIndex = 2
        Me.Menu_BT1.TabStop = False
        '
        'MenuTopPanel
        '
        Me.MenuTopPanel.BackColor = System.Drawing.Color.Transparent
        Me.MenuTopPanel.Controls.Add(Me.CloseLabel)
        Me.MenuTopPanel.Controls.Add(Me.MenuTitle)
        Me.MenuTopPanel.Controls.Add(Me.CloseButton)
        Me.MenuTopPanel.Controls.Add(Me.ListButton2)
        Me.MenuTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuTopPanel.Name = "MenuTopPanel"
        Me.MenuTopPanel.Size = New System.Drawing.Size(425, 35)
        Me.MenuTopPanel.TabIndex = 1
        '
        'CloseLabel
        '
        Me.CloseLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseLabel.Font = New System.Drawing.Font("나눔스퀘어", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CloseLabel.Location = New System.Drawing.Point(307, 0)
        Me.CloseLabel.Name = "CloseLabel"
        Me.CloseLabel.Size = New System.Drawing.Size(83, 35)
        Me.CloseLabel.TabIndex = 3
        Me.CloseLabel.Text = "monZi 종료"
        Me.CloseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuTitle
        '
        Me.MenuTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuTitle.Font = New System.Drawing.Font("나눔스퀘어", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.MenuTitle.Location = New System.Drawing.Point(35, 0)
        Me.MenuTitle.Name = "MenuTitle"
        Me.MenuTitle.Size = New System.Drawing.Size(175, 35)
        Me.MenuTitle.TabIndex = 2
        Me.MenuTitle.Text = "메뉴"
        Me.MenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CloseButton
        '
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseButton.Image = Global.monZi.My.Resources.Resources.closeicon
        Me.CloseButton.Location = New System.Drawing.Point(390, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(35, 35)
        Me.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.TabStop = False
        '
        'ListButton2
        '
        Me.ListButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListButton2.Image = Global.monZi.My.Resources.Resources.listicon
        Me.ListButton2.Location = New System.Drawing.Point(0, 0)
        Me.ListButton2.Name = "ListButton2"
        Me.ListButton2.Size = New System.Drawing.Size(35, 35)
        Me.ListButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ListButton2.TabIndex = 0
        Me.ListButton2.TabStop = False
        '
        'Transani
        '
        Me.Transani.Interval = 5
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'ColorTrans
        '
        Me.ColorTrans.Interval = 13
        '
        'MainGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(425, 210)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainGUI"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "monZ"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.TopPanel.ResumeLayout(False)
        CType(Me.WidgetButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HideButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomPanel.ResumeLayout(False)
        Me.BottomBT2_Panel.ResumeLayout(False)
        CType(Me.UpdateButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomBT1_Panel.ResumeLayout(False)
        CType(Me.LocationButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatePanel.ResumeLayout(False)
        Me.DashPanel.ResumeLayout(False)
        CType(Me.DashPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuMainPanel.ResumeLayout(False)
        CType(Me.Menu_BT4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_BT3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_BT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_BT1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuTopPanel.ResumeLayout(False)
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents StatePanel As Panel
    Friend WithEvents DashPanel As Panel
    Friend WithEvents DashPic As PictureBox
    Friend WithEvents HideButton As PictureBox
    Friend WithEvents ListButton As PictureBox
    Friend WithEvents LocationButton As PictureBox
    Friend WithEvents AirCommentLabel As Label
    Friend WithEvents AirDetailLabel As Label
    Friend WithEvents AirStateLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents UpdateLabel As Label
    Friend WithEvents UpdateButton As PictureBox
    Friend WithEvents MainPanel As Panel
    Friend WithEvents hideani As Timer
    Friend WithEvents BottomBT2_Panel As Panel
    Friend WithEvents BottomBT1_Panel As Panel
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents MenuTopPanel As Panel
    Friend WithEvents MenuTitle As Label
    Friend WithEvents CloseButton As PictureBox
    Friend WithEvents ListButton2 As PictureBox
    Friend WithEvents Transani As Timer
    Friend WithEvents MenuMainPanel As Panel
    Friend WithEvents Menu_BT1 As PictureBox
    Friend WithEvents Menu_BT4 As PictureBox
    Friend WithEvents Menu_BT3 As PictureBox
    Friend WithEvents Menu_BT2 As PictureBox
    Friend WithEvents CloseLabel As Label
    Friend WithEvents HistoryButton As PictureBox
    Friend WithEvents WidgetButton As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ColorTrans As Timer
End Class
