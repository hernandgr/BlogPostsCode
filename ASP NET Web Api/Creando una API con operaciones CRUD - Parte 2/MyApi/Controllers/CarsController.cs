using MyApi.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

        [HttpPost]
        public IHttpActionResult AddCar([FromBody]Car car)
        {
            if (ModelState.IsValid)
            {
                dbContext.Cars.Add(car);
                dbContext.SaveChanges();

                return Ok(car);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult UpdateCar(int id, [FromBody]Car car)
        {
            if (ModelState.IsValid)
            {
                var carExists = dbContext.Cars.Count(c => c.Id == id) > 0;

                if (carExists)
                {
                    dbContext.Entry(car).State = EntityState.Modified;
                    dbContext.SaveChanges();

                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteCar(int id)
        {
            var car = dbContext.Cars.Find(id);

            if (car != null)
            {
                dbContext.Cars.Remove(car);
                dbContext.SaveChanges();

                return Ok(car);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
