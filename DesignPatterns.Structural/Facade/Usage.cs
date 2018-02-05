using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Usage
    {
        public void displayPattern()
        {
            User follower = new User
            {
                UserName = "Robert"
            };

            User following = new User
            {
                UserName = "Edwin"
            };

            Follower followerFacade = new Follower();
            followerFacade.Follow(follower, following);
        }
    }
}
