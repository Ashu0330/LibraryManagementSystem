using LibraryManagement.Domain.LibraryDto;
using LibraryManagement.Presentation.Helper;
using LibraryManagement.Services.ILibaryservices;
using LibraryManagement.Services.LibararyServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Api.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService libraryService;
        public LibraryController(ILibraryService libraryService)
        {
            this.libraryService = libraryService;
        }
        [HttpGet]
        public async Task<ApiResponse<IEnumerable<BooksModel>>> GetAllBooks()
        {
            return await libraryService.GetAllBooks();
        }
        [HttpPost]
        public async Task<ApiResponse<bool>> InsertIntoBooks(BooksModel model)
        {
            return await this.libraryService.InsertIntoBooks(model);
        }

    }
}
