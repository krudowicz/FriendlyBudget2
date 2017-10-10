using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget2.DTO
{
    class Familymember
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Income> Incomes { get; set; }
        public ICollection<Expenditure> Expenditures { get; set; }
        public long Budget { get; set; }
        public long Balance { get; set; }
    }
}
