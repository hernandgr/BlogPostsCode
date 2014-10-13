using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.NamedRegistrations.Models;

namespace Unity.NamedRegistrations.Controllers
{
    public class MessagesController : Controller
    {
        [Dependency("English")]
        public IMessages EnglishMessages { get; set; }

        [Dependency("Spanish")]
        public IMessages SpanishMessages { get; set; }

        // GET: Messages
        public ActionResult Index()
        {
            ViewBag.EnglishMessage = EnglishMessages.Greeting();
            ViewBag.SpanishMessage = SpanishMessages.Greeting();
            return View();
        }
    }
}