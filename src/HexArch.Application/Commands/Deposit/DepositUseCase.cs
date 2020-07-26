namespace HexArch.Application.Commands.Deposit
{
    using System;
    using System.Threading.Tasks;
    using HexArch.Application.Repositories;
    using HexArch.Domain.Accounts;
    using HexArch.Domain.ValueObjects;

    public sealed class DepositUseCase : IDepositUseCase
    {
        private readonly IAccountReadOnlyRepository accountReadOnlyRepository;
        private readonly IAccountWriteOnlyRepository accountWriteOnlyRepository;

        public DepositUseCase(
            IAccountReadOnlyRepository accountReadOnlyRepository,
            IAccountWriteOnlyRepository accountWriteOnlyRepository)
        {
            this.accountReadOnlyRepository = accountReadOnlyRepository;
            this.accountWriteOnlyRepository = accountWriteOnlyRepository;
        }

        public async Task<DepositResult> Execute(Guid accountId, Amount amount)
        {
            Account account = await accountReadOnlyRepository.Get(accountId);
            if (account == null)
                throw new AccountNotFoundException($"The account {accountId} does not exists or is already closed.");

            account.Deposit(amount);
            Credit credit = (Credit)account.GetLastTransaction();

            await accountWriteOnlyRepository.Update(
                account,
                credit);

            DepositResult result = new DepositResult(
                credit,
                account.GetCurrentBalance());
            return result;
        }
    }
}
