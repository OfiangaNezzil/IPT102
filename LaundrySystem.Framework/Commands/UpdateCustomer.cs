using Dapper;
using LaundrySystem.Domain.Models;
using LaundrySystem.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Framework.Commands
{
    public class UpdateCustomer
    {
        private readonly IRepository<Customer> _repository;
        private readonly ICustomerCommand _commands;
        private readonly string _connectionString;

        public UpdateCustomer(IRepository<Customer> repository, ICustomerCommand commands, string connectionString)
        {
            _repository = repository;
            _commands = commands;
            _connectionString = connectionString;
        }

        public async Task<bool> ExecuteAsync(int customerId, string name, DateTime laundryDate)
        {
            var parameters = new DynamicParameters();
            parameters.Add("CustomerId", customerId);
            parameters.Add("CustomerName", name);
            parameters.Add("LaundryDate", laundryDate);

            return await _repository.UpdateAsync(
                _connectionString,
                _commands.Update,
                parameters);
        }
    }
}
