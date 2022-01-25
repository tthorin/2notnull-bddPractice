namespace BddPracticeLib.Interfaces;

public interface IBankCustomer
{
    string AccountHolder { get; set; }
    IBankAccount Card { get; }
    IBankAccount Salary { get; }
}
