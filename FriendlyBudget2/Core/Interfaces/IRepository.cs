using FriendlyBudget2.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget2.Core.Interfaces
{
    interface IRepository<T>
    {

        T GetById(long id);
        T GetOne();
        IEnumerable<T> GetMany();
        IEnumerable<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Remove(T item);
        void Save();

    }
}
