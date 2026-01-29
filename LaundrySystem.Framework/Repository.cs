using Dapper;
using LaundrySystem.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace LaundrySystem.Framework
{
    public class Repository<T> : IRepository<T>
    {
        private SqlConnection CreateConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }

        public async Task<IEnumerable<T>> ReadAllAsync(
            string connectionString,
            string storedProcedure,
            DynamicParameters? parameters = null)
        {
            using var connection = CreateConnection(connectionString);
            return await connection.QueryAsync<T>(
                storedProcedure,
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<T?> ReadByIdAsync(
            string connectionString,
            string storedProcedure,
            DynamicParameters? parameters = null)
        {
            using var connection = CreateConnection(connectionString);
            return await connection.QueryFirstOrDefaultAsync<T>(
                storedProcedure,
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<bool> CreateAsync(
            string connectionString,
            string storedProcedure,
            DynamicParameters? parameters = null)
        {
            using var connection = CreateConnection(connectionString);
            int rows = await connection.ExecuteAsync(
                storedProcedure,
                parameters,
                commandType: CommandType.StoredProcedure);

            return rows > 0;
        }

        public async Task<bool> UpdateAsync(
            string connectionString,
            string storedProcedure,
            DynamicParameters? parameters = null)
        {
            using var connection = CreateConnection(connectionString);
            int rows = await connection.ExecuteAsync(
                storedProcedure,
                parameters,
                commandType: CommandType.StoredProcedure);

            return rows > 0;
        }

        public async Task<bool> DeleteAsync(
            string connectionString,
            string storedProcedure,
            DynamicParameters? parameters = null)
        {
            using var connection = CreateConnection(connectionString);
            int rows = await connection.ExecuteAsync(
                storedProcedure,
                parameters,
                commandType: CommandType.StoredProcedure);

            return rows > 0;
        }
    }
}
