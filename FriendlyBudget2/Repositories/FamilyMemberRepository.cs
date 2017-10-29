using FriendlyBudget2.Core.Interfaces;
using FriendlyBudget2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget2.Repositories
{
    class FamilyMemberRepository : IRepository<FamilyMember>
    {
        private IDataProvider<FamilyMember> DataProvider;

        public FamilyMemberRepository(IDataProvider<FamilyMember> dataProvider)
        {
            DataProvider = dataProvider;
        }

        public void Add(FamilyMember entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FamilyMember> GetAll()
        {
            throw new NotImplementedException();
        }

        public FamilyMember GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FamilyMember> GetMany()
        {
            throw new NotImplementedException();
        }

        public FamilyMember GetOne()
        {
            throw new NotImplementedException();
        }

        public void Remove(FamilyMember entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(FamilyMember entity)
        {
            throw new NotImplementedException();
        }
    }
}
