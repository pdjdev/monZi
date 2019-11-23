namespace WindowsFormsApp1.Forms
{
    partial class MainGUI
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
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.StatePanel = new System.Windows.Forms.Panel();
            this.AirStateLabel = new System.Windows.Forms.Label();
            this.AirDetailLabel = new System.Windows.Forms.Label();
            this.AirCommentLabel = new System.Windows.Forms.Label();
            this.DashPanel = new System.Windows.Forms.Panel();
            this.DashPic = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.WidgetButton = new System.Windows.Forms.PictureBox();
            this.HistoryButton = new System.Windows.Forms.PictureBox();
            this.HideButton = new System.Windows.Forms.PictureBox();
            this.ListButton = new System.Windows.Forms.PictureBox();
            this.hideani = new System.Windows.Forms.Timer(this.components);
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuMainPanel = new System.Windows.Forms.Panel();
            this.Menu_BT4 = new System.Windows.Forms.PictureBox();
            this.Menu_BT3 = new System.Windows.Forms.PictureBox();
            this.Menu_BT2 = new System.Windows.Forms.PictureBox();
            this.Menu_BT1 = new System.Windows.Forms.PictureBox();
            this.MenuTopPanel = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.MenuTitle = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.ListButton2 = new System.Windows.Forms.PictureBox();
            this.Transani = new System.Windows.Forms.Timer(this.components);
            this.ColorTrans = new System.Windows.Forms.Timer(this.components);
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.BottomBT2_Panel = new System.Windows.Forms.Panel();
            this.UpdateLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.PictureBox();
            this.BottomBT1_Panel = new System.Windows.Forms.Panel();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.LocationButton = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.StatePanel.SuspendLayout();
            this.DashPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashPic)).BeginInit();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidgetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListButton)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.MenuMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_BT4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_BT3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_BT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_BT1)).BeginInit();
            this.MenuTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListButton2)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.BottomBT2_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateButton)).BeginInit();
            this.BottomBT1_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocationButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Interval = 10000;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.MainPanel.Controls.Add(this.StatePanel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(425, 175);
            this.MainPanel.TabIndex = 6;
            // 
            // StatePanel
            // 
            this.StatePanel.BackColor = System.Drawing.Color.Transparent;
            this.StatePanel.Controls.Add(this.AirStateLabel);
            this.StatePanel.Controls.Add(this.AirDetailLabel);
            this.StatePanel.Controls.Add(this.AirCommentLabel);
            this.StatePanel.Controls.Add(this.DashPanel);
            this.StatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatePanel.Location = new System.Drawing.Point(0, 35);
            this.StatePanel.Name = "StatePanel";
            this.StatePanel.Size = new System.Drawing.Size(425, 140);
            this.StatePanel.TabIndex = 2;
            // 
            // AirStateLabel
            // 
            this.AirStateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AirStateLabel.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AirStateLabel.Location = new System.Drawing.Point(155, 34);
            this.AirStateLabel.Name = "AirStateLabel";
            this.AirStateLabel.Size = new System.Drawing.Size(270, 56);
            this.AirStateLabel.TabIndex = 1;
            this.AirStateLabel.Text = "로드 중";
            this.AirStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AirDetailLabel
            // 
            this.AirDetailLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AirDetailLabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AirDetailLabel.Location = new System.Drawing.Point(155, 90);
            this.AirDetailLabel.Name = "AirDetailLabel";
            this.AirDetailLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.AirDetailLabel.Size = new System.Drawing.Size(270, 50);
            this.AirDetailLabel.TabIndex = 2;
            this.AirDetailLabel.Text = "미세먼지(pm10): 15 ㎍/㎥\r\n초미세먼지(pm2.5): 15 ㎍/㎥\r\n";
            // 
            // AirCommentLabel
            // 
            this.AirCommentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AirCommentLabel.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AirCommentLabel.Location = new System.Drawing.Point(155, 0);
            this.AirCommentLabel.Name = "AirCommentLabel";
            this.AirCommentLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.AirCommentLabel.Size = new System.Drawing.Size(270, 34);
            this.AirCommentLabel.TabIndex = 3;
            this.AirCommentLabel.Text = "잠시만 기다려 주세요";
            this.AirCommentLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DashPanel
            // 
            this.DashPanel.Controls.Add(this.DashPic);
            this.DashPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DashPanel.Location = new System.Drawing.Point(0, 0);
            this.DashPanel.Name = "DashPanel";
            this.DashPanel.Padding = new System.Windows.Forms.Padding(15, 0, 5, 5);
            this.DashPanel.Size = new System.Drawing.Size(155, 140);
            this.DashPanel.TabIndex = 0;
            // 
            // DashPic
            // 
            this.DashPic.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.dash_back;
            this.DashPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashPic.Location = new System.Drawing.Point(15, 0);
            this.DashPic.Name = "DashPic";
            this.DashPic.Size = new System.Drawing.Size(135, 135);
            this.DashPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DashPic.TabIndex = 0;
            this.DashPic.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.TitleLabel);
            this.TopPanel.Controls.Add(this.WidgetButton);
            this.TopPanel.Controls.Add(this.HistoryButton);
            this.TopPanel.Controls.Add(this.HideButton);
            this.TopPanel.Controls.Add(this.ListButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(425, 35);
            this.TopPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleLabel.Location = new System.Drawing.Point(35, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(285, 35);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "현재 대기";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WidgetButton
            // 
            this.WidgetButton.BackColor = System.Drawing.Color.Transparent;
            this.WidgetButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.WidgetButton.Image = global::WindowsFormsApp1.Properties.Resources.widget_1;
            this.WidgetButton.Location = new System.Drawing.Point(320, 0);
            this.WidgetButton.Name = "WidgetButton";
            this.WidgetButton.Size = new System.Drawing.Size(35, 35);
            this.WidgetButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WidgetButton.TabIndex = 7;
            this.WidgetButton.TabStop = false;
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.Transparent;
            this.HistoryButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HistoryButton.Image = global::WindowsFormsApp1.Properties.Resources.hisicon;
            this.HistoryButton.Location = new System.Drawing.Point(355, 0);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(35, 35);
            this.HistoryButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HistoryButton.TabIndex = 6;
            this.HistoryButton.TabStop = false;
            // 
            // HideButton
            // 
            this.HideButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HideButton.Image = global::WindowsFormsApp1.Properties.Resources.hideicon;
            this.HideButton.Location = new System.Drawing.Point(390, 0);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(35, 35);
            this.HideButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HideButton.TabIndex = 1;
            this.HideButton.TabStop = false;
            // 
            // ListButton
            // 
            this.ListButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListButton.Image = global::WindowsFormsApp1.Properties.Resources.listicon;
            this.ListButton.Location = new System.Drawing.Point(0, 0);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(35, 35);
            this.ListButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ListButton.TabIndex = 0;
            this.ListButton.TabStop = false;
            // 
            // hideani
            // 
            this.hideani.Interval = 10;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuPanel.Controls.Add(this.MenuMainPanel);
            this.MenuPanel.Controls.Add(this.MenuTopPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(425, 10);
            this.MenuPanel.TabIndex = 7;
            // 
            // MenuMainPanel
            // 
            this.MenuMainPanel.Controls.Add(this.Menu_BT4);
            this.MenuMainPanel.Controls.Add(this.Menu_BT3);
            this.MenuMainPanel.Controls.Add(this.Menu_BT2);
            this.MenuMainPanel.Controls.Add(this.Menu_BT1);
            this.MenuMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuMainPanel.Location = new System.Drawing.Point(0, 35);
            this.MenuMainPanel.Name = "MenuMainPanel";
            this.MenuMainPanel.Padding = new System.Windows.Forms.Padding(5);
            this.MenuMainPanel.Size = new System.Drawing.Size(425, 0);
            this.MenuMainPanel.TabIndex = 3;
            // 
            // Menu_BT4
            // 
            this.Menu_BT4.Location = new System.Drawing.Point(215, 72);
            this.Menu_BT4.Name = "Menu_BT4";
            this.Menu_BT4.Size = new System.Drawing.Size(202, 59);
            this.Menu_BT4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu_BT4.TabIndex = 5;
            this.Menu_BT4.TabStop = false;
            // 
            // Menu_BT3
            // 
            this.Menu_BT3.Location = new System.Drawing.Point(8, 72);
            this.Menu_BT3.Name = "Menu_BT3";
            this.Menu_BT3.Size = new System.Drawing.Size(202, 59);
            this.Menu_BT3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu_BT3.TabIndex = 4;
            this.Menu_BT3.TabStop = false;
            // 
            // Menu_BT2
            // 
            this.Menu_BT2.Location = new System.Drawing.Point(215, 8);
            this.Menu_BT2.Name = "Menu_BT2";
            this.Menu_BT2.Size = new System.Drawing.Size(202, 59);
            this.Menu_BT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu_BT2.TabIndex = 3;
            this.Menu_BT2.TabStop = false;
            // 
            // Menu_BT1
            // 
            this.Menu_BT1.Location = new System.Drawing.Point(8, 8);
            this.Menu_BT1.Name = "Menu_BT1";
            this.Menu_BT1.Size = new System.Drawing.Size(202, 59);
            this.Menu_BT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu_BT1.TabIndex = 2;
            this.Menu_BT1.TabStop = false;
            // 
            // MenuTopPanel
            // 
            this.MenuTopPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuTopPanel.Controls.Add(this.CloseLabel);
            this.MenuTopPanel.Controls.Add(this.MenuTitle);
            this.MenuTopPanel.Controls.Add(this.CloseButton);
            this.MenuTopPanel.Controls.Add(this.ListButton2);
            this.MenuTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuTopPanel.Name = "MenuTopPanel";
            this.MenuTopPanel.Size = new System.Drawing.Size(425, 35);
            this.MenuTopPanel.TabIndex = 1;
            // 
            // CloseLabel
            // 
            this.CloseLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseLabel.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CloseLabel.Location = new System.Drawing.Point(307, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(83, 35);
            this.CloseLabel.TabIndex = 3;
            this.CloseLabel.Text = "monZi 종료";
            this.CloseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MenuTitle
            // 
            this.MenuTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuTitle.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuTitle.Location = new System.Drawing.Point(35, 0);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(175, 35);
            this.MenuTitle.TabIndex = 2;
            this.MenuTitle.Text = "메뉴";
            this.MenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Image = global::WindowsFormsApp1.Properties.Resources.closeicon;
            this.CloseButton.Location = new System.Drawing.Point(390, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            // 
            // ListButton2
            // 
            this.ListButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListButton2.Location = new System.Drawing.Point(0, 0);
            this.ListButton2.Name = "ListButton2";
            this.ListButton2.Size = new System.Drawing.Size(35, 35);
            this.ListButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ListButton2.TabIndex = 0;
            this.ListButton2.TabStop = false;
            // 
            // Transani
            // 
            this.Transani.Interval = 5;
            // 
            // ColorTrans
            // 
            this.ColorTrans.Interval = 13;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.BottomPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomPanel.Controls.Add(this.BottomBT2_Panel);
            this.BottomPanel.Controls.Add(this.BottomBT1_Panel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 175);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(425, 35);
            this.BottomPanel.TabIndex = 5;
            // 
            // BottomBT2_Panel
            // 
            this.BottomBT2_Panel.BackColor = System.Drawing.Color.Transparent;
            this.BottomBT2_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomBT2_Panel.Controls.Add(this.UpdateLabel);
            this.BottomBT2_Panel.Controls.Add(this.UpdateButton);
            this.BottomBT2_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomBT2_Panel.Location = new System.Drawing.Point(293, 0);
            this.BottomBT2_Panel.Name = "BottomBT2_Panel";
            this.BottomBT2_Panel.Size = new System.Drawing.Size(132, 35);
            this.BottomBT2_Panel.TabIndex = 4;
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateLabel.Font = new System.Drawing.Font("맑은 고딕", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UpdateLabel.Location = new System.Drawing.Point(0, 0);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(97, 35);
            this.UpdateLabel.TabIndex = 4;
            this.UpdateLabel.Text = "업데이트\r\n되지 않음";
            this.UpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.UpdateButton.Image = global::WindowsFormsApp1.Properties.Resources.refreshico;
            this.UpdateButton.Location = new System.Drawing.Point(97, 0);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(35, 35);
            this.UpdateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.TabStop = false;
            // 
            // BottomBT1_Panel
            // 
            this.BottomBT1_Panel.BackColor = System.Drawing.Color.Transparent;
            this.BottomBT1_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomBT1_Panel.Controls.Add(this.LocationLabel);
            this.BottomBT1_Panel.Controls.Add(this.LocationButton);
            this.BottomBT1_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BottomBT1_Panel.Location = new System.Drawing.Point(0, 0);
            this.BottomBT1_Panel.Name = "BottomBT1_Panel";
            this.BottomBT1_Panel.Size = new System.Drawing.Size(293, 35);
            this.BottomBT1_Panel.TabIndex = 6;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoEllipsis = true;
            this.LocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.LocationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LocationLabel.Font = new System.Drawing.Font("나눔스퀘어", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LocationLabel.Location = new System.Drawing.Point(35, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(268, 35);
            this.LocationLabel.TabIndex = 3;
            this.LocationLabel.Text = "위치를 설정하세요";
            this.LocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LocationButton
            // 
            this.LocationButton.BackColor = System.Drawing.Color.Transparent;
            this.LocationButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.LocationButton.Image = global::WindowsFormsApp1.Properties.Resources.locicon;
            this.LocationButton.Location = new System.Drawing.Point(0, 0);
            this.LocationButton.Name = "LocationButton";
            this.LocationButton.Size = new System.Drawing.Size(35, 35);
            this.LocationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LocationButton.TabIndex = 1;
            this.LocationButton.TabStop = false;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(425, 210);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BottomPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainGUI";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MainPanel.ResumeLayout(false);
            this.StatePanel.ResumeLayout(false);
            this.DashPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DashPic)).EndInit();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WidgetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListButton)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Menu_BT4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_BT3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_BT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_BT1)).EndInit();
            this.MenuTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListButton2)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.BottomBT2_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateButton)).EndInit();
            this.BottomBT1_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LocationButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Panel MainPanel;
        internal System.Windows.Forms.Panel StatePanel;
        internal System.Windows.Forms.Label AirStateLabel;
        internal System.Windows.Forms.Label AirDetailLabel;
        internal System.Windows.Forms.Label AirCommentLabel;
        internal System.Windows.Forms.Panel DashPanel;
        internal System.Windows.Forms.PictureBox DashPic;
        internal System.Windows.Forms.Panel TopPanel;
        internal System.Windows.Forms.Label TitleLabel;
        internal System.Windows.Forms.PictureBox WidgetButton;
        internal System.Windows.Forms.PictureBox HistoryButton;
        internal System.Windows.Forms.PictureBox HideButton;
        internal System.Windows.Forms.PictureBox ListButton;
        internal System.Windows.Forms.Timer hideani;
        internal System.Windows.Forms.Panel MenuPanel;
        internal System.Windows.Forms.Panel MenuMainPanel;
        internal System.Windows.Forms.PictureBox Menu_BT4;
        internal System.Windows.Forms.PictureBox Menu_BT3;
        internal System.Windows.Forms.PictureBox Menu_BT2;
        internal System.Windows.Forms.PictureBox Menu_BT1;
        internal System.Windows.Forms.Panel MenuTopPanel;
        internal System.Windows.Forms.Label CloseLabel;
        internal System.Windows.Forms.Label MenuTitle;
        internal System.Windows.Forms.PictureBox CloseButton;
        internal System.Windows.Forms.PictureBox ListButton2;
        internal System.Windows.Forms.Timer Transani;
        internal System.Windows.Forms.Timer ColorTrans;
        internal System.Windows.Forms.Panel BottomPanel;
        internal System.Windows.Forms.Panel BottomBT2_Panel;
        internal System.Windows.Forms.Label UpdateLabel;
        internal System.Windows.Forms.PictureBox UpdateButton;
        internal System.Windows.Forms.Panel BottomBT1_Panel;
        internal System.Windows.Forms.Label LocationLabel;
        internal System.Windows.Forms.PictureBox LocationButton;
    }
}