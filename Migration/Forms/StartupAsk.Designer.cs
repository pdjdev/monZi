namespace WindowsFormsApp1.Forms
{
    partial class StartupAsk
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
            this.AirCommentLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.CloseBT = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AirCommentLabel
            // 
            this.AirCommentLabel.BackColor = System.Drawing.Color.Transparent;
            this.AirCommentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AirCommentLabel.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AirCommentLabel.ForeColor = System.Drawing.Color.White;
            this.AirCommentLabel.Location = new System.Drawing.Point(79, 0);
            this.AirCommentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AirCommentLabel.Name = "AirCommentLabel";
            this.AirCommentLabel.Padding = new System.Windows.Forms.Padding(13, 0, 0, 3);
            this.AirCommentLabel.Size = new System.Drawing.Size(291, 64);
            this.AirCommentLabel.TabIndex = 10;
            this.AirCommentLabel.Text = "현재 monZi가 시작프로그램으로\r\n설정되지 않은 것 같습니다.\r\n시작프로그램으로 설정하시겠습니까?";
            this.AirCommentLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.TopPanel.Controls.Add(this.TitleLabel);
            this.TopPanel.Controls.Add(this.CloseBT);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TopPanel.Size = new System.Drawing.Size(380, 30);
            this.TopPanel.TabIndex = 13;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(5, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(328, 30);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "시작프로그램 설정";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.MainPanel.Controls.Add(this.Label1);
            this.MainPanel.Controls.Add(this.AirCommentLabel);
            this.MainPanel.Controls.Add(this.PictureBox2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MainPanel.Size = new System.Drawing.Size(380, 94);
            this.MainPanel.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(79, 64);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(13, 5, 0, 3);
            this.Label1.Size = new System.Drawing.Size(291, 30);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "(더욱 편리하게 실시간 업데이트를 받을 수 있습니다)";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 124);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(380, 42);
            this.Panel1.TabIndex = 14;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(67)))), ((int)(((byte)(74)))));
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(137, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(136, 34);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "네, 설정하겠습니다";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(67)))), ((int)(((byte)(74)))));
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(279, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(96, 34);
            this.Button2.TabIndex = 6;
            this.Button2.Text = "괜찮습니다";
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // CloseBT
            // 
            this.CloseBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBT.Image = global::WindowsFormsApp1.Properties.Resources.closeicon;
            this.CloseBT.Location = new System.Drawing.Point(333, 0);
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
            this.PictureBox2.Location = new System.Drawing.Point(10, 0);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(69, 94);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 7;
            this.PictureBox2.TabStop = false;
            // 
            // StartupAsk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(380, 166);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartupAsk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StartupAsk";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.TopPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label AirCommentLabel;
        internal System.Windows.Forms.Panel TopPanel;
        internal System.Windows.Forms.Label TitleLabel;
        internal System.Windows.Forms.PictureBox CloseBT;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Panel MainPanel;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
    }
}