using System;

static class airAPI
{
    private static var AirApiKey = "";

    // 측정소 이름을 받아서 미세먼지 정보 리턴하는 함수
    public static void OLDgetairinfo(string station)
    {
        var currenturl = "http://openapi.airkorea.or.kr/openapi/services/rest/ArpltnInforInqireSvc/getMsrstnAcctoRltmMesureDnsty?serviceKey=";

        if (My.Settings.USERAPIKEY == null/* TODO Change to default(_) if this is not a reference type */ )
            currenturl += AirApiKey;
        else
            currenturl += My.Settings.USERAPIKEY;

        currenturl += "&numOfRows=1&pageSize=1&pageNo=1&startPage=1&stationName=";
        currenturl += System.Web.HttpUtility.UrlEncode(station);
        currenturl += "&dataTerm=DAILY&ver=1.3";

        var currentsource = webget(currenturl);

        return currentsource;
    }

    // 측정소 이름을 받아서 미세먼지 정보 리턴하는 함수 - 개인 RPI 서버!!
    public static void getairinfo(string station)
    {
        var currenturl = "http://db.monzi-host.ze.am/monziDB/";
        currenturl += System.Web.HttpUtility.UrlEncode(station) + ".xml";

        string currentsource;

        // 무조건 AKAPI 쓰는것이 아니면
        if (!My.Settings.UseAKAPI)
        {
            try
            {
                // 개인 RPI 서버로 요청 한번 하고 나서 실패시에
                currentsource = webget(currenturl);
            }
            catch (Exception ex)
            {
                // AKAPI 이용
                currentsource = OLDgetairinfo(station);
            }
        }
        else
            // 쓰는 걸로 설정되어있으면
            currentsource = OLDgetairinfo(station);

        return currentsource;
    }

    // TM좌표를 받아 가장 주변의 측정소 받는 함수
    public static void getNearStation(string xnum, string ynum)
    {
        string currenturl = "http://openapi.airkorea.or.kr/openapi/services/rest/MsrstnInfoInqireSvc/getNearbyMsrstnList?serviceKey=";

        if (My.Settings.USERAPIKEY == null/* TODO Change to default(_) if this is not a reference type */ )
            currenturl += AirApiKey;
        else
            currenturl += My.Settings.USERAPIKEY;

        currenturl += "&tmX=" + xnum + "&tmY=" + ynum;


        var currentsource = webget(currenturl);

        return currentsource;
    }

    // (기존) 읍면동 정보를 받아 가장주변 측정소 이름을 리턴
    public static void getstation(string input)
    {
        var currenturl = "http://openapi.airkorea.or.kr/openapi/services/rest/MsrstnInfoInqireSvc/getTMStdrCrdnt?serviceKey="
            + AirApiKey
            + "&numOfRows=10&pageSize=10&pageNo=1&startPage=1&umdName=";
        currenturl += System.Web.HttpUtility.UrlEncode(input);

        var currentsource = webget(currenturl);

        string xnum = midReturn("<tmX>", "</tmX>", currentsource);
        string ynum = midReturn("<tmY>", "</tmY>", currentsource);
        Interaction.MsgBox("로케이션info: " + Constants.vbCr + xnum + Constants.vbCr + ynum);

        currenturl = "http://openapi.airkorea.or.kr/openapi/services/rest/MsrstnInfoInqireSvc/getNearbyMsrstnList?serviceKey="
            + AirApiKey + "&tmX=";
        currenturl += xnum;
        currenturl += "&tmY=";
        currenturl += ynum;

        currentsource = webget(currenturl);

        return getData(currentsource, "stationName");
    }

    public static void findStationByName(string name)
    {
        var currenturl = "http://openapi.airkorea.or.kr/openapi/services/rest/MsrstnInfoInqireSvc/getMsrstnList?serviceKey=";

        if (My.Settings.USERAPIKEY == null/* TODO Change to default(_) if this is not a reference type */ )
            currenturl += AirApiKey;
        else
            currenturl += My.Settings.USERAPIKEY;

        currenturl += "&numOfRows=1&pageSize=1&pageNo=1&startPage=1&stationName=" + System.Web.HttpUtility.UrlEncode(name);

        string currentsource = webget(currenturl);

        if (currentsource.Contains("<stationName>"))
            return getData(currentsource, "stationName");
        else
            return "{ERROR}";
    }
}
