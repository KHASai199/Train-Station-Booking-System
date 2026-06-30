namespace Project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFaild = new Label();
            pictureBox1 = new PictureBox();
            labelTitle2 = new Label();
            labelTitle = new Label();
            btnExit = new Button();
            labelPass = new Label();
            labelUser = new Label();
            textBoxPass = new TextBox();
            textBoxUser = new TextBox();
            btnLogin = new Button();
            checkBoxShow = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelFaild
            // 
            labelFaild.BackColor = Color.Transparent;
            labelFaild.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFaild.ForeColor = Color.Red;
            labelFaild.Location = new Point(295, 202);
            labelFaild.Name = "labelFaild";
            labelFaild.Size = new Size(221, 30);
            labelFaild.TabIndex = 21;
            labelFaild.Text = "اسم المستخدم أو الباسورد غلط";
            labelFaild.TextAlign = ContentAlignment.MiddleCenter;
            labelFaild.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.train__1_;
            pictureBox1.Location = new Point(364, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // labelTitle2
            // 
            labelTitle2.AutoSize = true;
            labelTitle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle2.ForeColor = SystemColors.ActiveCaption;
            labelTitle2.Location = new Point(283, 136);
            labelTitle2.Name = "labelTitle2";
            labelTitle2.Size = new Size(244, 25);
            labelTitle2.TabIndex = 19;
            labelTitle2.Text = "Egyptian National Railways";
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.FromArgb(26, 46, 74);
            labelTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(181, 212, 244);
            labelTitle.Location = new Point(237, 93);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(340, 30);
            labelTitle.TabIndex = 18;
            labelTitle.Text = "نظام حجز تذاكر القطار";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(26, 46, 74);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 46, 74);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 60, 90);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(180, 200, 220);
            btnExit.Location = new Point(256, 389);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(300, 38);
            btnExit.TabIndex = 17;
            btnExit.Text = "خروج";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPass.ForeColor = Color.FromArgb(200, 220, 240);
            labelPass.Location = new Point(114, 288);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(107, 25);
            labelPass.TabIndex = 16;
            labelPass.Text = "كلمة المرور :";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUser.ForeColor = Color.FromArgb(200, 220, 240);
            labelUser.Location = new Point(89, 235);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(132, 25);
            labelUser.TabIndex = 15;
            labelUser.Text = "اسم المستخدم :";
            // 
            // textBoxPass
            // 
            textBoxPass.BackColor = Color.FromArgb(13, 30, 48);
            textBoxPass.BorderStyle = BorderStyle.FixedSingle;
            textBoxPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPass.ForeColor = Color.FromArgb(214, 234, 248);
            textBoxPass.Location = new Point(256, 286);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(300, 31);
            textBoxPass.TabIndex = 14;
            // 
            // textBoxUser
            // 
            textBoxUser.BackColor = Color.FromArgb(13, 30, 48);
            textBoxUser.BorderStyle = BorderStyle.FixedSingle;
            textBoxUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUser.ForeColor = Color.FromArgb(214, 234, 248);
            textBoxUser.Location = new Point(256, 235);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(300, 31);
            textBoxUser.TabIndex = 13;
            // 
            // btnLogin
            // 
            btnLogin.AccessibleRole = AccessibleRole.None;
            btnLogin.BackColor = Color.FromArgb(24, 95, 165);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(256, 354);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 38);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "تسجيل الدخول";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBoxShow
            // 
            checkBoxShow.AutoSize = true;
            checkBoxShow.Cursor = Cursors.Hand;
            checkBoxShow.ForeColor = Color.FromArgb(122, 174, 212);
            checkBoxShow.Location = new Point(407, 323);
            checkBoxShow.Name = "checkBoxShow";
            checkBoxShow.Size = new Size(149, 24);
            checkBoxShow.TabIndex = 11;
            checkBoxShow.Text = "إظهار كلمة المرور  ";
            checkBoxShow.UseVisualStyleBackColor = true;
            checkBoxShow.CheckedChanged += checkBoxShow_CheckedChanged;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(180, 200, 220);
            label1.Location = new Point(587, 389);
            label1.Name = "label1";
            label1.Size = new Size(163, 38);
            label1.TabIndex = 22;
            label1.Text = "إنشاء حساب جديد ؟";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 46, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelFaild);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitle2);
            Controls.Add(labelTitle);
            Controls.Add(btnExit);
            Controls.Add(labelPass);
            Controls.Add(labelUser);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(btnLogin);
            Controls.Add(checkBoxShow);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "محطة القطار — تسجيل الدخول";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFaild;
        private PictureBox pictureBox1;
        private Label labelTitle2;
        private Label labelTitle;
        private Button btnExit;
        private Label labelPass;
        private Label labelUser;
        private TextBox textBoxPass;
        private TextBox textBoxUser;
        private Button btnLogin;
        private CheckBox checkBoxShow;
        private Label label1;
    }
}
