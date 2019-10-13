using Forum.Infrastructure.Context;
using Forum.Infrastructure.ModelsPreview;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Forum.Infrastructure.Services
{
    public class TopicService : IService
    {
        private readonly ApplicationDbContext _context;

        public TopicService(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICollection<TopicModelPreview> GetPosts(string searchText)
        {
            var topics = _context.Topics
                .Include(p => p.Posts.Select(u => u.CreatedBy))
                .Include(d => d.Category).AsQueryable();

            if (searchText != null)
                topics = topics.Where(d => d.Title.Contains(searchText));

            return topics.ToList().AsQueryable()
                .Select(TopicModelPreview.Projection)
                .ToList();
        }
    }
}