using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Core.Entities
{
    public class User
    {
        public User(Guid id, string userName)
        {
            Id = id;
            UserName = userName;
        }
        public Guid Id { get; protected set; }
        public string UserName { get; protected set; }


    }
}
