using Microsoft.WindowsAzure.Mobile.Service;

namespace MobileServiceDemo.Models
{
    public class Persona : EntityData
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
}