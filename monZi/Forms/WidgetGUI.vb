Imports System.Runtime.InteropServices

Public Class WidgetGUI
    Dim loc As Point

    Dim themecol As Color = Nothing
    Dim targcol As Color = Color.FromArgb(49, 159, 158)
    Dim formshown As Boolean = False

#Region "Aero 그림자 효과 (Vista이상)"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region


#Region "페이드 효과" 'Load시 Opacity=0 꼭하기

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        FadeIn(Me, My.Settings.widget_opacity)
        formshown = True
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        FadeOut(Me)
    End Sub
#End Region


#Region "창 이동, 붙기 관련"

    Private Function DoSnap(ByVal pos As Integer, ByVal edge As Integer) As Boolean
        Dim delta As Integer = pos - edge
        Return delta > 0 AndAlso delta <= dpicalc(Me, 20)
    End Function

    Protected Overrides Sub OnResizeEnd(ByVal e As EventArgs)
        If My.Settings.widget_stick Then
            MyBase.OnResizeEnd(e)
            Dim scn As Screen = Screen.FromPoint(Me.Location)
            If DoSnap(Me.Left, scn.WorkingArea.Left) Then Me.Left = scn.WorkingArea.Left
            If DoSnap(Me.Top, scn.WorkingArea.Top) Then Me.Top = scn.WorkingArea.Top
            If DoSnap(scn.WorkingArea.Right, Me.Right) Then Me.Left = scn.WorkingArea.Right - Me.Width
            If DoSnap(scn.WorkingArea.Bottom, Me.Bottom) Then Me.Top = scn.WorkingArea.Bottom - Me.Height
        End If
    End Sub

    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTBORDER As Integer = 18
    Private Const HTBOTTOM As Integer = 15
    Private Const HTBOTTOMLEFT As Integer = 16
    Private Const HTBOTTOMRIGHT As Integer = 17
    Private Const HTCAPTION As Integer = 2
    Private Const HTLEFT As Integer = 10
    Private Const HTRIGHT As Integer = 11
    Private Const HTTOP As Integer = 12
    Private Const HTTOPLEFT As Integer = 13
    Private Const HTTOPRIGHT As Integer = 14

    Private Sub MoveForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Sub MoveArea_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TopPanel.MouseDown,
        TitleLabel.MouseDown, DashPic.MouseDown, AirStateLabel.MouseDown, AirDetailLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left And Me.WindowState <> FormWindowState.Maximized Then
            If Not My.Settings.widget_locked Then MoveForm()
        End If
    End Sub

#End Region

    Private Sub WidgetGUI_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim isDisplayAvailable As Boolean = False

        For Each scrn In Screen.AllScreens
            If scrn.DeviceName = My.Settings.widget_display Then
                Me.Location = scrn.Bounds.Location
                isDisplayAvailable = True
                Exit For
            End If
        Next

        ShowInTaskbar = My.Settings.widget_showicon
        Location = My.Settings.widget_position
        If Not IsOnScreen(Me) Then Location = New Point(100, 100) '디스플레이 범위 밖일시 걍 초기화

        Opacity = 0
        lockChk()
        DrawState()
    End Sub

    Private Sub Form_DoubleClick(sender As Object, e As MouseEventArgs) Handles TopPanel.DoubleClick,
    TitleLabel.DoubleClick, DashPic.DoubleClick, AirStateLabel.DoubleClick, AirDetailLabel.DoubleClick
        TrayForm.MainGUI_Open()
    End Sub

    'Private Sub FormDrag_MouseUp(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseUp,
    '    TitleLabel.MouseUp, DashPic.MouseUp, AirStateLabel.MouseUp, AirDetailLabel.MouseUp
    '    My.Settings.widget_position = Location
    '    My.Settings.widget_display = Screen.FromControl(Me).DeviceName
    '    My.Settings.Save()
    '    My.Settings.Reload()
    'End Sub

    Private Sub MainForm_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        If formshown Then
            My.Settings.widget_position = Location
            My.Settings.widget_display = Screen.FromControl(Me).DeviceName
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

    Private Sub BT_MouseEnter(sender As Object, e As EventArgs) Handles MenuBT.MouseEnter, LockBT.MouseEnter
        sender.BackColor = ControlPaint.Light(MainPanel.BackColor, 0.5)
    End Sub

    Private Sub BT_MouseLeave(sender As Object, e As EventArgs) Handles MenuBT.MouseLeave, LockBT.MouseLeave
        sender.BackColor = MainPanel.BackColor
    End Sub

    Private Sub LockBT_Click(sender As Object, e As EventArgs) Handles LockBT.Click
        My.Settings.widget_locked = Not My.Settings.widget_locked

        lockChk()
    End Sub

    Private Sub lockChk()
        If My.Settings.widget_locked Then
            LockBT.Image = My.Resources.lockicon_1
        Else
            LockBT.Image = My.Resources.lockicon_2
        End If
    End Sub

    '상태 그리기
    Public Sub DrawState()
        DashPic.Image = Nothing

        Select Case APIForm.combnum
            Case -4
                AirStateLabel.Text = "점검중"
                AirDetailLabel.Text = "해당 측정소에서 대기 상태를" + vbCr + "받아올 수 없습니다." + vbCr + "메인 창을 열어 장소를 변경하세요."
                TitleLabel.Text = APIForm.guititle
                themecol = Color.FromArgb(49, 27, 146)
                DashPic.Image = My.Resources.dash_maintenance
                Icon = My.Resources.ico_er
            Case -3
                AirStateLabel.Text = "위치 설정"
                AirDetailLabel.Text = "메인 창을 열어" + vbCr + "위치를 지정해 주세요"
                themecol = Color.FromArgb(55, 71, 79)
            Case -2
                TitleLabel.Text = "monZi 오류"
                AirStateLabel.Text = "오프라인"
                AirDetailLabel.Text = "인터넷 연결을 확인한 뒤" + vbCr + "새로고침해 주세요" + vbCr + "(3분 간격으로 자동 체크합니다)"
                themecol = Color.FromArgb(55, 71, 79)
                Icon = My.Resources.ico_er
            Case -1
                TitleLabel.Text = "monZi 오류"
                AirStateLabel.Text = "오류 발생"
                AirDetailLabel.Text = "인터넷 연결 문제, 혹은 측정소 점검 등으로 인한 접근 제한이 원인일 수 있습니다."
                themecol = Color.FromArgb(55, 71, 79)
                Icon = My.Resources.ico_er
            Case 0
                AirStateLabel.Text = "로드 중"
                AirDetailLabel.Text = "이 상태가 지속된다면" + vbCr + "프로그램을 다시 시작해 주세요"
                themecol = Color.FromArgb(55, 71, 79)
            Case 1
                AirStateLabel.Text = "최고"
                themecol = Color.FromArgb(30, 136, 229)
                DashPic.Image = My.Resources.dash_1
                Icon = My.Resources.ico_gr1
            Case 2
                AirStateLabel.Text = "좋음"
                themecol = Color.FromArgb(43, 201, 207)

                If My.Settings.AirStd = "AK" Then '에어코리아 기준시
                    DashPic.Image = My.Resources.dash_1
                Else
                    DashPic.Image = My.Resources.dash_2_8
                End If

                Icon = My.Resources.ico_gr2
            Case 3
                AirStateLabel.Text = "양호"
                themecol = Color.FromArgb(49, 159, 158)
                DashPic.Image = My.Resources.dash_3_8
                Icon = My.Resources.ico_gr3
            Case 4
                AirStateLabel.Text = "보통"
                themecol = Color.FromArgb(11, 182, 82)

                If My.Settings.AirStd = "AK" Then '에어코리아 기준시
                    DashPic.Image = My.Resources.dash_3_8
                Else
                    DashPic.Image = My.Resources.dash_4_8
                End If

                Icon = My.Resources.ico_gr4
            Case 5
                AirStateLabel.Text = "나쁨"
                themecol = Color.FromArgb(239, 108, 0)

                If My.Settings.AirStd = "AK" Then '에어코리아 기준시
                    DashPic.Image = My.Resources.dash_6_8
                Else
                    DashPic.Image = My.Resources.dash_5_8
                End If

                Icon = My.Resources.ico_gr5
            Case 6
                AirStateLabel.Text = "매우 나쁨"
                themecol = Color.FromArgb(229, 57, 53)

                If My.Settings.AirStd = "AK" Then '에어코리아 기준시
                    DashPic.Image = My.Resources.dash_2
                Else
                    DashPic.Image = My.Resources.dash_6_8
                End If

                Icon = My.Resources.ico_gr6
            Case 7
                AirStateLabel.Text = "극도로 나쁨"
                themecol = Color.FromArgb(86, 9, 7)
                DashPic.Image = My.Resources.dash_7_8
                Icon = My.Resources.ico_gr7
            Case 8
                AirStateLabel.Text = "최악"
                themecol = Color.FromArgb(18, 18, 18)
                DashPic.Image = My.Resources.dash_2
                Icon = My.Resources.ico_gr8
        End Select

        Text = AirStateLabel.Text + " - monZi 위젯"
        If My.Settings.FadeEnabled Then
            targcol = themecol
            ColorTrans.Start()
        Else
            SetColor(themecol)
        End If



        If Not (APIForm.combnum = 0 Or APIForm.combnum = -1 Or APIForm.combnum = -2 Or APIForm.combnum = -3 Or APIForm.combnum = -4) Then
            TitleLabel.Text = My.Settings.LocationName
            AirDetailLabel.Text = "pm10(2.5): " + APIForm.pm10num + "(" + APIForm.pm25num + ") ㎍/㎥" + vbCr + APIForm.NowChk
        End If

        Me.ValidateChildren()

    End Sub

    Private Sub SetColor(col As Color)
        MainPanel.BackColor = col
        TopPanel.BackColor = col
        LockBT.BackColor = col
        MenuBT.BackColor = col
        BottomPanel.BackColor = col
    End Sub

    Private Sub Menu_DisableWidget_Click(sender As Object, e As EventArgs) Handles Menu_DisableWidget.Click
        If MsgBox("위젯을 비활성화하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
            MainGUI.WidgetButton.Image = My.Resources.widget_1
            My.Settings.widget_enabled = False
            My.Settings.Save()
            My.Settings.Reload()
            Me.Close()
        End If
    End Sub

    Private Sub MenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuStrip.Opening

        ToolStripComboBox1.Width = dpicalc(Me, 160)

        Select Case My.Settings.widget_opacity
            Case 1
                ToolStripComboBox1.SelectedIndex = 0
            Case 0.9
                ToolStripComboBox1.SelectedIndex = 1
            Case 0.8
                ToolStripComboBox1.SelectedIndex = 2
            Case 0.7
                ToolStripComboBox1.SelectedIndex = 3
            Case 0.6
                ToolStripComboBox1.SelectedIndex = 4
            Case 0.5
                ToolStripComboBox1.SelectedIndex = 5
            Case 0.4
                ToolStripComboBox1.SelectedIndex = 6
            Case 0.3
                ToolStripComboBox1.SelectedIndex = 7
            Case 0.2
                ToolStripComboBox1.SelectedIndex = 8
        End Select

        If My.Settings.widget_stick Then
            Menu_StickHelp.Text = "모서리에 달라붙지 않기"
        Else
            Menu_StickHelp.Text = "모서리에 달라붙기"
        End If

        If My.Settings.widget_showicon Then
            Menu_ShowIcon.Text = "아이콘 표시 안함"
        Else
            Menu_ShowIcon.Text = "아이콘 표시"
        End If
    End Sub

    Private Sub MenuBT_Click(sender As Object, e As EventArgs) Handles MenuBT.Click
        MenuStrip.Show(Cursor.Position)
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Select Case ToolStripComboBox1.SelectedIndex
            Case 0 '100
                Opacity = 1
            Case 1 '90
                Opacity = 0.9
            Case 2 '80
                Opacity = 0.8
            Case 3 '70
                Opacity = 0.7
            Case 4 '60
                Opacity = 0.6
            Case 5 '50
                Opacity = 0.5
            Case 6 '40
                Opacity = 0.4
            Case 7 '30
                Opacity = 0.3
            Case 8 '20
                Opacity = 0.2
        End Select

        My.Settings.widget_opacity = Opacity
    End Sub

    Private Sub Menu_StickHelp_Click(sender As Object, e As EventArgs) Handles Menu_StickHelp.Click
        My.Settings.widget_stick = Not My.Settings.widget_stick
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub ColorTrans_Tick(sender As Object, e As EventArgs) Handles ColorTrans.Tick

        Dim nowcol As Color = MainPanel.BackColor
        Dim delta As Integer = 7

        Dim CR = Convert.ToInt16(nowcol.R)
        Dim CG = Convert.ToInt16(nowcol.G)
        Dim CB = Convert.ToInt16(nowcol.B)

        If CR > Convert.ToInt16(targcol.R) Then
            CR -= delta
            If CR < Convert.ToInt16(targcol.R) Then CR = Convert.ToInt16(targcol.R)

        ElseIf CR < Convert.ToInt16(targcol.R) Then
            CR += delta
            If CR > Convert.ToInt16(targcol.R) Then CR = Convert.ToInt16(targcol.R)

        End If

        If CG > Convert.ToInt16(targcol.G) Then
            CG -= delta
            If CG < Convert.ToInt16(targcol.G) Then CG = Convert.ToInt16(targcol.G)

        ElseIf CG < Convert.ToInt16(targcol.G) Then
            CG += delta
            If CG > Convert.ToInt16(targcol.G) Then CG = Convert.ToInt16(targcol.G)

        End If

        If CB > Convert.ToInt16(targcol.B) Then
            CB -= delta
            If CB < Convert.ToInt16(targcol.B) Then CB = Convert.ToInt16(targcol.B)

        ElseIf CB < Convert.ToInt16(targcol.B) Then
            CB += delta
            If CB > Convert.ToInt16(targcol.B) Then CB = Convert.ToInt16(targcol.B)

        End If

        'TitleLabel.Text = CR.ToString + ", " + CG.ToString + ", " + CB.ToString
        SetColor(Color.FromArgb(CR, CG, CB))

        If CR = Convert.ToInt16(targcol.R) And CG = Convert.ToInt16(targcol.G) And CB = Convert.ToInt16(targcol.B) Then
            ColorTrans.Stop()
            'TitleLabel.Text = "done"
        End If

    End Sub

    Private Sub Menu_ChangeWidget_Click(sender As Object, e As EventArgs) Handles Menu_ChangeWidget.Click
        My.Settings.widget_type = "2"
        My.Settings.Save()
        My.Settings.Reload()

        Widget2GUI.Show()
        Close()
    End Sub

    Private Sub Menu_ShowIcon_Click(sender As Object, e As EventArgs) Handles Menu_ShowIcon.Click
        If My.Settings.widget_showicon Then
            My.Settings.widget_showicon = False
            Menu_StickHelp.Text = "아이콘 표시 안함"
        Else
            My.Settings.widget_showicon = True
            Menu_StickHelp.Text = "아이콘 표시"
        End If

        My.Settings.Save()
        My.Settings.Reload()
        ShowInTaskbar = My.Settings.widget_showicon
    End Sub
End Class
