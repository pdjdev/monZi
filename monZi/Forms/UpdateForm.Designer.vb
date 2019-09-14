<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateForm))
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CloseBT = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NewVerLabel = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ForceUpdButton = New System.Windows.Forms.Button()
        Me.UpdButton = New System.Windows.Forms.Button()
        Me.VerLabel = New System.Windows.Forms.Label()
        Me.UpdateChk = New System.ComponentModel.BackgroundWorker()
        Me.TopPanel.SuspendLayout()
        CType(Me.CloseBT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.TitleLabel)
        Me.TopPanel.Controls.Add(Me.CloseBT)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.TopPanel.Size = New System.Drawing.Size(425, 30)
        Me.TopPanel.TabIndex = 8
        '
        'TitleLabel
        '
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TitleLabel.Font = New System.Drawing.Font("나눔스퀘어", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(10, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(139, 30)
        Me.TitleLabel.TabIndex = 4
        Me.TitleLabel.Text = "업데이트 확인"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CloseBT
        '
        Me.CloseBT.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseBT.Image = Global.monZi.My.Resources.Resources.closeicon
        Me.CloseBT.Location = New System.Drawing.Point(378, 0)
        Me.CloseBT.Name = "CloseBT"
        Me.CloseBT.Size = New System.Drawing.Size(47, 30)
        Me.CloseBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloseBT.TabIndex = 3
        Me.CloseBT.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.NewVerLabel)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.VerLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel1.Size = New System.Drawing.Size(425, 180)
        Me.Panel1.TabIndex = 9
        '
        'NewVerLabel
        '
        Me.NewVerLabel.AutoSize = True
        Me.NewVerLabel.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.NewVerLabel.Location = New System.Drawing.Point(162, 12)
        Me.NewVerLabel.Name = "NewVerLabel"
        Me.NewVerLabel.Size = New System.Drawing.Size(172, 20)
        Me.NewVerLabel.TabIndex = 42
        Me.NewVerLabel.Text = "최신 버전: (불러오는 중)"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Location = New System.Drawing.Point(18, 43)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(390, 1)
        Me.Panel4.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RichTextBox1)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Location = New System.Drawing.Point(18, 46)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(390, 122)
        Me.Panel3.TabIndex = 41
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(390, 80)
        Me.RichTextBox1.TabIndex = 37
        Me.RichTextBox1.Text = ""
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 80)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(390, 5)
        Me.Panel6.TabIndex = 40
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ForceUpdButton)
        Me.Panel5.Controls.Add(Me.UpdButton)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 85)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(390, 37)
        Me.Panel5.TabIndex = 39
        '
        'ForceUpdButton
        '
        Me.ForceUpdButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.ForceUpdButton.Enabled = False
        Me.ForceUpdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForceUpdButton.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForceUpdButton.Location = New System.Drawing.Point(0, 0)
        Me.ForceUpdButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ForceUpdButton.Name = "ForceUpdButton"
        Me.ForceUpdButton.Size = New System.Drawing.Size(98, 37)
        Me.ForceUpdButton.TabIndex = 38
        Me.ForceUpdButton.Text = "상관없이 가기"
        Me.ForceUpdButton.UseVisualStyleBackColor = True
        '
        'UpdButton
        '
        Me.UpdButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.UpdButton.Enabled = False
        Me.UpdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdButton.Location = New System.Drawing.Point(212, 0)
        Me.UpdButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UpdButton.Name = "UpdButton"
        Me.UpdButton.Size = New System.Drawing.Size(178, 37)
        Me.UpdButton.TabIndex = 21
        Me.UpdButton.Text = "업데이트 다운 페이지 열기"
        Me.UpdButton.UseVisualStyleBackColor = True
        '
        'VerLabel
        '
        Me.VerLabel.AutoSize = True
        Me.VerLabel.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.VerLabel.Location = New System.Drawing.Point(14, 12)
        Me.VerLabel.Name = "VerLabel"
        Me.VerLabel.Size = New System.Drawing.Size(77, 20)
        Me.VerLabel.TabIndex = 39
        Me.VerLabel.Text = "현재 버전:"
        '
        'UpdateChk
        '
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Magenta
        Me.ClientSize = New System.Drawing.Size(425, 210)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopPanel)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "업데이트 확인"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.TopPanel.ResumeLayout(False)
        CType(Me.CloseBT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents CloseBT As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NewVerLabel As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents UpdButton As Button
    Friend WithEvents VerLabel As Label
    Friend WithEvents ForceUpdButton As Button
    Friend WithEvents UpdateChk As System.ComponentModel.BackgroundWorker
End Class
