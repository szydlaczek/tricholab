using System;
using System.Collections;
using System.Collections.Generic;

namespace Forum.Core.Entities
{
    public class Category
    {
        protected Category()
        {
            Topics = new HashSet<Topic>();
        }

        public Category(Guid Id, string name) : this()
        {
            Id = id;
            Name = name;
        }

        public Guid id { get; protected set; }
        public string Name { get; protected set; }
        public ICollection<Topic> Topics { get; protected set; }
    }
}