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
    public class ReadCustomerById
    {
        private readonly IRepository<Customer> _repository;
        private readonly ICustomerCommand _commands;
        private readonly string _connectionString;

        public ReadCustomerById(IRepository<Customer> repository, ICustomerCommand commands, string connectionString)
        {
            _repository = repository;
            _commands = commands;
            _connectionString = connectionString;
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
