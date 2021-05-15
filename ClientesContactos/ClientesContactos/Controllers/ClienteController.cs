using Model.Model.Cliente;
using Service.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientesContactos.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _IClienteService;
        public ClienteController()
        {
            _IClienteService = new ClienteService();
        }
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ReadAll()
        {
            var (Respuesta, Clientes) = _IClienteService.ReadAll();
            return Json(new { Respuesta, Clientes });
        }

        [HttpPost]
        public ActionResult ReadId(int Id)
        {
            var (Respuesta, Cliente) = _IClienteService.ReadId(Id);
            return Json(new { Respuesta, Cliente });
        }

        [HttpPost]
        public ActionResult Save(VoCliente Cliente)
        {
            var Respuesta = _IClienteService.Save(Cliente);
            return Json(new { Respuesta });
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            var Respuesta = _IClienteService.Delete(Id);
            return Json(new { Respuesta });
        }
    }
}