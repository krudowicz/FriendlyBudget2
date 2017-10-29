using System;
using NUnit.Framework;
using System.Collections.Generic;
using FriendlyBudget2.DTO;
using FriendlyBudget2.Services;


namespace FriendlyBudget.Tests.Services
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Calculator_TotalIncome_Returns_Proper_Value()
        {
            #region setup
            Income income1 = new Income();
            income1.AmountMain = 50;
            income1.AmountSecondary = 250;
            Income income2 = new Income();
            income2.AmountMain = 100;
            income2.AmountSecondary = 100;

            List<Income> incomes = new List<Income>();
            incomes.Add(income1);
            incomes.Add(income2);

            FamilyMember familyMember = new FamilyMember();
            familyMember.Incomes = incomes;
            Calculator calculator = new Calculator(familyMember);
            #endregion

            double expected = 153.50;
            double actual = calculator.TotalIncome();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Calculator_TotalExpenditure_Returns_Proper_Value()
        {
            #region setup
            Expenditure expenditure1 = new Expenditure();
            expenditure1.AmountMain = 50;
            expenditure1.AmountSecondary = 250;
            Expenditure expenditure2 = new Expenditure();
            expenditure2.AmountMain = 100;
            expenditure2.AmountSecondary = 100;

            List<Expenditure> expenditures = new List<Expenditure>();
            expenditures.Add(expenditure1);
            expenditures.Add(expenditure2);

            FamilyMember familyMember = new FamilyMember();
            familyMember.Expenditures = expenditures;
            Calculator calculator = new Calculator(familyMember);
            #endregion

            double expected = 153.50;
            double actual = calculator.TotalExpenditure();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Calculator_BudgetBalance_Returns_Proper_Value()
        {
            #region setup
            Expenditure expenditure1 = new Expenditure();
            expenditure1.AmountMain = 50;
            expenditure1.AmountSecondary = 250;

            List<Expenditure> expenditures = new List<Expenditure>();
            expenditures.Add(expenditure1);

            FamilyMember familyMember = new FamilyMember();
            familyMember.Expenditures = expenditures;
            familyMember.Budget = 150;
            Calculator calculator = new Calculator(familyMember);
            #endregion

            double expected = 97.50;
            double actual = calculator.BudgetBalance();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Calculator_Balance_Returns_Proper_Value()
        {
            #region setup
            Expenditure expenditure1 = new Expenditure();
            expenditure1.AmountMain = 50;
            expenditure1.AmountSecondary = 0;

            Income income1 = new Income();
            income1.AmountMain = 44;
            income1.AmountSecondary = 50;

            List<Expenditure> expenditures = new List<Expenditure>();
            expenditures.Add(expenditure1);

            List<Income> incomes = new List<Income>();
            incomes.Add(income1);

            FamilyMember familyMember = new FamilyMember();
            familyMember.Expenditures = expenditures;
            familyMember.Incomes = incomes;
            Calculator calculator = new Calculator(familyMember);
            #endregion

            double expected = -5.50;
            double actual = calculator.Balance();

            Assert.AreEqual(expected, actual);
        }
    }
}
