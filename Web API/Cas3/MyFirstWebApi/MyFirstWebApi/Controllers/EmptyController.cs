using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstWebApi.Controllers
{
    [RoutePrefix("api/empty")]
    public class EmptyController : ApiController
    {
        [HttpGet]
        [Route("HelloWorld")]
        public string Get()
        {
            return "Hello World";
        }
        [HttpGet]
        [Route("GoodByeWorld")]
        public string GetMe()
        {
            return "Goodbye Cruel World, Goodbye";
        }
        [Route("~/api/alternative/getalternative")]
        public string GetAlternative()
        {
            return "Im not empty";
        }
        [HttpGet]
        [Route("echo/{n}")]
        public int Echo(int n)
        {
            return 1337;
        }
        [HttpGet]
        [Route("sum/{a}/{b}")]
        public int Sum(int a, int b)
        {
            return a + b;
        }

        [HttpGet]
        public IHttpActionResult Result()
        {
            return NotFound();
        }
        [HttpGet]
        [Route("returninteger/{id}")]
        public IHttpActionResult ReturnInteger(int id)
        {
            if (id < 0)
            {
                return BadRequest("enter a value greter than zero");
            }
            else
            {
                return Ok();
            }
        }
    }
}
