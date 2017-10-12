using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget2.Core.Abstracts;

namespace FriendlyBudget2.DTO
{
    class Income : DataObject
    {
        
        public long AmountMain { get; set; }
        public long AmountSecondary { get; set; }
        public bool isConstant { get; set; }
        public DateTime Date { get; set; }
        public IncomeCategory Category { get; set; }
    }
}
