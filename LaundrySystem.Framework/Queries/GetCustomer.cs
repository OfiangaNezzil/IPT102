using Dapper;
using LaundrySystem.Domain.Models;
using LaundrySystem.Domain.Queries;
using LaundrySystem.Framework.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaundrySystem.Framework.Queries
{
    internal class GetCustomer : IGetCustomer
    {
        private readonly IRepository<Customer> _repository;
        private readonly ICustomerCommand _commands;
        private readonly string _connectionString;

        public GetCustomer(
            IRepository<Customer> repository,
            ICustomerCommand commands,
            string connectionString)
        {
            _repository = repository;
            _commands = commands;
            _connectionString = connectionString;
        }

        public Task<IEnumerable<Customer>> ExecuteAsync()
        {
            return _repository.ReadAllAsync(
                _connectionString,
                _commands.ReadAll);
        }

        public Task<Customer?> ExecuteAsync(int customerId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("CustomerId", customerId);

            return _repository.ReadByIdAsync(
                _connectionString,
                _commands.ReadById,
                parameters);
        }
    }
}
