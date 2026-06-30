using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class SignUp : Form
    {
        private UserManager manager = new UserManager();
        public SignUp()
        {
            InitializeComponent();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
            textBoxConfirm.UseSystemPasswordChar = true;
        }
        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                textBoxPass.UseSystemPasswordChar = false;
                textBoxConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
                textBoxConfirm.UseSystemPasswordChar = true;

            }
        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text.Trim();
            string password = textBoxPass.Text;
            string confirm = textBoxConfirm.Text;

            if (username == "" || password == "" || confirm == "")
            {
                MessageBox.Show("من فضلك اكمل كل الحقول", "تنبيه",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (manager.UsernameExists(username))
            {
                MessageBox.Show("اسم المستخدم موجود بالفعل!", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!manager.ValidatePassword(password))
            {
                MessageBox.Show(
                    "كلمة المرور يجب أن تكون:\n" +
                    "- 8 أحرف على الأقل\n" +
                    "- تحتوي على حرف كبير\n" +
                    "- تحتوي على حرف صغير\n" +
                    "- تحتوي على رقم",
                    "كلمة مرور ضعيفة",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("كلمة المرور غير متطابقة!", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User(username, password);
            manager.SaveUser(newUser);

            MessageBox.Show("تم إنشاء الحساب بنجاح!", "تم",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
