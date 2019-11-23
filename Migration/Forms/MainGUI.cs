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
    public partial class MainGUI : Form
    {
        // 슬라이딩 애니메이션 구현을 위한 임시변수
        private int poscount = 0;
        private bool ShowingMenu = false;
        private bool goUp = false;

        // 메뉴폼 Trans 애니메이션 구현을 위한 임시변수
        private int transnum = 0;
        private string titleStr = "";

        private Color themecol;
        private Color targcol = Color.FromArgb(49, 159, 158);
        private bool firstShwon = true;

        public MainGUI()
        {
            InitializeComponent();
        }

        // 페이드 효과 FadeIn에 시작프로그램 안내폼 표시 이벤트있음

        private void FadeInEffect(object sender, EventArgs e)
        {
            this.Refresh();
            FadeIn(this, 1);


            // ===시작프로그램안내폼===
            if (!My.Settings.StartupPopIgnore)
            {
                bool startupset = true;
                try
                {
                    startupset = checkStartUp();
                }
                catch (Exception ex)
                {
                    // 오류가 발생하면 아무것도 안하는걸로
                    startupset = false;
                }
                if (!startupset)
                {
                    StartupAsk.SetDesktopLocation(this.Location.X + this.Size.Width / (double)2 - StartupAsk.Size.Width / (double)2, this.Location.Y + this.Size.Height / (double)2 - StartupAsk.Size.Height / (double)2);
                    StartupAsk.Show();
                    StartupAsk.TopMost = true;
                }
            }
        }

        private void FadeOutEffect(object sender, EventArgs e)
        {
            FadeOut(this);
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

            // 디버그모드====================================
            // If My.Settings.APIFORM Then HistoryButton.Show()
            // =============================================

            DrawState();
            Opacity = 0;

            // 일단 초기로 메뉴패널을 비활성화하고 숨겨놓기
            ShowingMenu = false;
            MenuPanel.Visible = false;

            if (My.Settings.UseNativeFont)
                ChangeToNativeFont(this);

            if (My.Settings.widget_enabled)
                WidgetButton.Image = My.Resources.widget_2;
            else
                WidgetButton.Image = My.Resources.widget_1;

            int opttmp = Convert.ToInt32(Mid(My.Settings.FormPos, 1, 1));
            goUp = (opttmp == 1 | opttmp == 3);

            if (goUp)
                HideButton.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }

        public void ModeChange()
        {
            if (ShowingMenu)
            {
                if (My.Settings.AniEnabled)
                {
                    transnum = 0;
                    MenuPanel.Dock = DockStyle.Top;
                    MenuPanel.Height = 1;
                    Transani.Start();
                }
                else
                    MenuPanel.Dock = DockStyle.Fill;

                MenuPanel.Visible = true;
            }
            else if (My.Settings.AniEnabled)
            {
                transnum = 0;
                MenuPanel.Dock = DockStyle.Top;
                MenuPanel.Height = MainPanel.Height;
                Transani.Start();
            }
            else
                MenuPanel.Visible = false;
        }

        private void AirDetailLabel_Click(object sender, EventArgs e)
        {
            if (APIForm.combnum == -4)
                Process.Start("http://www.airkorea.or.kr/web/realSearch");
            else if (APIForm.combnum == -5)
                Process.Start("https://monzi.ze.am/help/qna#h.p_1xVTMpkeAAVn");
        }

        public void DrawState()
        {
            if (ShowingMenu == true)
            {
                ShowingMenu = false;
                ModeChange();
            }

            switch (APIForm.combnum)
            {
                case -5:
                    {
                        AirStateLabel.Text = "트래픽 초과";
                        AirCommentLabel.Text = "monZi 요청 트래픽 초과";
                        AirDetailLabel.Text = "서버 요청이 급격히 증가하여 현재 접근이 불가합니다." + Constants.vbCr + "(여기를 클릭하여 도움말 페이지 열기)";
                        titleStr = APIForm.guititle;
                        LocationLabel.Text = My.Settings.LocationName;
                        themecol = Color.FromArgb(49, 27, 146);
                        DashPic.Image = My.Resources.dash_maintenance;
                        break;
                    }

                case -4:
                    {
                        AirStateLabel.Text = "점검중";
                        AirCommentLabel.Text = "점검중/사용 불가 상태입니다";
                        AirDetailLabel.Text = "해당 측정소에서 대기 상태를 받아올 수 없습니다." + Constants.vbCr + "'측정소명으로 검색'을 통해 다른 측정소를 지정하세요." + Constants.vbCr + "(여기를 클릭하여 주변 측정소 정보 조회)";
                        titleStr = APIForm.guititle;
                        LocationLabel.Text = My.Settings.LocationName;
                        themecol = Color.FromArgb(49, 27, 146);
                        DashPic.Image = My.Resources.dash_maintenance;
                        break;
                    }

                case -3:
                    {
                        AirStateLabel.Text = "위치 설정";
                        AirCommentLabel.Text = "위치를 지정해 주세요";
                        titleStr = "monZi";
                        LocationLabel.Text = "여기를 눌러 위치를 지정";
                        AirDetailLabel.Text = "대기 상태를 업데이트 받을 위치를" + Constants.vbCr + "좌측 아래 위치명 부분을 눌러 설정하세요";
                        themecol = Color.FromArgb(55, 71, 79);
                        DashPic.Image = null;
                        break;
                    }

                case -2:
                    {
                        AirStateLabel.Text = "오프라인";
                        AirCommentLabel.Text = "인터넷에 연결되지 않았네요";
                        titleStr = "인터넷 연결 안됨";
                        LocationLabel.Text = "";
                        AirDetailLabel.Text = "인터넷 연결을 확인한 뒤 새로고침해 주세요" + Constants.vbCr + "(3분 간격으로 자동 체크합니다)";
                        themecol = Color.FromArgb(55, 71, 79);
                        DashPic.Image = null;
                        break;
                    }

                case -1:
                    {
                        AirStateLabel.Text = "오류";
                        AirCommentLabel.Text = "새로고침 혹은" + Constants.vbCr + "새로 위치를 지정해 보세요";
                        titleStr = "오류 발생";
                        LocationLabel.Text = "";
                        AirDetailLabel.Text = "인터넷 연결 문제, 혹은 측정소 점검" + Constants.vbCr + "등으로 인한 접근 제한이 원인일 수 있습니다." + Constants.vbCr + "(문제가 지속될시 업데이트를 확인하세요)";
                        themecol = Color.FromArgb(55, 71, 79);
                        DashPic.Image = null;
                        break;
                    }

                case 0:
                    {
                        firstShwon = false;
                        AirStateLabel.Text = "로드 중";
                        AirCommentLabel.Text = "잠시만 기다려 주세요";
                        titleStr = "로드 중";
                        LocationLabel.Text = "로드 중";
                        AirDetailLabel.Text = "정보를 불러오고 있는 중입니다.";
                        themecol = Color.FromArgb(55, 71, 79);
                        DashPic.Image = null;
                        break;
                    }

                case 1:
                    {
                        AirStateLabel.Text = "최고";
                        AirCommentLabel.Text = "신선한 공기 마음껏 마시세요~";
                        themecol = Color.FromArgb(30, 136, 229);
                        DashPic.Image = My.Resources.dash_1;
                        break;
                    }

                case 2:
                    {
                        AirStateLabel.Text = "좋음";
                        AirCommentLabel.Text = "환기하셔도 좋습니다!";
                        themecol = Color.FromArgb(43, 201, 207);

                        if (My.Settings.AirStd == "AK")
                            DashPic.Image = My.Resources.dash_1;
                        else
                            DashPic.Image = My.Resources.dash_2_8;
                        break;
                    }

                case 3:
                    {
                        AirStateLabel.Text = "양호";
                        AirCommentLabel.Text = "괜찮은 날이네요!";
                        themecol = Color.FromArgb(49, 159, 158);
                        DashPic.Image = My.Resources.dash_3_8;
                        break;
                    }

                case 4:
                    {
                        AirStateLabel.Text = "보통";
                        AirCommentLabel.Text = "그럭저럭 괜찮은 날이네요!";
                        themecol = Color.FromArgb(11, 182, 82);

                        if (My.Settings.AirStd == "AK")
                            DashPic.Image = My.Resources.dash_3_8;
                        else
                            DashPic.Image = My.Resources.dash_4_8;
                        break;
                    }

                case 5:
                    {
                        AirStateLabel.Text = "나쁨";
                        AirCommentLabel.Text = "열린 창문이 있다면 닫아주세요~";
                        themecol = Color.FromArgb(239, 108, 0);

                        if (My.Settings.AirStd == "AK")
                            DashPic.Image = My.Resources.dash_6_8;
                        else
                            DashPic.Image = My.Resources.dash_5_8;
                        break;
                    }

                case 6:
                    {
                        AirStateLabel.Text = "매우 나쁨";
                        AirCommentLabel.Text = "외출시 마스크 꼭 챙기세요!";
                        themecol = Color.FromArgb(229, 57, 53);

                        if (My.Settings.AirStd == "AK")
                            DashPic.Image = My.Resources.dash_2;
                        else
                            DashPic.Image = My.Resources.dash_6_8;
                        break;
                    }

                case 7:
                    {
                        AirStateLabel.Text = "극도로 나쁨";
                        AirCommentLabel.Text = "주의해 주세요!";
                        themecol = Color.FromArgb(86, 9, 7);
                        DashPic.Image = My.Resources.dash_7_8;
                        break;
                    }

                case 8:
                    {
                        AirStateLabel.Text = "최악";
                        AirCommentLabel.Text = "가능하다면 외출을 삼가주세요!";
                        themecol = Color.FromArgb(18, 18, 18);
                        DashPic.Image = My.Resources.dash_2;
                        break;
                    }
            }

            string pm10lvl = "-";
            string pm25lvl = "-";

            switch (APIForm.pm10gnum)
            {
                case 1:
                    {
                        pm10lvl = "최고";
                        break;
                    }

                case 2:
                    {
                        pm10lvl = "좋음";
                        break;
                    }

                case 3:
                    {
                        pm10lvl = "양호";
                        break;
                    }

                case 4:
                    {
                        pm10lvl = "보통";
                        break;
                    }

                case 5:
                    {
                        pm10lvl = "나쁨";
                        break;
                    }

                case 6:
                    {
                        pm10lvl = "매우 나쁨";
                        break;
                    }

                case 7:
                    {
                        pm10lvl = "극도로 나쁨";
                        break;
                    }

                case 8:
                    {
                        pm10lvl = "최악";
                        break;
                    }
            }

            switch (APIForm.pm25gnum)
            {
                case 1:
                    {
                        pm25lvl = "최고";
                        break;
                    }

                case 2:
                    {
                        pm25lvl = "좋음";
                        break;
                    }

                case 3:
                    {
                        pm25lvl = "양호";
                        break;
                    }

                case 4:
                    {
                        pm25lvl = "보통";
                        break;
                    }

                case 5:
                    {
                        pm25lvl = "나쁨";
                        break;
                    }

                case 6:
                    {
                        pm25lvl = "매우 나쁨";
                        break;
                    }

                case 7:
                    {
                        pm25lvl = "극도로 나쁨";
                        break;
                    }

                case 8:
                    {
                        pm25lvl = "최악";
                        break;
                    }
            }

            if (My.Settings.FadeEnabled & !firstShwon)
            {
                targcol = themecol;
                ColorTrans.Start();
            }
            else
            {
                firstShwon = false;
                SetColor(themecol);
            }

            if (!(APIForm.combnum == 0 | APIForm.combnum == -1 | APIForm.combnum == -2 | APIForm.combnum == -3 | APIForm.combnum == -4 | APIForm.combnum == -5))
            {
                titleStr = APIForm.guititle;
                LocationLabel.Text = My.Settings.LocationName;
                AirDetailLabel.Text = "미세먼지(pm10): " + APIForm.pm10num + "㎍/㎥ (" + pm10lvl + ")"
                    + Constants.vbCr + "초미세먼지(pm2.5): " + APIForm.pm25num + "㎍/㎥ (" + pm25lvl + ")" + Constants.vbCr; // _
                                                                                                                      // + "마지막 측정: " + APIForm.NowChk
                UpdateLabel.Text = "업데이트: " + APIForm.APIupdTime + Constants.vbCr + "측정: " + Convert.ToInt16(Mid(APIForm.NowChk, 9, 2)).ToString + "일 " + Mid(APIForm.NowChk, 12);
            }
            else if (APIForm.combnum == 0)
                UpdateLabel.Text = "업데이트 중";
            else
                UpdateLabel.Text = "업데이트" + Constants.vbCr + "되지 않음";

            TitleLabel.Text = titleStr;

            if (!My.Settings.CustomAPI == null/* TODO Change to default(_) if this is not a reference type */ )
                LocationLabel.Text = My.Settings.CustomAPI;

            this.ValidateChildren();
        }

        private void SetColor(Color col)
        {
            MainPanel.BackColor = col;
            ListButton.BackColor = col;
            HideButton.BackColor = col;
            HistoryButton.BackColor = col;
            BottomPanel.BackColor = ControlPaint.Dark(col, 0.2);
            MenuPanel.BackColor = ControlPaint.Dark(col, 0.01);
            Menu_BT1.BackColor = col;
            Menu_BT2.BackColor = col;
            Menu_BT3.BackColor = col;
            Menu_BT4.BackColor = col;
            BottomBT1_Panel.BackColor = Color.Transparent;
            BottomBT2_Panel.BackColor = Color.Transparent;
        }

        private void hideani_Tick(object sender, EventArgs e)
        {
            if (poscount >= 15)
            {
                this.Opacity = 0;
                poscount = 0;
                hideani.Stop();
                this.Close();
            }
            else
            {
                if (goUp)
                    SetDesktopLocation(Location.X, Location.Y - dpicalc(this, poscount));
                else
                    SetDesktopLocation(Location.X, Location.Y + dpicalc(this, poscount));

                poscount += 1;
                Opacity -= 1 / (double)15;
            }
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            TopMost = false;

            if (My.Settings.AniEnabled)
                hideani.Start();
            else
                this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

            // 커스텀API 설정시에는 위치설정 X
            if (!My.Settings.CustomAPI == null/* TODO Change to default(_) if this is not a reference type */ )
            {
                Interaction.MsgBox("사용자 지정 API를 해제한 후 변경하실 수 있습니다", Constants.vbInformation);
                goto endtask;
            }

            if (!(My.Settings.LocationName == null/* TODO Change to default(_) if this is not a reference type */))
            {
                if (MsgBox("기존에 설정된 위치(" + My.Settings.LocationName + ")를 변경하시겠습니까?", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbNo)
                    goto endtask;
            }

            this.TopMost = false;

            Point mouseloc = new Point(Cursor.Position.X, Cursor.Position.Y);
            int marign = dpicalc(this, 10);

            var showx = Screen.GetWorkingArea(mouseloc).Width - LocationSet.Width - marign;
            var showy = Screen.GetWorkingArea(mouseloc).Height - LocationSet.Height - marign;
            LocationSet.SetDesktopLocation(showx, showy);

            LocationSet.Show();
            this.Close();
            endtask:
            ;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (!APIForm.combnum == -3)
            {
                UpdateLabel.Text = "업데이트 중";
                APIForm.AirAPICheck.CancelAsync();
                APIForm.Close();
                APIForm.PrevChk = "-1"; // 무조건 업데이트하도록
                DrawState();
                APIForm.Activate();
            }
            else
                Interaction.MsgBox("위치를 지정한 뒤 업데이트를 해 주세요.", Constants.vbInformation);
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            PictureBox obj = sender;
            obj.BackColor = ControlPaint.Light(MainPanel.BackColor, 0.2);

            string helptext = "";

            switch (obj.Name)
            {
                case "HideButton":
                    {
                        helptext = "숨김";
                        break;
                    }

                case "ListButton":
                    {
                        helptext = "메뉴";
                        break;
                    }

                case "HistoryButton":
                    {
                        helptext = "이전 위치";
                        break;
                    }

                case "WidgetButton":
                    {
                        if (My.Settings.widget_enabled)
                            helptext = "위젯 숨기기";
                        else
                            helptext = "위젯 표시하기";
                        break;
                    }
            }

            TitleLabel.Text = helptext;
            MenuTitle.Text = helptext;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            PictureBox obj = sender;
            obj.BackColor = Color.Transparent;
            TitleLabel.Text = titleStr;
            MenuTitle.Text = "메뉴";
        }

        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            object obj = sender;

            if (obj.Name == "CloseLabel" | obj.Name == "CloseButton")
            {
                CloseLabel.BackColor = ControlPaint.Light(MenuPanel.BackColor, 0.2);
                CloseButton.BackColor = ControlPaint.Light(MenuPanel.BackColor, 0.2);
            }
            else
                obj.BackColor = ControlPaint.Light(MenuPanel.BackColor, 0.2);

            string helptext = "";

            switch (obj.Name)
            {
                case "ListButton2":
                    {
                        helptext = "메인 화면";
                        break;
                    }

                case "CloseButton":
                    {
                        helptext = "monZi 종료";
                        break;
                    }

                case "CloseLabel":
                    {
                        helptext = "monZi 종료";
                        break;
                    }
            }

            TitleLabel.Text = helptext;
            MenuTitle.Text = helptext;
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            object obj = sender;

            if (obj.Name == "CloseLabel" | obj.Name == "CloseButton")
            {
                CloseLabel.BackColor = Color.Transparent;
                CloseButton.BackColor = Color.Transparent;
            }
            else
                obj.BackColor = Color.Transparent;

            TitleLabel.Text = titleStr;
            MenuTitle.Text = "메뉴";
        }

        private void BottomButton1_MouseEnter(object sender, EventArgs e)
        {
            BottomBT1_Panel.BackColor = ControlPaint.Light(BottomPanel.BackColor, 0.2);
            string helptext = "위치 설정/변경";

            TitleLabel.Text = helptext;
            MenuTitle.Text = helptext;
        }

        private void BottomButton1_MouseLeave(object sender, EventArgs e)
        {
            BottomBT1_Panel.BackColor = Color.Transparent;
            TitleLabel.Text = titleStr;
            MenuTitle.Text = "메뉴";
        }

        private void BottomButton2_MouseEnter(object sender, EventArgs e)
        {
            BottomBT2_Panel.BackColor = ControlPaint.Light(BottomPanel.BackColor, 0.2);
            string helptext = "대기 정보 업데이트";

            TitleLabel.Text = helptext;
            MenuTitle.Text = helptext;
        }

        private void BottomButton2_MouseLeave(object sender, EventArgs e)
        {
            BottomBT2_Panel.BackColor = Color.Transparent;
            TitleLabel.Text = titleStr;
            MenuTitle.Text = "메뉴";
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            if (ShowingMenu == false)
                ShowingMenu = true;
            else
                ShowingMenu = false;

            ModeChange();
        }

        private void Transani_Tick(object sender, EventArgs e)
        {
            if (ShowingMenu)
            {
                if ((MenuPanel.Height + transnum <= MainPanel.Height))
                {
                    transnum += dpicalc(this, 2);
                    MenuPanel.Height += transnum;
                }
                else
                {
                    MenuPanel.Dock = DockStyle.Fill;
                    Transani.Stop();
                }
            }
            else if ((MenuPanel.Height - transnum >= 1))
            {
                transnum += dpicalc(this, 2);
                MenuPanel.Height -= transnum;
            }
            else
            {
                MenuPanel.Visible = false;
                ShowingMenu = false;
                MenuPanel.Dock = DockStyle.Top;
                Transani.Stop();
            }
        }

        private void MenuButtons_MouseEnter(object sender, EventArgs e)
        {
            PictureBox btobj = sender;
            btobj.BackColor = ControlPaint.Light(MainPanel.BackColor, 0.2);
        }

        private void MenuButtons_MouseLeave(object sender, EventArgs e)
        {
            PictureBox btobj = sender;
            btobj.BackColor = MainPanel.BackColor;
        }

        private void Menu_BT1_Click(object sender, EventArgs e)
        {
            OptionForm.Show();
        }

        private void Menu_BT3_Click(object sender, EventArgs e)
        {
            this.TopMost = false;

            Point mouseloc = new Point(Cursor.Position.X, Cursor.Position.Y);
            int marign = dpicalc(this, 10);

            var showx = Screen.GetWorkingArea(mouseloc).Width - UpdateForm.Width - marign;
            var showy = Screen.GetWorkingArea(mouseloc).Height - UpdateForm.Height - marign;
            UpdateForm.SetDesktopLocation(showx, showy);

            FadeOut(this);
            Hide();
            UpdateForm.Show();
        }

        private void Menu_BT2_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("도움말 페이지로 이동하시겠습니까?", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbYes)
                Process.Start("http://help.monzi-host.ze.am");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            FadeOut(this);
            TrayForm.Close();
        }

        private void Menu_BT4_Click(object sender, EventArgs e)
        {
            this.TopMost = false;

            Point mouseloc = new Point(Cursor.Position.X, Cursor.Position.Y);
            int marign = dpicalc(this, 10);

            var showx = Screen.GetWorkingArea(mouseloc).Width - about.Width - marign;
            var showy = Screen.GetWorkingArea(mouseloc).Height - about.Height - marign;
            about.SetDesktopLocation(showx, showy);

            FadeOut(this);
            Hide();
            about.Show();
        }

        private void RecentLocButton_Click(object sender, EventArgs e)
        {

            // 커스텀API 설정시에는 위치설정 X
            if (!My.Settings.CustomAPI == null/* TODO Change to default(_) if this is not a reference type */ )
            {
                Interaction.MsgBox("사용자 지정 API를 해제한 후 변경하실 수 있습니다", Constants.vbInformation);
                goto endtask;
            }

            this.TopMost = false;

            Point mouseloc = new Point(Cursor.Position.X, Cursor.Position.Y);
            int marign = dpicalc(this, 10);

            var showx = Screen.GetWorkingArea(mouseloc).Width - LocList.Width - marign;
            var showy = Screen.GetWorkingArea(mouseloc).Height - LocList.Height - marign;
            LocList.SetDesktopLocation(showx, showy);

            FadeOut(this);
            LocList.Show();
            this.Close();

            endtask:
            ;
        }

        private void WidgetButton_Click(object sender, EventArgs e)
        {
            // Application.OpenForms().OfType(Of WidgetGUI).Any
            if (My.Settings.widget_enabled)
            {
                // 설정 활성화시에
                My.Settings.widget_enabled = false;
                WidgetButton.Image = My.Resources.widget_1;
                WidgetGUI.Close();
            }
            else
            {
                // 비활성화시에
                My.Settings.widget_enabled = true;
                WidgetButton.Image = My.Resources.widget_2;
                WidgetGUI.Show();
            }

            My.Settings.Save();
            My.Settings.Reload();
        }

        private void ColorTrans_Tick(object sender, EventArgs e)
        {
            Color nowcol = MainPanel.BackColor;
            int delta = 7;

            var CR = Convert.ToInt16(nowcol.R);
            var CG = Convert.ToInt16(nowcol.G);
            var CB = Convert.ToInt16(nowcol.B);

            if (CR > Convert.ToInt16(targcol.R))
            {
                CR -= delta;
                if (CR < Convert.ToInt16(targcol.R))
                    CR = Convert.ToInt16(targcol.R);
            }
            else if (CR < Convert.ToInt16(targcol.R))
            {
                CR += delta;
                if (CR > Convert.ToInt16(targcol.R))
                    CR = Convert.ToInt16(targcol.R);
            }

            if (CG > Convert.ToInt16(targcol.G))
            {
                CG -= delta;
                if (CG < Convert.ToInt16(targcol.G))
                    CG = Convert.ToInt16(targcol.G);
            }
            else if (CG < Convert.ToInt16(targcol.G))
            {
                CG += delta;
                if (CG > Convert.ToInt16(targcol.G))
                    CG = Convert.ToInt16(targcol.G);
            }

            if (CB > Convert.ToInt16(targcol.B))
            {
                CB -= delta;
                if (CB < Convert.ToInt16(targcol.B))
                    CB = Convert.ToInt16(targcol.B);
            }
            else if (CB < Convert.ToInt16(targcol.B))
            {
                CB += delta;
                if (CB > Convert.ToInt16(targcol.B))
                    CB = Convert.ToInt16(targcol.B);
            }

            // TitleLabel.Text = CR.ToString + ", " + CG.ToString + ", " + CB.ToString
            SetColor(Color.FromArgb(CR, CG, CB));

            if (CR == Convert.ToInt16(targcol.R) & CG == Convert.ToInt16(targcol.G) & CB == Convert.ToInt16(targcol.B))
                ColorTrans.Stop();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {
            ColorTrans.Start();
        }

    }
}
