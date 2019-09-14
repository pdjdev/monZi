<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APIForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(APIForm))
        Me.AirAPICheck = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PCTimeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.APICheck = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.customapibox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.userapikeybox = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AirAPICheck
        '
        Me.AirAPICheck.WorkerSupportsCancellation = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "guiopen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(19, 48)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "findair"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PCTimeCheck
        '
        Me.PCTimeCheck.Enabled = True
        Me.PCTimeCheck.Interval = 2000
        '
        'APICheck
        '
        Me.APICheck.Interval = 300000
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(19, 80)
        Me.Button3.Margin = New System.Windows.Forms.Padding(1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "updateair"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(178, 183)
        Me.Button4.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 30)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "apply"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(19, 151)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(242, 23)
        Me.NumericUpDown1.TabIndex = 4
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(268, 16)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(118, 19)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "실시간 알림 설정"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(141, 80)
        Me.Button6.Margin = New System.Windows.Forms.Padding(1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(120, 30)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "reset"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(141, 16)
        Me.Button7.Margin = New System.Windows.Forms.Padding(1)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 30)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "close"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(19, 112)
        Me.Button8.Margin = New System.Windows.Forms.Padding(1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(120, 30)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "popup"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(141, 48)
        Me.Button9.Margin = New System.Windows.Forms.Padding(1)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(120, 30)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "hide"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(268, 37)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(118, 19)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "실시간 푸시 설정"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(19, 183)
        Me.Button5.Margin = New System.Windows.Forms.Padding(1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 30)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "isAPIBusy"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'customapibox
        '
        Me.customapibox.Location = New System.Drawing.Point(270, 112)
        Me.customapibox.Name = "customapibox"
        Me.customapibox.Size = New System.Drawing.Size(145, 23)
        Me.customapibox.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(267, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "not changed"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(141, 112)
        Me.Button10.Margin = New System.Windows.Forms.Padding(1)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(120, 30)
        Me.Button10.TabIndex = 16
        Me.Button10.Text = "makeException"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'userapikeybox
        '
        Me.userapikeybox.Location = New System.Drawing.Point(270, 188)
        Me.userapikeybox.Name = "userapikeybox"
        Me.userapikeybox.Size = New System.Drawing.Size(145, 23)
        Me.userapikeybox.TabIndex = 18
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(421, 188)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(44, 23)
        Me.Button11.TabIndex = 19
        Me.Button11.Text = "적용"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 30)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "AKAPI 개인인증키설정" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(비어 있음=기본값)"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(96, 183)
        Me.Button12.Margin = New System.Windows.Forms.Padding(1)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 30)
        Me.Button12.TabIndex = 21
        Me.Button12.Text = "APIType"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "커스텀APIURI"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(421, 112)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(44, 23)
        Me.Button13.TabIndex = 23
        Me.Button13.Text = "적용"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'APIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(477, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.userapikeybox)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.customapibox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "APIForm"
        Me.Text = "APIForm"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AirAPICheck As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PCTimeCheck As Timer
    Friend WithEvents APICheck As Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button5 As Button
    Friend WithEvents customapibox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents userapikeybox As TextBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button13 As Button
End Class
