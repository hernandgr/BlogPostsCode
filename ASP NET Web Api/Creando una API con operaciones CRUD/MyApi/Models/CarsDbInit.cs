using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyApi.Models
{
    public class CarsDbInit : DropCreateDatabaseAlways<CarsDbContext>
    {
        protected override void Seed(CarsDbContext context)
        {
            context.Cars.Add(new Car() { Id = 1, Name = "Porsche 911", Color = "Blue" });
            context.SaveChanges();
            //base.Seed(context);
        }
    }
}