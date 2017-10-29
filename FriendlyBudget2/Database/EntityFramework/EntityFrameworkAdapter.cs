using FriendlyBudget2.Core.Abstracts;
using FriendlyBudget2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget2.Database.EntityFramework
{
    class EntityFrameworkAdapter : IDataProvider<DataObject>
    {
        public void Add(DataObject entity)
        {
            using(var context = new MainContext())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        //TODO: Change this method to use generics - need to have flexible types.
        public DataObject GetById(long id)
        {
            using (var context = new MainContext())
            {
                throw new NotImplementedException();
            }
        }

        //TODO: Change this method to use generics - need to have flexible types.
        public IEnumerable<DataObject> GetByQuery(string query)
        {
            using (var context = new MainContext())
            {
                throw new NotImplementedException();
            }
        }

        public void Remove(DataObject entity)
        {
            using (var context = new MainContext())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(DataObject entity)
        {
            using (var context = new MainContext())
            {
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
