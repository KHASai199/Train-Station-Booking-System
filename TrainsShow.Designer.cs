namespace Project
{
    partial class TrainsShow
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
            btnLoad = new Button();
            btnShow = new Button();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            lblPrice = new Label();
            lblTo = new Label();
            lblFrom = new Label();
            lblName = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            lblCount = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            listBoxTickets = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(120, 20, 20);
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.ForeColor = Color.White;
            btnLoad.Location = new Point(74, 472);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(195, 40);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "⬇️⬇️ تحميل";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.FromArgb(120, 20, 20);
            btnShow.Cursor = Cursors.Hand;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.ForeColor = Color.White;
            btnShow.Location = new Point(321, 472);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(195, 40);
            btnShow.TabIndex = 2;
            btnShow.Text = "📃عرض التفاصيل";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(120, 20, 20);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(569, 472);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(195, 40);
            btnBack.TabIndex = 3;
            btnBack.Text = "⤵️⤵️ رجوع";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(60, 0, 0);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(lblTo);
            groupBox1.Controls.Add(lblFrom);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.FromArgb(255, 200, 200);
            groupBox1.Location = new Point(74, 279);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 168);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "📃تفاصيل التذكرة";
            // 
            // lblPrice
            // 
            lblPrice.FlatStyle = FlatStyle.Flat;
            lblPrice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPrice.Location = new Point(56, 123);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(172, 25);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "\"               \"";
            // 
            // lblTo
            // 
            lblTo.FlatStyle = FlatStyle.Flat;
            lblTo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblTo.Location = new Point(56, 91);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(172, 25);
            lblTo.TabIndex = 6;
            lblTo.Text = "\"               \"";
            // 
            // lblFrom
            // 
            lblFrom.FlatStyle = FlatStyle.Flat;
            lblFrom.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblFrom.Location = new Point(56, 63);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(172, 25);
            lblFrom.TabIndex = 5;
            lblFrom.Text = "\"               \"";
            // 
            // lblName
            // 
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblName.Location = new Point(56, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(172, 25);
            lblName.TabIndex = 4;
            lblName.Text = "\"               \"";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(297, 123);
            label6.Name = "label6";
            label6.Size = new Size(123, 23);
            label6.TabIndex = 3;
            label6.Text = ": السعر الاجمالى";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(297, 91);
            label5.Name = "label5";
            label5.Size = new Size(43, 23);
            label5.TabIndex = 2;
            label5.Text = ": الى";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(297, 63);
            label4.Name = "label4";
            label4.Size = new Size(40, 23);
            label4.TabIndex = 1;
            label4.Text = ": من";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(297, 33);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 0;
            label3.Text = ": الاسم";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(60, 0, 0);
            groupBox2.Controls.Add(lblCount);
            groupBox2.Controls.Add(label2);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.ForeColor = Color.FromArgb(255, 200, 200);
            groupBox2.Location = new Point(582, 279);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(182, 168);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "📊 احصائيات";
            // 
            // lblCount
            // 
            lblCount.FlatStyle = FlatStyle.Flat;
            lblCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(27, 83);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(132, 28);
            lblCount.TabIndex = 1;
            lblCount.Text = "\"               \"";
            lblCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(170, 41);
            label2.TabIndex = 0;
            label2.Text = "اجمالى التذاكر";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(60, 0, 0);
            groupBox3.Controls.Add(listBoxTickets);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.ForeColor = Color.FromArgb(255, 200, 200);
            groupBox3.Location = new Point(74, 70);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(690, 194);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "قائمة التذاكر";
            // 
            // listBoxTickets
            // 
            listBoxTickets.BackColor = Color.FromArgb(40, 0, 0);
            listBoxTickets.BorderStyle = BorderStyle.FixedSingle;
            listBoxTickets.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxTickets.ForeColor = Color.WhiteSmoke;
            listBoxTickets.FormattingEnabled = true;
            listBoxTickets.Location = new Point(6, 26);
            listBoxTickets.Name = "listBoxTickets";
            listBoxTickets.Size = new Size(678, 152);
            listBoxTickets.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 41);
            label1.TabIndex = 9;
            label1.Text = "عرض التذاكر المحجوزة";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ticket2;
            pictureBox1.Location = new Point(223, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 0, 0);
            ClientSize = new Size(832, 533);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Controls.Add(btnShow);
            Controls.Add(btnLoad);
            ForeColor = Color.FromArgb(255, 200, 200);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "عرض التذاكر المحجوزة";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnShow;
        private Button btnBack;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListBox listBoxTickets;
        private Label label1;
        private Label lblCount;
        private Label label2;
        private Label lblPrice;
        private Label lblTo;
        private Label lblFrom;
        private Label lblName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
    }
}