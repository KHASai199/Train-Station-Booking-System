using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
        internal class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public User(string username, string password)
            {
                Username = username;
                Password = password;
            }
        }
        internal class AdminUser : User
        {
            public string Role { get; set; }
            public AdminUser(string username, string password, string role)
                : base(username, password)
            {
                Role = role;
            }
        }
}

