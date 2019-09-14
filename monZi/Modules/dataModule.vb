Imports System.Security.Principal
Imports System.Text.RegularExpressions

Module dataModule

#Region "문자열 관련"
    'web에서 문자열 가져오는 함수
    Public Function webget(url As String)
        Dim source = New System.Net.WebClient()
        source.Encoding = System.Text.Encoding.UTF8
        'MsgBox(url)

        Dim sourcestr As String = Nothing

        sourcestr = source.DownloadString(url)


        Return sourcestr
    End Function

    'xml형식 파일을 전체값에서 따로 추출하는 함수
    Public Function getData(datastr As String, name As String)

        Return midReturn("<" + name + ">", "</" + name + ">", datastr)

    End Function

    '중간의 문자열을 리턴하는 함수
    Public Function midReturn(ByVal first As String, ByVal last As String, ByVal total As String) As String
        If last.Length < 1 Then
            midReturn = total.Substring(total.IndexOf(first))
        End If
        If first.Length < 1 Then
            midReturn = total.Substring(0, (total.IndexOf(last)))
        End If

        midReturn = ((total.Substring(total.IndexOf(first), (total.IndexOf(last) - total.IndexOf(first)))).Replace(first, "")).Replace(last, "")
    End Function
#End Region

#Region "시작프로그램설정"

    Public Function checkStartUp() As Boolean
        Dim destlnk As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\monzi.lnk"

        If IO.File.Exists(destlnk) Then
            If GetTargetPath(destlnk) = Application.ExecutablePath Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Sub SetStartup()
        Dim Path As String
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)

        Path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\monzi.lnk"

        Dim wsh As Object = CreateObject("WScript.Shell")

        Dim MyShortcut
        MyShortcut = wsh.CreateShortcut(Path)
        MyShortcut.TargetPath = wsh.ExpandEnvironmentStrings(Application.ExecutablePath)
        MyShortcut.WindowStyle = 4
        MyShortcut.Save()
    End Sub

    Sub RemoveStartup()
        My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\monzi.lnk")
    End Sub

    '바로가기 파일의 목적지경로를 리턴 -> Win7 포함한 일부 환경에 문제 있어 사용안함!!!
    Public Function GetLnkTarget(lnkPath As String) As String
        Dim shl = New Shell32.Shell()
        lnkPath = System.IO.Path.GetFullPath(lnkPath)
        Dim dir = shl.[NameSpace](System.IO.Path.GetDirectoryName(lnkPath))
        Dim itm = dir.Items().Item(System.IO.Path.GetFileName(lnkPath))
        Dim lnk = DirectCast(itm.GetLink, Shell32.ShellLinkObject)
        Return lnk.Target.Path
    End Function

    '바로가기 목적지경로 리턴 2
    Function GetTargetPath(ByVal FileName As String)
        Dim Obj As Object
        Obj = CreateObject("WScript.Shell")
        Dim Shortcut As Object
        Shortcut = Obj.CreateShortcut(FileName)
        GetTargetPath = Shortcut.TargetPath
    End Function
#End Region

#Region "히스토리 데이터 관리"
    Public Function CheckHisExist(isStationName As Boolean, locstring As String) As Boolean

        Dim isExists As Boolean = False
        Dim tmpdata As String = My.Settings.LocHistory

        If isStationName Then

ret:
            If tmpdata.Contains("<locinfo>") Then

                Dim FirstStart As Long = tmpdata.IndexOf("<locinfo>") + 10

                Dim chkdata = (Trim(Mid$(tmpdata, FirstStart, tmpdata.Substring(FirstStart).IndexOf("</locinfo>") + 1)))

                If getData(chkdata, "type") = "station" Then '측정소 데이터만 불러오기!!!

                    If locstring = getData(chkdata, "string") Then
                        isExists = True
                        GoTo endtask
                    End If

                    tmpdata = Mid(tmpdata, FirstStart, tmpdata.Length)
                    GoTo ret
                End If

            End If


        Else


ret2:
            If tmpdata.Contains("<locinfo>") Then

                Dim FirstStart As Long = tmpdata.IndexOf("<locinfo>") + 10

                Dim chkdata = (Trim(Mid$(tmpdata, FirstStart, tmpdata.Substring(FirstStart).IndexOf("</locinfo>") + 1)))

                If getData(chkdata, "type") = "location" Then '측정소 데이터만 불러오기!!!

                    If locstring = getData(chkdata, "string") Then
                        isExists = True
                        GoTo endtask
                    End If

                    tmpdata = Mid(tmpdata, FirstStart, tmpdata.Length)
                    GoTo ret2
                End If

            End If

        End If

endtask:
        Return isExists


    End Function

    Public Sub CleanHistory() '설정값 정리, 최대 저장갯수를 제한해 나머지 버리는 Sub

        Dim tmpdata As String = My.Settings.LocHistory
        Dim newdata As String = Nothing

        Dim finddata As New Regex("<locinfo>")
        Dim datacount As MatchCollection = finddata.Matches(tmpdata)

        Dim tmpcount As Integer = 0

        If datacount.Count > 20 Then

ret:
            If tmpdata.Contains("<locinfo>") And tmpcount < 20 Then

                Dim FirstStart As Long = tmpdata.IndexOf("<locinfo>") + 10
                newdata += (Trim(Mid$(tmpdata, FirstStart - 9, tmpdata.Substring(FirstStart).IndexOf("</locinfo>") + 20))) + vbCr
                tmpdata = Mid(tmpdata, FirstStart, tmpdata.Length)

                tmpcount += 1
                GoTo ret

            End If

            My.Settings.LocHistory = newdata

        End If



        'MsgBox(newdata)

    End Sub

    Public Sub AddLocHistory_Axis(locstring As String, pointX As String, pointY As String)

        Dim hisdata As String = "<locinfo>" + vbCr
        hisdata += "<type>location</type>" + vbCr
        hisdata += "<string>" + locstring + "</string>" + vbCr
        hisdata += "<X>" + pointX + "</X>" + vbCr
        hisdata += "<Y>" + pointY + "</Y>" + vbCr
        hisdata += "</locinfo>" + vbCr

        My.Settings.LocHistory = hisdata + My.Settings.LocHistory

    End Sub

    Public Sub AddLocHistory_station(stationname As String)

        Dim hisdata As String = "<locinfo>" + vbCr
        hisdata += "<type>station</type>" + vbCr
        hisdata += "<string>" + stationname + "</string>" + vbCr
        hisdata += "</locinfo>" + vbCr

        My.Settings.LocHistory = hisdata + My.Settings.LocHistory

    End Sub
#End Region

End Module
