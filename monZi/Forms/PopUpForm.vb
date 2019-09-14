Public Class PopUpForm

#Region "Aero 그림자 효과 (Vista이상)"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

#Region "페이드 효과" 'Load시 Opacity=0 꼭하기

    Dim MouseOn = False

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        FadeOut(Me)
    End Sub
#End Region

    Sub DrawPopUp()
        Dim themecol As Color = Nothing

        Select Case APIForm.combnum
            Case -4
                AirStateLabel.Text = "점검중"
                AirCommentLabel.Text = "점검중/사용 불가 상태입니다"
                AirDetailLabel.Text = "해당 측정소에서 대기 상태를 받아올 수 없습니다." + vbCr + "'측정소명으로 검색'을 통해 다른 측정소를 지정하세요."
                TitleLabel.Text = APIForm.guititle
                themecol = Color.FromArgb(49, 27, 146)
                PictureBox2.Image = My.Resources.dash_maintenance
            Case -2
                TitleLabel.Text = "monZi 오류"
                AirStateLabel.Text = "오프라인"
                AirCommentLabel.Text = "인터넷에 연결되어 있지 않네요"
                AirDetailLabel.Text = "인터넷 연결을 확인한 뒤 새로고침해 주세요" + vbCr + "(3분 간격으로 자동 체크합니다)"
                themecol = Color.FromArgb(55, 71, 79)
            Case -1
                TitleLabel.Text = "monZi 오류"
                AirStateLabel.Text = "오류 발생"
                AirCommentLabel.Text = "문제가 발생하였습니다"
                AirDetailLabel.Text = "인터넷 연결 문제, 혹은 측정소 점검" + vbCr + "등으로 인한 접근 제한이 원인일 수 있습니다."
                themecol = Color.FromArgb(55, 71, 79)
            Case 0
                AirStateLabel.Text = "로드 중"
                AirCommentLabel.Text = "정보를 불러오고 있습니다"
                AirDetailLabel.Text = "이 상태가 지속된다면 프로그램을 다시 시작해 주세요"
                themecol = Color.FromArgb(55, 71, 79)
            Case 1
                AirStateLabel.Text = "최고"
                AirCommentLabel.Text = "신선한 공기 마음껏 마시세요~"
                themecol = Color.FromArgb(30, 136, 229)
            Case 2
                AirStateLabel.Text = "좋음"
                AirCommentLabel.Text = "환기하셔도 좋습니다!"
                themecol = Color.FromArgb(43, 201, 207)
            Case 3
                AirStateLabel.Text = "양호"
                AirCommentLabel.Text = "괜찮은 날이네요!"
                themecol = Color.FromArgb(49, 159, 158)
            Case 4
                AirStateLabel.Text = "보통"
                AirCommentLabel.Text = "그럭저럭 괜찮은 날이네요!"
                themecol = Color.FromArgb(11, 182, 82)
            Case 5
                AirStateLabel.Text = "나쁨"
                AirCommentLabel.Text = "열린 창문이 있다면 닫아주세요~"
                themecol = Color.FromArgb(239, 108, 0)
            Case 6
                AirStateLabel.Text = "매우 나쁨"
                AirCommentLabel.Text = "외출시 마스크 꼭 챙기세요!"
                themecol = Color.FromArgb(229, 57, 53)
            Case 7
                AirStateLabel.Text = "극도로 나쁨"
                AirCommentLabel.Text = "주의해 주세요!"
                themecol = Color.FromArgb(86, 9, 7)
            Case 8
                AirStateLabel.Text = "최악"
                AirCommentLabel.Text = "가능하다면 외출을 삼가주세요!"
                themecol = Color.FromArgb(18, 18, 18)
        End Select

        MainPanel.BackColor = themecol
        TopPanel.BackColor = themecol


        If Not (APIForm.combnum = 0 Or APIForm.combnum = -1 Or APIForm.combnum = -2 Or APIForm.combnum = -4) Then
            TitleLabel.Text = "실시간 대기 알림 - " + My.Settings.LocationName
            AirDetailLabel.Text = "pm10: " + APIForm.pm10num + "㎍/㎥ | pm2.5: " + APIForm.pm25num + "㎍/㎥" + vbCr _
                + "(" + APIForm.NowChk + ")"
            If My.Settings.PushWithsound Then My.Computer.Audio.Play(My.Resources.popup_snd, AudioPlayMode.Background)
        End If


        If Not My.Settings.CustomAPI = Nothing Then
            TitleLabel.Text = "실시간 대기 알림 - " + APIForm.guititle
        End If
    End Sub

    Private Sub PopUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawPopUp()
        Opacity = 0
        TopMost = My.Settings.PushTopmost
        If My.Settings.UseNativeFont Then
            AirCommentLabel.Height -= dpicalc(Me, 5)
            AirCommentLabel.Padding = New Padding(dpicalc(Me, 9), 0, 0, 0)
            AirDetailLabel.Height -= dpicalc(Me, 5)
            ChangeToNativeFont(Me)
        End If
    End Sub

    Private Sub AirDetailLabel_Click(sender As Object, e As EventArgs) Handles AirDetailLabel.Click

    End Sub

    Private Sub AirStateLabel_Click(sender As Object, e As EventArgs) Handles AirStateLabel.Click

    End Sub

    Private Sub ClosePopup(sender As Object, e As EventArgs) Handles CloseBT.Click  ', Me.LostFocus <-이거는 그냥 안하기로 (너무 창이 쉽게 사라져버림)
        Me.Close()
    End Sub

    Private Sub CloseBT_MouseEnter(sender As Object, e As EventArgs) Handles CloseBT.MouseEnter, OptBT.MouseEnter
        sender.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.5)
    End Sub

    Private Sub CloseBT_MouseLeave(sender As Object, e As EventArgs) Handles OptBT.MouseLeave, CloseBT.MouseLeave
        sender.BackColor = TopPanel.BackColor
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles OptBT.Click
        OptionForm.mode = 2
        OptionForm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles AniTimer.Tick

        If MouseOn Then
            If Not Opacity = 1 Then
                Opacity += 0.02
            End If
        Else
            If Opacity > 0.8 Then
                Opacity -= 0.02
            Else
                AniTimer.Stop()
            End If
        End If

    End Sub

    Private Sub TitleLabel_MouseEnter(sender As Object, e As EventArgs) Handles TitleLabel.MouseEnter, PictureBox2.MouseEnter, OptBT.MouseEnter, MainPanel.MouseEnter, CloseBT.MouseEnter, AirStateLabel.MouseEnter, AirDetailLabel.MouseEnter, AirCommentLabel.MouseEnter
        AniTimer.Start()
        MouseOn = True
    End Sub

    Private Sub TitleLabel_MouseLeave(sender As Object, e As EventArgs) Handles TitleLabel.MouseLeave, PictureBox2.MouseLeave, OptBT.MouseLeave, MainPanel.MouseLeave, CloseBT.MouseLeave, AirStateLabel.MouseLeave, AirDetailLabel.MouseLeave, AirCommentLabel.MouseLeave
        MouseOn = False
    End Sub

    Private Sub FirstWaitTimer_Tick(sender As Object, e As EventArgs) Handles FirstWaitTimer.Tick
        AniTimer.Start()
        FirstWaitTimer.Stop()
    End Sub
End Class