Option Explicit On
Option Infer Off

Public Class TrayForm
    Dim p As New Point
    Public PopShown = False

    Private TrayIconPoints As New List(Of Point)
    Private OverTrayTimer As New Windows.Forms.Timer

    Private Sub TrayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InstallCompleteEventSub()

        '버전 업데이트시 이전의 Settings를 업데이트하기위해
        If My.Settings.upgradeRequired Then

            Try
                My.Settings.Upgrade()
                My.Settings.upgradeRequired = False
                My.Settings.Save()
                My.Settings.Reload()
            Catch ex As Exception

            End Try

        End If

        AddHandler OverTrayTimer.Tick, AddressOf OverTrayTimer_Tick

        With OverTrayTimer
            .Interval = 1000
            .Enabled = True
        End With

        FormBorderStyle = FormBorderStyle.None
        Me.Opacity = 0
        Me.Hide()
        APIForm.Activate()

        If Not isSettingAvailable() Then '셋팅값이 엉터리(암것도없을)일시 (최초실행시)
            '최초실행 대화상자 실행

            APIForm.PCTimeCheck.Stop() '일단 PC체크 타이머를 멈춤
            APIForm.combnum = -3 '-3으로 표시모드를 돌리고
            MainGUI.DrawState() '값 지정하라 보여주고
            MainGUI_Open() '폼을 보여줘서 유도
        End If

        If My.Settings.widget_enabled Then WidgetGUI.Show()
    End Sub

    Function isSettingAvailable() As Boolean
        Dim routeok As Boolean = False

        If Not (My.Settings.StationName = Nothing) Then '측정소명이 지정되어 있을시
            routeok = True
        ElseIf Not (My.Settings.LocationPoint_X = Nothing Or My.Settings.LocationPoint_Y = Nothing) Then '좌표가 있을시
            routeok = True
        End If

        Return routeok
    End Function

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        If Not Application.OpenForms().OfType(Of MainGUI).Any Then
            WindowState = FormWindowState.Normal

            MainGUI_Open()

            WindowState = FormWindowState.Minimized
        Else
            MainGUI.Close()
        End If

        Me.Hide()
    End Sub

    Public Sub MainGUI_Open()
        Dim marign As Integer = dpicalc(Me, 10)
        Dim showx = 0
        Dim showy = 0

        Select Case Convert.ToInt32(Mid(My.Settings.FormPos, 1, 1))
            Case 0 '우하단
                showx = Screen.PrimaryScreen.WorkingArea.Width - MainGUI.Width - marign
                showy = Screen.PrimaryScreen.WorkingArea.Height - MainGUI.Height - marign

            Case 1 '우상단
                showx = Screen.PrimaryScreen.WorkingArea.Width - MainGUI.Width - marign
                showy = marign

            Case 2 '좌하단
                showx = marign
                showy = Screen.PrimaryScreen.WorkingArea.Height - MainGUI.Height - marign

            Case 3 '좌상단
                showx = marign
                showy = marign

        End Select

        MainGUI.SetDesktopLocation(showx, showy)

        MainGUI.Show()
    End Sub

    Private Sub M1closeappToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles M1closeappToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub M2updateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles M2updateToolStripMenuItem.Click
        'APIForm.Show()
        If My.Settings.ChkEnabled Then
            My.Settings.ChkEnabled = False
        Else
            My.Settings.ChkEnabled = True
        End If
    End Sub

    Private Sub M3pushToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles M3pushToolStripMenuItem.Click
        If My.Settings.PushEnabled Then
            My.Settings.PushEnabled = False
        Else
            My.Settings.PushEnabled = True
        End If
    End Sub

    Public Sub trayico_selector()

        If My.Settings.TrayEnabled = False Then GoTo ignoretask

        Dim traystr As String = My.Settings.LocationName + " - "

        If APIForm.combnum = -3 Then
            traystr = "아이콘을 눌러 위치를 설정해 주세요"
            GoTo ignoretask
        End If

        Select Case APIForm.combnum
            Case 0
                NotifyIcon1.Icon = My.Resources.ico_load
                traystr += "로드 중"
            Case 1
                NotifyIcon1.Icon = My.Resources.ico_gr1
                traystr += "최고"
            Case 2
                NotifyIcon1.Icon = My.Resources.ico_gr2
                traystr += "좋음"
            Case 3
                NotifyIcon1.Icon = My.Resources.ico_gr3
                traystr += "양호"
            Case 4
                NotifyIcon1.Icon = My.Resources.ico_gr4
                traystr += "보통"
            Case 5
                NotifyIcon1.Icon = My.Resources.ico_gr5
                traystr += "나쁨"
            Case 6
                NotifyIcon1.Icon = My.Resources.ico_gr6
                traystr += "매우 나쁨"
            Case 7
                NotifyIcon1.Icon = My.Resources.ico_gr7
                traystr += "극도로 나쁨"
            Case 8
                NotifyIcon1.Icon = My.Resources.ico_gr8
                traystr += "최악"
            Case Else
                NotifyIcon1.Icon = My.Resources.ico_er
                traystr += "알 수 없음"
        End Select

        'traystr += vbCr + "마지막 업데이트: " + APIForm.APIupdTime
        'NotifyIcon1.Text = traystr

ignoretask:

        NotifyIcon1.Visible = True

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

        APIFormShowToolStripMenuItem.Visible = My.Settings.APIFORM



        If My.Settings.PushEnabled Then
            M3pushToolStripMenuItem.Text = "푸시 알림 끄기"
        Else
            M3pushToolStripMenuItem.Text = "푸시 알림 켜기"
        End If

        If My.Settings.ChkEnabled Then
            M2updateToolStripMenuItem.Text = "업데이트 끄기"
            M3pushToolStripMenuItem.Enabled = True

        Else
            '비활성화시 Push도 비활성화
            M2updateToolStripMenuItem.Text = "업데이트 켜기"

            M3pushToolStripMenuItem.Enabled = False
            M3pushToolStripMenuItem.Text = "푸시 알림 켜기"
        End If

    End Sub

    Private Sub M0openGUIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles M0openGUIToolStripMenuItem.Click
        WindowState = FormWindowState.Normal

        MainGUI_Open()

        WindowState = FormWindowState.Minimized
        Me.Hide()

    End Sub

    Private Sub APIFormShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles APIFormShowToolStripMenuItem.Click
        APIForm.Show()
    End Sub

    Private Sub InstallCompleteEventSub()
        Dim savepath As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\_monzi\finevent.tmp"

        If My.Computer.FileSystem.FileExists(savepath) Then

            Dim fileReader As String
            Try
                fileReader = My.Computer.FileSystem.ReadAllText(savepath, System.Text.Encoding.GetEncoding(949))
                If getData(fileReader, "showPage") = "1" Then

                    Process.Start("https://monzi.ze.am/install_done")
                End If
            Catch ex As Exception

                '로그 오류 발생 (아무 것도 안함)
            End Try

            My.Computer.FileSystem.DeleteFile(savepath)

        Else

        End If
    End Sub

    'Private Sub NotifyIcon1_MouseDown(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDown
    '    If Not PopShown Then
    '        PopShown = True
    '        Try
    '            p.X = Cursor.Position.X - (TrayHover.Width / 2)
    '            p.Y = Screen.GetWorkingArea(Cursor.Position).Height - TrayHover.Height - dpicalc(Me, 10)
    '            TrayHover.SetDesktopLocation(p.X, p.Y)
    '            TrayHover.Show()
    '        Catch ex As Exception

    '        End Try

    '    End If
    'End Sub

    Private Sub NotifyIcon1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseMove
        Dim MouseAt As New Point(MousePosition.X, MousePosition.Y)

        'Save point if it hasn't already been saved  
        If Not TrayIconPoints.Contains(MouseAt) Then
            TrayIconPoints.Add(MouseAt)
        End If
    End Sub

    Private Function GetTrayIconRectangle() As Rectangle
        Dim curPoint As Point
        Dim TopLeft As New Point(10000, 10000)
        Dim BottomRight As New Point(-10000, -10000)

        For Each curPoint In TrayIconPoints
            If curPoint.X < TopLeft.X Then
                TopLeft.X = curPoint.X
            End If

            If curPoint.Y < TopLeft.Y Then
                TopLeft.Y = curPoint.Y
            End If

            If curPoint.X > BottomRight.X Then
                BottomRight.X = curPoint.X
            End If

            If curPoint.Y > BottomRight.Y Then
                BottomRight.Y = curPoint.Y
            End If
        Next

        Return New Rectangle(TopLeft, New Size(BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y))
    End Function

    Private Sub OverTrayTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If GetTrayIconRectangle.Contains(MousePosition) Then
            If Not PopShown And Not Application.OpenForms().OfType(Of MainGUI).Any Then
                Try
                    PopShown = True
                    p.X = Cursor.Position.X - (TrayHover.Width / 2)
                    p.Y = Screen.GetWorkingArea(Cursor.Position).Height - TrayHover.Height - dpicalc(Me, 10)
                    TrayHover.SetDesktopLocation(p.X, p.Y)
                    TrayHover.Show()
                Catch ex As Exception

                End Try
            End If
        Else
            If PopShown Then
                PopShown = False
                TrayHover.Close()
            End If
        End If
    End Sub
End Class