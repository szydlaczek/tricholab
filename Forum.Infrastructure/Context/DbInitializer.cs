using Forum.Core.Entities;
using System;
using System.Data.Entity;

namespace Forum.Infrastructure.Context
{
    public class DbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var user = new User(Guid.NewGuid(), "grzegorz.szydlo");
            var post = new Post(Guid.NewGuid(), "Test", user);
            context.Posts.Add(post);
            base.Seed(context);
        }
    }
}
