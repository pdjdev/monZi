Imports System.IO
Imports System.Net
Imports System.Text

Module MapApi

    '카카오 위치수집 API
    Public Function getLocationKakao(query As String)

        Dim url As String = "https://dapi.kakao.com/v2/local/search/address.xml?query=" & query
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        With request.Headers
            .Add("Authorization", "KakaoAK " & Secrets.KakaoRestApiKey)
        End With

        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        Dim status As String = response.StatusCode.ToString()

        If status = "OK" Then
            Dim stream As Stream = response.GetResponseStream()
            Dim reader As StreamReader = New StreamReader(stream)
            Dim text As String = reader.ReadToEnd()

            Return text
        Else
            Return Nothing
        End If
    End Function

    '카카오API로 얻은 좌표값을 TN좌표로 컨버팅 ('/'로 나눔!!!)
    Public Function convertToTMKakao(xnum As String, ynum As String) As String

        Dim url As String = "https://dapi.kakao.com/v2/local/geo/transcoord.xml?x=" + xnum + "&y=" + ynum + "&output_coord=TM"
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        With request.Headers
            .Add("Authorization", "KakaoAK " & Secrets.KakaoRestApiKey)
        End With

        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        Dim status As String = response.StatusCode.ToString()

        If status = "OK" Then
            Dim stream As Stream = response.GetResponseStream()
            Dim reader As StreamReader = New StreamReader(stream)
            Dim text As String = reader.ReadToEnd()

            Return getData(text, "x") + "/" + getData(text, "y")
        Else
            Return Nothing
        End If
    End Function
End Module
