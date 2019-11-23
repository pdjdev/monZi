using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Security.Principal;
using System.Text.RegularExpressions;

static class dataModule
{

    // web에서 문자열 가져오는 함수
    public static void webget(string url)
    {
        var source = new System.Net.WebClient();
        source.Encoding = System.Text.Encoding.UTF8;
        // MsgBox(url)

        string sourcestr = null;

        sourcestr = source.DownloadString(url);


        return sourcestr;
    }

    // xml형식 파일을 전체값에서 따로 추출하는 함수
    public static void getData(string datastr, string name)
    {
        return midReturn("<" + name + ">", "</" + name + ">", datastr);
    }

    // 중간의 문자열을 리턴하는 함수
    public static string midReturn(string first, string last, string total)
    {
        if (last.Length < 1)
            midReturn = total.Substring(total.IndexOf(first));
        if (first.Length < 1)
            midReturn = total.Substring(0, (total.IndexOf(last)));

        midReturn = ((total.Substring(total.IndexOf(first), (total.IndexOf(last) - total.IndexOf(first)))).Replace(first, "")).Replace(last, "");
    }


    public static bool checkStartUp()
    {
        string destlnk = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\monzi.lnk";

        if (System.IO.File.Exists(destlnk))
        {
            if (GetTargetPath(destlnk) == Application.ExecutablePath)
                return true;
            else
                return false;
        }
        else
            return false;
    }

    public static void SetStartup()
    {
        string Path;
        var identity = WindowsIdentity.GetCurrent();
        var principal = new WindowsPrincipal(identity);

        Path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\monzi.lnk";

        object wsh = Interaction.CreateObject("WScript.Shell");

        var MyShortcut;
        MyShortcut = wsh.CreateShortcut(Path);
        MyShortcut.TargetPath = wsh.ExpandEnvironmentStrings(Application.ExecutablePath);
        MyShortcut.WindowStyle = 4;
        MyShortcut.Save();
    }

    public static void RemoveStartup()
    {
        My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\monzi.lnk");
    }

    // 바로가기 파일의 목적지경로를 리턴 -> Win7 포함한 일부 환경에 문제 있어 사용안함!!!
    public static string GetLnkTarget(string lnkPath)
    {
        var shl = new Shell32.Shell();
        lnkPath = System.IO.Path.GetFullPath(lnkPath);
        var dir = shl.NameSpace(System.IO.Path.GetDirectoryName(lnkPath));
        var itm = dir.Items().Item(System.IO.Path.GetFileName(lnkPath));
        var lnk = (Shell32.ShellLinkObject)itm.GetLink;
        return lnk.Target.Path;
    }

    // 바로가기 목적지경로 리턴 2
    public static void GetTargetPath(string FileName)
    {
        object Obj;
        Obj = Interaction.CreateObject("WScript.Shell");
        object Shortcut;
        Shortcut = Obj.CreateShortcut(FileName);
        GetTargetPath = Shortcut.TargetPath;
    }

    public static bool CheckHisExist(bool isStationName, string locstring)
    {
        bool isExists = false;
        string tmpdata = My.Settings.LocHistory;

        if (isStationName)
        {
        ret:
            ;
            if (tmpdata.Contains("<locinfo>"))
            {
                long FirstStart = tmpdata.IndexOf("<locinfo>") + 10;

                var chkdata = (Strings.Trim(Mid(tmpdata, FirstStart, tmpdata.Substring(FirstStart).IndexOf("</locinfo>") + 1)));

                if (getData(chkdata, "type") == "station")
                {
                    if (locstring == getData(chkdata, "string"))
                    {
                        isExists = true;
                        goto endtask;
                    }

                    tmpdata = Strings.Mid(tmpdata, FirstStart, tmpdata.Length);
                    goto ret;
                }
            }
        }
        else
        {
        ret2:
            ;
            if (tmpdata.Contains("<locinfo>"))
            {
                long FirstStart = tmpdata.IndexOf("<locinfo>") + 10;

                var chkdata = (Strings.Trim(Mid(tmpdata, FirstStart, tmpdata.Substring(FirstStart).IndexOf("</locinfo>") + 1)));

                if (getData(chkdata, "type") == "location")
                {
                    if (locstring == getData(chkdata, "string"))
                    {
                        isExists = true;
                        goto endtask;
                    }

                    tmpdata = Strings.Mid(tmpdata, FirstStart, tmpdata.Length);
                    goto ret2;
                }
            }
        }

    endtask:
        ;
        return isExists;
    }

    public static void CleanHistory() // 설정값 정리, 최대 저장갯수를 제한해 나머지 버리는 Sub
    {
        string tmpdata = My.Settings.LocHistory;
        string newdata = null;

        Regex finddata = new Regex("<locinfo>");
        MatchCollection datacount = finddata.Matches(tmpdata);

        int tmpcount = 0;

        if (datacount.Count > 20)
        {
        ret:
            ;
            if (tmpdata.Contains("<locinfo>") & tmpcount < 20)
            {
                long FirstStart = tmpdata.IndexOf("<locinfo>") + 10;
                newdata += (Strings.Trim(Mid(tmpdata, FirstStart - 9, tmpdata.Substring(FirstStart).IndexOf("</locinfo>") + 20))) + Constants.vbCr;
                tmpdata = Strings.Mid(tmpdata, FirstStart, tmpdata.Length);

                tmpcount += 1;
                goto ret;
            }

            My.Settings.LocHistory = newdata;
        }
    }

    public static void AddLocHistory_Axis(string locstring, string pointX, string pointY)
    {
        string hisdata = "<locinfo>" + Constants.vbCr;
        hisdata += "<type>location</type>" + Constants.vbCr;
        hisdata += "<string>" + locstring + "</string>" + Constants.vbCr;
        hisdata += "<X>" + pointX + "</X>" + Constants.vbCr;
        hisdata += "<Y>" + pointY + "</Y>" + Constants.vbCr;
        hisdata += "</locinfo>" + Constants.vbCr;

        My.Settings.LocHistory = hisdata + My.Settings.LocHistory;
    }

    public static void AddLocHistory_station(string stationname)
    {
        string hisdata = "<locinfo>" + Constants.vbCr;
        hisdata += "<type>station</type>" + Constants.vbCr;
        hisdata += "<string>" + stationname + "</string>" + Constants.vbCr;
        hisdata += "</locinfo>" + Constants.vbCr;

        My.Settings.LocHistory = hisdata + My.Settings.LocHistory;
    }
}
