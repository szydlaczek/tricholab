using Autofac;
using Forum.Infrastructure.Services;
using System.Linq;
using System.Reflection;

namespace Forum.Infrastructure.Ioc
{
    public class ServicesModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(ServicesModule).GetTypeInfo().Assembly;
            builder.RegisterAssemblyTypes(assembly)
                .Where(x => x.IsAssignableTo<IService>())
                .AsSelf()
                .InstancePerLifetimeScope();
        }
    }
}