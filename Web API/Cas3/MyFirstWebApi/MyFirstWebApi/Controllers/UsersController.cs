using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstWebApi.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        [HttpGet]
        [Route("{id:int}")]
        public string GetUserById(int id)
        {
            return "Riste";
        }
        [HttpGet]
        [Route("{name}")]
        public string GetUserByName(string name)
        {
            return "Orce";
        }
    }
}
