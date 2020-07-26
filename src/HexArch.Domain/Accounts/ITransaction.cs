namespace HexArch.Domain.Accounts
{
    using HexArch.Domain.ValueObjects;
    using System;

    public interface ITransaction
    {
        Amount Amount { get; }
        string Description { get; }
        DateTime TransactionDate { get; }
    }
}
