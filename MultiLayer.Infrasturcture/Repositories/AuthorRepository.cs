using MultiLayer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayer.Infrasturcture.Repositories
{
    public class AuthorRepository : IAuthor
    {
        private MultilayerDbContext db = new MultilayerDbContext();

        public IQueryable<Domain.Entities.Author> GelAll
        {
            get { throw new NotImplementedException(); }
        }

        public Domain.Entities.Author GetById<TKey>(TKey Id)
        {
            throw new NotImplementedException();
        }

        public bool INSERT(Domain.Entities.Author Entity)
        {
            throw new NotImplementedException();
        }

        public bool Update<TKey>(TKey Id, Domain.Entities.Author Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete<TKey>(TKey Id)
        {
            throw new NotImplementedException();
        }
    }
}
