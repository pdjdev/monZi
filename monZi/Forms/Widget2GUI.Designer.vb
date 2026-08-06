<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Widget2GUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Widget2GUI))
        Me.AirDetailLabel = New System.Windows.Forms.Label()
        Me.DashPic = New System.Windows.Forms.PictureBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.StatePanel = New System.Windows.Forms.Panel()
        Me.AirStateLabel = New System.Windows.Forms.Label()
        Me.AirCommentLabel = New System.Windows.Forms.Label()
        Me.DashPanel = New System.Windows.Forms.Panel()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.LockBT = New System.Windows.Forms.PictureBox()
        Me.MenuBT = New System.Windows.Forms.PictureBox()
        Me.ColorTrans = New System.Windows.Forms.Timer(Me.components)
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.BottomBT2_Panel = New System.Windows.Forms.Panel()
        Me.UpdateLabel = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.PictureBox()
        Me.BottomBT1_Panel = New System.Windows.Forms.Panel()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.LocationButton = New System.Windows.Forms.PictureBox()
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu_DisableWidget = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ChangeWidget = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_StickHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ShowIcon = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        CType(Me.DashPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.StatePanel.SuspendLayout()
        Me.DashPanel.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        CType(Me.LockBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomPanel.SuspendLayout()
        Me.BottomBT2_Panel.SuspendLayout()
        CType(Me.UpdateButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomBT1_Panel.SuspendLayout()
        CType(Me.LocationButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'AirDetailLabel
        '
        Me.AirDetailLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AirDetailLabel.Font = New System.Drawing.Font("Noto Sans KR", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AirDetailLabel.Location = New System.Drawing.Point(186, 110)
        Me.AirDetailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AirDetailLabel.Name = "AirDetailLabel"
        Me.AirDetailLabel.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.AirDetailLabel.Size = New System.Drawing.Size(298, 62)
        Me.AirDetailLabel.TabIndex = 2
        Me.AirDetailLabel.Text = "미세먼지(pm10): 15 ㎍/㎥" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "초미세먼지(pm2.5): 15 ㎍/㎥" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DashPic
        '
        Me.DashPic.BackgroundImage = Global.monZi.My.Resources.Resources.dash_back
        Me.DashPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DashPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashPic.Location = New System.Drawing.Point(6, 0)
        Me.DashPic.Margin = New System.Windows.Forms.Padding(4)
        Me.DashPic.Name = "DashPic"
        Me.DashPic.Size = New System.Drawing.Size(174, 166)
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
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(484, 210)
        Me.MainPanel.TabIndex = 6
        '
        'StatePanel
        '
        Me.StatePanel.BackColor = System.Drawing.Color.Transparent
        Me.StatePanel.Controls.Add(Me.AirStateLabel)
        Me.StatePanel.Controls.Add(Me.AirDetailLabel)
        Me.StatePanel.Controls.Add(Me.AirCommentLabel)
        Me.StatePanel.Controls.Add(Me.DashPanel)
        Me.StatePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatePanel.Location = New System.Drawing.Point(0, 38)
        Me.StatePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.StatePanel.Name = "StatePanel"
        Me.StatePanel.Size = New System.Drawing.Size(484, 172)
        Me.StatePanel.TabIndex = 2
        '
        'AirStateLabel
        '
        Me.AirStateLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AirStateLabel.Font = New System.Drawing.Font("Noto Sans KR", 25.0!, System.Drawing.FontStyle.Bold)
        Me.AirStateLabel.Location = New System.Drawing.Point(186, 38)
        Me.AirStateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AirStateLabel.Name = "AirStateLabel"
        Me.AirStateLabel.Size = New System.Drawing.Size(298, 72)
        Me.AirStateLabel.TabIndex = 1
        Me.AirStateLabel.Text = "로드 중"
        Me.AirStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AirCommentLabel
        '
        Me.AirCommentLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AirCommentLabel.Font = New System.Drawing.Font("Noto Sans KR", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AirCommentLabel.Location = New System.Drawing.Point(186, 0)
        Me.AirCommentLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AirCommentLabel.Name = "AirCommentLabel"
        Me.AirCommentLabel.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.AirCommentLabel.Size = New System.Drawing.Size(298, 38)
        Me.AirCommentLabel.TabIndex = 3
        Me.AirCommentLabel.Text = "잠시만 기다려 주세요"
        Me.AirCommentLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'DashPanel
        '
        Me.DashPanel.Controls.Add(Me.DashPic)
        Me.DashPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.DashPanel.Location = New System.Drawing.Point(0, 0)
        Me.DashPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.DashPanel.Name = "DashPanel"
        Me.DashPanel.Padding = New System.Windows.Forms.Padding(6, 0, 6, 6)
        Me.DashPanel.Size = New System.Drawing.Size(186, 172)
        Me.DashPanel.TabIndex = 0
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.Transparent
        Me.TopPanel.Controls.Add(Me.TitleLabel)
        Me.TopPanel.Controls.Add(Me.LockBT)
        Me.TopPanel.Controls.Add(Me.MenuBT)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(484, 38)
        Me.TopPanel.TabIndex = 0
        '
        'TitleLabel
        '
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.Font = New System.Drawing.Font("Noto Sans KR", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(44, 0)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(396, 38)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "현재 대기"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LockBT
        '
        Me.LockBT.Dock = System.Windows.Forms.DockStyle.Left
        Me.LockBT.Image = Global.monZi.My.Resources.Resources.lockicon_2
        Me.LockBT.Location = New System.Drawing.Point(0, 0)
        Me.LockBT.Margin = New System.Windows.Forms.Padding(4)
        Me.LockBT.Name = "LockBT"
        Me.LockBT.Size = New System.Drawing.Size(44, 38)
        Me.LockBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LockBT.TabIndex = 13
        Me.LockBT.TabStop = False
        '
        'MenuBT
        '
        Me.MenuBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuBT.Image = Global.monZi.My.Resources.Resources.moreicon
        Me.MenuBT.Location = New System.Drawing.Point(440, 0)
        Me.MenuBT.Margin = New System.Windows.Forms.Padding(4)
        Me.MenuBT.Name = "MenuBT"
        Me.MenuBT.Size = New System.Drawing.Size(44, 38)
        Me.MenuBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MenuBT.TabIndex = 14
        Me.MenuBT.TabStop = False
        '
        'ColorTrans
        '
        Me.ColorTrans.Interval = 13
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BottomPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomPanel.Controls.Add(Me.BottomBT2_Panel)
        Me.BottomPanel.Controls.Add(Me.BottomBT1_Panel)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 210)
        Me.BottomPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(484, 38)
        Me.BottomPanel.TabIndex = 5
        '
        'BottomBT2_Panel
        '
        Me.BottomBT2_Panel.BackColor = System.Drawing.Color.Transparent
        Me.BottomBT2_Panel.BackgroundImage = Global.monZi.My.Resources.Resources.shadow
        Me.BottomBT2_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomBT2_Panel.Controls.Add(Me.UpdateLabel)
        Me.BottomBT2_Panel.Controls.Add(Me.UpdateButton)
        Me.BottomBT2_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomBT2_Panel.Location = New System.Drawing.Point(316, 0)
        Me.BottomBT2_Panel.Margin = New System.Windows.Forms.Padding(4)
        Me.BottomBT2_Panel.Name = "BottomBT2_Panel"
        Me.BottomBT2_Panel.Size = New System.Drawing.Size(168, 38)
        Me.BottomBT2_Panel.TabIndex = 4
        '
        'UpdateLabel
        '
        Me.UpdateLabel.BackColor = System.Drawing.Color.Transparent
        Me.UpdateLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdateLabel.Font = New System.Drawing.Font("맑은 고딕", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.UpdateLabel.Location = New System.Drawing.Point(0, 0)
        Me.UpdateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UpdateLabel.Name = "UpdateLabel"
        Me.UpdateLabel.Size = New System.Drawing.Size(130, 38)
        Me.UpdateLabel.TabIndex = 4
        Me.UpdateLabel.Text = "업데이트" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "되지 않음"
        Me.UpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdateButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.UpdateButton.Image = Global.monZi.My.Resources.Resources.resize_icon
        Me.UpdateButton.Location = New System.Drawing.Point(130, 0)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(38, 38)
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
        Me.BottomBT1_Panel.Margin = New System.Windows.Forms.Padding(4)
        Me.BottomBT1_Panel.Name = "BottomBT1_Panel"
        Me.BottomBT1_Panel.Size = New System.Drawing.Size(316, 38)
        Me.BottomBT1_Panel.TabIndex = 6
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoEllipsis = True
        Me.LocationLabel.BackColor = System.Drawing.Color.Transparent
        Me.LocationLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocationLabel.Font = New System.Drawing.Font("Noto Sans KR", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LocationLabel.Location = New System.Drawing.Point(44, 0)
        Me.LocationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(272, 38)
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
        Me.LocationButton.Margin = New System.Windows.Forms.Padding(4)
        Me.LocationButton.Name = "LocationButton"
        Me.LocationButton.Size = New System.Drawing.Size(44, 38)
        Me.LocationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LocationButton.TabIndex = 1
        Me.LocationButton.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.Font = New System.Drawing.Font("Noto Sans KR", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_DisableWidget, Me.Menu_ChangeWidget, Me.Menu_StickHelp, Me.Menu_ShowIcon, Me.ToolStripComboBox1})
        Me.MenuStrip.Name = "ContextMenuStrip1"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip.ShowImageMargin = False
        Me.MenuStrip.Size = New System.Drawing.Size(274, 224)
        '
        'Menu_DisableWidget
        '
        Me.Menu_DisableWidget.Font = New System.Drawing.Font("Noto Sans KR", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Menu_DisableWidget.Image = Global.monZi.My.Resources.Resources.closeicon_b
        Me.Menu_DisableWidget.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Menu_DisableWidget.Name = "Menu_DisableWidget"
        Me.Menu_DisableWidget.Padding = New System.Windows.Forms.Padding(0)
        Me.Menu_DisableWidget.Size = New System.Drawing.Size(273, 34)
        Me.Menu_DisableWidget.Text = "위젯 비활성화"
        '
        'Menu_ChangeWidget
        '
        Me.Menu_ChangeWidget.Font = New System.Drawing.Font("Noto Sans KR", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Menu_ChangeWidget.Image = Global.monZi.My.Resources.Resources.closeicon_b
        Me.Menu_ChangeWidget.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Menu_ChangeWidget.Name = "Menu_ChangeWidget"
        Me.Menu_ChangeWidget.Padding = New System.Windows.Forms.Padding(0)
        Me.Menu_ChangeWidget.Size = New System.Drawing.Size(273, 34)
        Me.Menu_ChangeWidget.Text = "심플 위젯으로 바꾸기"
        '
        'Menu_StickHelp
        '
        Me.Menu_StickHelp.Font = New System.Drawing.Font("Noto Sans KR", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Menu_StickHelp.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Menu_StickHelp.Name = "Menu_StickHelp"
        Me.Menu_StickHelp.Size = New System.Drawing.Size(273, 36)
        Me.Menu_StickHelp.Text = "모서리에 달라붙지 않기"
        '
        'Menu_ShowIcon
        '
        Me.Menu_ShowIcon.Font = New System.Drawing.Font("Noto Sans KR", 13.0!)
        Me.Menu_ShowIcon.Name = "Menu_ShowIcon"
        Me.Menu_ShowIcon.Size = New System.Drawing.Size(273, 36)
        Me.Menu_ShowIcon.Text = "아이콘 표시 안함"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ToolStripComboBox1.Font = New System.Drawing.Font("Noto Sans KR", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"100% (불투명)", "90%", "80%", "70%", "60%", "50%", "40%", "30%", "20%"})
        Me.ToolStripComboBox1.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(160, 40)
        '
        'Widget2GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 248)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.Font = New System.Drawing.Font("Noto Sans KR", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(484, 248)
        Me.Name = "Widget2GUI"
        Me.Text = "Widget2GUI"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.DashPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.StatePanel.ResumeLayout(False)
        Me.DashPanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        CType(Me.LockBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomPanel.ResumeLayout(False)
        Me.BottomBT2_Panel.ResumeLayout(False)
        CType(Me.UpdateButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomBT1_Panel.ResumeLayout(False)
        CType(Me.LocationButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AirDetailLabel As Label
    Friend WithEvents DashPic As PictureBox
    Friend WithEvents MainPanel As Panel
    Friend WithEvents StatePanel As Panel
    Friend WithEvents AirStateLabel As Label
    Friend WithEvents AirCommentLabel As Label
    Friend WithEvents DashPanel As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents ColorTrans As Timer
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents BottomBT2_Panel As Panel
    Friend WithEvents UpdateLabel As Label
    Friend WithEvents UpdateButton As PictureBox
    Friend WithEvents BottomBT1_Panel As Panel
    Friend WithEvents LocationLabel As Label
    Friend WithEvents LocationButton As PictureBox
    Friend WithEvents LockBT As PictureBox
    Friend WithEvents MenuBT As PictureBox
    Friend WithEvents MenuStrip As ContextMenuStrip
    Friend WithEvents Menu_DisableWidget As ToolStripMenuItem
    Friend WithEvents Menu_StickHelp As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents Menu_ChangeWidget As ToolStripMenuItem
    Friend WithEvents Menu_ShowIcon As ToolStripMenuItem
End Class
