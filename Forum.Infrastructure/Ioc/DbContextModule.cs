using Autofac;
using Forum.Infrastructure.Context;

namespace Forum.Infrastructure.Ioc
{
    public class DbContextModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var dbConnectionFactory = Effort.DbConnectionFactory.CreatePersistent(nameof(ApplicationDbContext));
            builder.Register(c =>
            {
                return new ApplicationDbContext(dbConnectionFactory);
            })
            .As<ApplicationDbContext>()
            .InstancePerRequest();
        }
    }
}