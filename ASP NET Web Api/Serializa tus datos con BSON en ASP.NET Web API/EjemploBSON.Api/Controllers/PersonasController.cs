using EjemploBSON.Api.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace EjemploBSON.Api.Controllers
{
    public class PersonasController : ApiController
    {
        // GET api/personas
        public IEnumerable<Persona> Get()
        {
            List<Persona> personas = new List<Persona>();

            personas.Add(new Persona() { Identificacion = 1, Nombre = "Hernan", Telefono = "1234567" });
            personas.Add(new Persona() { Identificacion = 2, Nombre = "Alejandro", Telefono = "8541421" });
            personas.Add(new Persona() { Identificacion = 3, Nombre = "Camilo", Telefono = "5214214" });

            return personas;
        }        
    }
}