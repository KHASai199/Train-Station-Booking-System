using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Project
{
    internal class UserManager
    {
        public bool UsernameExists(string username)
        {
            if (!File.Exists("User.txt"))
                return false;
            try
            {
                foreach (string line in File.ReadLines("User.txt"))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 1 && parts[0] == username)
                        return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في قراءة ملف المستخدمين: " + ex.Message);
            }
            return false;
        }

        public bool CheckCredentials(string username, string password)
        {
            if (!File.Exists("User.txt"))
                return false;

            try
            {
                foreach (string line in File.ReadLines("User.txt"))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                        return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في قراءة ملف المستخدمين: " + ex.Message);
            }

            return false;
        }

        public bool ValidatePassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpper = false, hasLower = false, hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            return hasUpper && hasLower && hasDigit;
        }

        public void SaveUser(User user)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("User.txt", true))
                {
                    sw.WriteLine(user.Username + "," + user.Password);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في حفظ المستخدم: " + ex.Message);
            }
        }
    }
}
