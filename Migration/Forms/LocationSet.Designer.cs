namespace WindowsFormsApp1.Forms
{
    partial class LocationSet
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.HelpText = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.CloseBT = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.NoticePic = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoticePic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(163)))));
            this.TopPanel.Controls.Add(this.TitleLabel);
            this.TopPanel.Controls.Add(this.CloseBT);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TopPanel.Size = new System.Drawing.Size(482, 30);
            this.TopPanel.TabIndex = 8;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLabel.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(10, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(139, 30);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "현위치 설정";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.DimGray;
            this.Button2.Enabled = false;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(355, 94);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(115, 40);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "적용하기";
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CheckBox1.Location = new System.Drawing.Point(20, 60);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(117, 17);
            this.CheckBox1.TabIndex = 4;
            this.CheckBox1.Text = "측정소명으로 검색";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBox1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox1.ForeColor = System.Drawing.Color.Black;
            this.TextBox1.Location = new System.Drawing.Point(0, 28);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(354, 24);
            this.TextBox1.TabIndex = 1;
            // 
            // HelpText
            // 
            this.HelpText.AutoSize = true;
            this.HelpText.Font = new System.Drawing.Font("나눔스퀘어", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HelpText.ForeColor = System.Drawing.Color.Gray;
            this.HelpText.Location = new System.Drawing.Point(6, 27);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(127, 21);
            this.HelpText.TabIndex = 4;
            this.HelpText.Text = "예: 청호로 300";
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.Gray;
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel4.Location = new System.Drawing.Point(0, 52);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(354, 2);
            this.Panel4.TabIndex = 2;
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LinkLabel1.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel1.Location = new System.Drawing.Point(291, 61);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(171, 13);
            this.LinkLabel1.TabIndex = 6;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "입력한 위치의 주변 측정소 조회...";
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.Button1);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel5.Location = new System.Drawing.Point(354, 0);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(88, 54);
            this.Panel5.TabIndex = 3;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.DimGray;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(6, 24);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(82, 30);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "조회";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.HelpText);
            this.Panel2.Controls.Add(this.TextBox1);
            this.Panel2.Controls.Add(this.Panel4);
            this.Panel2.Controls.Add(this.Panel5);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(20, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(442, 54);
            this.Panel2.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("나눔스퀘어", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(15, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(273, 21);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "현재 위치의 주소를 입력해 주세요.";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 30);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(482, 54);
            this.Panel1.TabIndex = 6;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.LinkLabel1);
            this.Panel3.Controls.Add(this.NoticePic);
            this.Panel3.Controls.Add(this.Button2);
            this.Panel3.Controls.Add(this.CheckBox1);
            this.Panel3.Controls.Add(this.Panel2);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(0, 84);
            this.Panel3.Name = "Panel3";
            this.Panel3.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Panel3.Size = new System.Drawing.Size(482, 146);
            this.Panel3.TabIndex = 7;
            // 
            // CloseBT
            // 
            this.CloseBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBT.Image = global::WindowsFormsApp1.Properties.Resources.closeicon;
            this.CloseBT.Location = new System.Drawing.Point(435, 0);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(47, 30);
            this.CloseBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBT.TabIndex = 3;
            this.CloseBT.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.PictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.locicon;
            this.PictureBox2.Location = new System.Drawing.Point(416, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(66, 54);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 2;
            this.PictureBox2.TabStop = false;
            // 
            // NoticePic
            // 
            this.NoticePic.Image = global::WindowsFormsApp1.Properties.Resources.noticetxt;
            this.NoticePic.Location = new System.Drawing.Point(13, 94);
            this.NoticePic.Name = "NoticePic";
            this.NoticePic.Size = new System.Drawing.Size(336, 40);
            this.NoticePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NoticePic.TabIndex = 5;
            this.NoticePic.TabStop = false;
            // 
            // LocationSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(482, 230);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LocationSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LocationSet";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.TopPanel.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoticePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox CloseBT;
        internal System.Windows.Forms.Panel TopPanel;
        internal System.Windows.Forms.Label TitleLabel;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.PictureBox NoticePic;
        internal System.Windows.Forms.Label HelpText;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Panel3;
    }
}