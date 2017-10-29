using FriendlyBudget2.Core.Interfaces;
using FriendlyBudget2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget2.Repositories
{
    class ExpenditureRepository : IRepository<Expenditure>
    {
        private IDataProvider<Expenditure> DataProvider;

        public ExpenditureRepository(IDataProvider<Expenditure> dataProvider)
        {
            DataProvider = dataProvider;
        }

        public void Add(Expenditure entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Expenditure> GetAll()
        {
            throw new NotImplementedException();
        }

        public Expenditure GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Expenditure> GetMany()
        {
            throw new NotImplementedException();
        }

        public Expenditure GetOne()
        {
            throw new NotImplementedException();
        }

        public void Remove(Expenditure entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Expenditure entity)
        {
            throw new NotImplementedException();
        }
    }
}
