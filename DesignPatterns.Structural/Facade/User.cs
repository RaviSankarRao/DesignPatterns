using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class User
    {
        private List<User> Followers = new List<User>(); // followers of a user

        public string UserName { get; set; }

        public bool Follow(User userToFollow)
        {
            // code for adding you as a follower

            return true;
        }

        public bool FollowerAdded(User newFollower)
        {
            // code for notifying the user you followed

            Notification notification = new Notification();
            return notification.NotifyUser(this,newFollower.UserName + " is now following you");
        }

        public bool FollowingTextPost(User userToFollow)
        {
            // code for posting sinple text

            Post post = new Post();
            return post.PostText(this, this.UserName + " is now following " + userToFollow.UserName);
        }

        public bool NotifiyFollowers(User userToFollow)
        {
            bool result = true;

            Notification notification = new Notification();
            foreach (var follower in Followers)
            {
                // code for notifying followers on your new activity
                result = notification.NotifyUser(this, this.UserName + " is now following " + userToFollow.UserName);
                if(!result)
                {
                    break;
                }
            }

            return result;
        }
    }
}
