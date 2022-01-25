namespace BddPracticeLib.Models;
using Interfaces;

public class BankCustomer : IBankCustomer
{
    public string AccountHolder { get; set; } = "";
    public IBankAccount Salary { get; }
    public IBankAccount Card { get; }

    public BankCustomer(IBankAccount salary, IBankAccount card)
    {
        Salary = salary;
        Card = card;
    }
}
