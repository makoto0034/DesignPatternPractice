using MediatRHandlers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRHandlers.Repositories
{
    public interface ICustomerRepository
    {
        Task<int> CreateCustomer(Customer customer);
        Task<Customer?> GetCustomer(int customerId);

    }
}
