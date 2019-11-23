namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel3 = new System.Windows.Forms.Panel();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.LinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Label4 = new System.Windows.Forms.Label();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Button1 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.RichTextBox1);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.Label3);
            this.Panel3.Controls.Add(this.LinkLabel2);
            this.Panel3.Controls.Add(this.Label4);
            this.Panel3.Controls.Add(this.LinkLabel1);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(0, 85);
            this.Panel3.Name = "Panel3";
            this.Panel3.Padding = new System.Windows.Forms.Padding(12);
            this.Panel3.Size = new System.Drawing.Size(525, 285);
            this.Panel3.TabIndex = 15;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox1.DetectUrls = false;
            this.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RichTextBox1.ForeColor = System.Drawing.Color.White;
            this.RichTextBox1.Location = new System.Drawing.Point(12, 58);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ReadOnly = true;
            this.RichTextBox1.Size = new System.Drawing.Size(501, 101);
            this.RichTextBox1.TabIndex = 5;
            this.RichTextBox1.Text = "Undefined";
            // 
            // Label2
            // 
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label2.Location = new System.Drawing.Point(12, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(501, 46);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "monZi 작동 도중 예키지 못한 예외 동작 발생으로 작업이 중단되었습니다.\r\n오류 사항은 다음과 같습니다:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label3.Location = new System.Drawing.Point(12, 159);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Label3.Size = new System.Drawing.Size(501, 53);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "프로그램 재시작 후에도 오류가 지속될경우, 새 업데이트를 확인해 보시고\r\n최신 버전으로 설치 후에도 오류가 지속된다면";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LinkLabel2
            // 
            this.LinkLabel2.AutoSize = true;
            this.LinkLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LinkLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LinkLabel2.Location = new System.Drawing.Point(12, 212);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new System.Drawing.Size(417, 17);
            this.LinkLabel2.TabIndex = 9;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "여기를 클릭하여 monZi의 애플리케이션 설정을 완전히 제거하십시오.";
            // 
            // Label4
            // 
            this.Label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label4.Location = new System.Drawing.Point(12, 229);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(501, 27);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "설정 초기화 후에도 오류가 지속된다면";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LinkLabel1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LinkLabel1.Location = new System.Drawing.Point(12, 256);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(420, 17);
            this.LinkLabel1.TabIndex = 7;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "이 링크를 클릭하여 오류 정보를 복사한 뒤 개발자에게 보고해 주세요.";
            // 
            // Button1
            // 
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Location = new System.Drawing.Point(389, 11);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(124, 46);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "프로그램 종료";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icon;
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(60, 60);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(10);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(525, 85);
            this.Panel1.TabIndex = 13;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(78, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(416, 42);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "불편을 끼쳐드려서 죄송합니다.\r\nmonZi 작동 도중 예상하지 못한 오류가 발생하였습니다.";
            // 
            // Button2
            // 
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Location = new System.Drawing.Point(256, 11);
            this.Button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(127, 46);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "강제로 계속 실행\r\n(권장하지 않음)";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Location = new System.Drawing.Point(12, 11);
            this.Button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(130, 46);
            this.Button3.TabIndex = 8;
            this.Button3.Text = "클립보드로\r\n오류 세부 내용 복사";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.Button1);
            this.Panel2.Controls.Add(this.Button2);
            this.Panel2.Controls.Add(this.Button3);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 370);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(525, 70);
            this.Panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(525, 440);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.LinkLabel LinkLabel2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Panel Panel2;
    }
}

