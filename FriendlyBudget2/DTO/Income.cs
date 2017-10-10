using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBudget2.DTO
{
    class Income
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long AmountMain { get; set; }
        public long AmountSecondary { get; set; }
        public bool isConstant { get; set; }
        public DateTime Date { get; set; }
        public IncomeCategory Category { get; set; }
    }
}
