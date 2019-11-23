using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class about : Form
    {
        public about()
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
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                loc = e.Location;
        }

        private void FormDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                this.Location += e.Location - loc;
        }

        private void about_Load(object sender, EventArgs e)
        {
            VerLabel.Text = My.Application.Info.Version.ToString;
            RichTextBox1.Text = My.Resources.appinfo;
            Opacity = 0;
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

        private void CloseBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 지메일
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:pdj5096@gmail.com");
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("http://t.me/pbjun");
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("http://pbjsw.kro.kr");
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://blog.pbj.kr");
        }

    }
}
