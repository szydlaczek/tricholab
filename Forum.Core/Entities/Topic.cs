using System;
using System.Collections.Generic;

namespace Forum.Core.Entities
{
    public class Topic
    {
        public Guid Id { get; protected set; }        
        public Category Category { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public string Title { get; protected set; }
        public ICollection<Post> Posts { get; protected set; }

        protected Topic()
        {
            Posts = new HashSet<Post>();
        }

        public Topic(Guid id, Category category, string title, Post post) : this()
        {
            Id = id;
            CreatedAt = DateTime.Now;
            Title = title;
            Category = category;
            Posts.Add(post);
        }
    }
}