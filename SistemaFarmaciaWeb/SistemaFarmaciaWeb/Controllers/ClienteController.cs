using SistemaFarmaciaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaFarmaciaWeb.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente

              private clientes modelocliente = new clientes();
        public ActionResult Index()
        {
           List<clientes> listaClientes = modelocliente.Listar();
            return View(listaClientes);
        }
    }
}