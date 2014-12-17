using MultiLayer.Domain.Entities;
using MultiLayer.Services.BlogServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayer.Presentation.Controllers
{        
    public class BlogController
    {
         private IBlogService blogService;

         public BlogController(IBlogService _blogSerive)
         {
             blogService = _blogSerive;
         }

         public void CreateBlog()
         {
             var b = new Blog()
             {
                 Id = 1,
                 Name = "MyTestBlog"
             };

             blogService.AddBlog(b);
         }
    }
}
