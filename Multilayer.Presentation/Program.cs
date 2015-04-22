using MultiLayer.Presentation.Controllers;
using MultiLayer.Services.BlogServices;
using Ninject;

namespace MultiLayer.Presentation
{
    class Program
    {        
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Load<Services.DIModule>();
            kernel.Bind<IBlogService>().To<BlogService>();
            

            IBlogService blogService = kernel.Get<IBlogService>();

            BlogController BlogControl = new BlogController(blogService);
            BlogControl.CreateBlog();
        }        
    }
}
