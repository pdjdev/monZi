Imports System.Runtime.InteropServices

Public Class Widget2GUI
    Dim loc As Point

    Dim themecol As Color = Nothing
    Dim targcol As Color = Color.FromArgb(49, 159, 158)

    Dim origianlSize As New Size
    Dim prevSize As New Size

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

        origianlSize = Size

        ZoomForm(Me, My.Settings.widget_zoom, True, True)

    End Sub

    Private Sub Form_DoubleClick(sender As Object, e As MouseEventArgs) Handles TopPanel.DoubleClick,
    TitleLabel.DoubleClick, DashPic.DoubleClick, AirStateLabel.DoubleClick, AirDetailLabel.DoubleClick
        TrayForm.MainGUI_Open()
    End Sub

    'Private Sub FormDrag_MouseUp(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseUp,
    '  TitleLabel.MouseUp, DashPic.MouseUp, AirStateLabel.MouseUp, AirDetailLabel.MouseUp
    'My.Settings.widget_position = Location
    'My.Settings.widget_display = Screen.FromControl(Me).DeviceName
    'My.Settings.Save()
    'My.Settings.Reload()
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
        Dim titleStr As String = Nothing
        DashPic.Image = Nothing

        Select Case APIForm.combnum
            Case -5
                AirStateLabel.Text = "트래픽 초과"
                AirCommentLabel.Text = "monZi 요청 트래픽 초과"
                AirDetailLabel.Text = "서버 요청이 급격히 증가하여 현재 접근이 불가합니다." + vbCr + "(여기를 클릭하여 도움말 페이지 열기)"
                titleStr = APIForm.guititle
                LocationLabel.Text = My.Settings.LocationName
                themecol = Color.FromArgb(49, 27, 146)
                DashPic.Image = My.Resources.dash_maintenance
            Case -4
                AirStateLabel.Text = "점검중"
                AirCommentLabel.Text = "점검중/사용 불가 상태입니다"
                AirDetailLabel.Text = "해당 측정소에서 대기 상태를 받아올 수 없습니다." + vbCr + "'측정소명으로 검색'을 통해 다른 측정소를 지정하세요." + vbCr + "(여기를 클릭하여 주변 측정소 정보 조회)"
                titleStr = APIForm.guititle
                LocationLabel.Text = My.Settings.LocationName
                themecol = Color.FromArgb(49, 27, 146)
                DashPic.Image = My.Resources.dash_maintenance
            Case -3
                AirStateLabel.Text = "위치 설정"
                AirCommentLabel.Text = "위치를 지정해 주세요"
                titleStr = "monZi"
                LocationLabel.Text = "여기를 눌러 위치를 지정"
                AirDetailLabel.Text = "대기 상태를 업데이트 받을 위치를" + vbCr + "좌측 아래 위치명 부분을 눌러 설정하세요"
                themecol = Color.FromArgb(55, 71, 79)
                DashPic.Image = Nothing
            Case -2
                AirStateLabel.Text = "오프라인"
                AirCommentLabel.Text = "인터넷에 연결되지 않았네요"
                titleStr = "인터넷 연결 안됨"
                LocationLabel.Text = ""
                AirDetailLabel.Text = "인터넷 연결을 확인한 뒤 새로고침해 주세요" + vbCr + "(3분 간격으로 자동 체크합니다)"
                themecol = Color.FromArgb(55, 71, 79)
                DashPic.Image = Nothing
            Case -1
                AirStateLabel.Text = "오류"
                AirCommentLabel.Text = "새로고침 혹은" + vbCr + "새로 위치를 지정해 보세요"
                titleStr = "오류 발생"
                LocationLabel.Text = ""
                AirDetailLabel.Text = "인터넷 연결 문제, 혹은 측정소 점검" + vbCr + "등으로 인한 접근 제한이 원인일 수 있습니다." + vbCr + "(문제가 지속될시 업데이트를 확인하세요)"
                themecol = Color.FromArgb(55, 71, 79)
                DashPic.Image = Nothing
            Case 0
                AirStateLabel.Text = "로드 중"
                AirCommentLabel.Text = "잠시만 기다려 주세요"
                titleStr = "로드 중"
                LocationLabel.Text = "로드 중"
                AirDetailLabel.Text = "정보를 불러오고 있는 중입니다."
                themecol = Color.FromArgb(55, 71, 79)
                DashPic.Image = Nothing
            Case 1
                AirStateLabel.Text = "최고"
                AirCommentLabel.Text = "신선한 공기 마음껏 마시세요~"
                themecol = Color.FromArgb(30, 136, 229)
                DashPic.Image = My.Resources.dash_1
            Case 2
                AirStateLabel.Text = "좋음"
                AirCommentLabel.Text = "환기하셔도 좋습니다!"
                themecol = Color.FromArgb(43, 201, 207)

                If My.Settings.AirStd = "AK" Then '에어코리아 기준시
                    DashPic.Image = My.Resources.dash_1
                Else
                    DashPic.Image = My.Resources.dash_2_8
                End If

            Case 3
                AirStateLabel.Text = "양호"
                AirCommentLabel.Text = "괜찮은 날이네요!"
                themecol = Color.FromArgb(49, 159, 158)
                DashPic.Image = My.Resources.dash_3_8
            Case 4
                AirStateLabel.Text = "보통"
                AirCommentLabel.Text = "그럭저럭 괜찮은 날이네요!"
                themecol = Color.FromArgb(11, 182, 82)

                If My.Settings.AirStd = "AK" Then '에어코리아 기준시
                    DashPic.Image = My.Resources.dash_3_8
                Else
                    DashPic.Image = My.Resources.dash_4_8
                End If

            Case 5
                AirStateLabel.Text = "나쁨"
                AirCommentLabel.Text = "열린 창문이 있다면 닫아주세요~"
                themecol = Color.FromArgb(239, 108, 0)

                If My.Settings.AirStd = "AK" Then '에어코리아 기준시
                    DashPic.Image = My.Resources.dash_6_8
                Else
                    DashPic.Image = My.Resources.dash_5_8
                End If

            Case 6
                AirStateLabel.Text = "매우 나쁨"
                AirCommentLabel.Text = "외출시 마스크 꼭 챙기세요!"
                themecol = Color.FromArgb(229, 57, 53)

                If My.Settings.AirStd = "AK" Then '에어코리아 기준시
                    DashPic.Image = My.Resources.dash_2
                Else
                    DashPic.Image = My.Resources.dash_6_8
                End If

            Case 7
                AirStateLabel.Text = "극도로 나쁨"
                AirCommentLabel.Text = "주의해 주세요!"
                themecol = Color.FromArgb(86, 9, 7)
                DashPic.Image = My.Resources.dash_7_8
            Case 8
                AirStateLabel.Text = "최악"
                AirCommentLabel.Text = "가능하다면 외출을 삼가주세요!"
                themecol = Color.FromArgb(18, 18, 18)
                DashPic.Image = My.Resources.dash_2
        End Select

        Dim pm10lvl As String = "-"
        Dim pm25lvl As String = "-"

        Select Case APIForm.pm10gnum
            Case 1
                pm10lvl = "최고"
            Case 2
                pm10lvl = "좋음"
            Case 3
                pm10lvl = "양호"
            Case 4
                pm10lvl = "보통"
            Case 5
                pm10lvl = "나쁨"
            Case 6
                pm10lvl = "매우 나쁨"
            Case 7
                pm10lvl = "극도로 나쁨"
            Case 8
                pm10lvl = "최악"
        End Select

        Select Case APIForm.pm25gnum
            Case 1
                pm25lvl = "최고"
            Case 2
                pm25lvl = "좋음"
            Case 3
                pm25lvl = "양호"
            Case 4
                pm25lvl = "보통"
            Case 5
                pm25lvl = "나쁨"
            Case 6
                pm25lvl = "매우 나쁨"
            Case 7
                pm25lvl = "극도로 나쁨"
            Case 8
                pm25lvl = "최악"
        End Select

        If My.Settings.FadeEnabled Then
            targcol = themecol
            ColorTrans.Start()
        Else
            SetColor(themecol)
        End If

        If Not (APIForm.combnum = 0 Or APIForm.combnum = -1 Or APIForm.combnum = -2 Or APIForm.combnum = -3 Or APIForm.combnum = -4 Or APIForm.combnum = -5) Then
            titleStr = APIForm.guititle
            LocationLabel.Text = My.Settings.LocationName
            AirDetailLabel.Text = "미세먼지(pm10): " + APIForm.pm10num + "㎍/㎥ (" + pm10lvl + ")" _
                + vbCr + "초미세먼지(pm2.5): " + APIForm.pm25num + "㎍/㎥ (" + pm25lvl + ")" + vbCr '_
            '+ "마지막 측정: " + APIForm.NowChk
            UpdateLabel.Text = "업데이트: " + APIForm.APIupdTime + vbCr + "측정: " + Convert.ToInt16(Mid(APIForm.NowChk, 9, 2)).ToString + "일 " + Mid(APIForm.NowChk, 12)
        ElseIf APIForm.combnum = 0 Then
            UpdateLabel.Text = "업데이트 중"
        Else
            UpdateLabel.Text = "업데이트" + vbCr + "되지 않음"
        End If

        TitleLabel.Text = titleStr

        If Not My.Settings.CustomAPI = Nothing Then
            LocationLabel.Text = My.Settings.CustomAPI
        End If

        Me.ValidateChildren()

    End Sub

    Private Sub SetColor(col As Color)
        MainPanel.BackColor = col
        TopPanel.BackColor = col
        LockBT.BackColor = col
        MenuBT.BackColor = col
        BottomPanel.BackColor = ControlPaint.Dark(col, 0.2)
        BackColor = ControlPaint.Dark(col, 0.2)
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
        My.Settings.widget_type = "1"
        My.Settings.Save()
        My.Settings.Reload()

        WidgetGUI.Show()
        Close()
    End Sub

    Private Sub UpdateButton_MouseMove(sender As Object, e As MouseEventArgs) Handles UpdateButton.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(PointToClient(MousePosition).X, PointToClient(MousePosition).X * (origianlSize.Height / origianlSize.Width))
            Invalidate()
        End If
    End Sub

    Private Sub UpdateButton_MouseUp(sender As Object, e As MouseEventArgs) Handles UpdateButton.MouseUp
        ZoomForm(Me, (Height / prevSize.Height), True, False)
        My.Settings.widget_zoom = (Height / origianlSize.Height)
        My.Settings.Save()
        My.Settings.Reload()
        MainPanel.Visible = True
        BottomPanel.Visible = True
    End Sub

    Private Sub UpdateButton_MouseDown(sender As Object, e As MouseEventArgs) Handles UpdateButton.MouseDown
        prevSize = Size
        MainPanel.Visible = False
        BottomPanel.Visible = False
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