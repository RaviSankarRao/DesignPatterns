using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class UserMemento
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public UserMemento(int userId, string name, string userName, string password)
        {
            this.UserId = userId;
            this.Name = name;
            this.UserName = userName;
            this.Password = password;
        }
    }
}
