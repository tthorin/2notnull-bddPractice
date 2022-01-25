namespace BddPracticeLib.Interfaces;

public interface IBankAccount
{
    public decimal Balance { get; }

    public decimal Deposit(decimal amount);

    public decimal Withdraw(decimal amount);
    public decimal TransferToAnotherAccount(IBankAccount recievingAccount, decimal amount);
}
