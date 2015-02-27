using MultiLayer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayer.Infrasturcture.Repositories
{
    public class PostRepository : IPost
    {
        private MultilayerDbContext Db = new MultilayerDbContext();

        public IQueryable<Domain.Entities.Post> GelAll
        {
            get { throw new NotImplementedException(); }
        }

        public Domain.Entities.Post GetById(object Id)
        {
            throw new NotImplementedException();
        }

        public bool INSERT(Domain.Entities.Post Entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(object Id, Domain.Entities.Post Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object Id)
        {
            throw new NotImplementedException();
        }
    }
}
