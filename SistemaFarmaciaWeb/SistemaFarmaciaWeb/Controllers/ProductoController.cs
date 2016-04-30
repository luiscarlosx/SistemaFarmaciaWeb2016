using SistemaFarmaciaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaFarmaciaWeb.Controllers
{
    public class ProductoController : Controller
    {

        private Producto modeloproducto = new Producto();
        // GET: Producto
        public ActionResult Index()
        {
            List<Producto> listaProductos = modeloproducto.Listar();
            return View(listaProductos);
        }
    }
}