Module airAPI

    '측정소 이름을 받아서 미세먼지 정보 리턴하는 함수
    Function OLDgetairinfo(station As String)
        Dim currenturl = "https://apis.data.go.kr/B552584/ArpltnInforInqireSvc/getMsrstnAcctoRltmMesureDnsty?serviceKey="

        If My.Settings.USERAPIKEY = Nothing Then
            currenturl += Secrets.AirKoreaServiceKey
        Else
            currenturl += My.Settings.USERAPIKEY
        End If

        currenturl += "&returnType=xml&numOfRows=1&pageSize=1&pageNo=1&startPage=1&stationName="
        currenturl += Web.HttpUtility.UrlEncode(station)
        currenturl += "&dataTerm=DAILY&ver=1.3"

        Dim currentsource = webget(currenturl)

        Return currentsource
    End Function

    '측정소 이름을 받아서 미세먼지 정보 리턴하는 함수 - 개인 RPI 서버!!
    Function getairinfo(station As String)
        Dim currenturl = Secrets.AirCacheEndpoint
        currenturl += Web.HttpUtility.UrlEncode(station) + ".xml"

        Dim currentsource As String

        '무조건 AKAPI 쓰는것이 아니면
        If Not My.Settings.UseAKAPI Then
            Try
                '개인 RPI 서버로 요청 한번 하고 나서 실패시에
                currentsource = webget(currenturl)
            Catch ex As Exception
                'AKAPI 이용
                currentsource = OLDgetairinfo(station)
            End Try
        Else
            '쓰는 걸로 설정되어있으면
            currentsource = OLDgetairinfo(station)
        End If

        Return currentsource
    End Function

    'TM좌표를 받아 가장 주변의 측정소 받는 함수
    Function getNearStation(xnum As String, ynum As String)
        Dim currenturl As String = "https://apis.data.go.kr/B552584/MsrstnInfoInqireSvc/getNearbyMsrstnList?serviceKey="

        If My.Settings.USERAPIKEY = Nothing Then
            currenturl += Secrets.AirKoreaServiceKey
        Else
            currenturl += My.Settings.USERAPIKEY
        End If

        currenturl += "&returnType=xml&tmX=" + xnum + "&tmY=" + ynum


        Dim currentsource = webget(currenturl)

        Return currentsource
    End Function

    Public Function findStationByName(name As String)
        Dim currenturl = "https://apis.data.go.kr/B552584/MsrstnInfoInqireSvc/getMsrstnList?serviceKey="

        If My.Settings.USERAPIKEY = Nothing Then
            currenturl += Secrets.AirKoreaServiceKey
        Else
            currenturl += My.Settings.USERAPIKEY
        End If

        currenturl += "&returnType=xml&numOfRows=1&pageSize=1&pageNo=1&startPage=1&stationName=" + Web.HttpUtility.UrlEncode(name)

        Dim currentsource As String = webget(currenturl)

        If currentsource.Contains("<stationName>") Then
            Return getData(currentsource, "stationName")
        Else
            Return "{ERROR}"
        End If
    End Function
End Module
