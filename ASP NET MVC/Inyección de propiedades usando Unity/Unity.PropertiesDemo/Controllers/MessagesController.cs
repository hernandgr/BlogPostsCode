using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.PropertiesDemo.Models;

namespace Unity.PropertiesDemo.Controllers
{
    public class MessagesController : Controller
    {
        [Dependency]
        public IMessages Messages { get; set; }

        // GET: Messages
        public ActionResult Index()
        {
            ViewBag.Message = Messages.Greeting();
            return View();
        }
    }
}