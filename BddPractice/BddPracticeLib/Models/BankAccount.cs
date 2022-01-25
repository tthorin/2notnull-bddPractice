namespace BddPracticeLib.Models;
using Interfaces;

public class BankAccount : IBankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance = 0) => Balance = initialBalance;
    public decimal Deposit(decimal amount)
    {
        if (amount <= 0) return Balance;

        Balance += amount;
        return Balance;
    }
    public decimal TransferToAnotherAccount(IBankAccount recievingAccount, decimal amount)
    {
        if (amount <= 0 || amount > Balance) return Balance;
        Balance -= amount;
        recievingAccount.Deposit(amount);
        return Balance;
    }
    public decimal Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance) return Balance;

        Balance -= amount;
        return Balance;
    }
}
