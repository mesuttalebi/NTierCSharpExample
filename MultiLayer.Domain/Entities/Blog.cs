using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayer.Domain.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Post> Posts { get; set; }
    }
}
