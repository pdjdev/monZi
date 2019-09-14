Public Class APIForm
    Dim PrevHour As Integer = -1 '0으로 해버리면 12시(00시)때 아예 되질 않으니 주의!!!
    Public PrevChk As String = "-1"
    Public NowChk As String = Nothing
    Dim PrevGrade As Integer = 0

    Public APIupdTime As String = Nothing

    Dim Checking As Boolean = False '체킹 여부
    Dim APIOK As Boolean = False '성공적 수집 여부
    Dim station As String = Nothing '측정소의 이름

    Public airData As String = Nothing

    Public pm10num As String = "-"
    Public pm25num As String = "-"

    Public pm10gnum As Integer = 0
    Public pm25gnum As Integer = 0

    Public combnum As Integer = 0 '대기 등급을 비교하여 산출하는 최종값 (ErrorLevel로도 쓰임!!)
    Public prevCombnum As Integer = 0 '업데이트 직전의 산출값 (값이 다를시 푸시알림 뜨도록 하기)
    Public combgrade As String = "오류"
    Public combcomment As String = "값을 불러오지 못했습니다"
    Public themecol As Color = Nothing
    Public guititle As String = "현재 대기"



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TrayForm.MainGUI_Open()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LocationSet.Show()
    End Sub

    Private Sub PCTimeCheck_Tick(sender As Object, e As EventArgs) Handles PCTimeCheck.Tick
        'If customapilink.Checked Then '커스텀API여부
        ' Label1.Text = "ok"
        ' PCTimeCheck.Interval = 5000
        '
        '
        '        '여기는 디버깅 항목!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        '
        '
        '
        '        Checking = True
        '        CombinedAPICheck()
        '
        '
        '
        '        '여기는 디버깅 항목!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        '
        '        Else

        PCTimeCheck.Interval = 5000
            '체크여부를 확인 (5초 간격)
            If My.Settings.ChkEnabled Then

                If Not (Now.Hour = PrevHour) Then '시간의 시가 바뀌었다면

                    If Not Checking Then
                        Checking = True
                        CombinedAPICheck()
                    End If

                End If
                PrevHour = Now.Hour

            Else
                '실시간 체킹을 안할 때

                If airData = Nothing Then '아무 수집 데이터가 없을때

                    If Not Checking Then '수집 데이터도 없고 체킹작업도 안하고있을때
                        Checking = True
                        CombinedAPICheck()
                    End If

                End If

            End If

        ' End If
    End Sub

    Public Sub CombinedAPICheck()
        AirAPICheck.CancelAsync()

        TrayForm.trayico_selector()
        'PrevChk = -1일 경우: 수동으로 리프레시 버튼 누름, 수동으로 재탐색
        If PrevChk = "-1" Then AirAPICheck.RunWorkerAsync()

        '정시에 과다하게 몰리지 않게 3분 - 4분으로 랜덤 간격 잡기
        Dim r As New Random
        APICheck.Interval() = r.Next(180000, 240000)
        APICheck.Start()
    End Sub

    Private Sub APICheck_Tick(sender As Object, e As EventArgs) Handles APICheck.Tick
        AirAPICheck.RunWorkerAsync()
    End Sub

    Sub AirCheck()

        Try
            pm10num = Convert.ToInt32(getData(airData, "pm10Value"))
        Catch
        End Try

        Try
            pm25num = Convert.ToInt32(getData(airData, "pm25Value"))
        Catch
        End Try

        Try
            guititle = getData(airData, "mangName") + " - " + station
        Catch ex As Exception

        End Try

        If IsNumeric(pm10num) Then

            If My.Settings.AirStd = "AK" Then '한국환경공단 기준시
                Select Case Convert.ToInt32(pm10num)
                    Case <= 30
                        pm10gnum = 2
                    Case <= 80
                        pm10gnum = 4
                    Case <= 150
                        pm10gnum = 5
                    Case >= 151
                        pm10gnum = 6
                End Select

            Else '나머지 (WHO)
                Select Case Convert.ToInt32(pm10num)
                    Case <= 15
                        pm10gnum = 1
                    Case <= 30
                        pm10gnum = 2
                    Case <= 40
                        pm10gnum = 3
                    Case <= 50
                        pm10gnum = 4
                    Case <= 75
                        pm10gnum = 5
                    Case <= 100
                        pm10gnum = 6
                    Case <= 150
                        pm10gnum = 7
                    Case >= 151
                        pm10gnum = 8
                End Select
            End If

        End If

        If IsNumeric(pm25num) Then

            If My.Settings.AirStd = "AK" Then '한국환경공단 기준시
                Select Case Convert.ToInt32(pm25num)
                    Case <= 15
                        pm25gnum = 2
                    Case <= 35
                        pm25gnum = 4
                    Case <= 75
                        pm25gnum = 5
                    Case >= 76
                        pm25gnum = 6
                End Select

            Else
                Select Case Convert.ToInt32(pm25num)
                    Case <= 8
                        pm25gnum = 1
                    Case <= 15
                        pm25gnum = 2
                    Case <= 20
                        pm25gnum = 3
                    Case <= 25
                        pm25gnum = 4
                    Case <= 37
                        pm25gnum = 5
                    Case <= 50
                        pm25gnum = 6
                    Case <= 75
                        pm25gnum = 7
                    Case >= 76
                        pm25gnum = 8
                End Select
            End If

        End If

        If pm10num = "-" And pm25num = "-" Then '미세, 초미세 모두 불러오지 못했을시
            combnum = -4
        Else
            If pm10gnum >= pm25gnum Then
                combnum = pm10gnum
            Else
                combnum = pm25gnum
            End If
        End If

        If airData.Contains("#CUSTOMAPI#") Then
            If airData.Contains("<stationName>") Then guititle += getData(airData, "stationName") + " "
            guititle += "(사용자 지정)"
        End If

    End Sub

    Sub PushCheck()

        '설정 비활성화시 취소
        If My.Settings.PushEnabled = False Or My.Settings.ChkEnabled = False Then GoTo endtask

        '메인GUI가 열려 있지 않을시에만 푸시 알림이 보여지도록 함
        If Application.OpenForms().OfType(Of MainGUI).Any Then GoTo endtask

        '======여기서부터 푸시 코드 시작======
        If prevCombnum = combnum And My.Settings.PushIgnore = True Then '무시옵션이켜졌고 이전의 상태값과 같을시
            GoTo endtask
        End If

        '여기로까지 내려오는 CASE:
        '무시옵션이 비활성화 or 무시옵션 있는데 이전State와 다름

        Dim pushlist As String = My.Settings.PushList
        If pushlist = Nothing Then GoTo endtask

        Select Case combnum
            Case -2 Or -1 '오류시
                If Not pushlist.Contains("e") Then GoTo endtask

            Case -4 '오류 아닌 점검
                If Not pushlist.Contains("e") Then GoTo endtask

            Case 1 '최고
                If Not pushlist.Contains("1") Then GoTo endtask

            Case 2 '좋음
                If Not pushlist.Contains("2") Then GoTo endtask

            Case 3 '양호
                If Not pushlist.Contains("3") Then GoTo endtask

            Case 4 '보통
                If Not pushlist.Contains("4") Then GoTo endtask

            Case 5 '나쁨
                If Not pushlist.Contains("5") Then GoTo endtask

            Case 6 '매우 나쁨
                If Not pushlist.Contains("6") Then GoTo endtask

            Case 7 '극도로 나쁨
                If Not pushlist.Contains("7") Then GoTo endtask

            Case 8 '최악
                If Not pushlist.Contains("8") Then GoTo endtask

            Case Else
                GoTo endtask
        End Select

        Show_Popup()

endtask:
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AirAPICheck.RunWorkerAsync()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        combnum = NumericUpDown1.Value
        MainGUI.DrawState()
        WidgetGUI.DrawState()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        My.Settings.ChkEnabled = CheckBox1.Checked
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Settings.Reset()
        My.Settings.Save()
        TrayForm.Close()
    End Sub

    Public Sub Show_Popup()
        PopUpForm.Close()
        Dim marign As Integer = dpicalc(Me, 10)
        Dim showx = 0
        Dim showy = 0

        Select Case Convert.ToInt32(Mid(My.Settings.FormPos, 2, 1))
            Case 0 '우하단
                showx = Screen.PrimaryScreen.WorkingArea.Width - PopUpForm.Width - marign
                showy = Screen.PrimaryScreen.WorkingArea.Height - PopUpForm.Height - marign

            Case 1 '우상단
                showx = Screen.PrimaryScreen.WorkingArea.Width - PopUpForm.Width - marign
                showy = marign

            Case 2 '좌하단
                showx = marign
                showy = Screen.PrimaryScreen.WorkingArea.Height - PopUpForm.Height - marign

            Case 3 '좌상단
                showx = marign
                showy = marign

        End Select


        PopUpForm.SetDesktopLocation(showx, showy)
        PopUpForm.Show()
    End Sub

    Private Sub AirAPICheck_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles AirAPICheck.DoWork
        APIOK = True


        If Not My.Computer.Network.IsAvailable Then

            combnum = -2
            APIOK = False
            GoTo endtask

        End If

        Try

            '디버깅 항목!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            If Not My.Settings.CustomAPI = Nothing Then

                airData = webget(My.Settings.CustomAPI) + "#CUSTOMAPI#"
                GoTo passforDEBUGING

            End If
            '디버깅 항목!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


            '실질적 에어데이터는 여기서 수집함!!! (변화여부를 파악해야 하므로)
            If Not (My.Settings.StationName = Nothing) Then '측정소명이 지정되어 있을시

                station = My.Settings.StationName

            ElseIf Not (My.Settings.LocationPoint_X = Nothing Or My.Settings.LocationPoint_Y = Nothing) Then '좌표가 있을시

                If station = Nothing Then '좌표 존재하는데 측정소명이 없을시
                    station = getData(getNearStation(My.Settings.LocationPoint_X, My.Settings.LocationPoint_Y), "stationName")
                    My.Settings.StationName = station
                    My.Settings.Save()
                    My.Settings.Reload()
                End If

            End If


            airData = getairinfo(station)

            'MsgBox(airData)

passforDEBUGING:

            APIupdTime = DateTime.Now.Day.ToString + "일 " + DateTime.Now.ToString("HH:mm:ss")
            NowChk = getData(airData, "dataTime")

        Catch ex As Exception
            APIOK = False
            combnum = -1
        End Try
endtask:
    End Sub

    Private Sub AirAPICheck_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles AirAPICheck.RunWorkerCompleted

        '여기는 결과값 판별 영역
        If APIOK Then '오류 없을시

            Dim AirChkHour() As String = NowChk.Split(" ")
            AirChkHour = AirChkHour(1).Split(":")
            'MsgBox(AirChkHour(0)) '업데이트의 시간대를 가져옴

            If AirChkHour(0) = "24" Then AirChkHour(0) = "00"
            '에어체크의 API가 00(오전12)시를 24시로 표시해서 이렇게 바꿔주어야함

            '값이 바뀌든 말든 일단 API 불러온겸 그리도록 하기
            AirCheck()

            '현재 공기를 체크한 PC시간과(24시) 실제 측정소의 측정기준시간(24시)이 같을 경우
            If AirChkHour(0) = DateTime.Now.ToString("HH") Then

                PrevChk = NowChk
                '체크 완료하였으므로 멈춤 ->다시 정각때까지 대기
                Checking = False
                APICheck.Stop()

            ElseIf My.Settings.ChkEnabled = False Then '혹은 실시간 체킹이 비활성화 되어있을때

                PrevChk = NowChk
                '체크 완료하였으므로 멈춤 ->새로고침 명령이 없다면 절대 업뎃 X
                Checking = False
                APICheck.Stop()

            ElseIf combnum = -4 Then '혹은 측정소가 점검중일시

                PrevChk = NowChk
                'API 호출 과부하를 막기 위해 업데이트 중지
                Checking = False
                APICheck.Stop()

            End If

        Else
            '오류발생 (그런데 erlevel을 앞서 다 combnum에 줘서 특별한 조치 필요없음)
            '타이머를 멈추지 않음으로써 오류가 일어나면 미리 설정된 인터벌마다 다시 시도하도록 하기

            'API서버 트래픽 초과
            If Not airData = Nothing Then
                If airData.Contains("resultCode") Then
                    If getData(airData, "resultCode") = "22" Then
                        combnum = -5
                        APICheck.Stop()
                    End If
                End If
            End If
        End If

        '메인GUI의 폼을 그리고 트레이도 새로고침
        MainGUI.DrawState()
        TrayForm.trayico_selector()
        If My.Settings.widget_enabled Then WidgetGUI.DrawState()

        '여기서부터는 푸시 알림 영역
        PushCheck()

        '이전의 상태 넘버를 저장해야함
        prevCombnum = combnum
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TrayForm.Close()
    End Sub

    Private Sub APIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = My.Settings.ChkEnabled
        CheckBox2.Checked = My.Settings.PushEnabled
        customapibox.Text = My.Settings.CustomAPI
        userapikeybox.Text = My.Settings.USERAPIKEY
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Show_Popup()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        My.Settings.PushEnabled = CheckBox2.Checked
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox(Checking)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Throw New System.Exception("APIForm 테스트 예외 발생")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        My.Settings.USERAPIKEY = userapikeybox.Text
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Not airData.Contains("<resultCode>") Then
            MsgBox("monZiAPI")
        Else
            MsgBox("AirKorea")
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Label1.Text = "changed"
        My.Settings.CustomAPI = customapibox.Text
        My.Settings.Save()
        My.Settings.Reload()
    End Sub
End Class
