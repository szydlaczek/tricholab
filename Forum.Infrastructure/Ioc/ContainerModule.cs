using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace Forum.Infrastructure.Ioc
{
    public class ContainerModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<DbContextModule>();
            builder.RegisterModule<ServicesModule>();
        }
    }
}
