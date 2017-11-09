using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BorregosOnline.DB;
using BorregosOnline.Models;

namespace BorregosOnline.Controllers
{
    public class UserModelsController : Controller
    {
        private Coneccion db = new Coneccion();

        // GET: UserModels
        [Route("usuarios")]
        public ActionResult Index()
        {
            return View(db.UserModels.ToList());
        }

        // GET: UserModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserModels userModels = db.UserModels.Find(id);
            if (userModels == null)
            {
                return HttpNotFound();
            }
            return View(userModels);
        }

        // GET: UserModels/Create
        [Route("usuarios/crear")]
        public ActionResult Create()
        {
            return View();
        }



        // POST: UserModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdProductor,Nombre,Rancho,CantidadDeBorregos,Contraseña,Telefono")] UserModels userModels)
        {
            if (ModelState.IsValid)
            {
                db.UserModels.Add(userModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userModels);
        }

        // GET: UserModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserModels userModels = db.UserModels.Find(id);
            if (userModels == null)
            {
                return HttpNotFound();
            }
            return View(userModels);
        }

        // POST: UserModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdProductor,Nombre,Rancho,CantidadDeBorregos,Contraseña,Telefono")] UserModels userModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userModels);
        }

        // GET: UserModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserModels userModels = db.UserModels.Find(id);
            if (userModels == null)
            {
                return HttpNotFound();
            }
            return View(userModels);
        }

        // POST: UserModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserModels userModels = db.UserModels.Find(id);
            db.UserModels.Remove(userModels);
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
