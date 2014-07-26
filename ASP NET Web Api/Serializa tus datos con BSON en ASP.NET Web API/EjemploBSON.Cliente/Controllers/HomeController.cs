using EjemploBSON.Cliente.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EjemploBSON.Cliente.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Persona> personas = Task.Run(async () => await ObtenerPersonas()).Result;

            return View(personas);
        }

        private async Task<List<Persona>> ObtenerPersonas()
        {
            List<Persona> personas = null;

            using (HttpClient cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("http://localhost:60461");

                // Adicionar encabezado con el tipo de contenido (application/bson)
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/bson"));

                // Enviar petición al servicio
                var resultado = await cliente.GetAsync("api/personas");
                resultado.EnsureSuccessStatusCode();

                // Deserializar el resultado
                MediaTypeFormatter[] formatos = new MediaTypeFormatter[] { new BsonMediaTypeFormatter() };
                personas = await resultado.Content.ReadAsAsync<List<Persona>>(formatos);
            }

            return personas;
        }
    }
}