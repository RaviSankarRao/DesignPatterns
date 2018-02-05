using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class PremiumState : State
    {
        public PremiumState(State state)
        {
            this.nextPage = "Premium Page";
            this.user = state.User;
            Initialize();
        }

        public override void Login()
        {
            level = 1;
            StateChangeCheck();
        }

        public override void LogOut()
        {
            level = 0;
            StateChangeCheck();
        }

        public override void Upgrade()
        {
            level = 2;
            StateChangeCheck();
        }

        private void Initialize()
        {
            level = 2;
        }

        private void StateChangeCheck()
        {
            switch (level)
            {
                case 0:
                    user.State = new LoggedOutState(this);
                    break;
                case 1:
                    user.State = new StandardState(this);
                    break;
                case 2:
                    user.State = this;
                    break;
            }
        }
    }
}
