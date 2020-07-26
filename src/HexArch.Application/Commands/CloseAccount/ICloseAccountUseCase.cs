namespace HexArch.Application.Commands.Close
{
    using System;
    using System.Threading.Tasks;

    public interface ICloseAccountUseCase
    {
        Task<Guid> Execute(Guid accountId);
    }
}
