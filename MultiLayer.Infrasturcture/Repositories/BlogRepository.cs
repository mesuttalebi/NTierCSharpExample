using MultiLayer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayer.Infrasturcture.Repositories
{
    public class BlogRepository : IBlog
    {
        private MultilayerDbContext db = new MultilayerDbContext();

        public IQueryable<Domain.Entities.Blog> GelAll
        {
            get { throw new NotImplementedException(); }
        }

        public Domain.Entities.Blog GetById(object Id)
        {
            throw new NotImplementedException();
        }

        public bool INSERT(Domain.Entities.Blog Entity)
        {
            using (var db = new  MultilayerDbContext())
            {
                db.Blogs.Add(Entity);
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public bool Update(object Id, Domain.Entities.Blog Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object Id)
        {
            throw new NotImplementedException();
        }
    }
}
