using System;

namespace Forum.Core.Entities
{
    public class Post
    {
        public Post(Guid id, string content, User user)
        {
            Id = id;
            Content = content;
            CreatedBy = user;
        }

        protected Post()
        {
        }

        public Guid Id { get; protected set; }
        public string Content { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public User CreatedBy { get; protected set; }
        public Topic Topic { get; protected set; }
        public Guid TopicId { get; protected set; }
    }
}