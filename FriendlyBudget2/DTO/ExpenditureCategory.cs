using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget2.DTO
{
    class ExpenditureCategory
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Expenditure> Expenditures { get; set; }
    }
}
