namespace HexArch.Application.Commands.Withdraw
{
    using HexArch.Domain.ValueObjects;
    using System;
    using System.Threading.Tasks;

    public interface IWithdrawUseCase
    {
        Task<WithdrawResult> Execute(Guid accountId, Amount amount);
    }
}
