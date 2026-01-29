using LaundrySystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Domain.Commands
{
    public interface IDeleteCommand
    {
        Task<bool> ExecuteAsync(Customer customer);
    }
}
