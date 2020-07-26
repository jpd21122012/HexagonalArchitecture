namespace HexArch.Application.Commands.Deposit
{
    using HexArch.Domain.ValueObjects;
    using System;
    using System.Threading.Tasks;

    public interface IDepositUseCase
    {
        Task<DepositResult> Execute(Guid accountId, Amount amount);
    }
}
