using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace LaundrySystem.Framework.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> ReadAllAsync(
            string connectionString,
            string storedProcedure,
            DynamicParameters? parameters = null);

        Task<T?> ReadByIdAsync(
            string connectionString,
            string storedProcedure,
            DynamicParameters? parameters = null);

        Task<bool> CreateAsync(
            string connectionString,
            string storedProcedure,
            DynamicParameters? parameters = null);

        Task<bool> UpdateAsync(
            string connectionString,
            string storedProcedure,
            DynamicParameters? parameters = null);

        Task<bool> DeleteAsync(
            string connectionString,
            string storedProcedure,
            DynamicParameters? parameters = null);
    }
}
