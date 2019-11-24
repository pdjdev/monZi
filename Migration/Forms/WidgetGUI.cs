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
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1.Forms
{
    public partial class WidgetGUI : Form
    {
        private Point loc;

        private Color themecol;
        private Color targcol = Color.FromArgb(49, 159, 158);

        public WidgetGUI()
        {
            InitializeComponent();
        }

        private void FadeInEffect(object sender, EventArgs e)
        {
            this.Refresh();
            FadeIn(this, My.Settings.widget_opacity);
        }

        private void FadeOutEffect(object sender, EventArgs e)
        {
            FadeOut(this);
        }



        private const int mSnapOffset = 30;
        private const int WM_WINDOWPOSCHANGING = 0x46;

        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWPOS
        {
            public IntPtr hwnd;
            public IntPtr hwndInsertAfter;
            public int x;
            public int y;
            public int cx;
            public int cy;
            public int flags;
        }

        protected override void WndProc(ref Message m)
        {
            // Listen for operating system messages
            switch (m.Msg)
            {
                case WM_WINDOWPOSCHANGING:
                    {
                        if (My.Settings.widget_stick)
                            SnapToDesktopBorder(this, m.LParam, 0);
                        break;
                    }
            }

            base.WndProc(m);
        }


        private void WidgetGUI_Load(object sender, EventArgs e)
        {
            bool isDisplayAvailable = false;

            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.DeviceName == My.Settings.widget_display)
                {
                    this.Location = scrn.Bounds.Location;
                    isDisplayAvailable = true;
                    break;
                }
            }

            Location = My.Settings.widget_position;
            if (!IsOnScreen(this))
                Location = new Point(100, 100); // 디스플레이 범위 밖일시 걍 초기화

            Opacity = 0;
            lockChk();
            DrawState();
        }

        private void Form_DoubleClick(object sender, MouseEventArgs e)
        {
            TrayForm.MainGUI_Open();
        }

        private void FormDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == Windows.Forms.MouseButtons.Left & !My.Settings.widget_locked)
                loc = e.Location;
        }

        private void FormDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == Windows.Forms.MouseButtons.Left & !My.Settings.widget_locked)
                this.Location += e.Location - loc;
        }

        private void FormDrag_MouseUp(object sender, MouseEventArgs e)
        {
            My.Settings.widget_position = Location;
            My.Settings.widget_display = Screen.FromControl(this).DeviceName;
            My.Settings.Save();
            My.Settings.Reload();
        }

        private void BT_MouseEnter(object sender, EventArgs e)
        {
            sender.BackColor = ControlPaint.Light(MainPanel.BackColor, 0.5);
        }

        private void BT_MouseLeave(object sender, EventArgs e)
        {
            sender.BackColor = MainPanel.BackColor;
        }

        private void LockBT_Click(object sender, EventArgs e)
        {
            My.Settings.widget_locked = !My.Settings.widget_locked;

            lockChk();
        }

        private void lockChk()
        {
            if (My.Settings.widget_locked)
                LockBT.Image = My.Resources.lockicon_1;
            else
                LockBT.Image = My.Resources.lockicon_2;
        }

        // 상태 그리기
        public void DrawState()
        {
            DashPic.Image = null;

            switch (APIForm.combnum)
            {
                case -4:
                    {
                        AirStateLabel.Text = "점검중";
                        AirDetailLabel.Text = "해당 측정소에서 대기 상태를" + Constants.vbCr + "받아올 수 없습니다." + Constants.vbCr + "메인 창을 열어 장소를 변경하세요.";
                        TitleLabel.Text = APIForm.guititle;
                        themecol = Color.FromArgb(49, 27, 146);
                        DashPic.Image = My.Resources.dash_maintenance;
                        Icon = My.Resources.ico_er;
                        break;
                    }

                case -3:
                    {
                        AirStateLabel.Text = "위치 설정";
                        AirDetailLabel.Text = "메인 창을 열어" + Constants.vbCr + "위치를 지정해 주세요";
                        themecol = Color.FromArgb(55, 71, 79);
                        break;
                    }

                case -2:
                    {
                        TitleLabel.Text = "monZi 오류";
                        AirStateLabel.Text = "오프라인";
                        AirDetailLabel.Text = "인터넷 연결을 확인한 뒤" + Constants.vbCr + "새로고침해 주세요" + Constants.vbCr + "(3분 간격으로 자동 체크합니다)";
                        themecol = Color.FromArgb(55, 71, 79);
                        Icon = My.Resources.ico_er;
                        break;
                    }

                case -1:
                    {
                        TitleLabel.Text = "monZi 오류";
                        AirStateLabel.Text = "오류 발생";
                        AirDetailLabel.Text = "인터넷 연결 문제, 혹은 측정소 점검 등으로 인한 접근 제한이 원인일 수 있습니다.";
                        themecol = Color.FromArgb(55, 71, 79);
                        Icon = My.Resources.ico_er;
                        break;
                    }

                case 0:
                    {
                        AirStateLabel.Text = "로드 중";
                        AirDetailLabel.Text = "이 상태가 지속된다면" + Constants.vbCr + "프로그램을 다시 시작해 주세요";
                        themecol = Color.FromArgb(55, 71, 79);
                        break;
                    }

                case 1:
                    {
                        AirStateLabel.Text = "최고";
                        themecol = Color.FromArgb(30, 136, 229);
                        DashPic.Image = My.Resources.dash_1;
                        Icon = My.Resources.ico_gr1;
                        break;
                    }

                case 2:
                    {
                        AirStateLabel.Text = "좋음";
                        themecol = Color.FromArgb(43, 201, 207);

                        if (My.Settings.AirStd == "AK")
                            DashPic.Image = My.Resources.dash_1;
                        else
                            DashPic.Image = My.Resources.dash_2_8;

                        Icon = My.Resources.ico_gr2;
                        break;
                    }

                case 3:
                    {
                        AirStateLabel.Text = "양호";
                        themecol = Color.FromArgb(49, 159, 158);
                        DashPic.Image = My.Resources.dash_3_8;
                        Icon = My.Resources.ico_gr3;
                        break;
                    }

                case 4:
                    {
                        AirStateLabel.Text = "보통";
                        themecol = Color.FromArgb(11, 182, 82);

                        if (My.Settings.AirStd == "AK")
                            DashPic.Image = My.Resources.dash_3_8;
                        else
                            DashPic.Image = My.Resources.dash_4_8;

                        Icon = My.Resources.ico_gr4;
                        break;
                    }

                case 5:
                    {
                        AirStateLabel.Text = "나쁨";
                        themecol = Color.FromArgb(239, 108, 0);

                        if (My.Settings.AirStd == "AK")
                            DashPic.Image = My.Resources.dash_6_8;
                        else
                            DashPic.Image = My.Resources.dash_5_8;

                        Icon = My.Resources.ico_gr5;
                        break;
                    }

                case 6:
                    {
                        AirStateLabel.Text = "매우 나쁨";
                        themecol = Color.FromArgb(229, 57, 53);

                        if (My.Settings.AirStd == "AK")
                            DashPic.Image = My.Resources.dash_2;
                        else
                            DashPic.Image = My.Resources.dash_6_8;

                        Icon = My.Resources.ico_gr6;
                        break;
                    }

                case 7:
                    {
                        AirStateLabel.Text = "극도로 나쁨";
                        themecol = Color.FromArgb(86, 9, 7);
                        DashPic.Image = My.Resources.dash_7_8;
                        Icon = My.Resources.ico_gr7;
                        break;
                    }

                case 8:
                    {
                        AirStateLabel.Text = "최악";
                        themecol = Color.FromArgb(18, 18, 18);
                        DashPic.Image = My.Resources.dash_2;
                        Icon = My.Resources.ico_gr8;
                        break;
                    }
            }

            Text = AirStateLabel.Text + " - monZi 위젯";
            if (My.Settings.FadeEnabled)
            {
                targcol = themecol;
                ColorTrans.Start();
            }
            else
                SetColor(themecol);



            if (!(APIForm.combnum == 0 | APIForm.combnum == -1 | APIForm.combnum == -2 | APIForm.combnum == -3 | APIForm.combnum == -4))
            {
                TitleLabel.Text = My.Settings.LocationName;
                AirDetailLabel.Text = "pm10(2.5): " + APIForm.pm10num + "(" + APIForm.pm25num + ") ㎍/㎥" + Constants.vbCr + APIForm.NowChk;
            }

            this.ValidateChildren();
        }

        private void SetColor(Color col)
        {
            MainPanel.BackColor = col;
            TopPanel.BackColor = col;
            LockBT.BackColor = col;
            MenuBT.BackColor = col;
            BottomPanel.BackColor = col;
        }

        private void Menu_DisableWidget_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("위젯을 비활성화하시겠습니까?", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbYes)
            {
                MainGUI.WidgetButton.Image = My.Resources.widget_1;
                My.Settings.widget_enabled = false;
                My.Settings.Save();
                My.Settings.Reload();
                this.Close();
            }
        }

        private void MenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ToolStripComboBox1.Width = dpicalc(this, 160);

            switch (My.Settings.widget_opacity)
            {
                case 1:
                    {
                        ToolStripComboBox1.SelectedIndex = 0;
                        break;
                    }

                case 0.9:
                    {
                        ToolStripComboBox1.SelectedIndex = 1;
                        break;
                    }

                case 0.8:
                    {
                        ToolStripComboBox1.SelectedIndex = 2;
                        break;
                    }

                case 0.7:
                    {
                        ToolStripComboBox1.SelectedIndex = 3;
                        break;
                    }

                case 0.6:
                    {
                        ToolStripComboBox1.SelectedIndex = 4;
                        break;
                    }

                case 0.5:
                    {
                        ToolStripComboBox1.SelectedIndex = 5;
                        break;
                    }

                case 0.4:
                    {
                        ToolStripComboBox1.SelectedIndex = 6;
                        break;
                    }

                case 0.3:
                    {
                        ToolStripComboBox1.SelectedIndex = 7;
                        break;
                    }

                case 0.2:
                    {
                        ToolStripComboBox1.SelectedIndex = 8;
                        break;
                    }
            }

            if (My.Settings.widget_stick)
                Menu_StickHelp.Text = "모서리에 달라붙지 않기";
            else
                Menu_StickHelp.Text = "모서리에 달라붙기";
        }

        private void MenuBT_Click(object sender, EventArgs e)
        {
            MenuStrip.Show(Cursor.Position);
        }

        private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ToolStripComboBox1.SelectedIndex)
            {
                case 0 // 100
               :
                    {
                        Opacity = 1;
                        break;
                    }

                case 1 // 90
         :
                    {
                        Opacity = 0.9;
                        break;
                    }

                case 2 // 80
         :
                    {
                        Opacity = 0.8;
                        break;
                    }

                case 3 // 70
         :
                    {
                        Opacity = 0.7;
                        break;
                    }

                case 4 // 60
         :
                    {
                        Opacity = 0.6;
                        break;
                    }

                case 5 // 50
         :
                    {
                        Opacity = 0.5;
                        break;
                    }

                case 6 // 40
         :
                    {
                        Opacity = 0.4;
                        break;
                    }

                case 7 // 30
         :
                    {
                        Opacity = 0.3;
                        break;
                    }

                case 8 // 20
         :
                    {
                        Opacity = 0.2;
                        break;
                    }
            }

            My.Settings.widget_opacity = Opacity;
        }

        private void Menu_StickHelp_Click(object sender, EventArgs e)
        {
            My.Settings.widget_stick = !My.Settings.widget_stick;
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
    }
}
