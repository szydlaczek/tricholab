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
        public DbSet<Category> Categories { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasMany(d => d.Posts)
                .WithRequired(d => d.Topic)
                .HasForeignKey(d => d.TopicId);

            modelBuilder.Entity<Category>().HasMany(t => t.Topics)
                .WithRequired(a => a.Category);

            base.OnModelCreating(modelBuilder);
        }
    }
}