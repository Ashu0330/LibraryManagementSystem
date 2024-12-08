using LibraryManagement.DAL.IFactoryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAL.FactoryServices
{
    public class ConnectionService : IConnectionService
    {
        string ConStr;
        public ConnectionService(string ConStr)
        {
            this.ConStr = ConStr;
        }
        public string GetConnection()
        {
            return this.ConStr;
        }
    }
}

