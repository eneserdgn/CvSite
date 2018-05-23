using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CvSitesiDeneme.Models;

namespace CvSitesiDeneme.Controllers
{
    public class EnteriesController : Controller
    {
        private CvContext db = new CvContext();

        // GET: Enteries
        public ActionResult Index()
        {
            return View(db.Enteries.ToList());
        }

        // GET: Enteries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entery entery = db.Enteries.Find(id);
            if (entery == null)
            {
                return HttpNotFound();
            }
            return View(entery);
        }

        // GET: Enteries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enteries/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,JobFirstName,JobLastName,Introduction")] Entery entery)
        {
            if (ModelState.IsValid)
            {
                db.Enteries.Add(entery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entery);
        }

        // GET: Enteries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entery entery = db.Enteries.Find(id);
            if (entery == null)
            {
                return HttpNotFound();
            }
            return View(entery);
        }

        // POST: Enteries/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,JobFirstName,JobLastName,Introduction")] Entery entery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entery);
        }

        // GET: Enteries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entery entery = db.Enteries.Find(id);
            if (entery == null)
            {
                return HttpNotFound();
            }
            return View(entery);
        }

        // POST: Enteries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entery entery = db.Enteries.Find(id);
            db.Enteries.Remove(entery);
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
