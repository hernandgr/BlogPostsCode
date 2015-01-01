using RedisListDemo.Web.Models;
using StackExchange.Redis;
using System.Collections.Generic;
using System.Web.Mvc;

namespace RedisListDemo.Web.Controllers
{
    public class ItemController : Controller
    {
        private const string KEY = "MyListKey";

        public ActionResult Index()
        {
            List<ItemModel> itemsList = new List<ItemModel>();

            // Connect to Redis database.
            IDatabase db = GetRedisDatabaseInstance();

            // Get all values in the list with the given key.
            RedisValue[] redisList = db.ListRange(KEY);

            // Fill object list.
            foreach (var redisValue in redisList)
            {
                itemsList.Add(new ItemModel() { Key = KEY, Value = redisValue });
            }

            return View(itemsList);
        }

        public ActionResult Create()
        {
            ItemModel item = new ItemModel()
            {
                Key = KEY
            };

            return View(item);
        }

        [HttpPost]
        public ActionResult Create(ItemModel item)
        {
            try
            {
                // Connect to Redis database.
                IDatabase db = GetRedisDatabaseInstance();

                // Add the new value to the list in Redis.
                db.ListRightPush(KEY, item.Value);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private static IDatabase GetRedisDatabaseInstance()
        {
            string server = "localhost";
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(server);
            IDatabase db = redis.GetDatabase();
            return db;
        }
    }
}