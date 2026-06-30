using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Project
{
    public partial class Admin : Form
    {
        private TicketManager ticketManager = new TicketManager();
        private List<Ticket> allTickets = new List<Ticket>();
        private int selectedIndex = -1;
        public Admin()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = "أهلاً ";
            LoadAllTickets();
        }
        private void LoadAllTickets()
        {
            allTickets = ticketManager.LoadTickets();
            ticketList.Items.Clear();

            foreach (Ticket t in allTickets)
                ticketList.Items.Add(t.ToString());
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = textSearch.Text.Trim();
            ticketList.Items.Clear();

            foreach (Ticket t in allTickets)
            {
                if (t.Name.Contains(keyword) || t.From.Contains(keyword) || t.To.Contains(keyword))
                    ticketList.Items.Add(t.ToString());
            }
        }

        private void ticketList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ticketList.SelectedIndex == -1)
                return;

            string selected = ticketList.SelectedItem.ToString();
            string[] parts = selected.Split('|');

            textName.Text = parts[0].Trim();
            textFrom.Text = parts[1].Trim();
            textTo.Text = parts[2].Trim();
            textPrice.Text = parts[3].Trim();

            selectedIndex = ticketList.SelectedIndex;
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
            {
                MessageBox.Show("اختار تذكرة الأول");
                return;
            }

            allTickets[selectedIndex].Name = textName.Text;
            allTickets[selectedIndex].From = textFrom.Text;
            allTickets[selectedIndex].To = textTo.Text;
            allTickets[selectedIndex].Price = textPrice.Text;

            SaveAllTickets();
            LoadAllTickets();
            ClearFields();

            MessageBox.Show("تم التعديل!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
            {
                MessageBox.Show("اختار تذكرة الأول");
                return;
            }

            DialogResult result = MessageBox.Show(
                "هل تريد حذف التذكرة؟",
                "تأكيد",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                allTickets.RemoveAt(selectedIndex);
                SaveAllTickets();
                LoadAllTickets();
                ClearFields();

                MessageBox.Show("تم الحذف!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            ticketList.ClearSelected();
            selectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Choose menu = new Choose();
            menu.Show();
            this.Close();
        }
        private void SaveAllTickets()
        {
            List<string> lines = new List<string>();

            foreach (Ticket t in allTickets)
            {
                lines.Add("Name: " + t.Name);
                lines.Add("From: " + t.From);
                lines.Add("To: " + t.To);
                lines.Add("Price: " + t.Price);
                lines.Add("-------------------");
            }

            File.WriteAllLines("tickets.txt", lines);
        }

        private void ClearFields()
        {
            textName.Text = "";
            textFrom.Text = "";
            textTo.Text = "";
            textPrice.Text = "";
        }
    }
}
