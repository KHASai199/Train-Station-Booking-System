using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project
{
    public partial class Booking : Form
    {
        private TicketManager ticketManager = new TicketManager();
        public Booking()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] stations = { "القاهرة", "الإسكندرية", "أسوان", "الأقصر", "القليوبية" };

            comFrom.Items.AddRange(stations);
            comTo.Items.AddRange(stations);

            radioNormal.Checked = true;
        }
        private string GetGrade()
        {
            if (radioNormal.Checked) return "normal";
            if (radioFirst.Checked) return "first";
            return "vip";
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("ادخل اسم المسافر");
                return;
            }
            if(int.TryParse(txtName.Text, out int number))
            {
                MessageBox.Show("الاسم لا يمكن أن يكون رقم");
                return;
            }
            if (comFrom.SelectedIndex == -1 || comTo.SelectedIndex == -1)
            {
                MessageBox.Show("اختار المحطات");
                return;
            }
            ///التحقق من أن المحطة مختلفة
            if (comFrom.SelectedIndex == comTo.SelectedIndex)
            {
                MessageBox.Show("محطة الانطلاق والوجهة لا يمكن أن تكونا نفس المحطة", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int total = ticketManager.CalculatePrice(
                    GetGrade(), chkMeal.Checked, chkWifi.Checked, (int)numTickets.Value);

                lblPrice.Text = total + " جنيه";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في حساب السعر: " + ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("ادخل اسم المسافر");
                return;
            }
            if (int.TryParse(txtName.Text, out int number))
            {
                MessageBox.Show("الاسم لا يمكن أن يكون رقم");
                return;
            }
            if (comFrom.SelectedIndex == -1 || comTo.SelectedIndex == -1)
            {
                MessageBox.Show("اختار المحطات");
                return;
            }

            try
            {
                Ticket t = new Ticket(txtName.Text, comFrom.Text, comTo.Text, lblPrice.Text);
                ticketManager.SaveTicket(t);
                MessageBox.Show("تم الحفظ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في الحفظ: " + ex.Message);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Choose menu = new Choose();
            menu.Show();
            this.Close();
        }

    }
}
