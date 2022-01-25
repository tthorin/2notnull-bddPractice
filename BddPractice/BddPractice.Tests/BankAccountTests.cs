namespace BddPracticeLib.Tests;

using BddPracticeLib.Models;
using Xunit;

public class BankAccountTests
{
    BankAccount _sut;
    public BankAccountTests()
    {
        _sut = new BankAccount();
    }

    [Fact]
    public void Deposit_ValidAmount_ShouldWork()
    {
        var expected = 100;
        _= _sut.Deposit(expected);

        var actual = _sut.Balance;

        Assert.Equal(expected, actual);
    }
}
