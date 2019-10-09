using System;

namespace Forum.Core.Entities
{
    public class Comment
    {
        public Guid PostId { get; protected set; }

        public Guid UserId { get; protected set; }

        public string Content { get; protected set; }

        public DateTime CreatedAt { get; protected set; }

        protected Comment()
        {
        }
    }
}