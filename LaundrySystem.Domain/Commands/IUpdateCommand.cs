using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaundrySystem.Domain.Models;

namespace LaundrySystem.Domain.Commands
{
    public interface IUpdateCommand
    {
        Task<bool> ExecuteAsync(Customer customer);
    }
}
