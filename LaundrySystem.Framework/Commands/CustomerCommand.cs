using LaundrySystem.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Framework.Commands
{
    public class CustomerCommand : ICustomerCommand
    {
        public string Create => "CreateCustomer";
        public string ReadAll => "GetAllCustomers";
        public string ReadById => "GetCustomerById";
        public string Update => "UpdateCustomer";
        public string Delete => "DeleteCustomer";
    }
}
