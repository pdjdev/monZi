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
    public partial class UpdateForm : Form
    {
        private string nowver = My.Application.Info.Version.ToString;
        private string newver = null;
        private string newinfo = null;
        private string updlink = null;
        private bool updateok = true;

        private Point loc;

        public UpdateForm()
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
            MainGUI.Show();
            FadeIn(MainGUI, 1);
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

        private void CloseBT_MouseEnter(object sender, EventArgs e)
        {
            CloseBT.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.2);
        }

        private void CloseBT_MouseLeave(object sender, EventArgs e)
        {
            CloseBT.BackColor = Color.Transparent;
        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateMgr_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            VerLabel.Text = My.Application.Info.Version.ToString;

            VerLabel.Text = "현재 버전: " + nowver;
            UpdateChk.RunWorkerAsync();
            if (My.Settings.UseNativeFont)
                ChangeToNativeFont(this);
        }

        private void UpdateChk_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                var info = webget("http://status.monzi-host.ze.am/");
                newver = getData(info, "version");
                newinfo = getData(info, "note");
                updlink = getData(info, "link");
            }
            catch (Exception ex)
            {
                updateok = false;
            }
        }

        private void UpdateChk_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            RichTextBox1.Text = newinfo;
            NewVerLabel.Text = "최신 버전: " + newver;


            if (updateok)
            {
                if (UpdateAvailable())
                {
                    UpdButton.Enabled = true;
                    NewVerLabel.Text += " (업데이트 가능)";
                }
                else
                    NewVerLabel.Text += " (최신 버전)";
                ForceUpdButton.Enabled = true;
            }
            else
                NewVerLabel.Text = "(업데이트 확인 실패)";
        }

        public void UpdateAvailable()
        {
            if (Convert.ToInt32(Strings.Replace(nowver, ".", null)) < Convert.ToInt32(Strings.Replace(newver, ".", null)))
                return true;
            else
                return false;
        }
        private void UpdButton_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("실행되는 페이지의 설치 파일을 받아 실행해 주시기 바랍니다" + Constants.vbCr + "(기존 버전을 삭제하시는것을 권장드립니다)", Constants.vbInformation);
            Process.Start(updlink);
        }

    }
}
