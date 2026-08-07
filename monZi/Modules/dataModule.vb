Imports System.Security.Principal

Imports System.IO
Imports System.Xml
Imports System.Xml.Linq

Module dataModule

    'web에서 문자열 가져오는 함수
    Public Function webget(url As String)
        Dim source = New System.Net.WebClient()
        source.Encoding = System.Text.Encoding.UTF8
        'MsgBox(url)

        Dim sourcestr As String = Nothing
        sourcestr = source.DownloadString(url)

        'MsgBox("요청: " + url + vbCrLf + "=====" + vbCrLf + "응답: " + sourcestr)

        Return sourcestr
    End Function

    'xml형식 파일을 전체값에서 따로 추출하는 함수
    Public Function getData(datastr As String, name As String) As String
        If String.IsNullOrWhiteSpace(datastr) OrElse String.IsNullOrWhiteSpace(name) Then Return Nothing

        Try
            Dim element = ParseXml(datastr).Descendants().FirstOrDefault(Function(candidate) candidate.Name.LocalName = name)
            If element Is Nothing Then Return Nothing
            Return element.Value
        Catch ex As XmlException
            Try
                Dim element = ParseXml("<root>" & datastr & "</root>").Descendants().FirstOrDefault(
            Function(candidate) candidate.Name.LocalName = name)
                If element Is Nothing Then Return Nothing
                Return element.Value
            Catch fragmentException As XmlException
                Return Nothing
            End Try
        End Try
    End Function

    Public Function getDataElements(datastr As String, name As String) As IEnumerable(Of XElement)
        If String.IsNullOrWhiteSpace(datastr) OrElse String.IsNullOrWhiteSpace(name) Then
            Return Enumerable.Empty(Of XElement)()
        End If

        Try
            Return ParseXml(datastr).Descendants().Where(
                Function(candidate) candidate.Name.LocalName = name).ToList()
        Catch ex As XmlException
            Try
                '설정값처럼 여러 XML 요소가 이어진 fragment도 지원한다.
                Return ParseXml("<root>" & datastr & "</root>").Descendants().Where(
                    Function(candidate) candidate.Name.LocalName = name).ToList()
            Catch fragmentException As XmlException
                Return Enumerable.Empty(Of XElement)()
            End Try
        End Try
    End Function

    Private Function ParseXml(xml As String) As XDocument
        Dim settings As New XmlReaderSettings With {
            .DtdProcessing = DtdProcessing.Prohibit,
            .XmlResolver = Nothing
        }

        Using reader = XmlReader.Create(New StringReader(xml), settings)
            Return XDocument.Load(reader, LoadOptions.PreserveWhitespace)
        End Using
    End Function

    Private Function GetHistoryItems() As List(Of XElement)
        Dim history = My.Settings.LocHistory
        If String.IsNullOrWhiteSpace(history) Then Return New List(Of XElement)()

        Try
            Dim document = ParseXml("<root>" & history & "</root>")
            Return document.Root.Elements().Where(
                Function(element) element.Name.LocalName = "locinfo").ToList()
        Catch ex As XmlException
            Return New List(Of XElement)()
        End Try
    End Function

    Private Function GetChildValue(parent As XElement, name As String) As String
        Dim child = parent.Elements().FirstOrDefault(
            Function(element) element.Name.LocalName = name)
        If child Is Nothing Then Return Nothing
        Return child.Value
    End Function

#Region "시작프로그램설정"

    Dim shortcutname = "\monzi.lnk"
    Const AppLaunchCmd = "C:\Windows\explorer.exe"
    Private Const ERROR_INSUFFICIENT_BUFFER As Integer = 122

    <System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Unicode)>
    Private Function GetCurrentApplicationUserModelId(ByRef applicationUserModelIdLength As UInteger,
                                                      applicationUserModelId As System.Text.StringBuilder) As Integer
    End Function

    'MSIX/AppX로 실행 중인 프로세스에만 AUMID가 존재한다.
    Private Function GetCurrentAppUserModelId() As String
        Try
            Dim length As UInteger = 0
            If GetCurrentApplicationUserModelId(length, Nothing) <> ERROR_INSUFFICIENT_BUFFER Then
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

    Private ReadOnly Property AppCode As String
        Get
            Return GetCurrentAppUserModelId()
        End Get
    End Property

    Private ReadOnly Property isStoreApp As Boolean
        Get
            Return Not String.IsNullOrEmpty(AppCode)
        End Get
    End Property

    Public Function checkStartUp() As Boolean
        Dim destlnk As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & shortcutname

        If IO.File.Exists(destlnk) Then
            If isStoreApp And GetTargetPath(destlnk) = AppLaunchCmd + " " + AppCode Then
                Return True
            ElseIf Not isStoreApp And GetTargetPath(destlnk) = Application.ExecutablePath Then
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

        Path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & shortcutname

        Dim wsh As Object = CreateObject("WScript.Shell")

        Dim MyShortcut
        MyShortcut = wsh.CreateShortcut(Path)

        If isStoreApp Then
            MyShortcut.TargetPath = wsh.ExpandEnvironmentStrings(AppLaunchCmd)
            MyShortcut.Arguments = AppCode
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
    Function GetTargetPath(ByVal FileName As String)
        Dim Obj As Object
        Obj = CreateObject("WScript.Shell")
        Dim Shortcut As Object
        Shortcut = Obj.CreateShortcut(FileName)

        If Not Shortcut.Arguments = "" Then
            Return Shortcut.TargetPath + " " + Shortcut.Arguments
        Else
            Return Shortcut.TargetPath
        End If
    End Function

#End Region

    Public Function CheckHisExist(isStationName As Boolean, locstring As String) As Boolean
        Dim expectedType = If(isStationName, "station", "location")
        Return GetHistoryItems().Any(Function(item) GetChildValue(item, "type") = expectedType AndAlso GetChildValue(item, "string") = locstring)
    End Function

    Public Sub CleanHistory() '설정값 정리, 최대 저장갯수를 제한해 나머지 버리는 Sub
        Dim items = GetHistoryItems()
        If items.Count > 20 Then
            My.Settings.LocHistory = String.Join(vbCrLf,
                items.Take(20).Select(Function(item) item.ToString(SaveOptions.DisableFormatting))) & vbCrLf
        End If
    End Sub

    Public Sub AddLocHistory_Axis(locstring As String, pointX As String, pointY As String)
        Dim item = New XElement("locinfo", New XElement("type", "location"),
            New XElement("string", locstring), New XElement("X", pointX), New XElement("Y", pointY))
        My.Settings.LocHistory = item.ToString(SaveOptions.DisableFormatting) & vbCrLf & My.Settings.LocHistory
    End Sub

    Public Sub AddLocHistory_station(stationname As String)
        Dim item = New XElement("locinfo", New XElement("type", "station"),
            New XElement("string", stationname))
        My.Settings.LocHistory = item.ToString(SaveOptions.DisableFormatting) & vbCrLf & My.Settings.LocHistory
    End Sub
End Module
