using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget2.Core.Interfaces
{
    interface IDataProvider<T>
    {
        T GetById(long id);
        IEnumerable<T> GetByQuery(string query);
        void Add(T entity);
        void Update(T item);
        void Remove(T item);
    }
}
