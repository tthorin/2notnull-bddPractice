using BddPracticeLib;
using BddPracticeLib.Interfaces;
using System;
using TechTalk.SpecFlow;

namespace BddPractice.Specs.StepDefinitions
{
    [Binding]
    public class BankAccountTransfersStepDefinitions
    {
        private readonly IBankCustomer bob = BddPracticeLibFactory.GetBankCustomer();

        [Given(@"Salary account has (\d+) sek")]
        public void GivenSalaryAccountHasSek(int amount)
        {
            bob.Salary.Deposit(amount);
        }

        [Given(@"card account has (\d+) sek")]
        public void GivenCardAccountHasDSek(int amount)
        {
            bob.Card.Deposit(amount);
        }

        [When(@"He transfers money from salary account to card account")]
        public void WhenHeTransfersMoneyFromSalaryAccountToCardAccount()
        {
            bob.Salary.TransferToAnotherAccount(bob.Card, 100);
        }

        [Then(@"card account should have (\d+) sek")]
        public void ThenCardAccountShouldHaveSek(int amount)
        {
            bob.Card.Balance.Should().Be(amount);
        }

        [Then(@"salary account should have (\d+) sek")]
        public void ThenSalaryAccountShouldHaveSek(int amount)
        {
            bob.Salary.Balance.Should().Be(amount);
        }
    }
}
