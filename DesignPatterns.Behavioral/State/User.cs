using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class User
    {
        State state;
        string name;

        public User(string name)
        {
            this.name = name;
            this.state = new LoggedOutState(this);
        }

        public string NexPage
        {
            get
            {
                return state.NextPage;
            }
        }

        public State State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public void Login()
        {
            state.Login();
        }

        public void LogOut()
        {
            state.LogOut();
        }

        public void Upgrade()
        {
            state.Upgrade();
        }
    }
}
