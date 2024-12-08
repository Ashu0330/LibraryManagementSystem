using LibraryManagement.Domain.LibraryDto;
using LibraryManagement.Presentation.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services.ILibaryservices
{
    public interface ILibraryService
    {
        public Task<ApiResponse<IEnumerable<BooksModel>>> GetAllBooks();
    }
}
