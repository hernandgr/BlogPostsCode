using System;
using System.Web.Mvc;

namespace ELMAHTest.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            throw new Exception("Oops!... better check ELMAH");
        }
    }
}