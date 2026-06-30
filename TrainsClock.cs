using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class TrainsClock : Form
    {
        private List<TrainSchedule> allSchedules = new List<TrainSchedule>();

        public TrainsClock()
        {
            InitializeComponent();
        }

        private void TrainsClock_Load(object sender, EventArgs e)
        {
            LoadSchedules();
            FillCombos();
            ShowSchedules(allSchedules);
            UpdateStats(allSchedules);
            timer1.Start();
            listViewSchedule.Columns[5].Width = -2;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void LoadSchedules()
        {
            allSchedules.Clear();
            allSchedules.Add(new TrainSchedule("T-101", "القاهرة", "الإسكندرية", "08:00", "10:30", "في الموعد"));
            allSchedules.Add(new TrainSchedule("T-202", "القاهرة", "أسوان", "11:15", "14:00", "متأخر"));
            allSchedules.Add(new TrainSchedule("T-303", "الإسكندرية", "الأقصر", "13:00", "16:45", "في الموعد"));
            allSchedules.Add(new TrainSchedule("T-404", "القاهرة", "القليوبية", "15:30", "—", "ملغي"));
            allSchedules.Add(new TrainSchedule("T-505", "أسوان", "القاهرة", "07:00", "12:30", "في الموعد"));
            allSchedules.Add(new TrainSchedule("T-606", "الأقصر", "الإسكندرية", "09:00", "15:00", "متأخر"));
            allSchedules.Add(new TrainSchedule("T-707", "القليوبية", "أسوان", "10:00", "17:00", "في الموعد"));
            allSchedules.Add(new TrainSchedule("T-808", "الإسكندرية", "القاهرة", "14:00", "16:30", "متأخر"));
        }

        private void FillCombos()
        {
            string[] stations = { "القاهرة", "الإسكندرية", "أسوان", "الأقصر", "القليوبية" };
            comboFrom.Items.Add("الكل");
            comboTo.Items.Add("الكل");
            comboFrom.Items.AddRange(stations);
            comboTo.Items.AddRange(stations);
            comboFrom.SelectedIndex = 0;
            comboTo.SelectedIndex = 0;
        }

        private void ShowSchedules(List<TrainSchedule> list)
        {
            listViewSchedule.Items.Clear();

            foreach (TrainSchedule s in list)
            {
                ListViewItem item = new ListViewItem(s.TrainNumber);
                item.SubItems.Add(s.From);
                item.SubItems.Add(s.To);
                item.SubItems.Add(s.DepartTime);
                item.SubItems.Add(s.ArriveTime);
                item.SubItems.Add(s.Status);
                listViewSchedule.Items.Add(item);
            }
        }

        private void UpdateStats(List<TrainSchedule> list)
        {
            int total = list.Count;
            int late = 0;
            int cancelled = 0;

            foreach (TrainSchedule s in list)
            {
                if (s.Status == "متأخر") late++;
                if (s.Status == "ملغي") cancelled++;
            }

            lblTotal.Text = total.ToString();
            lblLate.Text = late.ToString();
            lblCancelled.Text = cancelled.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fromFilter = comboFrom.Text;
            string toFilter = comboTo.Text;

            List<TrainSchedule> filtered = new List<TrainSchedule>();

            foreach (TrainSchedule s in allSchedules)
            {
                bool matchFrom = (fromFilter == "الكل" || s.From == fromFilter);
                bool matchTo = (toFilter == "الكل" || s.To == toFilter);

                if (matchFrom && matchTo)
                    filtered.Add(s);
            }

            ShowSchedules(filtered);
            UpdateStats(filtered);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboFrom.SelectedIndex = 0;
            comboTo.SelectedIndex = 0;
            ShowSchedules(allSchedules);
            UpdateStats(allSchedules);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Choose menu = new Choose();
            menu.Show();
            this.Close();
        }

    }
}
