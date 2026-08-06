<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WidgetGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WidgetGUI))
        Me.DashPanel = New System.Windows.Forms.Panel()
        Me.DashPic = New System.Windows.Forms.PictureBox()
        Me.MenuBT = New System.Windows.Forms.PictureBox()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.AirStateLabel = New System.Windows.Forms.Label()
        Me.AirDetailLabel = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.LockBT = New System.Windows.Forms.PictureBox()
        Me.Menu_ChangeWidget = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Menu_DisableWidget = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_StickHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ShowIcon = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorTrans = New System.Windows.Forms.Timer(Me.components)
        Me.DashPanel.SuspendLayout()
        CType(Me.DashPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        CType(Me.LockBT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DashPanel
        '
        Me.DashPanel.Controls.Add(Me.DashPic)
        Me.DashPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashPanel.Location = New System.Drawing.Point(0, 35)
        Me.DashPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DashPanel.Name = "DashPanel"
        Me.DashPanel.Size = New System.Drawing.Size(231, 205)
        Me.DashPanel.TabIndex = 1
        '
        'DashPic
        '
        Me.DashPic.BackgroundImage = Global.monZi.My.Resources.Resources.dash_back
        Me.DashPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DashPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashPic.Location = New System.Drawing.Point(0, 0)
        Me.DashPic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DashPic.Name = "DashPic"
        Me.DashPic.Size = New System.Drawing.Size(231, 205)
        Me.DashPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DashPic.TabIndex = 1
        Me.DashPic.TabStop = False
        '
        'MenuBT
        '
        Me.MenuBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuBT.Image = Global.monZi.My.Resources.Resources.moreicon
        Me.MenuBT.Location = New System.Drawing.Point(195, 0)
        Me.MenuBT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MenuBT.Name = "MenuBT"
        Me.MenuBT.Size = New System.Drawing.Size(36, 35)
        Me.MenuBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MenuBT.TabIndex = 5
        Me.MenuBT.TabStop = False
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.AirStateLabel)
        Me.BottomPanel.Controls.Add(Me.AirDetailLabel)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 240)
        Me.BottomPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(231, 110)
        Me.BottomPanel.TabIndex = 2
        '
        'AirStateLabel
        '
        Me.AirStateLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AirStateLabel.Font = New System.Drawing.Font("Noto Sans KR", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.AirStateLabel.ForeColor = System.Drawing.Color.White
        Me.AirStateLabel.Location = New System.Drawing.Point(0, 0)
        Me.AirStateLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.AirStateLabel.Name = "AirStateLabel"
        Me.AirStateLabel.Size = New System.Drawing.Size(231, 59)
        Me.AirStateLabel.TabIndex = 2
        Me.AirStateLabel.Text = "로드 중"
        Me.AirStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AirDetailLabel
        '
        Me.AirDetailLabel.BackColor = System.Drawing.Color.Transparent
        Me.AirDetailLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AirDetailLabel.Font = New System.Drawing.Font("Noto Sans KR", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AirDetailLabel.ForeColor = System.Drawing.Color.White
        Me.AirDetailLabel.Location = New System.Drawing.Point(0, 59)
        Me.AirDetailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AirDetailLabel.Name = "AirDetailLabel"
        Me.AirDetailLabel.Size = New System.Drawing.Size(231, 51)
        Me.AirDetailLabel.TabIndex = 10
        Me.AirDetailLabel.Text = "잠시만 기다려 주세요"
        Me.AirDetailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.DashPanel)
        Me.MainPanel.Controls.Add(Me.BottomPanel)
        Me.MainPanel.Controls.Add(Me.TopPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(231, 350)
        Me.MainPanel.TabIndex = 2
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.TitleLabel)
        Me.TopPanel.Controls.Add(Me.LockBT)
        Me.TopPanel.Controls.Add(Me.MenuBT)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(231, 35)
        Me.TopPanel.TabIndex = 6
        '
        'TitleLabel
        '
        Me.TitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.Font = New System.Drawing.Font("Noto Sans KR", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(36, 0)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(159, 35)
        Me.TitleLabel.TabIndex = 11
        Me.TitleLabel.Text = "monZi"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LockBT
        '
        Me.LockBT.Dock = System.Windows.Forms.DockStyle.Left
        Me.LockBT.Image = Global.monZi.My.Resources.Resources.lockicon_2
        Me.LockBT.Location = New System.Drawing.Point(0, 0)
        Me.LockBT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LockBT.Name = "LockBT"
        Me.LockBT.Size = New System.Drawing.Size(36, 35)
        Me.LockBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LockBT.TabIndex = 12
        Me.LockBT.TabStop = False
        '
        'Menu_ChangeWidget
        '
        Me.Menu_ChangeWidget.Font = New System.Drawing.Font("Noto Sans KR", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Menu_ChangeWidget.Image = Global.monZi.My.Resources.Resources.closeicon_b
        Me.Menu_ChangeWidget.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.Menu_ChangeWidget.Name = "Menu_ChangeWidget"
        Me.Menu_ChangeWidget.Padding = New System.Windows.Forms.Padding(0)
        Me.Menu_ChangeWidget.Size = New System.Drawing.Size(273, 34)
        Me.Menu_ChangeWidget.Text = "확장 위젯으로 바꾸기"
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
        'ColorTrans
        '
        Me.ColorTrans.Interval = 13
        '
        'WidgetGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(231, 350)
        Me.Controls.Add(Me.MainPanel)
        Me.Font = New System.Drawing.Font("Noto Sans KR", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "WidgetGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "monZi - 위젯"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.DashPanel.ResumeLayout(False)
        CType(Me.DashPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        CType(Me.LockBT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DashPanel As Panel
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents DashPic As PictureBox
    Friend WithEvents AirStateLabel As Label
    Friend WithEvents AirDetailLabel As Label
    Friend WithEvents MenuBT As PictureBox
    Friend WithEvents TopPanel As Panel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents LockBT As PictureBox
    Friend WithEvents Menu_ChangeWidget As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents MenuStrip As ContextMenuStrip
    Friend WithEvents Menu_StickHelp As ToolStripMenuItem
    Friend WithEvents ColorTrans As Timer
    Friend WithEvents Menu_DisableWidget As ToolStripMenuItem
    Friend WithEvents Menu_ShowIcon As ToolStripMenuItem
End Class
