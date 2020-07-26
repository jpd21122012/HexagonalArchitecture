namespace HexArch.UseCases.Tests
{
    using Xunit;
    using NSubstitute;
    using System;
    using HexArch.Application.Commands.Register;
    using HexArch.Application.Repositories;

    public class CustomerTests
    {
        public IAccountReadOnlyRepository accountReadOnlyRepository;
        public IAccountWriteOnlyRepository accountWriteOnlyRepository;
        public ICustomerReadOnlyRepository customerReadOnlyRepository;
        public ICustomerWriteOnlyRepository customerWriteOnlyRepository;

        public CustomerTests()
        {
            accountReadOnlyRepository = Substitute.For<IAccountReadOnlyRepository>();
            accountWriteOnlyRepository = Substitute.For<IAccountWriteOnlyRepository>();
            customerReadOnlyRepository = Substitute.For<ICustomerReadOnlyRepository>();
            customerWriteOnlyRepository = Substitute.For<ICustomerWriteOnlyRepository>();
        }

        [Theory]
        [InlineData("08724050601", "Jorge Perales Diaz", 300)]
        [InlineData("08724050601", "Jorge Perales Diaz ", 100)]
        [InlineData("08724050601", "Jorge Perales Diaz", 500)]
        [InlineData("08724050601", "Jorge Perales Diaz", 10000)]
        public async void Register_Valid_User_Account(string personnummer, string name, double amount)
        {
            var registerUseCase = new RegisterUseCase(
                customerWriteOnlyRepository,
                accountWriteOnlyRepository
            );

            RegisterResult result = await registerUseCase.Execute(
                personnummer,
                name,
                amount);

            Assert.Equal(personnummer, result.Customer.Personnummer);
            Assert.Equal(name, result.Customer.Name);
            Assert.True(result.Customer.CustomerId != Guid.Empty);
            Assert.True(result.Account.AccountId != Guid.Empty);
        }
    }
}
