using Ninject;
using NinjectPropertiesDemo.Models;
using System.Web.Mvc;

namespace NinjectPropertiesDemo.Controllers
{
    public class AnimalsController : Controller
    {
        [Inject]
        public IAnimal Animal { get; set; }

        // GET: Animals
        public ActionResult Index()
        {
            ViewBag.AnimalSound = Animal.Sound();

            return View();
        }
    }
}