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
    public partial class OptionForm : Form
    {
        public int mode = 1;
        private Point Loc;

        private Color ActiveColor = Color.FromArgb(0, 229, 255);
        private Color inActiveColor = Color.FromArgb(0, 86, 98);
        private bool optionchanged = false;

        private int DEBUGCOUNT = 0; // 디버그 옵션 이벤트카운트
        private bool DEBUGMODE = false; // 디버그 옵션 표시 여부 (배포시에는 FALSE로 두기)

        public OptionForm()
        {
            InitializeComponent();
        }

        private void FadeInEffect(object sender, EventArgs e)
        {
            optionchanged = false;
            ApplyBT.Text = "닫기";
            this.Refresh();
            FadeIn(this, 1);
        }

        private void FadeOutEffect(object sender, EventArgs e)
        {
            FadeOut(this);
            MainGUI.TopMost = true;
        }

        private void FormDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == Windows.Forms.MouseButtons.Left)
                Loc = e.Location;
        }

        private void FormDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == Windows.Forms.MouseButtons.Left)
                this.Location += e.Location - Loc;
        }

        private void LocationSet_Load(object sender, EventArgs e)
        {
            MainGUI.TopMost = false; // 화면 크기가 작은 PC에서 MainGUI가 옵션창을 가리기에 잠시 TopMost 해제하기 -> FormClosing때 다시 복구
            Modeset(mode);
            SettingLoad();
            Opacity = 0;
            DEBUGMODE = (My.Settings.APIFORM | My.Settings.UseAKAPI);
            DEBUGPANEL.Visible = DEBUGMODE;
            if (My.Settings.UseNativeFont)
                ChangeToNativeFont(this);
        }

        private void CloseBT_MouseEnter(object sender, EventArgs e)
        {
            CloseBT.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.2);
        }

        private void CloseBT_MouseLeave(object sender, EventArgs e)
        {
            CloseBT.BackColor = Color.Transparent;
        }

        public void Modeset(int mode)
        {
            switch (mode)
            {
                case 1:
                    {
                        Tab1.BackColor = ActiveColor;
                        Tab2.BackColor = inActiveColor;
                        Tab3.BackColor = inActiveColor;
                        TabPanel1.Show();
                        TabPanel2.Hide();
                        TabPanel3.Hide();
                        break;
                    }

                case 2:
                    {
                        Tab1.BackColor = inActiveColor;
                        Tab2.BackColor = ActiveColor;
                        Tab3.BackColor = inActiveColor;
                        TabPanel1.Hide();
                        TabPanel2.Show();
                        TabPanel3.Hide();


                        // 에어코리아 <> WHO기준 따라 표시할 컨트롤 바꿔뿌기
                        if (stdchk_airkorea.Checked)
                        {
                            alchk_1.Enabled = false;
                            alchk_3.Enabled = false;
                            alchk_7.Enabled = false;
                            alchk_8.Enabled = false;
                        }
                        else
                        {
                            alchk_1.Enabled = true;
                            alchk_3.Enabled = true;
                            alchk_7.Enabled = true;
                            alchk_8.Enabled = true;
                        }

                        break;
                    }

                case 3:
                    {
                        Tab1.BackColor = inActiveColor;
                        Tab2.BackColor = inActiveColor;
                        Tab3.BackColor = ActiveColor;
                        TabPanel1.Hide();
                        TabPanel2.Hide();
                        TabPanel3.Show();
                        break;
                    }
            }
        }

        private void TabLabel1_Click(object sender, EventArgs e)
        {
            Modeset(1);
        }

        private void TabLabel2_Click(object sender, EventArgs e)
        {
            Modeset(2);
        }

        private void TabLabel3_Click(object sender, EventArgs e)
        {
            Modeset(3);
        }

        public void SettingLoad()
        {

            // Tab1
            try
            {
                dfchk_1.Checked = checkStartUp();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("시작프로그램 설정 여부 확인 도중 오류가 발생했습니다.", Constants.vbCritical);
            }

            if (My.Settings.AirStd == "AK")
                stdchk_airkorea.Checked = true;
            else
                stdchk_who.Checked = true;

            dfchk_3.Checked = My.Settings.ChkEnabled;
            dfchk_4.Checked = My.Settings.TrayEnabled;

            alchk.Enabled = dfchk_3.Checked;

            // Tab2
            alchk.Checked = My.Settings.PushEnabled;
            alchk_Panel.Enabled = alchk.Checked;

            string pushlist = My.Settings.PushList;

            if (pushlist == null)
                goto pass1;

            if (pushlist.Contains("1"))
                alchk_1.Checked = true;
            if (pushlist.Contains("2"))
                alchk_2.Checked = true;
            if (pushlist.Contains("3"))
                alchk_3.Checked = true;
            if (pushlist.Contains("4"))
                alchk_4.Checked = true;
            if (pushlist.Contains("5"))
                alchk_5.Checked = true;
            if (pushlist.Contains("6"))
                alchk_6.Checked = true;
            if (pushlist.Contains("7"))
                alchk_7.Checked = true;
            if (pushlist.Contains("8"))
                alchk_8.Checked = true;
            if (pushlist.Contains("e"))
                alchk_2_4.Checked = true;

            pass1:
            ;
            alchk_2_1.Checked = My.Settings.PushWithsound;
            alchk_2_2.Checked = My.Settings.PushIgnore;
            alchk_2_3.Checked = My.Settings.PushTopmost;


            // Tab3
            etchk_1.Checked = My.Settings.AeroEnabled;
            etchk_2.Checked = My.Settings.FadeEnabled;
            etchk_3.Checked = My.Settings.AniEnabled;
            etchk_4.Checked = My.Settings.UseNativeFont;
            etchk_debug.Checked = My.Settings.APIFORM;
            etchk_useakapi.Checked = My.Settings.UseAKAPI;


            string posSet = My.Settings.FormPos;
            ComboBox1.SelectedIndex = Convert.ToInt32(Strings.Mid(posSet, 1, 1));
            ComboBox2.SelectedIndex = Convert.ToInt32(Strings.Mid(posSet, 2, 1));
        }

        public void ApplySet()
        {

            // Tab1

            try
            {
                if (dfchk_1.Checked)
                    SetStartup();
                else if (checkStartUp())
                    RemoveStartup();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("시작프로그램 설정 중 오류가 발생했습니다." + Constants.vbCr + "해당 설정을 제외한 설정은 저장됩니다.", Constants.vbCritical);
            }

            My.Settings.ChkEnabled = dfchk_3.Checked;
            My.Settings.TrayEnabled = dfchk_4.Checked;

            if (stdchk_who.Checked)
                My.Settings.AirStd = "WHO";
            else if (stdchk_airkorea.Checked)
                My.Settings.AirStd = "AK";


            // Tab2
            string pushlist = null;

            My.Settings.PushEnabled = alchk.Checked;

            if (alchk_1.Checked)
                pushlist += "1";
            if (alchk_2.Checked)
                pushlist += "2";
            if (alchk_3.Checked)
                pushlist += "3";
            if (alchk_4.Checked)
                pushlist += "4";
            if (alchk_5.Checked)
                pushlist += "5";
            if (alchk_6.Checked)
                pushlist += "6";
            if (alchk_7.Checked)
                pushlist += "7";
            if (alchk_8.Checked)
                pushlist += "8";
            if (alchk_2_4.Checked)
                pushlist += "e";

            My.Settings.PushList = pushlist;

            My.Settings.PushWithsound = alchk_2_1.Checked;
            My.Settings.PushIgnore = alchk_2_2.Checked;
            My.Settings.PushTopmost = alchk_2_3.Checked;


            // Tab3
            My.Settings.AeroEnabled = etchk_1.Checked;
            My.Settings.FadeEnabled = etchk_2.Checked;
            My.Settings.AniEnabled = etchk_3.Checked;
            My.Settings.UseNativeFont = etchk_4.Checked;
            My.Settings.APIFORM = etchk_debug.Checked;
            My.Settings.UseAKAPI = etchk_useakapi.Checked;
            My.Settings.FormPos = ComboBox1.SelectedIndex.ToString + ComboBox2.SelectedIndex.ToString;

            My.Settings.Save();
            My.Settings.Reload();
        }

        private void alchk_CheckedChanged(object sender, EventArgs e)
        {
            alchk_Panel.Enabled = alchk.Checked;
        }

        private void dfchk_3_CheckedChanged(object sender, EventArgs e)
        {
            if (dfchk_3.Checked == false & alchk.Checked)
            {
                if (Interaction.MsgBox("대기 상태 업데이트를 비활성화할시 푸시 알림 설정 기능도 비활성화됩니다. 계속하시겠습니까?", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbYes)
                    alchk.Checked = false;
                else
                    dfchk_3.Checked = true;
            }

            alchk.Enabled = dfchk_3.Checked;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ApplySet();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("정말로 초기화 하시겠습니까?" + Constants.vbCr + "(지역 설정, 알림 설정 등이 모두 초기화됩니다.)", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbYes)
            {
                My.Settings.Reset();
                My.Settings.Save();
                My.Settings.Reload();

                Interaction.MsgBox("프로그램이 종료됩니다. 다시 실행해 주세요.", Constants.vbInformation);
                Application.Exit();
            }
        }

        private void etchk_1_CheckedChanged(object sender, EventArgs e)
        {
            if (!My.Settings.AeroEnabled == etchk_1.Checked)
                Interaction.MsgBox("Aero 활성화 변경은 다음 창 실행때부터 적용됩니다.", Constants.vbInformation);
        }

        private void etchk_4_CheckedChanged(object sender, EventArgs e)
        {
            if (!My.Settings.UseNativeFont == etchk_4.Checked)
                Interaction.MsgBox("해당 설정은 프로그램을 다시 시작하여야 완전히 적용됩니다.", Constants.vbInformation);
        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            if (optionchanged == true)
            {
                if (Interaction.MsgBox("변경 사항을 저장하지 않고 닫으시겠습니까?", Constants.vbQuestion + Constants.vbYesNo) == Constants.vbNo)
                    goto donothing;
            }

            this.Close();
            donothing:
            ;
        }

        private void OptionChangedEvent()
        {
            optionchanged = true;
            ApplyBT.Text = "적용하기";
        }



        private void PictureBox2_Click(object sender, EventArgs e)
        {
            DEBUGCOUNT += 1;

            if (DEBUGCOUNT == 10)
            {
                Interaction.MsgBox("디버그모드 활성화", Constants.vbInformation);
                DEBUGMODE = true;
                DEBUGPANEL.Visible = DEBUGMODE;
            }
        }

        private void OptionChangedEvent(object sender, EventArgs e)
        {
        }

        private void stdchk_who_CheckedChanged(object sender, EventArgs e)
        {
            if ((stdchk_airkorea.Checked & !My.Settings.AirStd == "AK") | (stdchk_who.Checked & !My.Settings.AirStd == "WHO"))
                Interaction.MsgBox("해당 설정은 대기 상태 업데이트 후에 적용됩니다.", Constants.vbInformation);
        }
    }
}
