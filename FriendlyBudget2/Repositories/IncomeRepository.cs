using FriendlyBudget2.Core.Interfaces;
using FriendlyBudget2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget2.Repositories
{
    class IncomeRepository : IRepository<Income>
    {
        private IDataProvider<Income> DataProvider;

        public IncomeRepository(IDataProvider<Income> dataProvider)
        {
            DataProvider = dataProvider;
        }

        public void Add(Income entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Income> GetAll()
        {
            throw new NotImplementedException();
        }

        public Income GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Income> GetMany()
        {
            throw new NotImplementedException();
        }

        public Income GetOne()
        {
            throw new NotImplementedException();
        }

        public void Remove(Income entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Income entity)
        {
            throw new NotImplementedException();
        }
    }
}
