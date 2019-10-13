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
            var user1 = new User(Guid.NewGuid(), "michal.mika");
            var user2 = new User(Guid.NewGuid(), "patryk.suchodolski");

            var categoryWebmastering = new Category(Guid.Parse("c50662ab-0354-4ad4-8b1a-35171a807200"), "Webmastering");
            var categoryCsharp = new Category(Guid.Parse("61d52040-6e8c-46e7-b95b-231e88e045c5"), "C#");
            var categoryCplusplus = new Category(Guid.Parse("059442c4-7243-49f3-a809-20e0431c1563"), "C++");

            var post1 = new Post(Guid.Parse("c50662ab-0354-4ad4-8b1a-35171a807201"), "Treść posta 1", user);
            var topic1 = new Topic(Guid.Parse("c50662ab-0354-4ad4-8b1a-35171a807202"), categoryWebmastering, "Znacznik div" ,post1);

            var post2 = new Post(Guid.Parse("c50662ab-0354-4ad4-8b1a-35171a807203"), "Treść posta 2", user1);
            var topic2 = new Topic(Guid.Parse("c50662ab-0354-4ad4-8b1a-35171a807204"), categoryCsharp, "Znacznik div", post2);

            var post3 = new Post(Guid.Parse("c50662ab-0354-4ad4-8b1a-35171a807205"), "Treść posta 2", user2);
            var topic3 = new Topic(Guid.Parse("c50662ab-0354-4ad4-8b1a-35171a807206"), categoryCplusplus, "Znacznik div", post3);

            context.Users.Add(user);
            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Categories.Add(categoryWebmastering);
            context.Categories.Add(categoryCsharp);
            context.Categories.Add(categoryCplusplus);
            context.Topics.Add(topic1);
            context.Topics.Add(topic2);
            context.Topics.Add(topic3);
            base.Seed(context);
        }
    }
}
