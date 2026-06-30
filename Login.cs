using static System.Windows.Forms.DataFormats;

namespace Project
{
    public partial class Login : Form
    {
        private UserManager manager = new UserManager();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
        }
        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                textBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxUser.Text;
            string pass = textBoxPass.Text;

            if (user == "" || pass == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم وكلمة المرور", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (manager.CheckCredentials(user, pass))
                {
                    Choose mainMenu = new Choose();
                    this.Hide();
                    mainMenu.Show();
                }
                else
                {
                    labelFaild.Visible = true;
                    textBoxPass.Clear();
                    textBoxPass.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تسجيل الدخول: " + ex.Message);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();
        }
    }
}
