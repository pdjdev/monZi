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
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1.Forms
{
    public partial class StartupAsk : Form
    {
        private Point loc;

        public StartupAsk()
        {
            InitializeComponent();
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
                Loc = e.Location;
        }

        private void FormDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == Windows.Forms.MouseButtons.Left)
                this.Location += e.Location - loc;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 이후 띄우지 않도록
            My.Settings.StartupPopIgnore = true;

            My.Settings.Save();
            My.Settings.Reload();
            this.Close();
        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SetStartup();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("시작프로그램 설정 중 오류가 발생했습니다." + Constants.vbCr + "'프로그램 설정'에서 다시 시도해 보시기 바랍니다.", Constants.vbCritical);
            }
            this.Close();
        }

        private void CloseBT_MouseEnter(object sender, EventArgs e)
        {
            CloseBT.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.5);
        }

        private void CloseBT_MouseLeave(object sender, EventArgs e)
        {
            CloseBT.BackColor = TopPanel.BackColor;
        }

        private void StartupAsk_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            if (My.Settings.UseNativeFont)
                ChangeToNativeFont(this);
        }
    }
}
