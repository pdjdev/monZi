namespace WindowsFormsApp1.Forms
{
    partial class APIForm
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
            this.Button13 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button12 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button11 = new System.Windows.Forms.Button();
            this.userapikeybox = new System.Windows.Forms.TextBox();
            this.Button10 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.customapibox = new System.Windows.Forms.TextBox();
            this.Button5 = new System.Windows.Forms.Button();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.APICheck = new System.Windows.Forms.Timer(this.components);
            this.PCTimeCheck = new System.Windows.Forms.Timer(this.components);
            this.Button7 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.AirAPICheck = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button13
            // 
            this.Button13.Location = new System.Drawing.Point(417, 109);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(44, 23);
            this.Button13.TabIndex = 44;
            this.Button13.Text = "적용";
            this.Button13.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(263, 85);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(79, 15);
            this.Label3.TabIndex = 43;
            this.Label3.Text = "커스텀APIURI";
            // 
            // Button12
            // 
            this.Button12.Location = new System.Drawing.Point(92, 180);
            this.Button12.Margin = new System.Windows.Forms.Padding(1);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(75, 30);
            this.Button12.TabIndex = 42;
            this.Button12.Text = "APIType";
            this.Button12.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(263, 148);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(128, 30);
            this.Label2.TabIndex = 41;
            this.Label2.Text = "AKAPI 개인인증키설정\r\n(비어 있음=기본값)";
            // 
            // Button11
            // 
            this.Button11.Location = new System.Drawing.Point(417, 185);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(44, 23);
            this.Button11.TabIndex = 40;
            this.Button11.Text = "적용";
            this.Button11.UseVisualStyleBackColor = true;
            // 
            // userapikeybox
            // 
            this.userapikeybox.Location = new System.Drawing.Point(266, 185);
            this.userapikeybox.Name = "userapikeybox";
            this.userapikeybox.Size = new System.Drawing.Size(145, 23);
            this.userapikeybox.TabIndex = 39;
            // 
            // Button10
            // 
            this.Button10.Location = new System.Drawing.Point(137, 109);
            this.Button10.Margin = new System.Windows.Forms.Padding(1);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(120, 30);
            this.Button10.TabIndex = 38;
            this.Button10.Text = "makeException";
            this.Button10.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(263, 60);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 15);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "not changed";
            // 
            // customapibox
            // 
            this.customapibox.Location = new System.Drawing.Point(266, 109);
            this.customapibox.Name = "customapibox";
            this.customapibox.Size = new System.Drawing.Size(145, 23);
            this.customapibox.TabIndex = 36;
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(15, 180);
            this.Button5.Margin = new System.Windows.Forms.Padding(1);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(75, 30);
            this.Button5.TabIndex = 35;
            this.Button5.Text = "isAPIBusy";
            this.Button5.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(264, 34);
            this.CheckBox2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(118, 19);
            this.CheckBox2.TabIndex = 34;
            this.CheckBox2.Text = "실시간 푸시 설정";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(137, 45);
            this.Button9.Margin = new System.Windows.Forms.Padding(1);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(120, 30);
            this.Button9.TabIndex = 33;
            this.Button9.Text = "hide";
            this.Button9.UseVisualStyleBackColor = true;
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(15, 109);
            this.Button8.Margin = new System.Windows.Forms.Padding(1);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(120, 30);
            this.Button8.TabIndex = 32;
            this.Button8.Text = "popup";
            this.Button8.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(137, 77);
            this.Button6.Margin = new System.Windows.Forms.Padding(1);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(120, 30);
            this.Button6.TabIndex = 30;
            this.Button6.Text = "reset";
            this.Button6.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(264, 13);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(118, 19);
            this.CheckBox1.TabIndex = 29;
            this.CheckBox1.Text = "실시간 알림 설정";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.Location = new System.Drawing.Point(15, 148);
            this.NumericUpDown1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.NumericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(242, 23);
            this.NumericUpDown1.TabIndex = 28;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(174, 180);
            this.Button4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(83, 30);
            this.Button4.TabIndex = 27;
            this.Button4.Text = "apply";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(15, 77);
            this.Button3.Margin = new System.Windows.Forms.Padding(1);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(120, 30);
            this.Button3.TabIndex = 26;
            this.Button3.Text = "updateair";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // APICheck
            // 
            this.APICheck.Interval = 300000;
            // 
            // PCTimeCheck
            // 
            this.PCTimeCheck.Enabled = true;
            this.PCTimeCheck.Interval = 2000;
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(137, 13);
            this.Button7.Margin = new System.Windows.Forms.Padding(1);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(120, 30);
            this.Button7.TabIndex = 31;
            this.Button7.Text = "close";
            this.Button7.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(15, 45);
            this.Button2.Margin = new System.Windows.Forms.Padding(1);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(120, 30);
            this.Button2.TabIndex = 25;
            this.Button2.Text = "findair";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(15, 13);
            this.Button1.Margin = new System.Windows.Forms.Padding(1);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(120, 30);
            this.Button1.TabIndex = 24;
            this.Button1.Text = "guiopen";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // AirAPICheck
            // 
            this.AirAPICheck.WorkerSupportsCancellation = true;
            // 
            // APIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(477, 223);
            this.ControlBox = false;
            this.Controls.Add(this.Button13);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Button12);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button11);
            this.Controls.Add(this.userapikeybox);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.customapibox);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.CheckBox2);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.NumericUpDown1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "APIForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "APIForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button13;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button Button12;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button11;
        internal System.Windows.Forms.TextBox userapikeybox;
        internal System.Windows.Forms.Button Button10;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox customapibox;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.CheckBox CheckBox2;
        internal System.Windows.Forms.Button Button9;
        internal System.Windows.Forms.Button Button8;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.NumericUpDown NumericUpDown1;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Timer APICheck;
        internal System.Windows.Forms.Timer PCTimeCheck;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.ComponentModel.BackgroundWorker AirAPICheck;
    }
}