using Forum.Infrastructure.Context;
using System.Data.Entity;
using System.Linq;

namespace Forum.Infrastructure.Services
{
    public class PostService : IService
    {
        private readonly ApplicationDbContext _context;

        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GetPosts()
        {
            var topics = _context.Topics.Include(p => p.Posts.Select(u => u.CreatedBy)).Include(d => d.Category).ToList();
        }
    }
}