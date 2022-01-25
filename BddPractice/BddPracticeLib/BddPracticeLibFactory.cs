namespace BddPracticeLib;
using Models;
using Interfaces;

using System;

public static class BddPracticeLibFactory
{
    public static IBankCustomer GetBankCustomer() => new BankCustomer(GetBankAccount(), GetBankAccount());
    private static IBankAccount GetBankAccount() => new BankAccount();
}
