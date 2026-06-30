namespace Project
{
    partial class SignUp
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
            btnBack = new Button();
            labelPass = new Label();
            labelUser = new Label();
            textBoxPass = new TextBox();
            textBoxUser = new TextBox();
            btnSign = new Button();
            checkBoxShow = new CheckBox();
            textBoxConfirm = new TextBox();
            label2 = new Label();
            labelTitle2 = new Label();
            labelTitle = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(26, 46, 74);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 46, 74);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 60, 90);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(180, 200, 220);
            btnBack.Location = new Point(121, 493);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(300, 38);
            btnBack.TabIndex = 29;
            btnBack.Text = "رجوع";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPass.ForeColor = Color.FromArgb(200, 220, 240);
            labelPass.Location = new Point(61, 307);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(107, 25);
            labelPass.TabIndex = 28;
            labelPass.Text = "كلمة المرور :";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUser.ForeColor = Color.FromArgb(200, 220, 240);
            labelUser.Location = new Point(36, 254);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(132, 25);
            labelUser.TabIndex = 27;
            labelUser.Text = "اسم المستخدم :";
            // 
            // textBoxPass
            // 
            textBoxPass.BackColor = Color.FromArgb(13, 30, 48);
            textBoxPass.BorderStyle = BorderStyle.FixedSingle;
            textBoxPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPass.ForeColor = Color.FromArgb(214, 234, 248);
            textBoxPass.Location = new Point(193, 305);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(300, 31);
            textBoxPass.TabIndex = 26;
            // 
            // textBoxUser
            // 
            textBoxUser.BackColor = Color.FromArgb(13, 30, 48);
            textBoxUser.BorderStyle = BorderStyle.FixedSingle;
            textBoxUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUser.ForeColor = Color.FromArgb(214, 234, 248);
            textBoxUser.Location = new Point(193, 254);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(300, 31);
            textBoxUser.TabIndex = 25;
            // 
            // btnSign
            // 
            btnSign.AccessibleRole = AccessibleRole.None;
            btnSign.BackColor = Color.FromArgb(24, 95, 165);
            btnSign.Cursor = Cursors.Hand;
            btnSign.FlatAppearance.BorderSize = 0;
            btnSign.FlatStyle = FlatStyle.Flat;
            btnSign.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSign.ForeColor = SystemColors.Control;
            btnSign.Location = new Point(121, 449);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(300, 38);
            btnSign.TabIndex = 24;
            btnSign.Text = "إنشاء حساب";
            btnSign.UseVisualStyleBackColor = false;
            btnSign.Click += btnSign_Click;
            // 
            // checkBoxShow
            // 
            checkBoxShow.AutoSize = true;
            checkBoxShow.Cursor = Cursors.Hand;
            checkBoxShow.ForeColor = Color.FromArgb(122, 174, 212);
            checkBoxShow.Location = new Point(272, 410);
            checkBoxShow.Name = "checkBoxShow";
            checkBoxShow.Size = new Size(149, 24);
            checkBoxShow.TabIndex = 23;
            checkBoxShow.Text = "إظهار كلمة المرور  ";
            checkBoxShow.UseVisualStyleBackColor = true;
            checkBoxShow.CheckedChanged += checkBoxShow_CheckedChanged;
            // 
            // textBoxConfirm
            // 
            textBoxConfirm.BackColor = Color.FromArgb(13, 30, 48);
            textBoxConfirm.BorderStyle = BorderStyle.FixedSingle;
            textBoxConfirm.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxConfirm.ForeColor = Color.FromArgb(214, 234, 248);
            textBoxConfirm.Location = new Point(193, 355);
            textBoxConfirm.Name = "textBoxConfirm";
            textBoxConfirm.Size = new Size(300, 31);
            textBoxConfirm.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(200, 220, 240);
            label2.Location = new Point(21, 357);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 33;
            label2.Text = "تاكيد كلمة المرور :";
            // 
            // labelTitle2
            // 
            labelTitle2.AutoSize = true;
            labelTitle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle2.ForeColor = SystemColors.ActiveCaption;
            labelTitle2.Location = new Point(219, 216);
            labelTitle2.Name = "labelTitle2";
            labelTitle2.Size = new Size(244, 25);
            labelTitle2.TabIndex = 35;
            labelTitle2.Text = "Egyptian National Railways";
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.FromArgb(26, 46, 74);
            labelTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(181, 212, 244);
            labelTitle.Location = new Point(177, 171);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(340, 30);
            labelTitle.TabIndex = 34;
            labelTitle.Text = "إنشاء حساب جديد";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.train2;
            pictureBox2.Location = new Point(177, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(208, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 46, 74);
            ClientSize = new Size(549, 608);
            Controls.Add(pictureBox2);
            Controls.Add(labelTitle2);
            Controls.Add(labelTitle);
            Controls.Add(label2);
            Controls.Add(textBoxConfirm);
            Controls.Add(btnBack);
            Controls.Add(labelPass);
            Controls.Add(labelUser);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(btnSign);
            Controls.Add(checkBoxShow);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "محطة القطار —إنشاء حساب جديد";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label labelPass;
        private Label labelUser;
        private TextBox textBoxPass;
        private TextBox textBoxUser;
        private Button btnSign;
        private CheckBox checkBoxShow;
        private TextBox textBoxConfirm;
        private Label label2;
        private Label labelTitle2;
        private Label labelTitle;
        private PictureBox pictureBox2;
    }
}