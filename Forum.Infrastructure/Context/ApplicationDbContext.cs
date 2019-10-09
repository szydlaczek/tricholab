
using Effort;
using Forum.Core.Entities;
using System.Data.Common;
using System.Data.Entity;

namespace Forum.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbConnection connection) : base(connection, false)
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
