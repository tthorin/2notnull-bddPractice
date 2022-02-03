using System.IO;

namespace BddPracticeLib.Tests;

using BddPracticeLib.Models;
using Xunit;

public class BankAccountTests
{
    private readonly BankAccount _sut;
    public BankAccountTests() => _sut = new BankAccount(1000);

    [Fact]
    public void Deposit_ValidAmount_ShouldWork()
    {
        const int expected = 1100;
        _ = _sut.Deposit(100);

        var actual = _sut.Balance;

        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Deposit_TryingToDepositNegativeValue_ShouldntChangeBalance()
    {
        const int expected = 1000;
        var actual = _sut.Deposit(-100);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Withdraw_ValidAmount_ShouldReturnCorrectBalance()
    {
        const int expected = 900;
        var actual = _sut.Withdraw(100);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Withdraw_NegativeAmount_ShouldntChangeBalance()
    {
        const int expected = 1000;
        var actual = _sut.Withdraw(-100);

        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Withdraw_AmountHigherThanBalance_ShouldntChangeBalance()
    {
        const int expected = 1000;
        var actual = _sut.Withdraw(-1100);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TransferToAnotherAccount_ValidAmount_ShouldWork()
    {
        var accountFrom = new BankAccount(1000);
        const int expectedTo = 1100;
        const int expectedFrom = 900;
        var actualFrom = accountFrom.TransferToAnotherAccount(_sut, 100);
        var actualTo = _sut.Balance;

        Assert.Equal(expectedFrom, actualFrom);
        Assert.Equal(expectedTo, actualTo);
    }
    [Fact]
    public void TransferToAnotherAccount_NegativeAmount_ShouldNotChangeEitherBalance()
    {
        BankAccount accountFrom = new(1000);
        const int expectedTo = 1000;
        const int expectedFrom = 1000;
        var actualFrom = accountFrom.TransferToAnotherAccount(_sut, -100);
        var actualTo = _sut.Balance;

        Assert.Equal(expectedFrom, actualFrom);
        Assert.Equal(expectedTo, actualTo);
    }
    [Fact]
    public void TransferToAnotherAccount_TransferMoreThanBalanceOnFromAccount_ShouldNotChangeEitherBalance()
    {
        var accountFrom = new BankAccount(1000);
        const int expectedTo = 1000;
        const int expectedFrom = 1000;
        var actualFrom = accountFrom.TransferToAnotherAccount(_sut, -1100);
        var actualTo = _sut.Balance;

        Assert.Equal(expectedFrom, actualFrom);
        Assert.Equal(expectedTo, actualTo);
    }

    [Fact]
    public void SaveFile_ShouldWork()
    {
        var text = "silly string";
        File.WriteAllText("./text.txt",text);
        var loaded = File.ReadAllText("./text.txt");
        Assert.Equal(text, loaded);
    }
}
