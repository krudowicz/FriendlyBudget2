using FriendlyBudget2.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget2.DTO
{
    class IncomeCategory : DataObject
    {
        public ICollection<Income> Incomes { get; set; }
    }
}
