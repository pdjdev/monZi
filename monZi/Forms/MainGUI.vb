Public Class MainGUI
    '슬라이딩 애니메이션 구현을 위한 임시변수
    Dim poscount As Integer = 0
    Dim ShowingMenu As Boolean = False
    Dim goUp As Boolean = False

    '메뉴폼 Trans 애니메이션 구현을 위한 임시변수
    Dim transnum As Integer = 0
    Dim titleStr As String = ""

    Dim themecol As Color = Nothing
    Dim targcol As Color = Color.FromArgb(49, 159, 158)
    Dim firstShwon As Boolean = True

#Region "Aero 그림자 효과 (Vista이상)"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region


    '페이드 효과 FadeIn에 시작프로그램 안내폼 표시 이벤트있음
#Region "페이드 효과" 'Load시 Opacity=0 꼭하기

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        FadeIn(Me, 1)


        '===시작프로그램안내폼===
        If Not My.Settings.StartupPopIgnore Then
            Dim startupset As Boolean = True
            Try
                startupset = checkStartUp()
            Catch ex As Exception
                '오류가 발생하면 아무것도 안하는걸로
                startupset = False
            End Try
            If Not startupset Then
                StartupAsk.SetDesktopLocation(Me.Location.X + Me.Size.Width / 2 - StartupAsk.Size.Width / 2,
                                              Me.Location.Y + Me.Size.Height / 2 - StartupAsk.Size.Height / 2)
                StartupAsk.Show()
                StartupAsk.TopMost = True
            End If
        End If


    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        FadeOut(Me)
    End Sub
#End Region

    Private Sub MainGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '디버그모드====================================
        'If My.Settings.APIFORM Then HistoryButton.Show()
        '=============================================

        DrawState()
        Opacity = 0

        '일단 초기로 메뉴패널을 비활성화하고 숨겨놓기
        ShowingMenu = False
        MenuPanel.Visible = False

        If My.Settings.UseNativeFont Then ChangeToNativeFont(Me)

        If My.Settings.widget_enabled Then
            WidgetButton.Image = My.Resources.widget_2
        Else
            WidgetButton.Image = My.Resources.widget_1
        End If

        Dim opttmp As Integer = Convert.ToInt32(Mid(My.Settings.FormPos, 1, 1))
        goUp = (opttmp = 1 Or opttmp = 3)

        If goUp Then
            HideButton.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
        End If

    End Sub

    Sub ModeChange()
        If ShowingMenu Then
            If My.Settings.AniEnabled Then
                transnum = 0
                MenuPanel.Dock = DockStyle.Top
                MenuPanel.Height = 1
                Transani.Start()
            Else
                MenuPanel.Dock = DockStyle.Fill
            End If

            MenuPanel.Visible = True
        Else

            If My.Settings.AniEnabled Then
                transnum = 0
                MenuPanel.Dock = DockStyle.Top
                MenuPanel.Height = MainPanel.Height
                Transani.Start()
            Else
                MenuPanel.Visible = False
            End If

        End If
    End Sub

    Private Sub AirDetailLabel_Click(sender As Object, e As EventArgs) Handles AirDetailLabel.Click
        If APIForm.combnum = -4 Then
            Process.Start("http://www.airkorea.or.kr/web/realSearch")
        ElseIf APIForm.combnum = -5 Then
            Process.Start("https://monzi.ze.am/help/qna#h.p_1xVTMpkeAAVn")
        End If
    End Sub

    Public Sub DrawState()

        If ShowingMenu = True Then
            ShowingMenu = False
            ModeChange()
        End If

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
                firstShwon = False
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

        If My.Settings.FadeEnabled And Not firstShwon Then
            targcol = themecol
            ColorTrans.Start()
        Else
            firstShwon = False
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
        ListButton.BackColor = col
        HideButton.BackColor = col
        HistoryButton.BackColor = col
        BottomPanel.BackColor = ControlPaint.Dark(col, 0.2)
        MenuPanel.BackColor = ControlPaint.Dark(col, 0.01)
        Menu_BT1.BackColor = col
        Menu_BT2.BackColor = col
        Menu_BT3.BackColor = col
        Menu_BT4.BackColor = col
        BottomBT1_Panel.BackColor = Color.Transparent
        BottomBT2_Panel.BackColor = Color.Transparent
    End Sub

    Private Sub hideani_Tick(sender As Object, e As EventArgs) Handles hideani.Tick
        If poscount >= 15 Then
            Me.Opacity = 0
            poscount = 0
            hideani.Stop()
            Me.Close()
        Else
            If goUp Then
                SetDesktopLocation(Location.X, Location.Y - dpicalc(Me, poscount))
            Else
                SetDesktopLocation(Location.X, Location.Y + dpicalc(Me, poscount))
            End If

            poscount += 1
            Opacity -= 1 / 15
        End If
    End Sub

    Private Sub HideButton_Click(sender As Object, e As EventArgs) Handles HideButton.Click
        TopMost = False

        If My.Settings.AniEnabled Then
            hideani.Start()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles LocationButton.Click, LocationLabel.Click

        '커스텀API 설정시에는 위치설정 X
        If Not My.Settings.CustomAPI = Nothing Then
            MsgBox("사용자 지정 API를 해제한 후 변경하실 수 있습니다", vbInformation)
            GoTo endtask
        End If

        If Not (My.Settings.LocationName = Nothing) Then
            If MsgBox("기존에 설정된 위치(" + My.Settings.LocationName + ")를 변경하시겠습니까?", vbQuestion + vbYesNo) = vbNo Then
                GoTo endtask
            End If
        End If

        Me.TopMost = False

        Dim mouseloc As New Point(Cursor.Position.X, Cursor.Position.Y)
        Dim marign As Integer = dpicalc(Me, 10)

        Dim showx = Screen.GetWorkingArea(mouseloc).Width - LocationSet.Width - marign
        Dim showy = Screen.GetWorkingArea(mouseloc).Height - LocationSet.Height - marign
        LocationSet.SetDesktopLocation(showx, showy)

        LocationSet.Show()
        Me.Close()
endtask:
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click, UpdateLabel.Click
        If Not APIForm.combnum = -3 Then '값이 유효할시
            UpdateLabel.Text = "업데이트 중"
            APIForm.AirAPICheck.CancelAsync()
            APIForm.Close()
            APIForm.PrevChk = "-1" '무조건 업데이트하도록
            DrawState()
            APIForm.Activate()
        Else
            MsgBox("위치를 지정한 뒤 업데이트를 해 주세요.", vbInformation)
        End If
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles HideButton.MouseEnter,
        ListButton.MouseEnter, HistoryButton.MouseEnter, WidgetButton.MouseEnter
        Dim obj As PictureBox = sender
        obj.BackColor = ControlPaint.Light(MainPanel.BackColor, 0.2)

        Dim helptext As String = ""

        Select Case obj.Name
            Case "HideButton"
                helptext = "숨김"
            Case "ListButton"
                helptext = "메뉴"
            Case "HistoryButton"
                helptext = "이전 위치"
            Case "WidgetButton"
                If My.Settings.widget_enabled Then
                    helptext = "위젯 숨기기"
                Else
                    helptext = "위젯 표시하기"
                End If
        End Select

        TitleLabel.Text = helptext
        MenuTitle.Text = helptext

    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles HideButton.MouseLeave,
        ListButton.MouseLeave, HistoryButton.MouseLeave, WidgetButton.MouseLeave
        Dim obj As PictureBox = sender
        obj.BackColor = Color.Transparent
        TitleLabel.Text = titleStr
        MenuTitle.Text = "메뉴"
    End Sub

    Private Sub MenuButton_MouseEnter(sender As Object, e As EventArgs) Handles ListButton2.MouseEnter, CloseButton.MouseEnter, CloseLabel.MouseEnter
        Dim obj As Object = sender

        If obj.Name = "CloseLabel" Or obj.Name = "CloseButton" Then
            CloseLabel.BackColor = ControlPaint.Light(MenuPanel.BackColor, 0.2)
            CloseButton.BackColor = ControlPaint.Light(MenuPanel.BackColor, 0.2)
        Else
            obj.BackColor = ControlPaint.Light(MenuPanel.BackColor, 0.2)
        End If

        Dim helptext As String = ""

        Select Case obj.Name
            Case "ListButton2"
                helptext = "메인 화면"
            Case "CloseButton" 
                helptext = "monZi 종료"
            Case "CloseLabel"
                helptext = "monZi 종료"
        End Select

        TitleLabel.Text = helptext
        MenuTitle.Text = helptext

    End Sub

    Private Sub MenuButton_MouseLeave(sender As Object, e As EventArgs) Handles ListButton2.MouseLeave, CloseButton.MouseLeave, CloseLabel.MouseLeave
        Dim obj As Object = sender

        If obj.Name = "CloseLabel" Or obj.Name = "CloseButton" Then
            CloseLabel.BackColor = Color.Transparent
            CloseButton.BackColor = Color.Transparent
        Else
            obj.BackColor = Color.Transparent
        End If

        TitleLabel.Text = titleStr
        MenuTitle.Text = "메뉴"
    End Sub

    Private Sub BottomButton1_MouseEnter(sender As Object, e As EventArgs) Handles LocationLabel.MouseEnter, LocationButton.MouseEnter
        BottomBT1_Panel.BackColor = ControlPaint.Light(BottomPanel.BackColor, 0.2)
        Dim helptext As String = "위치 설정/변경"

        TitleLabel.Text = helptext
        MenuTitle.Text = helptext
    End Sub

    Private Sub BottomButton1_MouseLeave(sender As Object, e As EventArgs) Handles LocationLabel.MouseLeave, LocationButton.MouseLeave
        BottomBT1_Panel.BackColor = Color.Transparent
        TitleLabel.Text = titleStr
        MenuTitle.Text = "메뉴"
    End Sub

    Private Sub BottomButton2_MouseEnter(sender As Object, e As EventArgs) Handles UpdateLabel.MouseEnter, UpdateButton.MouseEnter
        BottomBT2_Panel.BackColor = ControlPaint.Light(BottomPanel.BackColor, 0.2)
        Dim helptext As String = "대기 정보 업데이트"

        TitleLabel.Text = helptext
        MenuTitle.Text = helptext
    End Sub

    Private Sub BottomButton2_MouseLeave(sender As Object, e As EventArgs) Handles UpdateLabel.MouseLeave, UpdateButton.MouseLeave
        BottomBT2_Panel.BackColor = Color.Transparent
        TitleLabel.Text = titleStr
        MenuTitle.Text = "메뉴"
    End Sub

    Private Sub ListButton_Click(sender As Object, e As EventArgs) Handles ListButton.Click, ListButton2.Click

        If ShowingMenu = False Then
            ShowingMenu = True
        Else
            ShowingMenu = False
        End If

        ModeChange()

    End Sub

    Private Sub Transani_Tick(sender As Object, e As EventArgs) Handles Transani.Tick
        If ShowingMenu Then
            If (MenuPanel.Height + transnum <= MainPanel.Height) Then
                transnum += dpicalc(Me, 2)
                MenuPanel.Height += transnum
            Else
                MenuPanel.Dock = DockStyle.Fill
                Transani.Stop()
            End If
        Else
            If (MenuPanel.Height - transnum >= 1) Then
                transnum += dpicalc(Me, 2)
                MenuPanel.Height -= transnum
            Else
                MenuPanel.Visible = False
                ShowingMenu = False
                MenuPanel.Dock = DockStyle.Top
                Transani.Stop()
            End If
        End If
    End Sub

    Private Sub MenuButtons_MouseEnter(sender As Object, e As EventArgs) Handles Menu_BT1.MouseEnter, Menu_BT2.MouseEnter, Menu_BT3.MouseEnter, Menu_BT4.MouseEnter
        Dim btobj As PictureBox = sender
        btobj.BackColor = ControlPaint.Light(MainPanel.BackColor, 0.2)
    End Sub

    Private Sub MenuButtons_MouseLeave(sender As Object, e As EventArgs) Handles Menu_BT1.MouseLeave, Menu_BT2.MouseLeave, Menu_BT3.MouseLeave, Menu_BT4.MouseLeave
        Dim btobj As PictureBox = sender
        btobj.BackColor = MainPanel.BackColor
    End Sub

    Private Sub Menu_BT1_Click(sender As Object, e As EventArgs) Handles Menu_BT1.Click
        OptionForm.Show()
    End Sub

    Private Sub Menu_BT3_Click(sender As Object, e As EventArgs) Handles Menu_BT3.Click

        Me.TopMost = False

        Dim mouseloc As New Point(Cursor.Position.X, Cursor.Position.Y)
        Dim marign As Integer = dpicalc(Me, 10)

        Dim showx = Screen.GetWorkingArea(mouseloc).Width - UpdateForm.Width - marign
        Dim showy = Screen.GetWorkingArea(mouseloc).Height - UpdateForm.Height - marign
        UpdateForm.SetDesktopLocation(showx, showy)

        FadeOut(Me)
        Hide()
        UpdateForm.Show()

    End Sub

    Private Sub Menu_BT2_Click(sender As Object, e As EventArgs) Handles Menu_BT2.Click
        If MsgBox("도움말 페이지로 이동하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
            Process.Start("http://help.monzi-host.ze.am")
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click, CloseLabel.Click
        FadeOut(Me)
        TrayForm.Close()
    End Sub

    Private Sub Menu_BT4_Click(sender As Object, e As EventArgs) Handles Menu_BT4.Click

        Me.TopMost = False

        Dim mouseloc As New Point(Cursor.Position.X, Cursor.Position.Y)
        Dim marign As Integer = dpicalc(Me, 10)

        Dim showx = Screen.GetWorkingArea(mouseloc).Width - about.Width - marign
        Dim showy = Screen.GetWorkingArea(mouseloc).Height - about.Height - marign
        about.SetDesktopLocation(showx, showy)

        FadeOut(Me)
        Hide()
        about.Show()


        'MsgBox(My.Resources.appinfo, vbInformation)
    End Sub

    Private Sub RecentLocButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click

        '커스텀API 설정시에는 위치설정 X
        If Not My.Settings.CustomAPI = Nothing Then
            MsgBox("사용자 지정 API를 해제한 후 변경하실 수 있습니다", vbInformation)
            GoTo endtask
        End If

        Me.TopMost = False

        Dim mouseloc As New Point(Cursor.Position.X, Cursor.Position.Y)
        Dim marign As Integer = dpicalc(Me, 10)

        Dim showx = Screen.GetWorkingArea(mouseloc).Width - LocList.Width - marign
        Dim showy = Screen.GetWorkingArea(mouseloc).Height - LocList.Height - marign
        LocList.SetDesktopLocation(showx, showy)

        FadeOut(Me)
        LocList.Show()
        Me.Close()

endtask:

    End Sub

    Private Sub WidgetButton_Click(sender As Object, e As EventArgs) Handles WidgetButton.Click
        'Application.OpenForms().OfType(Of WidgetGUI).Any
        If My.Settings.widget_enabled Then
            '설정 활성화시에
            My.Settings.widget_enabled = False
            WidgetButton.Image = My.Resources.widget_1
            WidgetGUI.Close()
        Else
            '비활성화시에
            My.Settings.widget_enabled = True
            WidgetButton.Image = My.Resources.widget_2
            WidgetGUI.Show()
        End If

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

    Private Sub TitleLabel_Click(sender As Object, e As EventArgs) Handles TitleLabel.Click
        ColorTrans.Start()
    End Sub
End Class