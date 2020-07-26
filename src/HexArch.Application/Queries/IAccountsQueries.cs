namespace HexArch.Application.Queries
{
    using HexArch.Application.Results;
    using System;
    using System.Threading.Tasks;

    public interface IAccountsQueries
    {
        Task<AccountResult> GetAccount(Guid accountId);
    }
}
