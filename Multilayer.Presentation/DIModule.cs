using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using MultiLayer.Services.BlogServices;

namespace MultiLayer.Presentation
{
    class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBlogService>().To<BlogService>();
        }
    }
}
