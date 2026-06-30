namespace Project
{
    partial class Admin
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
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            textSearch = new TextBox();
            groupBox2 = new GroupBox();
            ticketList = new ListBox();
            groupBox3 = new GroupBox();
            textPrice = new TextBox();
            textTo = new TextBox();
            textFrom = new TextBox();
            textName = new TextBox();
            IbIPrice = new Label();
            IbITo = new Label();
            IbIFrom = new Label();
            IbIName = new Label();
            btnDelete = new Button();
            bntSave = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelWelcome = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(textSearch);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(27, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(530, 83);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "بحث";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(60, 50, 90);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(30, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textSearch
            // 
            textSearch.BackColor = Color.FromArgb(30, 20, 50);
            textSearch.BorderStyle = BorderStyle.FixedSingle;
            textSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textSearch.ForeColor = Color.White;
            textSearch.Location = new Point(170, 36);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "ابحث بالاسم أو الرحلة...";
            textSearch.Size = new Size(344, 27);
            textSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ticketList);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(27, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(530, 148);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "قائمةالتذاكر";
            // 
            // ticketList
            // 
            ticketList.BackColor = Color.FromArgb(15, 8, 32);
            ticketList.BorderStyle = BorderStyle.FixedSingle;
            ticketList.ForeColor = Color.FromArgb(206, 203, 246);
            ticketList.FormattingEnabled = true;
            ticketList.Location = new Point(20, 26);
            ticketList.Name = "ticketList";
            ticketList.Size = new Size(494, 102);
            ticketList.TabIndex = 0;
            ticketList.SelectedIndexChanged += ticketList_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textPrice);
            groupBox3.Controls.Add(textTo);
            groupBox3.Controls.Add(textFrom);
            groupBox3.Controls.Add(textName);
            groupBox3.Controls.Add(IbIPrice);
            groupBox3.Controls.Add(IbITo);
            groupBox3.Controls.Add(IbIFrom);
            groupBox3.Controls.Add(IbIName);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(27, 342);
            groupBox3.Name = "groupBox3";
            groupBox3.RightToLeft = RightToLeft.Yes;
            groupBox3.Size = new Size(530, 210);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "تعديل بيانات التذكرة";
            // 
            // textPrice
            // 
            textPrice.BackColor = Color.FromArgb(30, 20, 50);
            textPrice.BorderStyle = BorderStyle.FixedSingle;
            textPrice.ForeColor = Color.White;
            textPrice.Location = new Point(30, 159);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(261, 30);
            textPrice.TabIndex = 7;
            // 
            // textTo
            // 
            textTo.BackColor = Color.FromArgb(30, 20, 50);
            textTo.BorderStyle = BorderStyle.FixedSingle;
            textTo.ForeColor = Color.White;
            textTo.Location = new Point(30, 119);
            textTo.Name = "textTo";
            textTo.Size = new Size(261, 30);
            textTo.TabIndex = 6;
            // 
            // textFrom
            // 
            textFrom.BackColor = Color.FromArgb(30, 20, 50);
            textFrom.BorderStyle = BorderStyle.FixedSingle;
            textFrom.ForeColor = Color.White;
            textFrom.Location = new Point(30, 79);
            textFrom.Name = "textFrom";
            textFrom.Size = new Size(261, 30);
            textFrom.TabIndex = 5;
            // 
            // textName
            // 
            textName.BackColor = Color.FromArgb(30, 20, 50);
            textName.BorderStyle = BorderStyle.FixedSingle;
            textName.ForeColor = Color.White;
            textName.Location = new Point(30, 37);
            textName.Name = "textName";
            textName.Size = new Size(261, 30);
            textName.TabIndex = 4;
            // 
            // IbIPrice
            // 
            IbIPrice.AutoSize = true;
            IbIPrice.ForeColor = Color.FromArgb(206, 203, 246);
            IbIPrice.Location = new Point(407, 166);
            IbIPrice.Name = "IbIPrice";
            IbIPrice.Size = new Size(104, 23);
            IbIPrice.TabIndex = 3;
            IbIPrice.Text = "السعر(جنية) :";
            // 
            // IbITo
            // 
            IbITo.AutoSize = true;
            IbITo.ForeColor = Color.FromArgb(206, 203, 246);
            IbITo.Location = new Point(407, 121);
            IbITo.Name = "IbITo";
            IbITo.Size = new Size(44, 23);
            IbITo.TabIndex = 2;
            IbITo.Text = "الى :";
            // 
            // IbIFrom
            // 
            IbIFrom.AutoSize = true;
            IbIFrom.ForeColor = Color.FromArgb(206, 203, 246);
            IbIFrom.Location = new Point(407, 79);
            IbIFrom.Name = "IbIFrom";
            IbIFrom.Size = new Size(41, 23);
            IbIFrom.TabIndex = 1;
            IbIFrom.Text = "من :";
            // 
            // IbIName
            // 
            IbIName.AutoSize = true;
            IbIName.ForeColor = Color.FromArgb(206, 203, 246);
            IbIName.Location = new Point(407, 37);
            IbIName.Name = "IbIName";
            IbIName.Size = new Size(107, 23);
            IbIName.TabIndex = 0;
            IbIName.Text = "اسم المسافر :";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(45, 15, 15);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(163, 45, 45);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(240, 149, 149);
            btnDelete.Location = new Point(27, 571);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 54);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "حذف التذكرة🗑️";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // bntSave
            // 
            bntSave.BackColor = Color.FromArgb(15, 110, 86);
            bntSave.Cursor = Cursors.Hand;
            bntSave.FlatAppearance.BorderSize = 0;
            bntSave.FlatStyle = FlatStyle.Flat;
            bntSave.ForeColor = Color.White;
            bntSave.Location = new Point(168, 571);
            bntSave.Name = "bntSave";
            bntSave.Size = new Size(121, 54);
            bntSave.TabIndex = 4;
            bntSave.Text = "حفظ التعديل 📃";
            bntSave.UseVisualStyleBackColor = false;
            bntSave.Click += bntSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(60, 50, 90);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(324, 571);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 54);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "الغاء التحديد";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(80, 80, 80);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(463, 571);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 54);
            btnBack.TabIndex = 6;
            btnBack.Text = "رجوع⤵️";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_gear;
            pictureBox1.Location = new Point(27, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(206, 203, 246);
            label1.Location = new Point(96, 33);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 9;
            label1.Text = "Administrator";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.ForeColor = Color.White;
            labelWelcome.Location = new Point(96, 9);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(123, 23);
            labelWelcome.TabIndex = 8;
            labelWelcome.Text = "labelWelcome";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 14, 46);
            ClientSize = new Size(582, 653);
            Controls.Add(label1);
            Controls.Add(labelWelcome);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(btnCancel);
            Controls.Add(bntSave);
            Controls.Add(btnDelete);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "لوحة إدارة التذاكر";
            Load += Form5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox textSearch;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnDelete;
        private Button bntSave;
        private Button btnCancel;
        private Button btnBack;
        private ListBox ticketList;
        private TextBox textPrice;
        private TextBox textTo;
        private TextBox textFrom;
        private TextBox textName;
        private Label IbIPrice;
        private Label IbITo;
        private Label IbIFrom;
        private Label IbIName;
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelWelcome;
    }
}