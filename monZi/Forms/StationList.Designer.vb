<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StationList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StationList))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CloseBT = New System.Windows.Forms.PictureBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.EmptyMsgPanel = New System.Windows.Forms.Panel()
        Me.EmptyMsg_Upper = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TopPanel.SuspendLayout()
        CType(Me.CloseBT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.EmptyMsgPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ColumnWidth = 5
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ListBox1.Font = New System.Drawing.Font("나눔스퀘어", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 30
        Me.ListBox1.Items.AddRange(New Object() {"List"})
        Me.ListBox1.Location = New System.Drawing.Point(0, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(472, 168)
        Me.ListBox1.TabIndex = 1
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.TitleLabel)
        Me.TopPanel.Controls.Add(Me.CloseBT)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.TopPanel.Size = New System.Drawing.Size(472, 28)
        Me.TopPanel.TabIndex = 13
        '
        'TitleLabel
        '
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.Font = New System.Drawing.Font("나눔스퀘어", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(10, 0)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(415, 28)
        Me.TitleLabel.TabIndex = 5
        Me.TitleLabel.Text = "주변 측정소 조회"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CloseBT
        '
        Me.CloseBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseBT.Image = Global.monZi.My.Resources.Resources.closeicon
        Me.CloseBT.Location = New System.Drawing.Point(425, 0)
        Me.CloseBT.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(47, 28)
        Me.CloseBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseBT.TabIndex = 3
        Me.CloseBT.TabStop = False
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.Controls.Add(Me.ListBox1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 28)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        Me.MainPanel.Size = New System.Drawing.Size(472, 192)
        Me.MainPanel.TabIndex = 15
        '
        'EmptyMsgPanel
        '
        Me.EmptyMsgPanel.BackColor = System.Drawing.Color.White
        Me.EmptyMsgPanel.Controls.Add(Me.Label1)
        Me.EmptyMsgPanel.Controls.Add(Me.EmptyMsg_Upper)
        Me.EmptyMsgPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmptyMsgPanel.Location = New System.Drawing.Point(0, 28)
        Me.EmptyMsgPanel.Name = "EmptyMsgPanel"
        Me.EmptyMsgPanel.Size = New System.Drawing.Size(472, 192)
        Me.EmptyMsgPanel.TabIndex = 2
        '
        'EmptyMsg_Upper
        '
        Me.EmptyMsg_Upper.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmptyMsg_Upper.Font = New System.Drawing.Font("나눔스퀘어", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.EmptyMsg_Upper.ForeColor = System.Drawing.Color.Gray
        Me.EmptyMsg_Upper.Location = New System.Drawing.Point(0, 0)
        Me.EmptyMsg_Upper.Name = "EmptyMsg_Upper"
        Me.EmptyMsg_Upper.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.EmptyMsg_Upper.Size = New System.Drawing.Size(472, 90)
        Me.EmptyMsg_Upper.TabIndex = 0
        Me.EmptyMsg_Upper.Text = "측정소 정보 조회에 실패하였습니다"
        Me.EmptyMsg_Upper.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("나눔스퀘어", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(0, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Label1.Size = New System.Drawing.Size(472, 90)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "요청이 너무 많아 접근이 일시적으로" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "제한되었을 수 있습니다."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StationList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Magenta
        Me.ClientSize = New System.Drawing.Size(472, 220)
        Me.Controls.Add(Me.EmptyMsgPanel)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "StationList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "최근 위치"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.TopPanel.ResumeLayout(False)
        CType(Me.CloseBT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.EmptyMsgPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TopPanel As Panel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents CloseBT As PictureBox
    Friend WithEvents MainPanel As Panel
    Friend WithEvents EmptyMsgPanel As Panel
    Friend WithEvents EmptyMsg_Upper As Label
    Friend WithEvents Label1 As Label
End Class
