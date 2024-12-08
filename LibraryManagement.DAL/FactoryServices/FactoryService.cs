using LibraryManagement.DAL.IFactoryServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAL.FactoryServices
{
    public class FactoryService : IFactoryService
    {
        private readonly IConnectionService connectionService;
        public FactoryService(IConnectionService connectionService)
        {
            this.connectionService = connectionService;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(this.connectionService.GetConnection());
        }
    }
}
