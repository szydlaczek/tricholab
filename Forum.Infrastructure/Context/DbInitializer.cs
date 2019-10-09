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

            var categoryWebmastering = new Category(Guid.Parse("c50662ab-0354-4ad4-8b1a-35171a807200"), "Webmastering");
            var categoryCsharp = new Category(Guid.Parse("61d52040-6e8c-46e7-b95b-231e88e045c5"), "C#");
            var categoryCplusplus = new Category(Guid.Parse("059442c4-7243-49f3-a809-20e0431c1563"), "C++");

            var post = new Post(Guid.NewGuid(), "Treść posta", user);
            var topic = new Topic(Guid.NewGuid(), categoryWebmastering, "Znacznik div" ,post);

            context.Users.Add(user);
            context.Categories.Add(categoryWebmastering);
            context.Topics.Add(topic);

            base.Seed(context);
        }
    }
}
