namespace Project
{
    partial class Booking
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            numTickets = new NumericUpDown();
            label6 = new Label();
            groupBox3 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            chkWifi = new CheckBox();
            chkMeal = new CheckBox();
            label7 = new Label();
            groupBox4 = new GroupBox();
            btnBack = new Button();
            btnSave = new Button();
            btnCalc = new Button();
            lblPrice = new Label();
            label70 = new Label();
            groupBox5 = new GroupBox();
            label60 = new Label();
            label50 = new Label();
            label40 = new Label();
            radioVIB = new RadioButton();
            radioFirst = new RadioButton();
            radioNormal = new RadioButton();
            label3 = new Label();
            txtName = new TextBox();
            label11 = new Label();
            comFrom = new ComboBox();
            comTo = new ComboBox();
            label20 = new Label();
            label30 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTickets).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(297, 21);
            label1.Name = "label1";
            label1.Size = new Size(209, 41);
            label1.TabIndex = 0;
            label1.Text = "حجز تذكرة قطار";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(26, 15, 4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(numTickets);
            groupBox2.Controls.Add(label6);
            groupBox2.ForeColor = Color.Gold;
            groupBox2.Location = new Point(487, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 93);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "عدد التذاكر";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(79, 56);
            label2.Name = "label2";
            label2.Size = new Size(129, 17);
            label2.TabIndex = 2;
            label2.Text = "(أقصى عدد للتذاكر 10)";
            // 
            // numTickets
            // 
            numTickets.BackColor = Color.FromArgb(133, 79, 11);
            numTickets.BorderStyle = BorderStyle.FixedSingle;
            numTickets.Cursor = Cursors.Hand;
            numTickets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numTickets.ForeColor = Color.White;
            numTickets.Location = new Point(70, 26);
            numTickets.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numTickets.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTickets.Name = "numTickets";
            numTickets.Size = new Size(154, 27);
            numTickets.TabIndex = 1;
            numTickets.TextAlign = HorizontalAlignment.Center;
            numTickets.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(20, 23);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(26, 15, 4);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(chkWifi);
            groupBox3.Controls.Add(chkMeal);
            groupBox3.Controls.Add(label7);
            groupBox3.ForeColor = Color.Gold;
            groupBox3.Location = new Point(31, 232);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(363, 87);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "اضافات اختياريه";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.wifi1;
            pictureBox3.Location = new Point(233, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.meal1;
            pictureBox2.Location = new Point(62, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // chkWifi
            // 
            chkWifi.Cursor = Cursors.Hand;
            chkWifi.Location = new Point(202, 26);
            chkWifi.Name = "chkWifi";
            chkWifi.Size = new Size(145, 55);
            chkWifi.TabIndex = 2;
            chkWifi.Text = "واى فاى\r\n+10 جنية\r\n";
            chkWifi.TextAlign = ContentAlignment.MiddleRight;
            chkWifi.UseVisualStyleBackColor = true;
            // 
            // chkMeal
            // 
            chkMeal.Cursor = Cursors.Hand;
            chkMeal.Location = new Point(37, 23);
            chkMeal.Name = "chkMeal";
            chkMeal.Size = new Size(135, 58);
            chkMeal.TabIndex = 1;
            chkMeal.Text = "وجبة\r\n+20 جينة\r\n";
            chkMeal.TextAlign = ContentAlignment.MiddleRight;
            chkMeal.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(17, 23);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(26, 15, 4);
            groupBox4.Controls.Add(btnBack);
            groupBox4.Controls.Add(btnSave);
            groupBox4.Controls.Add(btnCalc);
            groupBox4.Controls.Add(lblPrice);
            groupBox4.Controls.Add(label70);
            groupBox4.Location = new Point(31, 325);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(729, 121);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(133, 79, 11);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(17, 32);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 53);
            btnBack.TabIndex = 4;
            btnBack.Text = "رجوع";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(133, 79, 11);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(133, 32);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 53);
            btnSave.TabIndex = 3;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.FromArgb(133, 79, 11);
            btnCalc.Cursor = Cursors.Hand;
            btnCalc.FlatAppearance.BorderSize = 0;
            btnCalc.FlatStyle = FlatStyle.Flat;
            btnCalc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalc.ForeColor = Color.White;
            btnCalc.Location = new Point(535, 26);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(145, 63);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "احسب السعر";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblPrice
            // 
            lblPrice.FlatStyle = FlatStyle.Flat;
            lblPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Gold;
            lblPrice.Location = new Point(251, 55);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(225, 45);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "0 جنية";
            lblPrice.TextAlign = ContentAlignment.TopCenter;
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.ForeColor = Color.Gold;
            label70.Location = new Point(312, 23);
            label70.Name = "label70";
            label70.Size = new Size(94, 20);
            label70.TabIndex = 0;
            label70.Text = "اجمالى السعر";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(26, 15, 4);
            groupBox5.Controls.Add(label60);
            groupBox5.Controls.Add(label50);
            groupBox5.Controls.Add(label40);
            groupBox5.Controls.Add(radioVIB);
            groupBox5.Controls.Add(radioFirst);
            groupBox5.Controls.Add(radioNormal);
            groupBox5.Controls.Add(label3);
            groupBox5.ForeColor = Color.Gold;
            groupBox5.Location = new Point(487, 76);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(250, 135);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "درجه السفر";
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Location = new Point(158, 99);
            label60.Name = "label60";
            label60.Size = new Size(74, 20);
            label60.TabIndex = 6;
            label60.Text = "(150 جنية)";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(158, 69);
            label50.Name = "label50";
            label50.Size = new Size(74, 20);
            label50.TabIndex = 5;
            label50.Text = "(100 جنية)";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(158, 39);
            label40.Name = "label40";
            label40.Size = new Size(66, 20);
            label40.TabIndex = 4;
            label40.Text = "(50 جنية)";
            // 
            // radioVIB
            // 
            radioVIB.AutoSize = true;
            radioVIB.Cursor = Cursors.Hand;
            radioVIB.ForeColor = Color.White;
            radioVIB.Location = new Point(12, 95);
            radioVIB.Name = "radioVIB";
            radioVIB.Size = new Size(77, 24);
            radioVIB.TabIndex = 3;
            radioVIB.TabStop = true;
            radioVIB.Text = "VIP نوم";
            radioVIB.UseVisualStyleBackColor = true;
            // 
            // radioFirst
            // 
            radioFirst.AutoSize = true;
            radioFirst.Cursor = Cursors.Hand;
            radioFirst.ForeColor = Color.White;
            radioFirst.Location = new Point(12, 65);
            radioFirst.Name = "radioFirst";
            radioFirst.Size = new Size(95, 24);
            radioFirst.TabIndex = 2;
            radioFirst.TabStop = true;
            radioFirst.Text = "درجة اولى";
            radioFirst.UseVisualStyleBackColor = true;
            // 
            // radioNormal
            // 
            radioNormal.AutoSize = true;
            radioNormal.Cursor = Cursors.Hand;
            radioNormal.ForeColor = Color.White;
            radioNormal.Location = new Point(12, 35);
            radioNormal.Name = "radioNormal";
            radioNormal.Size = new Size(99, 24);
            radioNormal.TabIndex = 1;
            radioNormal.TabStop = true;
            radioNormal.Text = "درجة عادية";
            radioNormal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(26, 15, 4);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(31, 99);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "اكتب اسم المسافر";
            txtName.Size = new Size(363, 31);
            txtName.TabIndex = 6;
            txtName.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Gold;
            label11.Location = new Point(31, 64);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 7;
            label11.Text = "اسم المسافر";
            // 
            // comFrom
            // 
            comFrom.BackColor = Color.FromArgb(26, 15, 4);
            comFrom.Cursor = Cursors.Hand;
            comFrom.FlatStyle = FlatStyle.Flat;
            comFrom.ForeColor = Color.White;
            comFrom.FormattingEnabled = true;
            comFrom.Location = new Point(31, 182);
            comFrom.Name = "comFrom";
            comFrom.Size = new Size(151, 28);
            comFrom.TabIndex = 8;
            comFrom.Text = "اختر _محطة";
            // 
            // comTo
            // 
            comTo.BackColor = Color.FromArgb(26, 15, 4);
            comTo.Cursor = Cursors.Hand;
            comTo.FlatStyle = FlatStyle.Flat;
            comTo.ForeColor = Color.White;
            comTo.FormattingEnabled = true;
            comTo.Location = new Point(243, 182);
            comTo.Name = "comTo";
            comTo.Size = new Size(151, 28);
            comTo.TabIndex = 9;
            comTo.Text = "اختر _محطة";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Gold;
            label20.Location = new Point(31, 156);
            label20.Name = "label20";
            label20.Size = new Size(99, 20);
            label20.TabIndex = 10;
            label20.Text = "من — المحطة";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.ForeColor = Color.Gold;
            label30.Location = new Point(243, 156);
            label30.Name = "label30";
            label30.Size = new Size(96, 20);
            label30.TabIndex = 11;
            label30.Text = "إلى — الوجهة";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.train1;
            pictureBox1.Location = new Point(229, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 26, 8);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label30);
            Controls.Add(label20);
            Controls.Add(comTo);
            Controls.Add(comFrom);
            Controls.Add(label11);
            Controls.Add(txtName);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "حجز تذكرة قطار";
            Load += Form3_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTickets).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label lblPrice;
        private Label label70;
        private Label label11;
        private Label label60;
        private Label label50;
        private Label label40;
        private Label label20;
        private Label label30;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox txtName;
        private RadioButton radioVIB;
        private RadioButton radioFirst;
        private RadioButton radioNormal;
        private CheckBox chkWifi;
        private CheckBox chkMeal;
        private ComboBox comFrom;
        private ComboBox comTo;
        private Button btnCalc;
        private Button btnBack;
        private Button btnSave;
        private NumericUpDown numTickets;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}