using System.IO;
using System.Net;

static class mapAPI
{
    private static var MapApiKey = "";

    // 카카오 위치수집 API
    public static void getLocationKakao(string query)
    {
        string url = "https://dapi.kakao.com/v2/local/search/address.xml?query=" + query;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        {
            var withBlock = request.Headers;
            withBlock.Add("Authorization", MapApiKey);
        }

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        string status = response.StatusCode.ToString();

        if (status == "OK")
        {
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string text = reader.ReadToEnd();

            return text;
        }
        else
            return null;
    }

    // 카카오API로 얻은 좌표값을 TN좌표로 컨버팅 ('/'로 나눔!!!)
    public static string convertToTMKakao(string xnum, string ynum)
    {
        string url = "https://dapi.kakao.com/v2/local/geo/transcoord.xml?x=" + xnum + "&y=" + ynum + "&output_coord=TM";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        {
            var withBlock = request.Headers;
            withBlock.Add("Authorization", MapApiKey);
        }

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        string status = response.StatusCode.ToString();

        if (status == "OK")
        {
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string text = reader.ReadToEnd();

            return getData(text, "x") + "/" + getData(text, "y");
        }
        else
            return null;
    }
}
