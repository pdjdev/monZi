using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();
        }

        private var MouseOn = false;

        private void FadeInEffect(object sender, EventArgs e)
        {
            this.Refresh();
            FadeIn(this, 1);
        }

        private void FadeOutEffect(object sender, EventArgs e)
        {
            FadeOut(this);
        }

        public void DrawPopUp()
        {
            Color themecol = null/* TODO Change to default(_) if this is not a reference type */;

            switch (APIForm.combnum)
            {
                case -4:
                    {
                        AirStateLabel.Text = "점검중";
                        AirCommentLabel.Text = "점검중/사용 불가 상태입니다";
                        AirDetailLabel.Text = "해당 측정소에서 대기 상태를 받아올 수 없습니다." + Constants.vbCr + "'측정소명으로 검색'을 통해 다른 측정소를 지정하세요.";
                        TitleLabel.Text = APIForm.guititle;
                        themecol = Color.FromArgb(49, 27, 146);
                        PictureBox2.Image = My.Resources.dash_maintenance;
                        break;
                    }

                case -2:
                    {
                        TitleLabel.Text = "monZi 오류";
                        AirStateLabel.Text = "오프라인";
                        AirCommentLabel.Text = "인터넷에 연결되어 있지 않네요";
                        AirDetailLabel.Text = "인터넷 연결을 확인한 뒤 새로고침해 주세요" + Constants.vbCr + "(3분 간격으로 자동 체크합니다)";
                        themecol = Color.FromArgb(55, 71, 79);
                        break;
                    }

                case -1:
                    {
                        TitleLabel.Text = "monZi 오류";
                        AirStateLabel.Text = "오류 발생";
                        AirCommentLabel.Text = "문제가 발생하였습니다";
                        AirDetailLabel.Text = "인터넷 연결 문제, 혹은 측정소 점검" + Constants.vbCr + "등으로 인한 접근 제한이 원인일 수 있습니다.";
                        themecol = Color.FromArgb(55, 71, 79);
                        break;
                    }

                case 0:
                    {
                        AirStateLabel.Text = "로드 중";
                        AirCommentLabel.Text = "정보를 불러오고 있습니다";
                        AirDetailLabel.Text = "이 상태가 지속된다면 프로그램을 다시 시작해 주세요";
                        themecol = Color.FromArgb(55, 71, 79);
                        break;
                    }

                case 1:
                    {
                        AirStateLabel.Text = "최고";
                        AirCommentLabel.Text = "신선한 공기 마음껏 마시세요~";
                        themecol = Color.FromArgb(30, 136, 229);
                        break;
                    }

                case 2:
                    {
                        AirStateLabel.Text = "좋음";
                        AirCommentLabel.Text = "환기하셔도 좋습니다!";
                        themecol = Color.FromArgb(43, 201, 207);
                        break;
                    }

                case 3:
                    {
                        AirStateLabel.Text = "양호";
                        AirCommentLabel.Text = "괜찮은 날이네요!";
                        themecol = Color.FromArgb(49, 159, 158);
                        break;
                    }

                case 4:
                    {
                        AirStateLabel.Text = "보통";
                        AirCommentLabel.Text = "그럭저럭 괜찮은 날이네요!";
                        themecol = Color.FromArgb(11, 182, 82);
                        break;
                    }

                case 5:
                    {
                        AirStateLabel.Text = "나쁨";
                        AirCommentLabel.Text = "열린 창문이 있다면 닫아주세요~";
                        themecol = Color.FromArgb(239, 108, 0);
                        break;
                    }

                case 6:
                    {
                        AirStateLabel.Text = "매우 나쁨";
                        AirCommentLabel.Text = "외출시 마스크 꼭 챙기세요!";
                        themecol = Color.FromArgb(229, 57, 53);
                        break;
                    }

                case 7:
                    {
                        AirStateLabel.Text = "극도로 나쁨";
                        AirCommentLabel.Text = "주의해 주세요!";
                        themecol = Color.FromArgb(86, 9, 7);
                        break;
                    }

                case 8:
                    {
                        AirStateLabel.Text = "최악";
                        AirCommentLabel.Text = "가능하다면 외출을 삼가주세요!";
                        themecol = Color.FromArgb(18, 18, 18);
                        break;
                    }
            }

            MainPanel.BackColor = themecol;
            TopPanel.BackColor = themecol;


            if (!(APIForm.combnum == 0 | APIForm.combnum == -1 | APIForm.combnum == -2 | APIForm.combnum == -4))
            {
                TitleLabel.Text = "실시간 대기 알림 - " + My.Settings.LocationName;
                AirDetailLabel.Text = "pm10: " + APIForm.pm10num + "㎍/㎥ | pm2.5: " + APIForm.pm25num + "㎍/㎥" + Constants.vbCr
                    + "(" + APIForm.NowChk + ")";
                if (My.Settings.PushWithsound)
                    My.Computer.Audio.Play(My.Resources.popup_snd, AudioPlayMode.Background);
            }


            if (!My.Settings.CustomAPI == null/* TODO Change to default(_) if this is not a reference type */ )
                TitleLabel.Text = "실시간 대기 알림 - " + APIForm.guititle;
        }

        private void PopUpForm_Load(object sender, EventArgs e)
        {
            DrawPopUp();
            Opacity = 0;
            TopMost = My.Settings.PushTopmost;
            if (My.Settings.UseNativeFont)
            {
                AirCommentLabel.Height -= dpicalc(this, 5);
                AirCommentLabel.Padding = new Padding(dpicalc(this, 9), 0, 0, 0);
                AirDetailLabel.Height -= dpicalc(this, 5);
                ChangeToNativeFont(this);
            }
        }

        private void AirDetailLabel_Click(object sender, EventArgs e)
        {
        }

        private void AirStateLabel_Click(object sender, EventArgs e)
        {
        }

        private void ClosePopup(object sender, EventArgs e)  // , Me.LostFocus <-이거는 그냥 안하기로 (너무 창이 쉽게 사라져버림)
        {
            this.Close();
        }

        private void CloseBT_MouseEnter(object sender, EventArgs e)
        {
            sender.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.5);
        }

        private void CloseBT_MouseLeave(object sender, EventArgs e)
        {
            sender.BackColor = TopPanel.BackColor;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            OptionForm.mode = 2;
            OptionForm.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (MouseOn)
            {
                if (!Opacity == 1)
                    Opacity += 0.02;
            }
            else if (Opacity > 0.8)
                Opacity -= 0.02;
            else
                AniTimer.Stop();
        }

        private void TitleLabel_MouseEnter(object sender, EventArgs e)
        {
            AniTimer.Start();
            MouseOn = true;
        }

        private void TitleLabel_MouseLeave(object sender, EventArgs e)
        {
            MouseOn = false;
        }

        private void FirstWaitTimer_Tick(object sender, EventArgs e)
        {
            AniTimer.Start();
            FirstWaitTimer.Stop();
        }

    }
}
