using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Framework.Interfaces
{
    public interface ICustomerCommand
    {
        string Create { get; }
        string ReadAll { get; }
        string ReadById { get; }
        string Update { get; }
        string Delete { get; }
    }
}