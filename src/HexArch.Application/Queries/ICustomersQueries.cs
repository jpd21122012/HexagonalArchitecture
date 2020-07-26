﻿namespace HexArch.Application.Queries
{
    using HexArch.Application.Results;
    using System;
    using System.Threading.Tasks;

    public interface ICustomersQueries
    {
        Task<CustomerResult> GetCustomer(Guid customerId);
    }
}
