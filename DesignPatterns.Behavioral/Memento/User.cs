using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    // Originator class

    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public void RestoreState(UserMemento userMemento)
        {
            this.UserId = userMemento.UserId;
            this.Name = userMemento.Name;
            this.UserName = userMemento.UserName;
            this.Password = userMemento.Password;
        }

        public UserMemento SaveState()
        {
            return new UserMemento(UserId, Name, UserName, Password);
        }
    }
}
