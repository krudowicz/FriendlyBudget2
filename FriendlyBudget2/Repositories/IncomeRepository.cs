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
        private IDataProvider<Income> _DataProvider { get; set; }

        public IncomeRepository()
        {

        }

        public IncomeRepository(IDataProvider<Income> DataProvider)
        {
            _DataProvider = DataProvider;
        }

        public Income GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Income GetByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public void Add(Income income)
        {
            throw new NotImplementedException();
        }

        public void Update(Income income)
        {
            throw new NotImplementedException();
        }

        public void Remove (Income income)
        {
            throw new NotImplementedException();
        }
    }
}
