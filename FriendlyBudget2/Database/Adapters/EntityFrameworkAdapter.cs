using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FriendlyBudget2.Core.Interfaces;
using FriendlyBudget2.Database.EntityFramework;

namespace FriendlyBudget2.Database.Adapters
{
    class EntityFrameworkAdapter : IDataProvider<object>
    {
        public void Add(object item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(object item, object itemToUpdate)
        {
            using (var context = new MainContext())
            {
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Remove(object item)
        {
            using(var context = new MainContext())
            {
                context.Entry(item).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
