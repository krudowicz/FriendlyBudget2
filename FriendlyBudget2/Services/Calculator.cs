using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlyBudget2.DTO;


//TODO: Change TotalIncome() and TotalExpenditure() to return values separated, not as a double
namespace FriendlyBudget2.Services
{
    class Calculator
    {
        private FamilyMember _FamilyMember;
        private ICollection<Income> _Incomes;
        private ICollection<Expenditure> _Expenditures;

        public FamilyMember FamilyMember
        {
            get
            {
                return _FamilyMember;
            }

            set
            {
                _FamilyMember = value;
                _Incomes = _FamilyMember.Incomes;
                _Expenditures = _FamilyMember.Expenditures;
            }
        }

        public Calculator(FamilyMember familyMember)
        {
            FamilyMember = familyMember;
        }

        private void GetIncomes()
        {
            _Incomes = _FamilyMember.Incomes;
        }

        private void GetExpenditures()
        {
            _Expenditures = _FamilyMember.Expenditures;
        }

        public double TotalIncome()
        {
            double totalIncome = 0;
            long totalIncomeMain = 0;
            long totalIncomeSecondary = 0;


            foreach(Income income in _Incomes)
            {
                totalIncomeMain += income.AmountMain;
                totalIncomeSecondary += income.AmountSecondary;
            }

            totalIncome = totalIncomeMain + (totalIncomeSecondary / 100) + ((totalIncomeSecondary % 100) / 100d);

            return totalIncome;
        }

        public double TotalExpenditure()
        {
            double totalExpenditure = 0;
            long totalExpenditureMain = 0;
            long totalExpenditureSecondary = 0;


            foreach (Expenditure income in _Expenditures)
            {
                totalExpenditureMain += income.AmountMain;
                totalExpenditureSecondary += income.AmountSecondary;
            }

            totalExpenditure = totalExpenditureMain + (totalExpenditureSecondary / 100) + ((totalExpenditureSecondary % 100) / 100d);

            return totalExpenditure;
        }

        public double BudgetBalance()
        {
            return _FamilyMember.Budget - TotalExpenditure();
        }

        public double Balance()
        {
            return TotalIncome() - TotalExpenditure();
        }
    }
}
