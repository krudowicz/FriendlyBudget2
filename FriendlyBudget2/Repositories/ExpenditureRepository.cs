using FriendlyBudget2.Core.Interfaces;
using FriendlyBudget2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget2.Database.DataProviders;

namespace FriendlyBudget2.Repositories
{
    class ExpenditureRepository : IRepository<Expenditure>
    {
        private IDataProvider<Expenditure> _DataProvider { get; set; }

        public ExpenditureRepository()
        {
            _DataProvider = new DefaultDataProvider();
        }

        public ExpenditureRepository(IDataProvider<Expenditure> DataProvider)
        {
            _DataProvider = DataProvider;
        }

        public Expenditure GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Expenditure GetByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public void Add(Expenditure expenditure)
        {
            throw new NotImplementedException();
        }

        public void Update(Expenditure expenditure)
        {
            throw new NotImplementedException();
        }

        public void Remove(Expenditure expenditure)
        {
            throw new NotImplementedException();
        }
    }
}
