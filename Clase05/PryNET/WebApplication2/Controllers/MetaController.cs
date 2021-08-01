using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace WebApplication2.Controllers
{
    public class MetaController : Controller
    {
        private conDB db = new conDB();

        // GET: Meta
        public ActionResult Index()
        {
            var tb_Meta = db.tb_Meta.Include(t => t.tb_Producto).Include(t => t.tb_Rol).Include(t => t.tb_SemanaPlanificada);
            return View(tb_Meta.ToList());
        }

        // GET: Meta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Meta tb_Meta = db.tb_Meta.Find(id);
            if (tb_Meta == null)
            {
                return HttpNotFound();
            }
            return View(tb_Meta);
        }

        // GET: Meta/Create
        public ActionResult Create()
        {
            ViewBag.idProducto = new SelectList(db.tb_Producto, "idProducto", "nombreProducto");
            ViewBag.idRol = new SelectList(db.tb_Rol, "idRol", "nombreRol");
            ViewBag.idSemanaPlan = new SelectList(db.tb_SemanaPlanificada, "idSemanaPlan", "nombreSemanaPlan");
            return View();
        }

        // POST: Meta/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idRol,idSemanaPlan,totalMeta,idProducto")] tb_Meta tb_Meta)
        {
            if (ModelState.IsValid)
            {
                db.tb_Meta.Add(tb_Meta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idProducto = new SelectList(db.tb_Producto, "idProducto", "nombreProducto", tb_Meta.idProducto);
            ViewBag.idRol = new SelectList(db.tb_Rol, "idRol", "nombreRol", tb_Meta.idRol);
            ViewBag.idSemanaPlan = new SelectList(db.tb_SemanaPlanificada, "idSemanaPlan", "nombreSemanaPlan", tb_Meta.idSemanaPlan);
            return View(tb_Meta);
        }

        // GET: Meta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Meta tb_Meta = db.tb_Meta.Find(id);
            if (tb_Meta == null)
            {
                return HttpNotFound();
            }
            ViewBag.idProducto = new SelectList(db.tb_Producto, "idProducto", "nombreProducto", tb_Meta.idProducto);
            ViewBag.idRol = new SelectList(db.tb_Rol, "idRol", "nombreRol", tb_Meta.idRol);
            ViewBag.idSemanaPlan = new SelectList(db.tb_SemanaPlanificada, "idSemanaPlan", "nombreSemanaPlan", tb_Meta.idSemanaPlan);
            return View(tb_Meta);
        }

        // POST: Meta/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idRol,idSemanaPlan,totalMeta,idProducto")] tb_Meta tb_Meta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Meta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idProducto = new SelectList(db.tb_Producto, "idProducto", "nombreProducto", tb_Meta.idProducto);
            ViewBag.idRol = new SelectList(db.tb_Rol, "idRol", "nombreRol", tb_Meta.idRol);
            ViewBag.idSemanaPlan = new SelectList(db.tb_SemanaPlanificada, "idSemanaPlan", "nombreSemanaPlan", tb_Meta.idSemanaPlan);
            return View(tb_Meta);
        }

        // GET: Meta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Meta tb_Meta = db.tb_Meta.Find(id);
            if (tb_Meta == null)
            {
                return HttpNotFound();
            }
            return View(tb_Meta);
        }

        // POST: Meta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Meta tb_Meta = db.tb_Meta.Find(id);
            db.tb_Meta.Remove(tb_Meta);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
