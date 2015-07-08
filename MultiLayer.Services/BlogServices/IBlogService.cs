using MultiLayer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayer.Services.BlogServices
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        IEnumerable<Blog> GetBlogs();
        Blog Find(int id);
        void Insert(Blog model);
    }
}
