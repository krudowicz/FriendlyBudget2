using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget2.DTO
{
    class FamilyMember
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<Income> Incomes { get; set; }
        public ICollection<Expenditure> Expenditures { get; set; }
        public double Budget { get; set; }
        public double BudgetBalance { get; set; }
        public double Balance { get; set; }
    }
}
