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
    public partial class LocList : Form
    {
        private Point loc;
        private Brush HighlightBrush = new SolidBrush(Color.FromArgb(85, 85, 85));

        private string[] ItemData = new string[256];
        private int count = 0;

        private bool isSetLocClicked = false;

        public LocList()
        {
            InitializeComponent();
        }
        private void FadeInEffect(object sender, EventArgs e)
        {
            this.Refresh();
            FadeIn(this, 1);

            ListBox1.Focus();
        }

        private void FadeOutEffect(object sender, EventArgs e)
        {
            FadeOut(this);
            if (!isSetLocClicked)
                TrayForm.MainGUI_Open();
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

        private void LocList_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            if (My.Settings.UseNativeFont)
                ChangeToNativeFont(this);

            LoadData();
        }

        private void CloseBT_MouseEnter(object sender, EventArgs e)
        {
            CloseBT.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.2);
        }

        private void CloseBT_MouseLeave(object sender, EventArgs e)
        {
            CloseBT.BackColor = Color.Transparent;
        }

        private void ListBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            if (ListBox1.Items.Count > 0)
            {
                e.DrawBackground();

                if ((e.Index % 2) == 1)
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), e.Bounds);
                else
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(245, 245, 245)), e.Bounds);

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    e.Graphics.FillRectangle(HighlightBrush, e.Bounds);


                using (SolidBrush b = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias;
                    e.Graphics.DrawString(ListBox1.GetItemText(ListBox1.Items(e.Index)), e.Font, b, e.Bounds.Left + dpicalc(this, 20), ((e.Bounds.Height - ListBox1.Font.Height) / 2) + e.Bounds.Top);
                }
                e.DrawFocusRectangle();
            }
        }

        private void ListBox1_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
        {
            e.ItemHeight = dpicalc(this, 40);
        }

        private void CloseBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            ApplySet();
        }

        public void ApplySet()
        {
            var ApplyData = ItemData[ListBox1.SelectedIndex];

            string newData = "<locinfo>" + ApplyData + "</locinfo>";

            for (var i = 0; i <= count - 1; i++)
            {
                if (!i == ListBox1.SelectedIndex)
                    newData += Constants.vbCr + "<locinfo>" + ItemData[i] + "</locinfo>";
            }

            My.Settings.LocHistory = newData;


            if (getData(ApplyData, "type") == "location")
            {
                My.Settings.StationName = null;
                My.Settings.LocationName = getData(ApplyData, "string");
                My.Settings.LocationPoint_X = getData(ApplyData, "X");
                My.Settings.LocationPoint_Y = getData(ApplyData, "Y");
            }
            else
            {
                My.Settings.LocationName = getData(ApplyData, "string") + " (측정소)";
                My.Settings.StationName = getData(ApplyData, "string");
            }

            APIForm.AirAPICheck.CancelAsync();
            APIForm.Close();
            APIForm.combnum = 0;
            APIForm.PrevChk = "-1"; // 무조건 업데이트하도록
            APIForm.prevCombnum = -1;
            MainGUI.DrawState();
            APIForm.Activate();
            TrayForm.MainGUI_Open();

            this.Close();
        }

        public void LoadData()
        {
            ListBox1.Items.Clear();
            var tmpdata = My.Settings.LocHistory;

            count = 0;

            ret:
            ;
            if (tmpdata.Contains("<locinfo>"))
            {
                long FirstStart = tmpdata.IndexOf("<locinfo>") + 10;

                ItemData[count] = Trim(Mid(tmpdata, FirstStart, tmpdata.Substring(FirstStart).IndexOf("</locinfo>") + 1));
                tmpdata = Mid(tmpdata, FirstStart, tmpdata.Length);

                if (getData(ItemData[count], "type") == "station")
                    ListBox1.Items.Add(getData(ItemData[count], "string") + " (측정소)");
                else
                    ListBox1.Items.Add(getData(ItemData[count], "string"));

                count += 1;
                goto ret;
            }

            if (ListBox1.Items.Count > 0)
            {
                ListBox1.SetSelected(0, true);
                EmptyMsgPanel.Hide();
                ClearButton.Show();
            }
            else
            {
                EmptyMsg_Upper.Height = EmptyMsgPanel.Height / (double)2;
                EmptyMsgPanel.Show();
                ClearButton.Hide();
            }
        }

        private void ClearButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Interaction.MsgBox("정말로 비우시겠습니까?", Constants.vbQuestion + MsgBoxStyle.YesNo) == Constants.vbYes)
            {
                My.Settings.LocHistory = null;
                My.Settings.Save();
                My.Settings.Reload();
                this.Close();
            }
        }

        private void ListBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Keys.Enter)
                ApplySet();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isSetLocClicked = true;

            Point mouseloc = new Point(Cursor.Position.X, Cursor.Position.Y);
            int marign = dpicalc(this, 10);

            var showx = Screen.GetWorkingArea(mouseloc).Width - LocationSet.Width - marign;
            var showy = Screen.GetWorkingArea(mouseloc).Height - LocationSet.Height - marign;
            LocationSet.SetDesktopLocation(showx, showy);

            LocationSet.Show();
            this.Close();
        }


    }
}
