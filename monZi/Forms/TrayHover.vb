Imports System.ComponentModel

Public Class TrayHover

#Region "Aero 그림자 효과 (Vista이상)"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

    Private Sub TrayHover_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub

    Private Sub TrayHover_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FadeOut(Me)
        TrayForm.PopShown = False
    End Sub

    Public Sub UpdateForm()
        Dim themecol As Color = Nothing
        PictureBox2.Image = Nothing

        Select Case APIForm.combnum
            Case -4
                AirStateLabel.Text = "점검중"
                AirDetailLabel.Text = "해당 측정소에서 대기 상태를 받아올 수 없습니다." + vbCr + "'측정소명으로 검색'을 통해 다른 측정소를 지정하세요."
                TitleLabel.Text = APIForm.guititle
                themecol = Color.FromArgb(49, 27, 146)
                PictureBox2.Image = My.Resources.dash_maintenance
            Case -2
                TitleLabel.Text = "monZi 오류"
                AirStateLabel.Text = "오프라인"
                AirDetailLabel.Text = "인터넷 연결을 확인한 뒤 새로고침해 주세요" + vbCr + "(3분 간격으로 자동 체크합니다)"
                themecol = Color.FromArgb(55, 71, 79)
            Case -1
                TitleLabel.Text = "monZi 오류"
                AirStateLabel.Text = "오류 발생"
                AirDetailLabel.Text = "인터넷 연결 문제, 혹은 측정소 점검" + vbCr + "등으로 인한 접근 제한이 원인일 수 있습니다."
                themecol = Color.FromArgb(55, 71, 79)
            Case 0
                AirStateLabel.Text = "로드 중"
                AirDetailLabel.Text = "이 상태가 지속된다면 프로그램을 다시 시작해 주세요"
                themecol = Color.FromArgb(55, 71, 79)
            Case 1
                AirStateLabel.Text = "최고"
                themecol = Color.FromArgb(30, 136, 229)
                PictureBox2.Image = My.Resources.dash_1
            Case 2
                AirStateLabel.Text = "좋음"
                themecol = Color.FromArgb(43, 201, 207)
                PictureBox2.Image = My.Resources.dash_2_8
            Case 3
                AirStateLabel.Text = "양호"
                themecol = Color.FromArgb(49, 159, 158)
                PictureBox2.Image = My.Resources.dash_3_8
            Case 4
                AirStateLabel.Text = "보통"
                themecol = Color.FromArgb(11, 182, 82)
                PictureBox2.Image = My.Resources.dash_4_8
            Case 5
                AirStateLabel.Text = "나쁨"
                themecol = Color.FromArgb(239, 108, 0)
                PictureBox2.Image = My.Resources.dash_5_8
            Case 6
                AirStateLabel.Text = "매우 나쁨"
                themecol = Color.FromArgb(229, 57, 53)
                PictureBox2.Image = My.Resources.dash_6_8
            Case 7
                AirStateLabel.Text = "극도로 나쁨"
                themecol = Color.FromArgb(86, 9, 7)
                PictureBox2.Image = My.Resources.dash_7_8
            Case 8
                AirStateLabel.Text = "최악"
                themecol = Color.FromArgb(18, 18, 18)
                PictureBox2.Image = My.Resources.dash_2
        End Select

        MainPanel.BackColor = themecol

        If Not (APIForm.combnum = 0 Or APIForm.combnum = -1 Or APIForm.combnum = -2 Or APIForm.combnum = -4) Then
            TitleLabel.Text = My.Settings.LocationName
            AirDetailLabel.Text = "미세/초미세: " + APIForm.pm10num + "/" + APIForm.pm25num + " (㎍/㎥)" + vbCr _
                + "업데이트: " + APIForm.NowChk
        End If


        If Not My.Settings.CustomAPI = Nothing Then
            TitleLabel.Text = "(사용자 지정)" + APIForm.guititle
        End If
    End Sub

    Private Sub TrayHover_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Refresh()
        FadeIn(Me, 0.9)
    End Sub

    Private Sub TrayHover_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateForm()
        Opacity = 0
    End Sub

    Private Sub TrayHover_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.Click, AirDetailLabel.Click,
        AirStateLabel.Click, MainPanel.Click, PictureBox2.Click, TitleLabel.Click
        TrayForm.MainGUI_Open()
        Close()
    End Sub
End Class