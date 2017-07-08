using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWithIdentity.Controllers
{
    [Authorize]
    public class TestController : Controller
    {
        [Authorize(Roles = "test")]
        // GET: Test
        public ActionResult Index1()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }
    }
}