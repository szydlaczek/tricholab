using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Core.Entities
{
    public class Post
    {
        public Post(Guid id, string content, User user)
        {
            Id = id;
        }
        protected Post() { }
        public Guid Id { get; protected set; }
        public string Content { get; protected set; }

        public DateTime CreatedAt { get; protected set; }
        public User CreatedBy { get; protected set; }
    }
}
