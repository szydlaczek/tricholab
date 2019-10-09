using System;

namespace Forum.Core.Entities
{
    public class User
    {
        protected User()
        {

        }

        public User(Guid id, string userName)
        {
            Id = id;
            UserName = userName;
        }

        public Guid Id { get; protected set; }
        public string UserName { get; protected set; }
    }
}