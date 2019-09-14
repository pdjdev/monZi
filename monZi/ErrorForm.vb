Public Class ErrorForm
    Public errorname As String = Nothing
    Public errordetail As String = Nothing
    Public errortime As DateTime

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub ErrorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = errorname
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        InfoCopy()
    End Sub

    Sub InfoCopy()
        Dim cominfo As String = "[예외 발생 시각]" + vbCr + errortime.ToString + vbCr + vbCr


        If MsgBox("PC, 프로그램 정보도 함께 복사하시겠습니까?" + vbCr + vbCr _
                  + "더욱 정확한 조사를 위해 특별한 경우가 아닌 경우 '예'를 눌러 복사해 주시기 바랍니다. (측정 위치와 같은 민감한 개인 정보는 다음 대화 상자에서 포함 여부를 설정하실 수 있습니다.)", vbQuestion + vbYesNo) = vbYes Then
            Dim g As Graphics = Me.CreateGraphics
            Dim dpi = g.DpiX.ToString()

            cominfo += "[디바이스 정보]" _
                + vbCr + "AppName: " + My.Application.Info.ProductName _
                + vbCr + "AppVersion: " + My.Application.Info.Version.ToString _
                + vbCr + "OS fullname: " + My.Computer.Info.OSFullName.ToString _
                + vbCr + "OS version: " + My.Computer.Info.OSVersion.ToString _
                + vbCr + "OS Platform: " + My.Computer.Info.OSPlatform.ToString _
                + vbCr + "TotalPhysicalMemory: " + My.Computer.Info.TotalPhysicalMemory.ToString _
                + vbCr + "ScreenDPI: " + dpi _
                + vbCr + "OS type: "
            If My.Computer.FileSystem.DirectoryExists("C:\Program Files (x86)") Then
                cominfo = cominfo + "64Bit OS"
            Else
                cominfo = cominfo + "32Bit OS"
            End If

            cominfo += vbCr + vbCr + "[애플리케이션 설정 값]" + vbCr
            '설정값 나열
            cominfo += "RecentCheck: " + My.Settings.RecentCheck.ToString + vbCr
            cominfo += "RecentAirCheck: " + My.Settings.RecentAirCheck.ToString + vbCr
            'cominfo += "LocationPoint_X: " + My.Settings.LocationPoint_X.ToString + vbCr
            'cominfo += "LocationPoint_Y: " + My.Settings.LocationPoint_Y.ToString + vbCr
            'cominfo += "LocationName: " + My.Settings.LocationName.ToString + vbCr
            'cominfo += "StationName: " + My.Settings.StationName.ToString + vbCr
            cominfo += "ChkEnabled: " + My.Settings.ChkEnabled.ToString + vbCr
            cominfo += "PushEnabled: " + My.Settings.PushEnabled.ToString + vbCr
            cominfo += "TrayEnabled: " + My.Settings.TrayEnabled.ToString + vbCr
            cominfo += "PushList: " + My.Settings.PushList.ToString + vbCr
            cominfo += "PushWithsound: " + My.Settings.PushWithsound.ToString + vbCr
            cominfo += "PushIgnore: " + My.Settings.PushIgnore.ToString + vbCr
            cominfo += "PushTopmost: " + My.Settings.PushTopmost.ToString + vbCr
            cominfo += "AeroEnabled: " + My.Settings.AeroEnabled.ToString + vbCr
            cominfo += "FadeEnabled: " + My.Settings.FadeEnabled.ToString + vbCr
            cominfo += "AniEnabled: " + My.Settings.AniEnabled.ToString + vbCr
            cominfo += "APIFORM: " + My.Settings.APIFORM.ToString + vbCr
            cominfo += "StartupPopIgnore: " + My.Settings.StartupPopIgnore.ToString + vbCr
            cominfo += "upgradeRequired: " + My.Settings.upgradeRequired.ToString + vbCr
            'cominfo += "LocHistory: " + My.Settings.LocHistory.ToString + vbCr
            cominfo += "UseNativeFont: " + My.Settings.UseNativeFont.ToString + vbCr
            cominfo += "widget_enabled: " + My.Settings.widget_enabled.ToString + vbCr
            cominfo += "widget_position: " + My.Settings.widget_position.ToString + vbCr
            cominfo += "widget_locked: " + My.Settings.widget_locked.ToString + vbCr
            cominfo += "widget_display: " + My.Settings.widget_display.ToString + vbCr
            cominfo += "widget_opacity: " + My.Settings.widget_opacity.ToString + vbCr

            If MsgBox("측정소, 위치 설정 정보도 포함하시겠습니까?" + vbCr _
                      + vbCr + "(해당 설정은 프로그램 오류 조사시에만 사용됩니다. 하지만 해당 정보는 민감한 개인 정보이기 때문에 설정 위치를 제공하기를 원치 않으신 경우 '아니오'를 누르시면 해당 정보는 제외된 채 정보가 복사됩니다)",
                      vbQuestion + vbYesNo) = vbYes Then
                cominfo += "LocationPoint_X: " + My.Settings.LocationPoint_X.ToString + vbCr
                cominfo += "LocationPoint_Y: " + My.Settings.LocationPoint_Y.ToString + vbCr
                cominfo += "LocationName: " + My.Settings.LocationName.ToString + vbCr
                cominfo += "StationName: " + My.Settings.StationName.ToString + vbCr
                cominfo += "LocHistory: " + My.Settings.LocHistory.ToString + vbCr
            End If

            cominfo += "AirStd: " + My.Settings.AirStd.ToString + vbCr
            cominfo += "FormPos: " + My.Settings.FormPos.ToString + vbCr
            cominfo += "UseAKAPI: " + My.Settings.UseAKAPI.ToString + vbCr

            If Not My.Settings.USERAPIKEY = Nothing Then
                If MsgBox("USER API Key가 설정되어 있습니다. 이도 로그에 포함시키겠습니까?", vbQuestion + vbYesNo) = vbYes Then
                    cominfo += "USERAPIKey: " + My.Settings.USERAPIKEY.ToString + vbCr
                End If
            End If
            cominfo += vbCr + vbCr

        End If

        cominfo += "[예외 오류 정보]" + vbCr + errordetail + vbCr + vbCr
        cominfo += "[로그 기록 시각]" + vbCr + DateTime.Now.ToString


        Clipboard.SetText(cominfo)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        InfoCopy()
        MsgBox("복사가 완료되었습니다. 곧 뜨는 양식 페이지 맨 처음 칸에 붙여넣기(Ctrl + V) 한 뒤 나머지 항목을 채워주시기 바랍니다." + vbCr + vbCr + "감사합니다.", vbInformation)
        TopMost = False
        Process.Start("http://monzierror.ze.am")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If MsgBox("애플리케이션 설정 제거시 모든 설정값이 초기화되며 이후 프로그램이 종료됩니다." + vbCr + "계속하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then

            Dim delok As Boolean = True

            'MsgBox(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\PBJSoftware")


            Try
                DeleteAppSettings()
            Catch ex As Exception
                MsgBox(ex.Message)
                delok = False
            End Try

            If Not delok Then
                If MsgBox("삭제 도중 문제가 발생했습니다." + vbCr + "직접 제거하시겠습니까?", vbYesNo + vbQuestion) = vbYes Then
                    MsgBox("이 메시지를 닫고 나서 열리는 창(%LocalAppdata&\PBJSoftware)에서 현재 프로그램의 프로세스명이 포함되어 있는 디렉토리를 모두 삭제한 뒤 프로그램을 다시 실행해주시기 바랍니다.", vbInformation)
                    Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\PBJSoftware")
                End If
            Else
                MsgBox("제거가 완료되었습니다. 프로그램이 종료됩니다.", vbInformation)
                Application.Exit()
            End If

        End If
    End Sub

    Sub DeleteAppSettings()

        Dim currentExeName As String = IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath)

        For Each foundDirectory As String In My.Computer.FileSystem.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\PBJSoftware",
                                                                                   FileIO.SearchOption.SearchTopLevelOnly, "*" + currentExeName + "*")
            System.IO.Directory.Delete(foundDirectory, True)
        Next

    End Sub
End Class