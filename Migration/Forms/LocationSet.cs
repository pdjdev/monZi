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

public class LocationSet
{
    private Point loc;

    private string locdata;
    private string bdname;
    private string locstr;
    public string x_num;
    public string y_num;
    private var[] tm_co = null;

    public string StationName = null;
    private string loctext = null; // 이거는 최종적으로 셋팅에 저장할 위치 텍스트 (locstr와는 다름)

    public bool complete = false;



    protected override void OnHandleCreated(EventArgs e)
    {
        CreateDropShadow(this);
        base.OnHandleCreated(e);
    }



    private void FadeInEffect(object sender, EventArgs e)
    {
        this.Refresh();
        FadeIn(this, 1);
    }

    private void FadeOutEffect(object sender, EventArgs e)
    {
        FadeOut(this);
    }

    private void FormDrag_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == Windows.Forms.MouseButtons.Left)
            loc = e.Location;
    }

    private void FormDrag_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == Windows.Forms.MouseButtons.Left)
            this.Location += e.Location - loc;
    }

    private void LocationSet_Load(object sender, EventArgs e)
    {
        Opacity = 0;
        if (My.Settings.UseNativeFont)
            ChangeToNativeFont(this);
        HelpText.Location = new Point(TextBox1.Location.X + dpicalc(this, 2), TextBox1.Location.Y);
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        if (!complete)
        {
            if (TextBox1.Text == null/* TODO Change to default(_) if this is not a reference type */ )
            {
                Interaction.MsgBox("주소를 입력해 주세요", Constants.vbExclamation);
                goto endtask;
            }


            Button2.Enabled = false;

            if (CheckBox1.Checked == false)
            {
                try
                {
                    locdata = getLocationKakao(TextBox1.Text);
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("위치 탐색 도중 오류가 발생했습니다." + Constants.vbCr + "값이 유효한지, 인터넷 연결이 되어 있는지 확인해 주세요.", Constants.vbCritical);
                    goto endtask;
                }

                try
                {
                    locstr = getData(locdata, "address_name");
                    x_num = getData(locdata, "x");
                    y_num = getData(locdata, "y");
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("유효한 주소가 아닌 것 같습니다. 주소를 확인해 주십시오.", Constants.vbExclamation);
                    goto endtask;
                }

                if (locdata.Contains("<building_name>"))
                    bdname = getData(locdata, "building_name");
                else
                    bdname = null;

                if (bdname == null)
                    loctext = locstr;
                else
                    loctext = bdname;

                if (Interaction.MsgBox("입력한 주소가 " + locstr + " " + bdname + "이(가) 맞습니까?", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbNo)
                {
                    Interaction.MsgBox("주소가 유효한지 확인해 주시고 더 자세한 주소로 입력해 보시기 바랍니다.", Constants.vbInformation);
                    goto endtask;
                }


                // TM좌표로 변환
                try
                {
                    tm_co = convertToTMKakao(x_num, y_num).Split("/");
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("위치 변환 도중 오류가 발생했습니다." + Constants.vbCr + "값이 유효한지, 인터넷 연결이 되어 있는지 확인해 주세요.", Constants.vbCritical);
                    goto endtask;
                }

                StationName = null;
            }
            else
            {
                string stationstr = null;

                try
                {
                    stationstr = findStationByName(TextBox1.Text);
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("측정소 탐색 도중 오류가 발생했습니다." + Constants.vbCr + "값이 유효한지, 인터넷 연결이 되어 있는지 확인해 주세요.", Constants.vbCritical);
                    goto endtask;
                }

                if (stationstr == "{ERROR}")
                {
                    Interaction.MsgBox("측정소를 찾을 수 없습니다. 측정소명을 정확히 입력하였는지 확인해 주세요.", Constants.vbCritical);
                    goto endtask;
                }

                if (Interaction.MsgBox("입력하신 측정소가 " + stationstr + "이(가) 맞습니까?", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbNo)
                {
                    Interaction.MsgBox("명칭이 유효한지 확인해 주시고 더 자세하게 입력해 보시기 바랍니다.", Constants.vbInformation);
                    goto endtask;
                }

                StationName = stationstr;
            }

            Interaction.MsgBox("성공적으로 확인되었습니다. '적용'을 눌러 설정을 저장합니다." + Constants.vbCr + Constants.vbCr + "'입력한 위치의 주변 측정소 조회...'를 눌러 주변 측정소를 선택하실 수도 있습니다.", Constants.vbInformation);

            CheckBox1.Enabled = false;
            complete = true;
            TextBox1.ReadOnly = true;
            Button1.Text = "변경하기";
            Button2.Enabled = true;
        }
        else
        {
            CheckBox1.Enabled = true;
            complete = false;
            TextBox1.ReadOnly = false;
            Button1.Text = "조회";
            Button2.Enabled = false;
        }



    endtask:
        ;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
        if (complete)
        {

            // 처음판별
            bool wasitfirst = false;
            if (My.Settings.LocationName == null/* TODO Change to default(_) if this is not a reference type */ )
                wasitfirst = true;

            if (StationName == null)
            {
                My.Settings.StationName = null;
                My.Settings.LocationName = loctext;
                My.Settings.LocationPoint_X = tm_co[0];
                My.Settings.LocationPoint_Y = tm_co[1];
            }
            else
            {
                My.Settings.LocationName = StationName + " (측정소)";
                My.Settings.StationName = StationName;
            }

            if (wasitfirst)
            {
                if (Interaction.MsgBox("처음 설정하시는 것 같네요. 실시간으로 대기 정보를 받아볼 수 있도록 다음 설정을 활성화 하시겠습니까?" + Constants.vbCr + Constants.vbCr + "- 자동으로 대기 상태 업데이트 (권장)" + Constants.vbCr + "- 대기 상태 푸시 알림 (권장)" + Constants.vbCr + Constants.vbCr + "'예'를 누를시 자동으로 적용되며, 이 설정은 나중에 '프로그램 설정'에서 변경하실 수 있습니다.", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbYes)
                {
                    My.Settings.ChkEnabled = true;
                    My.Settings.PushEnabled = true;
                }
            }


            APIForm.AirAPICheck.CancelAsync();
            APIForm.Close();
            APIForm.combnum = 0;
            APIForm.PrevChk = "-1"; // 무조건 업데이트하도록
            APIForm.prevCombnum = -1;
            MainGUI.DrawState();
            APIForm.Activate();
            TrayForm.MainGUI_Open();


            if (StationName == null)
            {
                if (!CheckHisExist(false, loctext))
                    AddLocHistory_Axis(loctext, tm_co[0], tm_co[1]);
            }
            else if (!CheckHisExist(true, StationName))
                AddLocHistory_station(StationName);

            My.Settings.Save();
            My.Settings.Reload();


            this.Close();
        }
    }

    private void PictureBox1_Click(object sender, EventArgs e)
    {
        if (complete)
        {
            if (Interaction.MsgBox("지정한 위치가 적용되지 않았습니다. 그래도 닫으시겠습니까?", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbNo)
                goto endtask;
        }

        TrayForm.MainGUI_Open();
        this.Close();
    endtask:
        ;
    }

    private void CloseBT_MouseEnter(object sender, EventArgs e)
    {
        CloseBT.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.2);
    }

    private void CloseBT_MouseLeave(object sender, EventArgs e)
    {
        CloseBT.BackColor = Color.Transparent;
    }

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        if (x_num == null | y_num == null | !complete)
            Interaction.MsgBox("우선 위치를 지정해 주세요.", Constants.vbInformation);
        else
        {
            try
            {
                StationList.AirStationData = getNearStation(tm_co[0], tm_co[1]);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("측정소를 검색하던 도중 오류가 발생했습니다." + Constants.vbCr + "주소가 유효한지 확인해 주세요.", Constants.vbExclamation);
                StationList.ShowDialog(this);
                goto donothing;
            }

            StationList.ShowDialog(this);
        }



    donothing:
        ;
    }

    private void TextBox1_TextChanged(object sender, EventArgs e)
    {
        HelpText.Hide();
    }
}
