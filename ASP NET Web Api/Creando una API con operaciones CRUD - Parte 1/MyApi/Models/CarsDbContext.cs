using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyApi.Models
{
    public class CarsDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CarsDbContext()
            : base("CarsDbConnection") // Nombre de la cadena de conexión a usar.
        { 
            var initializer = new CarsDbInit();
            Database.SetInitializer(initializer);
        }
    }
}