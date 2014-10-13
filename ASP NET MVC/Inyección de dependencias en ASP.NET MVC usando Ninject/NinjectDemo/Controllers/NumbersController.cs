using NinjectDemo.Repositories;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NinjectDemo.Controllers
{
    public class NumbersController : Controller
    {
        private readonly INumberRepository numbersRepo;

        public NumbersController(INumberRepository repo)
        {
            numbersRepo = repo;
        }

        // GET: Numbers
        public ActionResult Index()
        {
            IList<int> numbers = numbersRepo.GetNumbers();
            return View(numbers);
        }
    }
}