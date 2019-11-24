using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class APIForm : Form
    {

        private int PrevHour = -1; // 0으로 해버리면 12시(00시)때 아예 되질 않으니 주의!!!
        public string PrevChk = "-1";
        public string NowChk = null;
        private int PrevGrade = 0;

        public string APIupdTime = null;

        private bool Checking = false; // 체킹 여부
        private bool APIOK = false; // 성공적 수집 여부
        private string station = null; // 측정소의 이름

        public string airData = null;

        public string pm10num = "-";
        public string pm25num = "-";

        public int pm10gnum = 0;
        public int pm25gnum = 0;

        public int combnum = 0; // 대기 등급을 비교하여 산출하는 최종값 (ErrorLevel로도 쓰임!!)
        public int prevCombnum = 0; // 업데이트 직전의 산출값 (값이 다를시 푸시알림 뜨도록 하기)
        public string combgrade = "오류";
        public string combcomment = "값을 불러오지 못했습니다";
        public Color themecol;
        public string guititle = "현재 대기";

        public APIForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TrayForm.MainGUI_Open();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LocationSet.Show();
        }

        private void PCTimeCheck_Tick(object sender, EventArgs e)
        {
            // If customapilink.Checked Then '커스텀API여부
            // Label1.Text = "ok"
            // PCTimeCheck.Interval = 5000
            // 
            // 
            // '여기는 디버깅 항목!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // 
            // 
            // 
            // Checking = True
            // CombinedAPICheck()
            // 
            // 
            // 
            // '여기는 디버깅 항목!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // 
            // Else

            PCTimeCheck.Interval = 5000;
            // 체크여부를 확인 (5초 간격)
            if (My.Settings.ChkEnabled)
            {
                if (!(DateTime.Now.Hour == PrevHour))
                {
                    if (!Checking)
                    {
                        Checking = true;
                        CombinedAPICheck();
                    }
                }
                PrevHour = DateTime.Now.Hour;
            }
            else
                // 실시간 체킹을 안할 때

                if (airData == null)
            {
                if (!Checking)
                {
                    Checking = true;
                    CombinedAPICheck();
                }
            }
        }

        public void CombinedAPICheck()
        {
            AirAPICheck.CancelAsync();

            TrayForm.trayico_selector();
            // PrevChk = -1일 경우: 수동으로 리프레시 버튼 누름, 수동으로 재탐색
            if (PrevChk == "-1")
                AirAPICheck.RunWorkerAsync();

            // 정시에 과다하게 몰리지 않게 3분 - 4분으로 랜덤 간격 잡기
            Random r = new Random();
            APICheck.Interval() = r.Next(180000, 240000);
            APICheck.Start();
        }

        private void APICheck_Tick(object sender, EventArgs e)
        {
            AirAPICheck.RunWorkerAsync();
        }

        public void AirCheck()
        {
            try
            {
                pm10num = Convert.ToInt32(getData(airData, "pm10Value"));
            }
            catch
            {
            }

            try
            {
                pm25num = Convert.ToInt32(getData(airData, "pm25Value"));
            }
            catch
            {
            }

            try
            {
                guititle = getData(airData, "mangName") + " - " + station;
            }
            catch (Exception ex)
            {
            }

            if (Information.IsNumeric(pm10num))
            {
                if (My.Settings.AirStd == "AK")
                {
                    switch (Convert.ToInt32(pm10num))
                    {
                        case object _ when Convert.ToInt32(pm10num) <= 30:
                            {
                                pm10gnum = 2;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm10num) <= 80:
                            {
                                pm10gnum = 4;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm10num) <= 150:
                            {
                                pm10gnum = 5;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm10num) >= 151:
                            {
                                pm10gnum = 6;
                                break;
                            }
                    }
                }
                else
                    switch (Convert.ToInt32(pm10num))
                    {
                        case object _ when Convert.ToInt32(pm10num) <= 15:
                            {
                                pm10gnum = 1;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm10num) <= 30:
                            {
                                pm10gnum = 2;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm10num) <= 40:
                            {
                                pm10gnum = 3;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm10num) <= 50:
                            {
                                pm10gnum = 4;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm10num) <= 75:
                            {
                                pm10gnum = 5;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm10num) <= 100:
                            {
                                pm10gnum = 6;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm10num) <= 150:
                            {
                                pm10gnum = 7;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm10num) >= 151:
                            {
                                pm10gnum = 8;
                                break;
                            }
                    }
            }

            if (Information.IsNumeric(pm25num))
            {
                if (My.Settings.AirStd == "AK")
                {
                    switch (Convert.ToInt32(pm25num))
                    {
                        case object _ when Convert.ToInt32(pm25num) <= 15:
                            {
                                pm25gnum = 2;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm25num) <= 35:
                            {
                                pm25gnum = 4;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm25num) <= 75:
                            {
                                pm25gnum = 5;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm25num) >= 76:
                            {
                                pm25gnum = 6;
                                break;
                            }
                    }
                }
                else
                    switch (Convert.ToInt32(pm25num))
                    {
                        case object _ when Convert.ToInt32(pm25num) <= 8:
                            {
                                pm25gnum = 1;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm25num) <= 15:
                            {
                                pm25gnum = 2;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm25num) <= 20:
                            {
                                pm25gnum = 3;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm25num) <= 25:
                            {
                                pm25gnum = 4;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm25num) <= 37:
                            {
                                pm25gnum = 5;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm25num) <= 50:
                            {
                                pm25gnum = 6;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm25num) <= 75:
                            {
                                pm25gnum = 7;
                                break;
                            }

                        case object _ when Convert.ToInt32(pm25num) >= 76:
                            {
                                pm25gnum = 8;
                                break;
                            }
                    }
            }

            if (pm10num == "-" & pm25num == "-")
                combnum = -4;
            else if (pm10gnum >= pm25gnum)
                combnum = pm10gnum;
            else
                combnum = pm25gnum;

            if (airData.Contains("#CUSTOMAPI#"))
            {
                if (airData.Contains("<stationName>"))
                    guititle += getData(airData, "stationName") + " ";
                guititle += "(사용자 지정)";
            }
        }

        public void PushCheck()
        {

            // 설정 비활성화시 취소
            if (My.Settings.PushEnabled == false | My.Settings.ChkEnabled == false)
                goto endtask;

            // 메인GUI가 열려 있지 않을시에만 푸시 알림이 보여지도록 함
            if (Application.OpenForms().OfType<MainGUI>.Any)
                goto endtask;

            // ======여기서부터 푸시 코드 시작======
            if (prevCombnum == combnum & My.Settings.PushIgnore == true)
                goto endtask;

            // 여기로까지 내려오는 CASE:
            // 무시옵션이 비활성화 or 무시옵션 있는데 이전State와 다름

            string pushlist = My.Settings.PushList;
            if (pushlist == null)
                goto endtask;

            switch (combnum)
            {
                case -2 | -1 // 오류시
               :
                    {
                        if (!pushlist.Contains("e"))
                            goto endtask;
                        break;
                    }

                case -4 // 오류 아닌 점검
         :
                    {
                        if (!pushlist.Contains("e"))
                            goto endtask;
                        break;
                    }

                case 1 // 최고
         :
                    {
                        if (!pushlist.Contains("1"))
                            goto endtask;
                        break;
                    }

                case 2 // 좋음
         :
                    {
                        if (!pushlist.Contains("2"))
                            goto endtask;
                        break;
                    }

                case 3 // 양호
         :
                    {
                        if (!pushlist.Contains("3"))
                            goto endtask;
                        break;
                    }

                case 4 // 보통
         :
                    {
                        if (!pushlist.Contains("4"))
                            goto endtask;
                        break;
                    }

                case 5 // 나쁨
         :
                    {
                        if (!pushlist.Contains("5"))
                            goto endtask;
                        break;
                    }

                case 6 // 매우 나쁨
         :
                    {
                        if (!pushlist.Contains("6"))
                            goto endtask;
                        break;
                    }

                case 7 // 극도로 나쁨
         :
                    {
                        if (!pushlist.Contains("7"))
                            goto endtask;
                        break;
                    }

                case 8 // 최악
         :
                    {
                        if (!pushlist.Contains("8"))
                            goto endtask;
                        break;
                    }

                default:
                    {
                        goto endtask;
                        break;
                    }
            }

            Show_Popup();

            endtask:
            ;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AirAPICheck.RunWorkerAsync();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            combnum = NumericUpDown1.Value;
            MainGUI.DrawState();
            WidgetGUI.DrawState();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            My.Settings.ChkEnabled = CheckBox1.Checked;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            My.Settings.Reset();
            My.Settings.Save();
            TrayForm.Close();
        }

        public void Show_Popup()
        {
            PopUpForm.Close();
            int marign = dpicalc(this, 10);
            var showx = 0;
            var showy = 0;

            switch (Convert.ToInt32(Mid(My.Settings.FormPos, 2, 1)))
            {
                case 0 // 우하단
               :
                    {
                        showx = Screen.PrimaryScreen.WorkingArea.Width - PopUpForm.Width - marign;
                        showy = Screen.PrimaryScreen.WorkingArea.Height - PopUpForm.Height - marign;
                        break;
                    }

                case 1 // 우상단
         :
                    {
                        showx = Screen.PrimaryScreen.WorkingArea.Width - PopUpForm.Width - marign;
                        showy = marign;
                        break;
                    }

                case 2 // 좌하단
         :
                    {
                        showx = marign;
                        showy = Screen.PrimaryScreen.WorkingArea.Height - PopUpForm.Height - marign;
                        break;
                    }

                case 3 // 좌상단
         :
                    {
                        showx = marign;
                        showy = marign;
                        break;
                    }
            }


            PopUpForm.SetDesktopLocation(showx, showy);
            PopUpForm.Show();
        }

        private void AirAPICheck_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            APIOK = true;


            if (!My.Computer.Network.IsAvailable)
            {
                combnum = -2;
                APIOK = false;
                goto endtask;
            }

            try
            {

                // 디버깅 항목!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                if (!My.Settings.CustomAPI == null/* TODO Change to default(_) if this is not a reference type */ )
                {
                    airData = webget(My.Settings.CustomAPI) + "#CUSTOMAPI#";
                    goto passforDEBUGING;
                }
                // 디버깅 항목!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


                // 실질적 에어데이터는 여기서 수집함!!! (변화여부를 파악해야 하므로)
                if (!(My.Settings.StationName == null/* TODO Change to default(_) if this is not a reference type */))
                    station = My.Settings.StationName;
                else if (!(My.Settings.LocationPoint_X == null/* TODO Change to default(_) if this is not a reference type */ | My.Settings.LocationPoint_Y == null/* TODO Change to default(_) if this is not a reference type */))
                {
                    if (station == null)
                    {
                        station = getData(getNearStation(My.Settings.LocationPoint_X, My.Settings.LocationPoint_Y), "stationName");
                        My.Settings.StationName = station;
                        My.Settings.Save();
                        My.Settings.Reload();
                    }
                }


                airData = getairinfo(station);

                // MsgBox(airData)

                passforDEBUGING:
                ;
                APIupdTime = DateTime.Now.Day.ToString() + "일 " + DateTime.Now.ToString("HH:mm:ss");
                NowChk = getData(airData, "dataTime");
            }
            catch (Exception ex)
            {
                APIOK = false;
                combnum = -1;
            }

            endtask:
            ;
        }

        private void AirAPICheck_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

            // 여기는 결과값 판별 영역
            if (APIOK)
            {
                string[] AirChkHour = NowChk.Split(" ");
                AirChkHour = AirChkHour[1].Split(":");
                // MsgBox(AirChkHour(0)) '업데이트의 시간대를 가져옴

                if (AirChkHour[0] == "24")
                    AirChkHour[0] = "00";
                // 에어체크의 API가 00(오전12)시를 24시로 표시해서 이렇게 바꿔주어야함

                // 값이 바뀌든 말든 일단 API 불러온겸 그리도록 하기
                AirCheck();

                // 현재 공기를 체크한 PC시간과(24시) 실제 측정소의 측정기준시간(24시)이 같을 경우
                if (AirChkHour[0] == DateTime.Now.ToString("HH"))
                {
                    PrevChk = NowChk;
                    // 체크 완료하였으므로 멈춤 ->다시 정각때까지 대기
                    Checking = false;
                    APICheck.Stop();
                }
                else if (My.Settings.ChkEnabled == false)
                {
                    PrevChk = NowChk;
                    // 체크 완료하였으므로 멈춤 ->새로고침 명령이 없다면 절대 업뎃 X
                    Checking = false;
                    APICheck.Stop();
                }
                else if (combnum == -4)
                {
                    PrevChk = NowChk;
                    // API 호출 과부하를 막기 위해 업데이트 중지
                    Checking = false;
                    APICheck.Stop();
                }
            }
            else
                // 오류발생 (그런데 erlevel을 앞서 다 combnum에 줘서 특별한 조치 필요없음)
                // 타이머를 멈추지 않음으로써 오류가 일어나면 미리 설정된 인터벌마다 다시 시도하도록 하기

                // API서버 트래픽 초과
                if (!airData == null)
            {
                if (airData.Contains("resultCode"))
                {
                    if (getData(airData, "resultCode") == "22")
                    {
                        combnum = -5;
                        APICheck.Stop();
                    }
                }
            }

            // 메인GUI의 폼을 그리고 트레이도 새로고침
            MainGUI.DrawState();
            TrayForm.trayico_selector();
            if (My.Settings.widget_enabled)
                WidgetGUI.DrawState();

            // 여기서부터는 푸시 알림 영역
            PushCheck();

            // 이전의 상태 넘버를 저장해야함
            prevCombnum = combnum;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            TrayForm.Close();
        }

        private void APIForm_Load(object sender, EventArgs e)
        {
            CheckBox1.Checked = My.Settings.ChkEnabled;
            CheckBox2.Checked = My.Settings.PushEnabled;
            customapibox.Text = My.Settings.CustomAPI;
            userapikeybox.Text = My.Settings.USERAPIKEY;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Show_Popup();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            My.Settings.PushEnabled = CheckBox2.Checked;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox(Checking);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            throw new System.Exception("APIForm 테스트 예외 발생");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            My.Settings.USERAPIKEY = userapikeybox.Text;
            My.Settings.Save();
            My.Settings.Reload();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (!airData.Contains("<resultCode>"))
                Interaction.MsgBox("monZiAPI");
            else
                Interaction.MsgBox("AirKorea");
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Label1.Text = "changed";
            My.Settings.CustomAPI = customapibox.Text;
            My.Settings.Save();
            My.Settings.Reload();
        }
    }
}
