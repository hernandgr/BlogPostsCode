using MyApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApi.Controllers
{
    public class CarsController : ApiController
    {
        private CarsDbContext dbContext = new CarsDbContext();

        [HttpGet]
        public IEnumerable<Car> SelectAllCars()
        {
            return dbContext.Cars.AsEnumerable();
        }
    }
}
