using Ninject.NamedRegistrations.Models;
using System.Web.Mvc;

namespace Ninject.NamedRegistrations.Controllers
{
    public class MessagesController : Controller
    {
        [Inject]
        [Named("English")]
        public IMessages EnglishMessages { get; set; }

        [Inject]
        [Named("Spanish")]
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