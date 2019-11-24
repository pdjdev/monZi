namespace WindowsFormsApp1.Forms
{
    partial class WidgetGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DashPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.AirStateLabel = new System.Windows.Forms.Label();
            this.AirDetailLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Menu_DisableWidget = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu_StickHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorTrans = new System.Windows.Forms.Timer(this.components);
            this.DashPic = new System.Windows.Forms.PictureBox();
            this.LockBT = new System.Windows.Forms.PictureBox();
            this.MenuBT = new System.Windows.Forms.PictureBox();
            this.DashPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBT)).BeginInit();
            this.SuspendLayout();
            // 
            // DashPanel
            // 
            this.DashPanel.Controls.Add(this.DashPic);
            this.DashPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashPanel.Location = new System.Drawing.Point(0, 28);
            this.DashPanel.Name = "DashPanel";
            this.DashPanel.Size = new System.Drawing.Size(185, 164);
            this.DashPanel.TabIndex = 1;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.AirStateLabel);
            this.BottomPanel.Controls.Add(this.AirDetailLabel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 192);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(185, 88);
            this.BottomPanel.TabIndex = 2;
            // 
            // AirStateLabel
            // 
            this.AirStateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AirStateLabel.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AirStateLabel.ForeColor = System.Drawing.Color.White;
            this.AirStateLabel.Location = new System.Drawing.Point(0, 0);
            this.AirStateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.AirStateLabel.Name = "AirStateLabel";
            this.AirStateLabel.Size = new System.Drawing.Size(185, 47);
            this.AirStateLabel.TabIndex = 2;
            this.AirStateLabel.Text = "로드 중";
            this.AirStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AirDetailLabel
            // 
            this.AirDetailLabel.BackColor = System.Drawing.Color.Transparent;
            this.AirDetailLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AirDetailLabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AirDetailLabel.ForeColor = System.Drawing.Color.White;
            this.AirDetailLabel.Location = new System.Drawing.Point(0, 47);
            this.AirDetailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AirDetailLabel.Name = "AirDetailLabel";
            this.AirDetailLabel.Size = new System.Drawing.Size(185, 41);
            this.AirDetailLabel.TabIndex = 10;
            this.AirDetailLabel.Text = "잠시만 기다려 주세요";
            this.AirDetailLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.MainPanel.Controls.Add(this.DashPanel);
            this.MainPanel.Controls.Add(this.BottomPanel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(185, 280);
            this.MainPanel.TabIndex = 3;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.TitleLabel);
            this.TopPanel.Controls.Add(this.LockBT);
            this.TopPanel.Controls.Add(this.MenuBT);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(185, 28);
            this.TopPanel.TabIndex = 6;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(29, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(127, 28);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "monZi";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu_DisableWidget
            // 
            this.Menu_DisableWidget.Font = new System.Drawing.Font("나눔스퀘어", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Menu_DisableWidget.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Menu_DisableWidget.Name = "Menu_DisableWidget";
            this.Menu_DisableWidget.Padding = new System.Windows.Forms.Padding(0);
            this.Menu_DisableWidget.Size = new System.Drawing.Size(226, 22);
            this.Menu_DisableWidget.Text = "위젯 비활성화";
            // 
            // ToolStripComboBox1
            // 
            this.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ToolStripComboBox1.Font = new System.Drawing.Font("나눔스퀘어", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ToolStripComboBox1.Items.AddRange(new object[] {
            "100% (불투명)",
            "90%",
            "80%",
            "70%",
            "60%",
            "50%",
            "40%",
            "30%",
            "20%"});
            this.ToolStripComboBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.ToolStripComboBox1.Name = "ToolStripComboBox1";
            this.ToolStripComboBox1.Size = new System.Drawing.Size(160, 28);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.White;
            this.MenuStrip.Font = new System.Drawing.Font("나눔스퀘어", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_DisableWidget,
            this.Menu_StickHelp,
            this.ToolStripComboBox1});
            this.MenuStrip.Name = "ContextMenuStrip1";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuStrip.ShowImageMargin = false;
            this.MenuStrip.Size = new System.Drawing.Size(227, 108);
            // 
            // Menu_StickHelp
            // 
            this.Menu_StickHelp.Font = new System.Drawing.Font("나눔스퀘어", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Menu_StickHelp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Menu_StickHelp.Name = "Menu_StickHelp";
            this.Menu_StickHelp.Size = new System.Drawing.Size(226, 24);
            this.Menu_StickHelp.Text = "모서리에 달라붙지 않기";
            // 
            // ColorTrans
            // 
            this.ColorTrans.Interval = 13;
            // 
            // DashPic
            // 
            this.DashPic.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dash_back;
            this.DashPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DashPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashPic.Location = new System.Drawing.Point(0, 0);
            this.DashPic.Name = "DashPic";
            this.DashPic.Size = new System.Drawing.Size(185, 164);
            this.DashPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DashPic.TabIndex = 1;
            this.DashPic.TabStop = false;
            // 
            // LockBT
            // 
            this.LockBT.Dock = System.Windows.Forms.DockStyle.Left;
            this.LockBT.Image = global::WindowsFormsApp1.Properties.Resources.lockicon_2;
            this.LockBT.Location = new System.Drawing.Point(0, 0);
            this.LockBT.Name = "LockBT";
            this.LockBT.Size = new System.Drawing.Size(29, 28);
            this.LockBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LockBT.TabIndex = 12;
            this.LockBT.TabStop = false;
            // 
            // MenuBT
            // 
            this.MenuBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuBT.Image = global::WindowsFormsApp1.Properties.Resources.moreicon;
            this.MenuBT.Location = new System.Drawing.Point(156, 0);
            this.MenuBT.Name = "MenuBT";
            this.MenuBT.Size = new System.Drawing.Size(29, 28);
            this.MenuBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuBT.TabIndex = 5;
            this.MenuBT.TabStop = false;
            // 
            // WidgetGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(185, 280);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WidgetGUI";
            this.Text = "WidgetGUI";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.DashPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DashPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox DashPic;
        internal System.Windows.Forms.Panel DashPanel;
        internal System.Windows.Forms.PictureBox MenuBT;
        internal System.Windows.Forms.Panel BottomPanel;
        internal System.Windows.Forms.Label AirStateLabel;
        internal System.Windows.Forms.Label AirDetailLabel;
        internal System.Windows.Forms.Panel MainPanel;
        internal System.Windows.Forms.Panel TopPanel;
        internal System.Windows.Forms.Label TitleLabel;
        internal System.Windows.Forms.PictureBox LockBT;
        internal System.Windows.Forms.ToolStripMenuItem Menu_DisableWidget;
        internal System.Windows.Forms.ToolStripComboBox ToolStripComboBox1;
        internal System.Windows.Forms.ContextMenuStrip MenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem Menu_StickHelp;
        internal System.Windows.Forms.Timer ColorTrans;
    }
}