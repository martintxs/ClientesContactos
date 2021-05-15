using Model.Model.Contacto;
using Service.Contacto;
using System.Web.Mvc;

namespace ClientesContactos.Controllers
{
    public class ContactoController : Controller
    {
        private readonly IContactoService _IContactoService;

        public ContactoController()
        {
            _IContactoService = new ContactoService();
        }
        // GET: Contacto
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ReadAll(int Id)
        {
            var (Respuesta, Contactos) = _IContactoService.ReadAll(Id);
            return Json(new { Respuesta, Contactos });
        }

        [HttpPost]
        public ActionResult ReadId(int Id)
        {
            var (Respuesta, Contacto) = _IContactoService.ReadId(Id);
            return Json(new { Respuesta, Contacto });
        }

        [HttpPost]
        public ActionResult Save(VoContacto Contacto)
        {
            var Respuesta = _IContactoService.Save(Contacto);
            return Json(new { Respuesta });
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            var Respuesta = _IContactoService.Delete(Id);
            return Json(new { Respuesta });
        }
    }
}