using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Follower
    {
        public bool Follow(User follower, User following)
        {
            bool result;

            // add user as follower
            result = follower.Follow(following);
            if(!result)
            {
                return false;
            }

            // notifiy user that they have an added follower
            result = follower.FollowerAdded(follower);
            if(!result)
            {
                return false;
            }

            // post that user is now following
            result = follower.FollowingTextPost(following);
            if(!result)
            {
                return false;
            }

            // notify all of user's followers of new following activity
            result = follower.NotifiyFollowers(following);
            if (!result)
            {
                return false;
            }

            return true;
        }
    }
}
