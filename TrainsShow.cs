using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class TrainsShow : Form
    {
        private TicketManager ticketManager = new TicketManager();
        public TrainsShow()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxTickets.Items.Clear();

                List<Ticket> tickets = ticketManager.LoadTickets();

                if (tickets.Count == 0)
                {
                    MessageBox.Show("لا يوجد تذاكر لعرضها");
                    return;
                }

                foreach (Ticket t in tickets)
                    listBoxTickets.Items.Add(t.ToString());

                lblCount.Text = "عدد التذاكر: " + listBoxTickets.Items.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل التذاكر: " + ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (listBoxTickets.SelectedIndex == -1)
            {
                MessageBox.Show("اختار تذكرة");
                return;
            }

            string data = listBoxTickets.SelectedItem.ToString();
            string[] parts = data.Split('|');

            lblName.Text = parts[0];
            lblTo.Text = parts[1];
            lblFrom.Text = parts[2];
            lblPrice.Text = parts[3];
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Choose menu = new Choose();
            menu.Show();
            this.Close();
        }
    }
}
