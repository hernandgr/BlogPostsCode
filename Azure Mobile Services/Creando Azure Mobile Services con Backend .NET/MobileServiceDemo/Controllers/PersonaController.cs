using Microsoft.WindowsAzure.Mobile.Service;
using MobileServiceDemo.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;

namespace MobileServiceDemo.Controllers
{
    public class PersonaController : TableController<Persona>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<Persona>(context, Request, Services);
        }

        // GET tables/Persona
        public IQueryable<Persona> GetAllPersona()
        {
            return Query();
        }

        // GET tables/Persona/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Persona> GetPersona(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Persona/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Persona> PatchPersona(string id, Delta<Persona> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Persona
        public async Task<IHttpActionResult> PostPersona(Persona item)
        {
            Persona current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Persona/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeletePersona(string id)
        {
            return DeleteAsync(id);
        }
    }
}