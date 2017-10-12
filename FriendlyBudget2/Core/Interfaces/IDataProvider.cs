using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget2.Core.Interfaces
{
    interface IDataProvider<T>
    {
        void Add(T item);
        void Update(T item, T itemToUpdate);
        void Remove(T item);
    }
}
