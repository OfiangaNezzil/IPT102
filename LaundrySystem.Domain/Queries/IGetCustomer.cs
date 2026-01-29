using LaundrySystem.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaundrySystem.Domain.Queries
{
    public interface IGetCustomer
    {
        Task<IEnumerable<Customer>> ExecuteAsync();
        Task<Customer?> ExecuteAsync(int customerId);
    }
}