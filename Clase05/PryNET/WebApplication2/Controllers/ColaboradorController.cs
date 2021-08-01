using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ColaboradorController : Controller
    {
        private conDB conn = new conDB();
        // GET: Colaborador
        public ActionResult Index()
        {
            return View(conn.tb_Colaborador.ToList());
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            ViewBag.ListaRoles = conn.tb_Rol.ToList();
            ViewBag.ListaTipoDocumento = conn.tb_TipoDocumento.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(tb_Colaborador colaborador)
        {
            return RedirectToAction("Index");
        }
    }
}