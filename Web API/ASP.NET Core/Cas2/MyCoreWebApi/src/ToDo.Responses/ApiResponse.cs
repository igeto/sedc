using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Responses
{
    public class ApiResponse<T>
    {
        public string Version { get; set; }
        public string MethodCalled { get; set; }
        public T ResponseData { get; set; }
        public ApiResponse( string version, string methodCalled, T responseData)
        {
            Version = version;
            MethodCalled = methodCalled;
            ResponseData = responseData;
        }
    }
}
