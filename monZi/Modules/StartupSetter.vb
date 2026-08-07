Imports System.Security.Principal

Module StartupSetter

    Dim shortcutname = "\monzi.lnk"
    Const appLaunchCmd = "C:\Windows\explorer.exe"
    Private Const errorInsufficientBuffer As Integer = 122

    <System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Unicode)>
    Private Function GetCurrentApplicationUserModelId(ByRef applicationUserModelIdLength As UInteger,
                                                      applicationUserModelId As System.Text.StringBuilder) As Integer
    End Function

    'MSIX/AppX로 실행 중인 프로세스에만 AUMID가 존재한다.
    Private Function GetCurrentAppUserModelId() As String
        Try
            Dim length As UInteger = 0
            If GetCurrentApplicationUserModelId(length, Nothing) <> errorInsufficientBuffer Then
                Return Nothing
            End If

            Dim applicationUserModelId As New System.Text.StringBuilder(CInt(length))
            If GetCurrentApplicationUserModelId(length, applicationUserModelId) <> 0 Then
                Return Nothing
            End If

            Return applicationUserModelId.ToString()
        Catch ex As EntryPointNotFoundException
            'Windows 7 등 패키지 ID API를 지원하지 않는 환경
            Return Nothing
        End Try
    End Function

    '시작프로그램 바로가기에서 Explorer가 실행할 AppsFolder 경로.
    '패키지 ID는 스토어 배포용 manifest의 Identity에 맞춰 관리한다.
    Private Const appCode As String = "shell:appsFolder\49490PBJSoftware.monZi_fv4zvza0919de!App"

    Private ReadOnly Property IsStoreApp As Boolean
        Get
            Return Not String.IsNullOrEmpty(GetCurrentAppUserModelId())
        End Get
    End Property

    Public Function CheckStartUp() As Boolean
        Dim destlnk As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & shortcutname

        If Not IO.File.Exists(destlnk) Then Return False

        Dim wsh As Object = CreateObject("WScript.Shell")
        Dim shortcut As Object = wsh.CreateShortcut(destlnk)
        Dim targetPath = CStr(shortcut.TargetPath)
        Dim arguments = CStr(shortcut.Arguments).Trim()
        'MSIX 바로가기는 explorer.exe가 AppsFolder 경로를 실행한다.
        If IsStoreApp AndAlso
           PathsEqual(targetPath, appLaunchCmd) AndAlso
           String.Equals(arguments, appCode, StringComparison.OrdinalIgnoreCase) Then
            Return True
        End If

        '일반 exe 바로가기 및 이전 버전이 남긴 "exe + shell:appsFolder" 형식도 인정한다.
        If Not PathsEqual(targetPath, Application.ExecutablePath) Then Return False

        Return String.IsNullOrEmpty(arguments) OrElse
               arguments.StartsWith("shell:appsFolder\", StringComparison.OrdinalIgnoreCase)
    End Function

    Private Function PathsEqual(firstPath As String, secondPath As String) As Boolean
        Return String.Equals(IO.Path.GetFullPath(firstPath).TrimEnd("\"c),
                             IO.Path.GetFullPath(secondPath).TrimEnd("\"c),
                             StringComparison.OrdinalIgnoreCase)
    End Function

    Sub SetStartup()
        Dim Path As String
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)

        Path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & shortcutname

        Dim wsh As Object = CreateObject("WScript.Shell")

        Dim MyShortcut
        MyShortcut = wsh.CreateShortcut(Path)

        If IsStoreApp Then
            MyShortcut.TargetPath = wsh.ExpandEnvironmentStrings(appLaunchCmd)
            MyShortcut.Arguments = appCode
        Else
            MyShortcut.TargetPath = wsh.ExpandEnvironmentStrings(Application.ExecutablePath)
        End If

        MyShortcut.WindowStyle = 4
        MyShortcut.Save()
    End Sub

    Sub RemoveStartup()
        My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\monzi.lnk")
    End Sub

    '바로가기 목적지경로 리턴 2
    Function GetTargetPath(ByVal fileName As String)
        Dim Obj As Object
        Obj = CreateObject("WScript.Shell")
        Dim Shortcut As Object
        Shortcut = Obj.CreateShortcut(fileName)

        If Not Shortcut.Arguments = "" Then
            Return Shortcut.TargetPath + " " + Shortcut.Arguments
        Else
            Return Shortcut.TargetPath
        End If
    End Function

End Module
