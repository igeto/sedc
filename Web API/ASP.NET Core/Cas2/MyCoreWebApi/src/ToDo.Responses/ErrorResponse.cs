using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Responses
{
    public class ErrorResponse
    {
        public ErrorResponse(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
        public string ErrorMessage { get; set; }
    }
}
