namespace WindowsFormsApp1.Forms
{
    partial class LocList
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
            this.EmptyMsg_DownLink = new System.Windows.Forms.LinkLabel();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.LinkLabel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EmptyMsgPanel = new System.Windows.Forms.Panel();
            this.EmptyMsg_Upper = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CloseBT = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            this.EmptyMsgPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBT)).BeginInit();
            this.SuspendLayout();
            // 
            // EmptyMsg_DownLink
            // 
            this.EmptyMsg_DownLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmptyMsg_DownLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmptyMsg_DownLink.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmptyMsg_DownLink.LinkColor = System.Drawing.Color.Gray;
            this.EmptyMsg_DownLink.Location = new System.Drawing.Point(0, 104);
            this.EmptyMsg_DownLink.Name = "EmptyMsg_DownLink";
            this.EmptyMsg_DownLink.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.EmptyMsg_DownLink.Size = new System.Drawing.Size(420, 97);
            this.EmptyMsg_DownLink.TabIndex = 1;
            this.EmptyMsg_DownLink.TabStop = true;
            this.EmptyMsg_DownLink.Text = "여길 눌러 위치를 설정하세요";
            this.EmptyMsg_DownLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ListBox1
            // 
            this.ListBox1.BackColor = System.Drawing.Color.White;
            this.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox1.ColumnWidth = 5;
            this.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ListBox1.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 23;
            this.ListBox1.Items.AddRange(new object[] {
            "List"});
            this.ListBox1.Location = new System.Drawing.Point(0, 12);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(420, 177);
            this.ListBox1.TabIndex = 1;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopPanel.Controls.Add(this.ClearButton);
            this.TopPanel.Controls.Add(this.TitleLabel);
            this.TopPanel.Controls.Add(this.CloseBT);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TopPanel.Size = new System.Drawing.Size(420, 30);
            this.TopPanel.TabIndex = 17;
            // 
            // ClearButton
            // 
            this.ClearButton.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearButton.Font = new System.Drawing.Font("나눔스퀘어", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClearButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClearButton.Location = new System.Drawing.Point(307, 0);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.ClearButton.Size = new System.Drawing.Size(66, 30);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.TabStop = true;
            this.ClearButton.Text = "비우기";
            this.ClearButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("나눔스퀘어", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(10, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(363, 30);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "최근 위치";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmptyMsgPanel
            // 
            this.EmptyMsgPanel.BackColor = System.Drawing.Color.White;
            this.EmptyMsgPanel.Controls.Add(this.EmptyMsg_DownLink);
            this.EmptyMsgPanel.Controls.Add(this.EmptyMsg_Upper);
            this.EmptyMsgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmptyMsgPanel.Location = new System.Drawing.Point(0, 30);
            this.EmptyMsgPanel.Name = "EmptyMsgPanel";
            this.EmptyMsgPanel.Size = new System.Drawing.Size(420, 201);
            this.EmptyMsgPanel.TabIndex = 16;
            // 
            // EmptyMsg_Upper
            // 
            this.EmptyMsg_Upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmptyMsg_Upper.Font = new System.Drawing.Font("나눔스퀘어", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmptyMsg_Upper.ForeColor = System.Drawing.Color.Gray;
            this.EmptyMsg_Upper.Location = new System.Drawing.Point(0, 0);
            this.EmptyMsg_Upper.Name = "EmptyMsg_Upper";
            this.EmptyMsg_Upper.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.EmptyMsg_Upper.Size = new System.Drawing.Size(420, 104);
            this.EmptyMsg_Upper.TabIndex = 0;
            this.EmptyMsg_Upper.Text = "최근 설정한 위치가 없습니다";
            this.EmptyMsg_Upper.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.ListBox1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.MainPanel.Size = new System.Drawing.Size(420, 201);
            this.MainPanel.TabIndex = 18;
            // 
            // CloseBT
            // 
            this.CloseBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBT.Image = global::WindowsFormsApp1.Properties.Resources.closeicon;
            this.CloseBT.Location = new System.Drawing.Point(373, 0);
            this.CloseBT.Margin = new System.Windows.Forms.Padding(2);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(47, 30);
            this.CloseBT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBT.TabIndex = 3;
            this.CloseBT.TabStop = false;
            // 
            // LocList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(420, 231);
            this.Controls.Add(this.EmptyMsgPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LocList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LocList";
            this.TopPanel.ResumeLayout(false);
            this.EmptyMsgPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.LinkLabel EmptyMsg_DownLink;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Panel TopPanel;
        internal System.Windows.Forms.LinkLabel ClearButton;
        internal System.Windows.Forms.Label TitleLabel;
        internal System.Windows.Forms.PictureBox CloseBT;
        internal System.Windows.Forms.Panel EmptyMsgPanel;
        internal System.Windows.Forms.Label EmptyMsg_Upper;
        internal System.Windows.Forms.Panel MainPanel;
    }
}