<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrayForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrayForm))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.M0openGUIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.M2updateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.M3pushToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.M1closeappToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APIFormShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "monZi - 두번 클릭하여 자세히 보기"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("나눔스퀘어", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M0openGUIToolStripMenuItem, Me.M2updateToolStripMenuItem, Me.M3pushToolStripMenuItem, Me.M1closeappToolStripMenuItem, Me.APIFormShowToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(169, 134)
        '
        'M0openGUIToolStripMenuItem
        '
        Me.M0openGUIToolStripMenuItem.Font = New System.Drawing.Font("나눔스퀘어 Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.M0openGUIToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.M0openGUIToolStripMenuItem.Name = "M0openGUIToolStripMenuItem"
        Me.M0openGUIToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.M0openGUIToolStripMenuItem.Text = "monZi 열기"
        '
        'M2updateToolStripMenuItem
        '
        Me.M2updateToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.M2updateToolStripMenuItem.Name = "M2updateToolStripMenuItem"
        Me.M2updateToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.M2updateToolStripMenuItem.Text = "실시간 업데이트"
        '
        'M3pushToolStripMenuItem
        '
        Me.M3pushToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.M3pushToolStripMenuItem.Name = "M3pushToolStripMenuItem"
        Me.M3pushToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.M3pushToolStripMenuItem.Text = "실시간 푸시 알림"
        '
        'M1closeappToolStripMenuItem
        '
        Me.M1closeappToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.M1closeappToolStripMenuItem.Name = "M1closeappToolStripMenuItem"
        Me.M1closeappToolStripMenuItem.ShowShortcutKeys = False
        Me.M1closeappToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.M1closeappToolStripMenuItem.Text = "프로그램 종료"
        '
        'APIFormShowToolStripMenuItem
        '
        Me.APIFormShowToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.APIFormShowToolStripMenuItem.Name = "APIFormShowToolStripMenuItem"
        Me.APIFormShowToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.APIFormShowToolStripMenuItem.Text = "APIForm Show"
        Me.APIFormShowToolStripMenuItem.Visible = False
        '
        'TrayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(82, 67)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TrayForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "TrayForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents M1closeappToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents M2updateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents M3pushToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents M0openGUIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents APIFormShowToolStripMenuItem As ToolStripMenuItem
End Class
