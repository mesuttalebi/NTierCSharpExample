using MultiLayer.Services.BlogServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using System.Reflection;
using MultiLayer.Domain.Entities;
using MultiLayer.Presentation.Controllers;
using MultiLayer.Domain.Interfaces;
using MultiLayer.Infrasturcture.Repositories;

namespace MultiLayer.Presentation
{
    class Program
    {        
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IBlogService>().To<BlogService>();
            kernel.Bind<IBlog>().To<BlogRepository>();

            IBlogService blogService = kernel.Get<IBlogService>();

            BlogController BlogControl = new BlogController(blogService);
            BlogControl.CreateBlog();
        }        
    }
}
