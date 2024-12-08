using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.RepositoryServices
{
    public interface IRepositoryService<T> where T : class
    {
        public Task<T> GetAsync(string query, object? parameters = null);
        public Task<IEnumerable<T>> GetAllAsync(string query, object? parameters = null);

    }
}
