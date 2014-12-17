using MultiLayer.Domain.Interfaces;
using MultiLayer.Infrasturcture.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayer.Services
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBlog>().To<BlogRepository>();
        }
    }
}
