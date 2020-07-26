namespace HexArch.Infrastructure.InMemoryDataAccess
{
    using HexArch.Domain.Accounts;
    using HexArch.Domain.Customers;
    using System.Collections.ObjectModel;

    public class Context
    {
        public Collection<Customer> Customers { get; set; }
        public Collection<Account> Accounts { get; set; }

        public Context()
        {
            Customers = new Collection<Customer>();
            Accounts = new Collection<Account>();
        }
    }
}
