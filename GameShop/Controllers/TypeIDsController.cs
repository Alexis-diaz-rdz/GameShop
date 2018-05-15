using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameShop.Models;

namespace GameShop.Controllers
{
    public class TypeIDsController : Controller
    {
        private GameShopContext db = new GameShopContext();

        // GET: TypeIDs
        public ActionResult Index()
        {
            return View(db.TypeIDs.ToList());
        }

        // GET: TypeIDs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeID typeID = db.TypeIDs.Find(id);
            if (typeID == null)
            {
                return HttpNotFound();
            }
            return View(typeID);
        }

        // GET: TypeIDs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeIDs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Type,TypeID_name,TypeID_Description")] TypeID typeID)
        {
            if (ModelState.IsValid)
            {
                db.TypeIDs.Add(typeID);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeID);
        }

        // GET: TypeIDs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeID typeID = db.TypeIDs.Find(id);
            if (typeID == null)
            {
                return HttpNotFound();
            }
            return View(typeID);
        }

        // POST: TypeIDs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Type,TypeID_name,TypeID_Description,ID_Number")] TypeID typeID)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeID).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeID);
        }

        // GET: TypeIDs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeID typeID = db.TypeIDs.Find(id);
            if (typeID == null)
            {
                return HttpNotFound();
            }
            return View(typeID);
        }

        // POST: TypeIDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeID typeID = db.TypeIDs.Find(id);
            db.TypeIDs.Remove(typeID);
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
