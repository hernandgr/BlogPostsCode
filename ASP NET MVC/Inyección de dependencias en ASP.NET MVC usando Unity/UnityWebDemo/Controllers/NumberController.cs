using System.Collections.Generic;
using System.Web.Mvc;
using UnityWebDemo.Repository;

namespace UnityWebDemo.Controllers
{
    public class NumberController : Controller
    {
        private readonly INumberRepository _repo;

        public NumberController(INumberRepository repo)
        {
            this._repo = repo;
        }

        public ActionResult Index()
        {
            IEnumerable<int> numbers = _repo.GetNumbers();

            return View(numbers);
        }
    }
}