using Forum.Core.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Forum.Infrastructure.ModelsPreview
{
    public class TopicModelPreview
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Answers { get; set; }
        public string CreatedBy { get; set; }
        public string Category { get; set; }
        public static Expression<Func<Topic, TopicModelPreview>> Projection
        {
            get
            {
                return p => new TopicModelPreview
                {
                    Answers = p.Posts.Count() - 1,
                    Category = p.Category.Name,
                    Id = p.Id,
                    Title = p.Title,
                    CreatedBy = p.Posts.FirstOrDefault().CreatedBy.UserName
                };
            }
        }
    }
}
