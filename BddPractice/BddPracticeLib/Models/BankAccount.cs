namespace BddPracticeLib.Models;
using Interfaces;

public class BankAccount : IBankAccount
{
    /// <summary>
    /// Gets the current balance of this account.
    /// </summary>
    /// <value>
    /// The balance.
    /// </value>
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance = 0) => Balance = initialBalance;

    /// <summary>
    /// Deposits the specified amount into the account.
    /// </summary>
    /// <param name="amount">The amount to deposit.</param>
    /// <returns>The balance of the account after the deposit.</returns>
    public decimal Deposit(decimal amount)
    {
        if (amount <= 0) return Balance;

        Balance += amount;
        return Balance;
    }
    /// <summary>
    /// Transfers to another account.
    /// </summary>
    /// <param name="recievingAccount">The recieving account.</param>
    /// <param name="amount">The amount to transfer.</param>
    /// <returns>The current balance of this account after the transfer.</returns>
    public decimal TransferToAnotherAccount(IBankAccount recievingAccount, decimal amount)
    {
        if (amount <= 0 || amount > Balance) return Balance;
        Balance -= amount;
        recievingAccount.Deposit(amount);
        return Balance;
    }
    /// <summary>
    /// Withdraws the specified amount from the account.
    /// </summary>
    /// <param name="amount">The amount to withdraw.</param>
    /// <returns>The current balance of the account after the withdrawal.</returns>
    public decimal Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance) return Balance;

        Balance -= amount;
        return Balance;
    }
}
