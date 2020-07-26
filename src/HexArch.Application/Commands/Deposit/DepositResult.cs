namespace HexArch.Application.Commands.Deposit
{
    using HexArch.Application.Results;
    using HexArch.Domain.Accounts;
    using HexArch.Domain.ValueObjects;

    public sealed class DepositResult
    {
        public TransactionResult Transaction { get; }
        public double UpdatedBalance { get; }

        public DepositResult(
            Credit credit,
            Amount updatedBalance)
        {
            Transaction = new TransactionResult(
                credit.Description,
                credit.Amount,
                credit.TransactionDate);

            UpdatedBalance = updatedBalance;
        }
    }
}
