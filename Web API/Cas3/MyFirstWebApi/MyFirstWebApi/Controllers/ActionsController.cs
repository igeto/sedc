using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstWebApi.Controllers
{
    public class ActionsController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetSum()
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        
    }
}
