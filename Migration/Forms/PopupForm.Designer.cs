namespace WindowsFormsApp1.Forms
{
    partial class PopupForm
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
            this.AirStateLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AirDetailLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AirCommentLabel = new System.Windows.Forms.Label();
            this.AniTimer = new System.Windows.Forms.Timer(this.components);
            this.FirstWaitTimer = new System.Windows.Forms.Timer(this.components);
            this.OptBT = new System.Windows.Forms.PictureBox();
            this.CloseBT = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OptBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AirStateLabel
            // 
            this.AirStateLabel.BackColor = System.Drawing.Color.Transparent;
            this.AirStateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AirStateLabel.Font = new System.Drawing.Font("나눔스퀘어 ExtraBold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AirStateLabel.ForeColor = System.Drawing.Color.White;
            this.AirStateLabel.Location = new System.Drawing.Point(93, 25);
            this.AirStateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AirStateLabel.Name = "AirStateLabel";
            this.AirStateLabel.Padding = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.AirStateLabel.Size = new System.Drawing.Size(269, 41);
            this.AirStateLabel.TabIndex = 8;
            this.AirStateLabel.Text = "로드 중";
            this.AirStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.TopPanel.Controls.Add(this.OptBT);
            this.TopPanel.Controls.Add(this.TitleLabel);
            this.TopPanel.Controls.Add(this.CloseBT);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TopPanel.Size = new System.Drawing.Size(374, 30);
            this.TopPanel.TabIndex = 11;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(5, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(322, 30);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "실시간 대기 알림";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AirDetailLabel
            // 
            this.AirDetailLabel.BackColor = System.Drawing.Color.Transparent;
            this.AirDetailLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AirDetailLabel.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AirDetailLabel.ForeColor = System.Drawing.Color.White;
            this.AirDetailLabel.Location = new System.Drawing.Point(93, 66);
            this.AirDetailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AirDetailLabel.Name = "AirDetailLabel";
            this.AirDetailLabel.Padding = new System.Windows.Forms.Padding(11, 1, 0, 0);
            this.AirDetailLabel.Size = new System.Drawing.Size(269, 31);
            this.AirDetailLabel.TabIndex = 9;
            this.AirDetailLabel.Text = "pm10: 15 ㎍/㎥  |  pm10: 15 ㎍/㎥\r\n마지막 측정: 2018-06-23 20:00 ";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.MainPanel.Controls.Add(this.AirStateLabel);
            this.MainPanel.Controls.Add(this.AirCommentLabel);
            this.MainPanel.Controls.Add(this.AirDetailLabel);
            this.MainPanel.Controls.Add(this.PictureBox2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(12, 0, 12, 15);
            this.MainPanel.Size = new System.Drawing.Size(374, 112);
            this.MainPanel.TabIndex = 12;
            // 
            // AirCommentLabel
            // 
            this.AirCommentLabel.BackColor = System.Drawing.Color.Transparent;
            this.AirCommentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AirCommentLabel.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AirCommentLabel.ForeColor = System.Drawing.Color.White;
            this.AirCommentLabel.Location = new System.Drawing.Point(93, 0);
            this.AirCommentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AirCommentLabel.Name = "AirCommentLabel";
            this.AirCommentLabel.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.AirCommentLabel.Size = new System.Drawing.Size(269, 25);
            this.AirCommentLabel.TabIndex = 10;
            this.AirCommentLabel.Text = "잠시만 기다려 주세요";
            this.AirCommentLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AniTimer
            // 
            this.AniTimer.Interval = 20;
            // 
            // FirstWaitTimer
            // 
            this.FirstWaitTimer.Enabled = true;
            this.FirstWaitTimer.Interval = 5000;
            // 
            // OptBT
            // 
            this.OptBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.OptBT.Image = global::WindowsFormsApp1.Properties.Resources.opticon;
            this.OptBT.Location = new System.Drawing.Point(280, 0);
            this.OptBT.Margin = new System.Windows.Forms.Padding(2);
            this.OptBT.Name = "OptBT";
            this.OptBT.Size = new System.Drawing.Size(47, 30);
            this.OptBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OptBT.TabIndex = 6;
            this.OptBT.TabStop = false;
            // 
            // CloseBT
            // 
            this.CloseBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBT.Image = global::WindowsFormsApp1.Properties.Resources.closeicon;
            this.CloseBT.Location = new System.Drawing.Point(327, 0);
            this.CloseBT.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(47, 30);
            this.CloseBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBT.TabIndex = 3;
            this.CloseBT.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.icon;
            this.PictureBox2.Location = new System.Drawing.Point(12, 0);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(81, 97);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 7;
            this.PictureBox2.TabStop = false;
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 142);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PopupForm";
            this.TopPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OptBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label AirStateLabel;
        internal System.Windows.Forms.Panel TopPanel;
        internal System.Windows.Forms.PictureBox OptBT;
        internal System.Windows.Forms.Label TitleLabel;
        internal System.Windows.Forms.PictureBox CloseBT;
        internal System.Windows.Forms.Label AirDetailLabel;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Panel MainPanel;
        internal System.Windows.Forms.Label AirCommentLabel;
        internal System.Windows.Forms.Timer AniTimer;
        internal System.Windows.Forms.Timer FirstWaitTimer;
    }
}