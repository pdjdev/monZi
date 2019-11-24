namespace WindowsFormsApp1.Forms
{
    partial class UpdateForm
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
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.NewVerLabel = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.ForceUpdButton = new System.Windows.Forms.Button();
            this.UpdButton = new System.Windows.Forms.Button();
            this.VerLabel = new System.Windows.Forms.Label();
            this.UpdateChk = new System.ComponentModel.BackgroundWorker();
            this.CloseBT = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBT)).BeginInit();
            this.SuspendLayout();
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.BackColor = System.Drawing.Color.White;
            this.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox1.Location = new System.Drawing.Point(0, 0);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ReadOnly = true;
            this.RichTextBox1.Size = new System.Drawing.Size(390, 80);
            this.RichTextBox1.TabIndex = 37;
            this.RichTextBox1.Text = "";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.TopPanel.Controls.Add(this.TitleLabel);
            this.TopPanel.Controls.Add(this.CloseBT);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TopPanel.Size = new System.Drawing.Size(425, 30);
            this.TopPanel.TabIndex = 10;
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
            this.TitleLabel.Text = "업데이트 확인";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.NewVerLabel);
            this.Panel1.Controls.Add(this.Panel4);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.VerLabel);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 30);
            this.Panel1.Name = "Panel1";
            this.Panel1.Padding = new System.Windows.Forms.Padding(15);
            this.Panel1.Size = new System.Drawing.Size(425, 180);
            this.Panel1.TabIndex = 11;
            // 
            // NewVerLabel
            // 
            this.NewVerLabel.AutoSize = true;
            this.NewVerLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NewVerLabel.Location = new System.Drawing.Point(162, 12);
            this.NewVerLabel.Name = "NewVerLabel";
            this.NewVerLabel.Size = new System.Drawing.Size(172, 20);
            this.NewVerLabel.TabIndex = 42;
            this.NewVerLabel.Text = "최신 버전: (불러오는 중)";
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.DimGray;
            this.Panel4.Location = new System.Drawing.Point(18, 43);
            this.Panel4.Margin = new System.Windows.Forms.Padding(8);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(390, 1);
            this.Panel4.TabIndex = 41;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.RichTextBox1);
            this.Panel3.Controls.Add(this.Panel6);
            this.Panel3.Controls.Add(this.Panel5);
            this.Panel3.Location = new System.Drawing.Point(18, 46);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(390, 122);
            this.Panel3.TabIndex = 41;
            // 
            // Panel6
            // 
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel6.Location = new System.Drawing.Point(0, 80);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(390, 5);
            this.Panel6.TabIndex = 40;
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.ForceUpdButton);
            this.Panel5.Controls.Add(this.UpdButton);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel5.Location = new System.Drawing.Point(0, 85);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(390, 37);
            this.Panel5.TabIndex = 39;
            // 
            // ForceUpdButton
            // 
            this.ForceUpdButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ForceUpdButton.Enabled = false;
            this.ForceUpdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForceUpdButton.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForceUpdButton.Location = new System.Drawing.Point(0, 0);
            this.ForceUpdButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ForceUpdButton.Name = "ForceUpdButton";
            this.ForceUpdButton.Size = new System.Drawing.Size(98, 37);
            this.ForceUpdButton.TabIndex = 38;
            this.ForceUpdButton.Text = "상관없이 가기";
            this.ForceUpdButton.UseVisualStyleBackColor = true;
            // 
            // UpdButton
            // 
            this.UpdButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.UpdButton.Enabled = false;
            this.UpdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdButton.Location = new System.Drawing.Point(212, 0);
            this.UpdButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(178, 37);
            this.UpdButton.TabIndex = 21;
            this.UpdButton.Text = "업데이트 다운 페이지 열기";
            this.UpdButton.UseVisualStyleBackColor = true;
            // 
            // VerLabel
            // 
            this.VerLabel.AutoSize = true;
            this.VerLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VerLabel.Location = new System.Drawing.Point(14, 12);
            this.VerLabel.Name = "VerLabel";
            this.VerLabel.Size = new System.Drawing.Size(77, 20);
            this.VerLabel.TabIndex = 39;
            this.VerLabel.Text = "현재 버전:";
            // 
            // CloseBT
            // 
            this.CloseBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBT.Image = global::WindowsFormsApp1.Properties.Resources.closeicon;
            this.CloseBT.Location = new System.Drawing.Point(378, 0);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(47, 30);
            this.CloseBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBT.TabIndex = 3;
            this.CloseBT.TabStop = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(425, 210);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UpdateForm";
            this.TopPanel.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.Panel TopPanel;
        internal System.Windows.Forms.Label TitleLabel;
        internal System.Windows.Forms.PictureBox CloseBT;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label NewVerLabel;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Panel Panel6;
        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Button ForceUpdButton;
        internal System.Windows.Forms.Button UpdButton;
        internal System.Windows.Forms.Label VerLabel;
        internal System.ComponentModel.BackgroundWorker UpdateChk;
    }
}