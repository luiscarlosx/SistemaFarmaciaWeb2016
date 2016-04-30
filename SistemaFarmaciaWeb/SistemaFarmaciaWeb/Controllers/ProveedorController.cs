using SistemaFarmaciaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaFarmaciaWeb.Controllers
{
    public class ProveedorController : Controller
    {
        // GET: Proveedor
          private proveedor modeloproveedor = new proveedor();
        public ActionResult Index()
        {
            List<proveedor> listaProveedores = modeloproveedor.Listar();
            return View(listaProveedores);
        }
    }
}