using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace WebApplication2.Controllers
{
    public class CategoriaController : Controller
    {
        private conDB conn = new conDB();
        // GET: Categoria
        public ActionResult Index()
        {
            return View(conn.tb_Categoria.ToList());
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(tb_Categoria cat)
        {
            conn.tb_Categoria.Add(cat);
            conn.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            tb_Categoria cat = new tb_Categoria();
            cat = conn.tb_Categoria.Find(id);
            return View(cat);
        }
        [HttpPost]
        public ActionResult Edit(tb_Categoria catnew)
        {
            tb_Categoria cat = new tb_Categoria();
            cat = conn.tb_Categoria.Find(catnew.idCategoria);
            cat.nombreCategoria = catnew.nombreCategoria;
            conn.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            conn.tb_Categoria.Remove(conn.tb_Categoria.Find(id));

            conn.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}