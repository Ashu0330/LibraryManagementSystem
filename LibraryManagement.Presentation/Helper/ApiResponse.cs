using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Presentation.Helper
{
    public class ApiResponse<T>
    {
        public bool IsSuccess { get; set; }
        public int ResponseCode { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }
        public ApiResponse(bool isSuccess, int responseCode, string message, T data)
        {
            this.IsSuccess = isSuccess;
            this.ResponseCode = responseCode;
            this.Message = message;
            this.Data = data;
        }
    }
}
