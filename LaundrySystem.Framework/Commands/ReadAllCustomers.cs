using LaundrySystem.Domain.Models;
using LaundrySystem.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Framework.Commands
{
    public class ReadAllCustomers
    {
        private readonly IRepository<Customer> _repository;
        private readonly ICustomerCommand _commands;
        private readonly string _connectionString;

        public ReadAllCustomers(IRepository<Customer> repository, ICustomerCommand commands, string connectionString)
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
    }
}
