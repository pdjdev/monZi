Public Class LocationSet
    Dim loc As Point

    Dim locdata As String
    Dim bdname As String
    Dim locstr As String
    Public x_num As String
    Public y_num As String
    Dim tm_co() = Nothing

    Public StationName As String = Nothing
    Dim loctext As String = Nothing '이거는 최종적으로 셋팅에 저장할 위치 텍스트 (locstr와는 다름)

    Public complete As Boolean = False


#Region "Aero 그림자 효과 (Vista이상)"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

#Region "페이드 효과" 'Load시 Opacity=0 꼭하기

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        FadeOut(Me)
    End Sub
#End Region

    Private Sub FormDrag_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown, TitleLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub FormDrag_MouseMove(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseMove, TitleLabel.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    Private Sub LocationSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0
        If My.Settings.UseNativeFont Then ChangeToNativeFont(Me)
        HelpText.Location = New Point(TextBox1.Location.X + dpicalc(Me, 2), TextBox1.Location.Y)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Not complete Then '조회가 완료되었을시

            If TextBox1.Text = Nothing Then
                MsgBox("주소를 입력해 주세요", vbExclamation)
                GoTo endtask
            End If


            Button2.Enabled = False

            If CheckBox1.Checked = False Then '카카오API를 통한 탐색

                Try
                    locdata = getLocationKakao(TextBox1.Text)
                Catch ex As Exception
                    MsgBox("위치 탐색 도중 오류가 발생했습니다." + vbCr + "값이 유효한지, 인터넷 연결이 되어 있는지 확인해 주세요.", vbCritical)
                    GoTo endtask
                End Try

                Try
                    locstr = getData(locdata, "address_name")
                    x_num = getData(locdata, "x")
                    y_num = getData(locdata, "y")
                Catch ex As Exception
                    MsgBox("유효한 주소가 아닌 것 같습니다. 주소를 확인해 주십시오.", vbExclamation)
                    GoTo endtask
                End Try

                If locdata.Contains("<building_name>") Then
                    bdname = getData(locdata, "building_name")
                Else
                    bdname = Nothing
                End If

                If bdname = Nothing Then
                    loctext = locstr
                Else
                    loctext = bdname
                End If

                If MsgBox("입력한 주소가 " + locstr + " " + bdname + "이(가) 맞습니까?", vbQuestion + vbYesNo) = vbNo Then
                    MsgBox("주소가 유효한지 확인해 주시고 더 자세한 주소로 입력해 보시기 바랍니다.", vbInformation)
                    GoTo endtask
                End If


                'TM좌표로 변환
                Try
                    tm_co = convertToTMKakao(x_num, y_num).Split("/")
                Catch ex As Exception
                    MsgBox("위치 변환 도중 오류가 발생했습니다." + vbCr + "값이 유효한지, 인터넷 연결이 되어 있는지 확인해 주세요.", vbCritical)
                    GoTo endtask
                End Try

                StationName = Nothing

            Else '직접 측정소 입력

                Dim stationstr As String = Nothing

                Try
                    stationstr = findStationByName(TextBox1.Text)
                Catch ex As Exception
                    MsgBox("측정소 탐색 도중 오류가 발생했습니다." + vbCr + "값이 유효한지, 인터넷 연결이 되어 있는지 확인해 주세요.", vbCritical)
                    GoTo endtask
                End Try

                If stationstr = "{ERROR}" Then
                    MsgBox("측정소를 찾을 수 없습니다. 측정소명을 정확히 입력하였는지 확인해 주세요.", vbCritical)
                    GoTo endtask
                End If

                If MsgBox("입력하신 측정소가 " + stationstr + "이(가) 맞습니까?", vbQuestion + vbYesNo) = vbNo Then
                    MsgBox("명칭이 유효한지 확인해 주시고 더 자세하게 입력해 보시기 바랍니다.", vbInformation)
                    GoTo endtask
                End If

                StationName = stationstr


            End If

            MsgBox("성공적으로 확인되었습니다. '적용'을 눌러 설정을 저장합니다." + vbCr + vbCr + "'입력한 위치의 주변 측정소 조회...'를 눌러 주변 측정소를 선택하실 수도 있습니다.", vbInformation)

            CheckBox1.Enabled = False
            complete = True
            TextBox1.ReadOnly = True
            Button1.Text = "변경하기"
            Button2.Enabled = True

            'MsgBox("클립보드 복사 완료", vbInformation)
            'Clipboard.SetText(locdata)

        Else

            CheckBox1.Enabled = True
            complete = False
            TextBox1.ReadOnly = False
            Button1.Text = "조회"
            Button2.Enabled = False
        End If



endtask:
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If complete Then

            '처음판별
            Dim wasitfirst As Boolean = False
            If My.Settings.LocationName = Nothing Then wasitfirst = True

            If StationName = Nothing Then
                My.Settings.StationName = Nothing
                My.Settings.LocationName = loctext
                My.Settings.LocationPoint_X = tm_co(0)
                My.Settings.LocationPoint_Y = tm_co(1)
            Else
                My.Settings.LocationName = StationName & " (측정소)"
                My.Settings.StationName = StationName
            End If

            If wasitfirst Then
                If MsgBox("처음 설정하시는 것 같네요. 실시간으로 대기 정보를 받아볼 수 있도록 다음 설정을 활성화 하시겠습니까?" _
                   + vbCr + vbCr + "- 자동으로 대기 상태 업데이트 (권장)" + vbCr _
                   + "- 대기 상태 푸시 알림 (권장)" + vbCr + vbCr _
                   + "'예'를 누를시 자동으로 적용되며, 이 설정은 나중에 '프로그램 설정'에서 변경하실 수 있습니다.", vbQuestion + vbYesNo) = vbYes Then
                    My.Settings.ChkEnabled = True
                    My.Settings.PushEnabled = True
                End If
            End If


            APIForm.AirAPICheck.CancelAsync()
            APIForm.Close()
            APIForm.combnum = 0
            APIForm.PrevChk = "-1" '무조건 업데이트하도록
            APIForm.prevCombnum = -1
            MainGUI.DrawState()
            APIForm.Activate()
            TrayForm.MainGUI_Open()


            If StationName = Nothing Then
                If Not CheckHisExist(False, loctext) Then
                    AddLocHistory_Axis(loctext, tm_co(0), tm_co(1))
                End If
            Else
                If Not CheckHisExist(True, StationName) Then
                    AddLocHistory_station(StationName)
                End If
            End If

            My.Settings.Save()
            My.Settings.Reload()


            Me.Close()
            End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles CloseBT.Click
        If complete Then
            If MsgBox("지정한 위치가 적용되지 않았습니다. 그래도 닫으시겠습니까?", vbQuestion + vbYesNo) = vbNo Then
                GoTo endtask
            End If
        End If

        TrayForm.MainGUI_Open()
        Me.Close()
endtask:
    End Sub

    Private Sub CloseBT_MouseEnter(sender As Object, e As EventArgs) Handles CloseBT.MouseEnter
        CloseBT.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.2)
    End Sub

    Private Sub CloseBT_MouseLeave(sender As Object, e As EventArgs) Handles CloseBT.MouseLeave
        CloseBT.BackColor = Color.Transparent
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If x_num = Nothing Or y_num = Nothing Or Not complete Then
            MsgBox("우선 위치를 지정해 주세요.", vbInformation)

        Else
            Try
                StationList.AirStationData = getNearStation(tm_co(0), tm_co(1))
            Catch ex As Exception
                MsgBox("측정소를 검색하던 도중 오류가 발생했습니다." + vbCr + "주소가 유효한지 확인해 주세요.", vbExclamation)
                StationList.ShowDialog(Me)
                GoTo donothing
            End Try

            StationList.ShowDialog(Me)

        End If



donothing:
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        HelpText.Hide()
    End Sub
End Class