using Dapper;
using LibraryManagement.DAL.IFactoryServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.RepositoryServices
{
    public class RepositoryService<T> : IRepositoryService<T> where T : class
    {
        private readonly IFactoryService factoryService;
        public RepositoryService(IFactoryService factoryService)
        {
            this.factoryService = factoryService;
        }

        public async Task<IEnumerable<T>> GetAllAsync(string query, object parameters)
        {
            var result = new List<T>();
            var connection = this.factoryService.CreateConnection();
            if (connection.State == ConnectionState.Closed) connection.Open();
            if (parameters != null)
            {
                result = (await connection.QueryAsync<T>(query, parameters, commandType: CommandType.StoredProcedure)).ToList();
            }
            else
                result = (await connection.QueryAsync<T>(query)).ToList();
            return result;

        }

        public async Task<T> GetAsync(string query, object parameters)
        {
            T? result;
            var connection = this.factoryService.CreateConnection();
            if (connection.State == ConnectionState.Closed) connection.Open();
            if (parameters != null)
            {
                result = (await connection.QueryAsync<T>(query, parameters, commandType: CommandType.StoredProcedure)).LastOrDefault();
            }
            else
                result = (await connection.QueryAsync<T>(query)).LastOrDefault();
            return result;
        }

    }
}
