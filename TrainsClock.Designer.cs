namespace Project
{
    partial class TrainsClock
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
            timer1 = new System.Windows.Forms.Timer(components);
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            labelTime = new Label();
            label2 = new Label();
            lblTitle = new Label();
            label1 = new Label();
            lblTotal = new Label();
            label4 = new Label();
            lblCancelled = new Label();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            btnReset = new Button();
            btnSearch = new Button();
            comboTo = new ComboBox();
            comboFrom = new ComboBox();
            listViewSchedule = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            lblLate = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(15, 42, 32);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(labelTime);
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(682, 102);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar__1_;
            pictureBox1.Location = new Point(71, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.FromArgb(126, 207, 160);
            labelTime.Location = new Point(71, 20);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(80, 25);
            labelTime.TabIndex = 2;
            labelTime.Text = "00:00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(90, 154, 120);
            label2.Location = new Point(466, 68);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 1;
            label2.Text = "Egyptian National Railways";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(126, 207, 160);
            lblTitle.Location = new Point(491, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(146, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "مواعيد القطارات";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(90, 154, 120);
            label1.Location = new Point(23, 78);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "إجمالي الرحلات";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(126, 207, 160);
            lblTotal.Location = new Point(38, 39);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 28);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "label1";
            lblTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(90, 154, 120);
            label4.Location = new Point(49, 78);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "ملغية";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCancelled
            // 
            lblCancelled.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCancelled.ForeColor = Color.FromArgb(226, 75, 74);
            lblCancelled.Location = new Point(40, 39);
            lblCancelled.Name = "lblCancelled";
            lblCancelled.Size = new Size(70, 28);
            lblCancelled.TabIndex = 0;
            lblCancelled.Text = "label4";
            lblCancelled.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(26, 74, 48);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(31, 537);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 39);
            btnBack.TabIndex = 7;
            btnBack.Text = "رجوع";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(15, 42, 32);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(comboTo);
            groupBox1.Controls.Add(comboFrom);
            groupBox1.ForeColor = Color.FromArgb(126, 207, 160);
            groupBox1.Location = new Point(31, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(624, 115);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "فلترة";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(126, 207, 160);
            label6.Location = new Point(289, 23);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 5;
            label6.Text = "الى — اختر المحطة";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(126, 207, 160);
            label5.Location = new Point(479, 23);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 4;
            label5.Text = "من — اختر المحطة";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(15, 42, 32);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(30, 61, 47);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(40, 58);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 3;
            btnReset.Text = "إعادة";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(26, 74, 48);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(26, 74, 48);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(152, 58);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // comboTo
            // 
            comboTo.BackColor = Color.FromArgb(15, 42, 32);
            comboTo.ForeColor = Color.FromArgb(90, 154, 120);
            comboTo.FormattingEnabled = true;
            comboTo.Location = new Point(277, 59);
            comboTo.Name = "comboTo";
            comboTo.Size = new Size(151, 28);
            comboTo.TabIndex = 1;
            // 
            // comboFrom
            // 
            comboFrom.BackColor = Color.FromArgb(15, 42, 32);
            comboFrom.ForeColor = Color.FromArgb(90, 154, 120);
            comboFrom.FormattingEnabled = true;
            comboFrom.Location = new Point(457, 59);
            comboFrom.Name = "comboFrom";
            comboFrom.Size = new Size(149, 28);
            comboFrom.TabIndex = 0;
            // 
            // listViewSchedule
            // 
            listViewSchedule.BackColor = Color.FromArgb(8, 21, 16);
            listViewSchedule.BorderStyle = BorderStyle.FixedSingle;
            listViewSchedule.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewSchedule.ForeColor = Color.FromArgb(126, 207, 160);
            listViewSchedule.FullRowSelect = true;
            listViewSchedule.GridLines = true;
            listViewSchedule.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewSchedule.Location = new Point(31, 388);
            listViewSchedule.Name = "listViewSchedule";
            listViewSchedule.Size = new Size(624, 121);
            listViewSchedule.TabIndex = 9;
            listViewSchedule.UseCompatibleStateImageBehavior = false;
            listViewSchedule.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "رقم القطار";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "المحطة";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "الوجهة";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "المغادرة";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "الوصول";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "الحالة";
            columnHeader6.Width = 80;
            // 
            // lblLate
            // 
            lblLate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLate.ForeColor = Color.FromArgb(239, 159, 39);
            lblLate.Location = new Point(36, 39);
            lblLate.Name = "lblLate";
            lblLate.Size = new Size(70, 28);
            lblLate.TabIndex = 0;
            lblLate.Text = "label3";
            lblLate.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(90, 154, 120);
            label3.Location = new Point(45, 78);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "متأخرة";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(501, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(154, 125);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblLate);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(268, 125);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(154, 125);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblCancelled);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(31, 125);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(154, 125);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            // 
            // TrainsClock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 31, 26);
            ClientSize = new Size(682, 588);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(listViewSchedule);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(panelHeader);
            ForeColor = Color.White;
            Name = "TrainsClock";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterParent;
            Text = "مواعيد القطارات";
            Load += TrainsClock_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel panelHeader;
        private Label labelTime;
        private Label label2;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Button btnBack;
        private GroupBox groupBox1;
        private Button btnReset;
        private Button btnSearch;
        private ComboBox comboTo;
        private ComboBox comboFrom;
        private ListView listViewSchedule;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label lblTotal;
        private Label lblCancelled;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label lblLate;
        private Label label3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}