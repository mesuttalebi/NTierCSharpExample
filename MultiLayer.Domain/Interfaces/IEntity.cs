using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayer.Domain.Interfaces
{
    public interface IEntity<T>
    {
        IQueryable<T> GelAll { get; }

        T GetById<TKey>(TKey Id);

        bool INSERT(T Entity);

        bool Update<TKey>(TKey Id, T Entity);

        bool Delete<TKey>(TKey Id);
    }
}
