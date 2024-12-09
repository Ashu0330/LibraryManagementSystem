using Dapper;
using LibraryManagement.Domain.LibraryDto;
using LibraryManagement.Infrastructure.RepositoryServices;
using LibraryManagement.Presentation.Helper;
using LibraryManagement.Services.ILibaryservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services.LibararyServices
{
    public class LibraryService : ILibraryService
    {
        private readonly IRepositoryService<BooksModel> repository;
        public LibraryService(IRepositoryService<BooksModel> repository)
        {
            this.repository = repository;
        }

        public async Task<ApiResponse<IEnumerable<BooksModel>>> GetAllBooks()
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@flag", (int)EnumOperation.GetAllData);
            var result = await this.repository.GetAllAsync("GetInsertUpdate", parameters);
            if (result != null && result.Count() > 0)
                return new ApiResponse<IEnumerable<BooksModel>>(true, 200, "Geta retrieved successfully", result);
            return new ApiResponse<IEnumerable<BooksModel>>(false, 404, "No Data Found", new List<BooksModel>());

        }

        public async Task<ApiResponse<bool>> InsertIntoBooks(BooksModel model)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@flag", (int)EnumOperation.InsertData);
            parameters.Add("@Author", model.Author);
            parameters.Add("@Title", model.Title);
            parameters.Add("@Genre", model.Genre);
            parameters.Add("@CopiesAvailable", model.CopiesAvailable);
            var result = await this.repository.GetAsync("GetInsertUpdate", parameters);
            if (result != null)
                return new ApiResponse<bool>(true, 200, "Data inserted successfully", true);
            return new ApiResponse<bool>(false, 404, "Error while inserting data", false);



        }
    }
}
