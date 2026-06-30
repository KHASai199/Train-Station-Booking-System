using static System.Windows.Forms.DataFormats;

namespace Project
{
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = "أهلاً "; 
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            labelDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public void btnBook_Click(object sender, EventArgs e)
        {   
            Booking booking = new Booking();
            booking.Show();
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TrainsShow viewTickets = new TrainsShow();
            viewTickets.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string pass = Microsoft.VisualBasic.Interaction.InputBox(
                "أدخل كلمة سر الأدمن:", "دخول الإدارة", "");

            if (pass == "admin123")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else if (pass == "")
            {
                MessageBox.Show("أدخل كلمة سر الأدمن");
            }
            else if (pass != "")
            {
                MessageBox.Show("كلمة السر غلط!");
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            TrainsClock schedule = new TrainsClock();
            schedule.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "هل تريد الخروج؟",
                "تأكيد",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
