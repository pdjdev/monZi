Public Class OptionForm
    Public mode As Integer = 1
    Dim Loc As Point

    Dim ActiveColor As Color = Color.FromArgb(0, 229, 255)
    Dim inActiveColor As Color = Color.FromArgb(0, 86, 98)
    Dim optionchanged As Boolean = False

    Dim DEBUGCOUNT As Integer = 0 '디버그 옵션 이벤트카운트
    Dim DEBUGMODE As Boolean = False '디버그 옵션 표시 여부 (배포시에는 FALSE로 두기)

#Region "Aero 그림자 효과 (Vista이상)"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

#Region "페이드 효과" 'Load시 Opacity=0 꼭하기

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        optionchanged = False
        ApplyBT.Text = "닫기"
        Me.Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        FadeOut(Me)
        MainGUI.TopMost = True
    End Sub
#End Region

    Private Sub FormDrag_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown, TitleLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Loc = e.Location
        End If
    End Sub

    Private Sub FormDrag_MouseMove(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseMove, TitleLabel.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - Loc
        End If
    End Sub

    Private Sub LocationSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainGUI.TopMost = False '화면 크기가 작은 PC에서 MainGUI가 옵션창을 가리기에 잠시 TopMost 해제하기 -> FormClosing때 다시 복구
        Modeset(mode)
        SettingLoad()
        Opacity = 0
        DEBUGMODE = (My.Settings.APIFORM Or My.Settings.UseAKAPI)
        DEBUGPANEL.Visible = DEBUGMODE
        If My.Settings.UseNativeFont Then ChangeToNativeFont(Me)
    End Sub

    Private Sub CloseBT_MouseEnter(sender As Object, e As EventArgs) Handles CloseBT.MouseEnter
        CloseBT.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.2)
    End Sub

    Private Sub CloseBT_MouseLeave(sender As Object, e As EventArgs) Handles CloseBT.MouseLeave
        CloseBT.BackColor = Color.Transparent
    End Sub

    Sub Modeset(mode As Integer)
        Select Case mode
            Case 1
                Tab1.BackColor = ActiveColor
                Tab2.BackColor = inActiveColor
                Tab3.BackColor = inActiveColor
                TabPanel1.Show()
                TabPanel2.Hide()
                TabPanel3.Hide()

            Case 2
                Tab1.BackColor = inActiveColor
                Tab2.BackColor = ActiveColor
                Tab3.BackColor = inActiveColor
                TabPanel1.Hide()
                TabPanel2.Show()
                TabPanel3.Hide()


                '에어코리아 <> WHO기준 따라 표시할 컨트롤 바꿔뿌기
                If stdchk_airkorea.Checked Then
                    alchk_1.Enabled = False
                    alchk_3.Enabled = False
                    alchk_7.Enabled = False
                    alchk_8.Enabled = False
                Else
                    alchk_1.Enabled = True
                    alchk_3.Enabled = True
                    alchk_7.Enabled = True
                    alchk_8.Enabled = True
                End If

            Case 3
                Tab1.BackColor = inActiveColor
                Tab2.BackColor = inActiveColor
                Tab3.BackColor = ActiveColor
                TabPanel1.Hide()
                TabPanel2.Hide()
                TabPanel3.Show()

        End Select
    End Sub

    Private Sub TabLabel1_Click(sender As Object, e As EventArgs) Handles TabLabel1.Click
        Modeset(1)
    End Sub

    Private Sub TabLabel2_Click(sender As Object, e As EventArgs) Handles TabLabel2.Click
        Modeset(2)
    End Sub

    Private Sub TabLabel3_Click(sender As Object, e As EventArgs) Handles TabLabel3.Click
        Modeset(3)
    End Sub

    Sub SettingLoad()

        'Tab1
        Try
            dfchk_1.Checked = checkStartUp()
        Catch ex As Exception
            MsgBox("시작프로그램 설정 여부 확인 도중 오류가 발생했습니다.", vbCritical)
        End Try

        If My.Settings.AirStd = "AK" Then
            stdchk_airkorea.Checked = True
        Else '"WHO"일시
            stdchk_who.Checked = True
        End If

        dfchk_3.Checked = My.Settings.ChkEnabled
        dfchk_4.Checked = My.Settings.TrayEnabled

        alchk.Enabled = dfchk_3.Checked

        'Tab2
        alchk.Checked = My.Settings.PushEnabled
        alchk_Panel.Enabled = alchk.Checked

        Dim pushlist As String = My.Settings.PushList

        If pushlist = Nothing Then GoTo pass1

        If pushlist.Contains("1") Then alchk_1.Checked = True
        If pushlist.Contains("2") Then alchk_2.Checked = True
        If pushlist.Contains("3") Then alchk_3.Checked = True
        If pushlist.Contains("4") Then alchk_4.Checked = True
        If pushlist.Contains("5") Then alchk_5.Checked = True
        If pushlist.Contains("6") Then alchk_6.Checked = True
        If pushlist.Contains("7") Then alchk_7.Checked = True
        If pushlist.Contains("8") Then alchk_8.Checked = True
        If pushlist.Contains("e") Then alchk_2_4.Checked = True

pass1:

        alchk_2_1.Checked = My.Settings.PushWithsound
        alchk_2_2.Checked = My.Settings.PushIgnore
        alchk_2_3.Checked = My.Settings.PushTopmost


        'Tab3
        etchk_1.Checked = My.Settings.AeroEnabled
        etchk_2.Checked = My.Settings.FadeEnabled
        etchk_3.Checked = My.Settings.AniEnabled
        etchk_4.Checked = My.Settings.UseNativeFont
        etchk_debug.Checked = My.Settings.APIFORM
        etchk_useakapi.Checked = My.Settings.UseAKAPI


        Dim posSet As String = My.Settings.FormPos
        ComboBox1.SelectedIndex = Convert.ToInt32(Mid(posSet, 1, 1))
        ComboBox2.SelectedIndex = Convert.ToInt32(Mid(posSet, 2, 1))

    End Sub

    Sub ApplySet()

        'Tab1

        Try
            If dfchk_1.Checked Then
                SetStartup()
            Else
                If checkStartUp() Then
                    RemoveStartup()
                End If
            End If
        Catch ex As Exception
            MsgBox("시작프로그램 설정 중 오류가 발생했습니다." + vbCr + "해당 설정을 제외한 설정은 저장됩니다.", vbCritical)
        End Try

        My.Settings.ChkEnabled = dfchk_3.Checked
        My.Settings.TrayEnabled = dfchk_4.Checked

        If stdchk_who.Checked Then
            My.Settings.AirStd = "WHO"
        ElseIf stdchk_airkorea.Checked Then
            My.Settings.AirStd = "AK"
        End If


        'Tab2
        Dim pushlist As String = Nothing

        My.Settings.PushEnabled = alchk.Checked

        If alchk_1.Checked Then pushlist += "1"
        If alchk_2.Checked Then pushlist += "2"
        If alchk_3.Checked Then pushlist += "3"
        If alchk_4.Checked Then pushlist += "4"
        If alchk_5.Checked Then pushlist += "5"
        If alchk_6.Checked Then pushlist += "6"
        If alchk_7.Checked Then pushlist += "7"
        If alchk_8.Checked Then pushlist += "8"
        If alchk_2_4.Checked Then pushlist += "e"

        My.Settings.PushList = pushlist

        My.Settings.PushWithsound = alchk_2_1.Checked
        My.Settings.PushIgnore = alchk_2_2.Checked
        My.Settings.PushTopmost = alchk_2_3.Checked


        'Tab3
        My.Settings.AeroEnabled = etchk_1.Checked
        My.Settings.FadeEnabled = etchk_2.Checked
        My.Settings.AniEnabled = etchk_3.Checked
        My.Settings.UseNativeFont = etchk_4.Checked
        My.Settings.APIFORM = etchk_debug.Checked
        My.Settings.UseAKAPI = etchk_useakapi.Checked
        My.Settings.FormPos = ComboBox1.SelectedIndex.ToString + ComboBox2.SelectedIndex.ToString

        My.Settings.Save()
        My.Settings.Reload()

    End Sub

    Private Sub alchk_CheckedChanged(sender As Object, e As EventArgs) Handles alchk.CheckedChanged
        alchk_Panel.Enabled = alchk.Checked
    End Sub

    Private Sub dfchk_3_CheckedChanged(sender As Object, e As EventArgs) Handles dfchk_3.CheckedChanged
        If dfchk_3.Checked = False And alchk.Checked Then
            If MsgBox("대기 상태 업데이트를 비활성화할시 푸시 알림 설정 기능도 비활성화됩니다. 계속하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
                alchk.Checked = False
            Else
                dfchk_3.Checked = True
            End If
        End If

        alchk.Enabled = dfchk_3.Checked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ApplyBT.Click
        ApplySet()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ResetBT.Click
        If MsgBox("정말로 초기화 하시겠습니까?" + vbCr + "(지역 설정, 알림 설정 등이 모두 초기화됩니다.)", vbQuestion + vbYesNo) = vbYes Then
            My.Settings.Reset()
            My.Settings.Save()
            My.Settings.Reload()

            MsgBox("프로그램이 종료됩니다. 다시 실행해 주세요.", vbInformation)
            Application.Exit()

        End If
    End Sub

    Private Sub etchk_1_CheckedChanged(sender As Object, e As EventArgs) Handles etchk_1.CheckedChanged
        If Not My.Settings.AeroEnabled = etchk_1.Checked Then
            MsgBox("Aero 활성화 변경은 다음 창 실행때부터 적용됩니다.", vbInformation)
        End If
    End Sub

    Private Sub etchk_4_CheckedChanged(sender As Object, e As EventArgs) Handles etchk_4.CheckedChanged
        If Not My.Settings.UseNativeFont = etchk_4.Checked Then
            MsgBox("해당 설정은 프로그램을 다시 시작하여야 완전히 적용됩니다.", vbInformation)
        End If
    End Sub

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        If optionchanged = True Then
            If MsgBox("변경 사항을 저장하지 않고 닫으시겠습니까?", vbQuestion + vbYesNo) = vbNo Then
                GoTo donothing
            End If
        End If

        Me.Close()
donothing:
    End Sub

    Private Sub OptionChangedEvent() Handles dfchk_1.CheckedChanged, dfchk_3.CheckedChanged,
        dfchk_4.CheckedChanged, alchk.CheckedChanged, alchk_1.CheckedChanged, alchk_2.CheckedChanged,
        alchk_3.CheckedChanged, alchk_4.CheckedChanged, alchk_5.CheckedChanged, alchk_6.CheckedChanged,
        alchk_7.CheckedChanged, alchk_8.CheckedChanged, alchk_2_1.CheckedChanged, alchk_2_2.CheckedChanged,
        alchk_2_3.CheckedChanged, etchk_1.CheckedChanged, etchk_2.CheckedChanged, etchk_3.CheckedChanged,
        etchk_debug.CheckedChanged, alchk_2_4.CheckedChanged, etchk_4.CheckedChanged, etchk_useakapi.CheckedChanged
        optionchanged = True
        ApplyBT.Text = "적용하기"
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        DEBUGCOUNT += 1

        If DEBUGCOUNT = 10 Then
            MsgBox("디버그모드 활성화", vbInformation)
            DEBUGMODE = True
            DEBUGPANEL.Visible = DEBUGMODE
        End If
    End Sub

    Private Sub OptionChangedEvent(sender As Object, e As EventArgs) Handles etchk_debug.CheckedChanged, etchk_3.CheckedChanged, etchk_2.CheckedChanged, dfchk_4.CheckedChanged, dfchk_1.CheckedChanged, alchk_8.CheckedChanged, alchk_7.CheckedChanged, alchk_6.CheckedChanged, alchk_5.CheckedChanged, alchk_4.CheckedChanged, alchk_3.CheckedChanged, alchk_2_4.CheckedChanged, alchk_2_3.CheckedChanged, alchk_2_2.CheckedChanged, alchk_2_1.CheckedChanged, alchk_2.CheckedChanged, alchk_1.CheckedChanged, etchk_useakapi.CheckedChanged

    End Sub

    Private Sub stdchk_who_CheckedChanged(sender As Object, e As EventArgs) Handles stdchk_who.CheckedChanged
        If (stdchk_airkorea.Checked And Not My.Settings.AirStd = "AK") Or
           (stdchk_who.Checked And Not My.Settings.AirStd = "WHO") Then
            MsgBox("해당 설정은 대기 상태 업데이트 후에 적용됩니다.", vbInformation)
        End If
    End Sub
End Class