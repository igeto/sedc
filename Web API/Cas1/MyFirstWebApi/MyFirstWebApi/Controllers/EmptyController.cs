using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstWebApi.Controllers
{
    public class EmptyController : ApiController
    {
        [HttpGet]
        [Route("api/Empty/HelloWorld")]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [HttpGet]
        [Route("api/Empty/GoodByeWorld")]
        public string GoodByeWorld()
        {
            return "Goodbye Cruel World, Goodbye";
        }
    }
}
