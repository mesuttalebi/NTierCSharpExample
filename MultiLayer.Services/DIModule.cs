using MultiLayer.Domain.Entities;
using MultiLayer.Domain.Interfaces;
using MultiLayer.Infrasturcture.Repositories;
using Ninject.Modules;

namespace MultiLayer.Services
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Blog>>().To<Repository<Blog>>();
        }
    }
}
