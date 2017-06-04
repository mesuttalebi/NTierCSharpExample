using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using MultiLayer.Domain;
using MultiLayer.Domain.Entities;

namespace MultiLayer.Infrasturcture
{
    public class MultilayerDbContext : IdentityDbContext<ApplicationUser>, IDbContext
    {
        public MultilayerDbContext()
           : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
