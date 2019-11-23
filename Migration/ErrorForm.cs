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

public class ErrorForm
{
    public string errorname = null;
    public string errordetail = null;
    public DateTime errortime;

    private void Button1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void ErrorForm_Load(object sender, EventArgs e)
    {
        RichTextBox1.Text = errorname;
    }

    private void Button3_Click(object sender, EventArgs e)
    {
        InfoCopy();
    }

    public void InfoCopy()
    {
        string cominfo = "[예외 발생 시각]" + Constants.vbCr + errortime.ToString() + Constants.vbCr + Constants.vbCr;


        if (Interaction.MsgBox("PC, 프로그램 정보도 함께 복사하시겠습니까?" + Constants.vbCr + Constants.vbCr + "더욱 정확한 조사를 위해 특별한 경우가 아닌 경우 '예'를 눌러 복사해 주시기 바랍니다. (측정 위치와 같은 민감한 개인 정보는 다음 대화 상자에서 포함 여부를 설정하실 수 있습니다.)", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbYes)
        {
            Graphics g = this.CreateGraphics;
            var dpi = g.DpiX.ToString();

            cominfo += "[디바이스 정보]"
                + Constants.vbCr + "AppName: " + My.Application.Info.ProductName
                + Constants.vbCr + "AppVersion: " + My.Application.Info.Version.ToString
                + Constants.vbCr + "OS fullname: " + My.Computer.Info.OSFullName.ToString
                + Constants.vbCr + "OS version: " + My.Computer.Info.OSVersion.ToString
                + Constants.vbCr + "OS Platform: " + My.Computer.Info.OSPlatform.ToString
                + Constants.vbCr + "TotalPhysicalMemory: " + My.Computer.Info.TotalPhysicalMemory.ToString
                + Constants.vbCr + "ScreenDPI: " + dpi
                + Constants.vbCr + "OS type: ";
            if (My.Computer.FileSystem.DirectoryExists(@"C:\Program Files (x86)"))
                cominfo = cominfo + "64Bit OS";
            else
                cominfo = cominfo + "32Bit OS";

            cominfo += Constants.vbCr + Constants.vbCr + "[애플리케이션 설정 값]" + Constants.vbCr;
            // 설정값 나열
            cominfo += "RecentCheck: " + My.Settings.RecentCheck.ToString + Constants.vbCr;
            cominfo += "RecentAirCheck: " + My.Settings.RecentAirCheck.ToString + Constants.vbCr;
            // cominfo += "LocationPoint_X: " + My.Settings.LocationPoint_X.ToString + vbCr
            // cominfo += "LocationPoint_Y: " + My.Settings.LocationPoint_Y.ToString + vbCr
            // cominfo += "LocationName: " + My.Settings.LocationName.ToString + vbCr
            // cominfo += "StationName: " + My.Settings.StationName.ToString + vbCr
            cominfo += "ChkEnabled: " + My.Settings.ChkEnabled.ToString + Constants.vbCr;
            cominfo += "PushEnabled: " + My.Settings.PushEnabled.ToString + Constants.vbCr;
            cominfo += "TrayEnabled: " + My.Settings.TrayEnabled.ToString + Constants.vbCr;
            cominfo += "PushList: " + My.Settings.PushList.ToString + Constants.vbCr;
            cominfo += "PushWithsound: " + My.Settings.PushWithsound.ToString + Constants.vbCr;
            cominfo += "PushIgnore: " + My.Settings.PushIgnore.ToString + Constants.vbCr;
            cominfo += "PushTopmost: " + My.Settings.PushTopmost.ToString + Constants.vbCr;
            cominfo += "AeroEnabled: " + My.Settings.AeroEnabled.ToString + Constants.vbCr;
            cominfo += "FadeEnabled: " + My.Settings.FadeEnabled.ToString + Constants.vbCr;
            cominfo += "AniEnabled: " + My.Settings.AniEnabled.ToString + Constants.vbCr;
            cominfo += "APIFORM: " + My.Settings.APIFORM.ToString + Constants.vbCr;
            cominfo += "StartupPopIgnore: " + My.Settings.StartupPopIgnore.ToString + Constants.vbCr;
            cominfo += "upgradeRequired: " + My.Settings.upgradeRequired.ToString + Constants.vbCr;
            // cominfo += "LocHistory: " + My.Settings.LocHistory.ToString + vbCr
            cominfo += "UseNativeFont: " + My.Settings.UseNativeFont.ToString + Constants.vbCr;
            cominfo += "widget_enabled: " + My.Settings.widget_enabled.ToString + Constants.vbCr;
            cominfo += "widget_position: " + My.Settings.widget_position.ToString + Constants.vbCr;
            cominfo += "widget_locked: " + My.Settings.widget_locked.ToString + Constants.vbCr;
            cominfo += "widget_display: " + My.Settings.widget_display.ToString + Constants.vbCr;
            cominfo += "widget_opacity: " + My.Settings.widget_opacity.ToString + Constants.vbCr;

            if (Interaction.MsgBox("측정소, 위치 설정 정보도 포함하시겠습니까?" + Constants.vbCr + Constants.vbCr + "(해당 설정은 프로그램 오류 조사시에만 사용됩니다. 하지만 해당 정보는 민감한 개인 정보이기 때문에 설정 위치를 제공하기를 원치 않으신 경우 '아니오'를 누르시면 해당 정보는 제외된 채 정보가 복사됩니다)", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbYes)
            {
                cominfo += "LocationPoint_X: " + My.Settings.LocationPoint_X.ToString + Constants.vbCr;
                cominfo += "LocationPoint_Y: " + My.Settings.LocationPoint_Y.ToString + Constants.vbCr;
                cominfo += "LocationName: " + My.Settings.LocationName.ToString + Constants.vbCr;
                cominfo += "StationName: " + My.Settings.StationName.ToString + Constants.vbCr;
                cominfo += "LocHistory: " + My.Settings.LocHistory.ToString + Constants.vbCr;
            }

            cominfo += "AirStd: " + My.Settings.AirStd.ToString + Constants.vbCr;
            cominfo += "FormPos: " + My.Settings.FormPos.ToString + Constants.vbCr;
            cominfo += "UseAKAPI: " + My.Settings.UseAKAPI.ToString + Constants.vbCr;

            if (!My.Settings.USERAPIKEY == null/* TODO Change to default(_) if this is not a reference type */ )
            {
                if (Interaction.MsgBox("USER API Key가 설정되어 있습니다. 이도 로그에 포함시키겠습니까?", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbYes)
                    cominfo += "USERAPIKey: " + My.Settings.USERAPIKEY.ToString + Constants.vbCr;
            }
            cominfo += Constants.vbCr + Constants.vbCr;
        }

        cominfo += "[예외 오류 정보]" + Constants.vbCr + errordetail + Constants.vbCr + Constants.vbCr;
        cominfo += "[로그 기록 시각]" + Constants.vbCr + DateTime.Now.ToString();


        Clipboard.SetText(cominfo);
    }

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        InfoCopy();
        Interaction.MsgBox("복사가 완료되었습니다. 곧 뜨는 양식 페이지 맨 처음 칸에 붙여넣기(Ctrl + V) 한 뒤 나머지 항목을 채워주시기 바랍니다." + Constants.vbCr + Constants.vbCr + "감사합니다.", Constants.vbInformation);
        TopMost = false;
        Process.Start("http://monzierror.ze.am");
    }

    private void Button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        if (Interaction.MsgBox("애플리케이션 설정 제거시 모든 설정값이 초기화되며 이후 프로그램이 종료됩니다." + Constants.vbCr + "계속하시겠습니까?", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbYes)
        {
            bool delok = true;

            // MsgBox(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\PBJSoftware")


            try
            {
                DeleteAppSettings();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
                delok = false;
            }

            if (!delok)
            {
                if (Interaction.MsgBox("삭제 도중 문제가 발생했습니다." + Constants.vbCr + "직접 제거하시겠습니까?", Constants.vbYesNo + Constants.vbQuestion) == Constants.vbYes)
                {
                    Interaction.MsgBox(@"이 메시지를 닫고 나서 열리는 창(%LocalAppdata&\PBJSoftware)에서 현재 프로그램의 프로세스명이 포함되어 있는 디렉토리를 모두 삭제한 뒤 프로그램을 다시 실행해주시기 바랍니다.", Constants.vbInformation);
                    Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\PBJSoftware");
                }
            }
            else
            {
                Interaction.MsgBox("제거가 완료되었습니다. 프로그램이 종료됩니다.", Constants.vbInformation);
                Application.Exit();
            }
        }
    }

    public void DeleteAppSettings()
    {
        string currentExeName = System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath);

        foreach (string foundDirectory in My.Computer.FileSystem.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\PBJSoftware", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*" + currentExeName + "*"))
            System.IO.Directory.Delete(foundDirectory, true);
    }
}
