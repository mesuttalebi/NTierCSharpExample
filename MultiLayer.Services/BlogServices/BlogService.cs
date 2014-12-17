using MultiLayer.Domain.Entities;
using MultiLayer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayer.Services.BlogServices
{
    public class BlogService : IBlogService
    {
        private IBlog blogRepository;

        public BlogService(IBlog _blogRepository)
        {
            blogRepository = _blogRepository;
        }

        public void AddBlog(Blog blog)
        {
            blogRepository.INSERT(blog);
        }
    }
}
