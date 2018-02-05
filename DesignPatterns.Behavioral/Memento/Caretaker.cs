using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class Caretaker
    {
        private UserMemento userMemento;

        public UserMemento UserMemento
        {
            get
            {
                return userMemento;
            }
            set
            {
                userMemento = value;
            }
        }
    }
}
