namespace Project
{
    partial class Choose
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
            components = new System.ComponentModel.Container();
            btnView = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            labelDate = new Label();
            labelTime = new Label();
            btnBook = new Button();
            labelWelcome = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnSchedule = new Button();
            btnAdmin = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(13, 34, 25);
            btnView.Cursor = Cursors.Hand;
            btnView.FlatAppearance.BorderColor = Color.FromArgb(13, 34, 25);
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 58, 40);
            btnView.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 34, 25);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnView.ForeColor = Color.FromArgb(159, 225, 203);
            btnView.Location = new Point(464, 116);
            btnView.Name = "btnView";
            btnView.Size = new Size(166, 118);
            btnView.TabIndex = 15;
            btnView.Text = "عرض التذاكر";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(93, 202, 165);
            label1.Location = new Point(75, 63);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "مستخدم عادي";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDate.ForeColor = Color.FromArgb(93, 202, 165);
            labelDate.ImageAlign = ContentAlignment.MiddleRight;
            labelDate.Location = new Point(639, 71);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(74, 20);
            labelDate.TabIndex = 2;
            labelDate.Text = "labelDate";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.FromArgb(159, 225, 203);
            labelTime.Location = new Point(630, 34);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(137, 37);
            labelTime.TabIndex = 1;
            labelTime.Text = "label1";
            labelTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(13, 34, 25);
            btnBook.Cursor = Cursors.Hand;
            btnBook.FlatAppearance.BorderColor = Color.FromArgb(13, 34, 25);
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 58, 40);
            btnBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 34, 25);
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBook.ForeColor = Color.FromArgb(159, 225, 203);
            btnBook.Location = new Point(189, 116);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(166, 118);
            btnBook.TabIndex = 14;
            btnBook.Text = "حجز تذكرة جديدة";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.ForeColor = Color.FromArgb(159, 225, 203);
            labelWelcome.Location = new Point(75, 30);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(145, 28);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "labelWelcome";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(13, 34, 25);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelDate);
            groupBox1.Controls.Add(labelTime);
            groupBox1.Controls.Add(labelWelcome);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(-1, -21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(802, 115);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(24, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(30, 58, 47);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(13, 34, 25);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 58, 40);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 34, 25);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(189, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(441, 51);
            btnExit.TabIndex = 18;
            btnExit.Text = "خروج من البرنامج";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.FromArgb(13, 34, 25);
            btnSchedule.Cursor = Cursors.Hand;
            btnSchedule.FlatAppearance.BorderColor = Color.FromArgb(13, 34, 25);
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 58, 40);
            btnSchedule.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 34, 25);
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSchedule.ForeColor = Color.FromArgb(159, 225, 203);
            btnSchedule.Location = new Point(464, 250);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(166, 118);
            btnSchedule.TabIndex = 17;
            btnSchedule.Text = "مواعيد القطارات";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(13, 34, 25);
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(13, 34, 25);
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 58, 40);
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 34, 25);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.FromArgb(159, 225, 203);
            btnAdmin.Location = new Point(189, 250);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(166, 118);
            btnAdmin.TabIndex = 16;
            btnAdmin.Text = "لوحة الاداره";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(13, 34, 25);
            pictureBox5.Location = new Point(524, 250);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(13, 34, 25);
            pictureBox4.Location = new Point(249, 250);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(13, 34, 25);
            pictureBox3.Location = new Point(501, 116);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(13, 34, 25);
            pictureBox2.Location = new Point(249, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(13, 34, 25);
            pictureBox6.Image = Properties.Resources.ticket1;
            pictureBox6.Location = new Point(249, 116);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(51, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(13, 34, 25);
            pictureBox7.Image = Properties.Resources.booking__1_;
            pictureBox7.Location = new Point(524, 116);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(51, 44);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 25;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(13, 34, 25);
            pictureBox8.Image = Properties.Resources.transport;
            pictureBox8.Location = new Point(524, 250);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(51, 44);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 26;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(13, 34, 25);
            pictureBox9.Image = Properties.Resources.admin_panel;
            pictureBox9.Location = new Point(249, 250);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(51, 44);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 27;
            pictureBox9.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(159, 225, 203);
            label2.Location = new Point(37, 224);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 28;
            label2.Text = "اختر العمليه :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 58, 47);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(btnView);
            Controls.Add(btnBook);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnSchedule);
            Controls.Add(btnAdmin);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "محطة القطار — القائمة الرئيسية";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnView;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label labelDate;
        private Label labelTime;
        private Button btnBook;
        private Label labelWelcome;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnSchedule;
        private Button btnAdmin;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label label2;
    }
}