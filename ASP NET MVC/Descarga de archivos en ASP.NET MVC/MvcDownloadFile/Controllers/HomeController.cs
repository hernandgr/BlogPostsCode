using System.IO;
using System.Text;
using System.Web.Mvc;

namespace MvcDownloadFile.Controllers
{
    public class HomeController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            return View();
        }

        public FileResult Download()
        {
            // Obtener contenido del archivo
            string text = "El texto para mi archivo.";


            return File(Encoding.ASCII.GetBytes(text), "text/plain", "Prueba.txt");
        }
    }
}