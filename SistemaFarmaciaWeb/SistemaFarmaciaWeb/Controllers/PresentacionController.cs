using SistemaFarmaciaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaFarmaciaWeb.Controllers
{
    public class PresentacionController : Controller
    {
        // GET: Presentacion
          private presentacion modelopresentacion = new presentacion();
        public ActionResult Index()
        {
           List<presentacion> listaPresentaciones = modelopresentacion.Listar();
            return View(listaPresentaciones);
        }
    }
}