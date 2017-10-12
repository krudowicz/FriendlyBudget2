using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget2.DTO;
using FriendlyBudget2.Core.Interfaces;

namespace FriendlyBudget2.Repositories
{
    class FamilyMemberRepository : IRepository<FamilyMember>
    {
        private IDataProvider<FamilyMember> _DataProvider { get; set; }

        public FamilyMemberRepository()
        {
        }

        public FamilyMemberRepository(IDataProvider<FamilyMember> DataProvider)
        {
            _DataProvider = DataProvider;
        }

        public FamilyMember GetById(long id)
        {
            throw new NotImplementedException();
        }

        public FamilyMember GetByQuery(string query)
        {
            throw new NotImplementedException();
        }

        public void Add(FamilyMember familyMember)
        {
            throw new NotImplementedException();
        }

        public void Update(FamilyMember familyMember)
        {
            throw new NotImplementedException();
        }

        public void Remove(FamilyMember familyMember)
        {
            throw new NotImplementedException();
        }
    }
}
