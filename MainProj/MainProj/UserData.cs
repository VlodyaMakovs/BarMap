using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProj
{
    internal class UserData
    {
        private int id;
        private string name;
        private string email;
        private string password;
        private int role;

        public UserData(int id, string name, string email, string password, int role)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.Role = role;  // 1-admin 2-moder 3-user 4-banUser
        }


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Role { get => role; set => role = value; }
    }
}
