namespace HexArch.Application.Commands.Withdraw
{
    using HexArch.Application.Results;
    using HexArch.Domain.Accounts;
    using HexArch.Domain.ValueObjects;

    public sealed class WithdrawResult
    {
        public TransactionResult Transaction { get; }
        public double UpdatedBalance { get; }

        public WithdrawResult(Debit transaction, Amount updatedBalance)
        {
            Transaction = new TransactionResult(
                transaction.Description,
                transaction.Amount,
                transaction.TransactionDate);

            UpdatedBalance = updatedBalance;
        }
    }
}
