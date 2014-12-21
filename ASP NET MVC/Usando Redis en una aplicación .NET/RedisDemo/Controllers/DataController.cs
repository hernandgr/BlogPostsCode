using RedisDemo.Models;
using StackExchange.Redis;
using System.Web.Mvc;

namespace RedisDemo.Controllers
{
    public class DataController : Controller
    {
        public ActionResult Index()
        {
            var data = new Data();
            return View(data);
        }

        [HttpPost]
        public ActionResult Index(Data data)
        {
            ModelState.Remove("Value");
            data.Message = string.Empty;
            data.Value = string.Empty;

            if (ModelState.IsValid)
            {
                ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
                var db = redis.GetDatabase();

                var value = db.StringGet(data.Key);

                if (value.HasValue)
                {
                    data.Value = value;
                }
                else
                {
                    data.Message = "Key not found.";
                }
            }

            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Data data)
        {
            if (ModelState.IsValid)
            {
                string server = "localhost";
                ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(server);
                var db = redis.GetDatabase();

                db.StringSet(data.Key, data.Value);

                return RedirectToAction("Create");
            }

            return View(data);
        }
    }
}