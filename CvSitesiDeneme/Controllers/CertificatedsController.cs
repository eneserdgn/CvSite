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
    public class CertificatedsController : Controller
    {
        private CvContext db = new CvContext();

        // GET: Certificateds
        public ActionResult Index()
        {
            return View(db.Certificateds.ToList());
        }

        // GET: Certificateds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Certificated certificated = db.Certificateds.Find(id);
            if (certificated == null)
            {
                return HttpNotFound();
            }
            return View(certificated);
        }

        // GET: Certificateds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Certificateds/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,StartDate,StopDate,Name,Number,Where,Explanation")] Certificated certificated)
        {
            if (ModelState.IsValid)
            {
                db.Certificateds.Add(certificated);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(certificated);
        }

        // GET: Certificateds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Certificated certificated = db.Certificateds.Find(id);
            if (certificated == null)
            {
                return HttpNotFound();
            }
            return View(certificated);
        }

        // POST: Certificateds/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,StartDate,StopDate,Name,Number,Where,Explanation")] Certificated certificated)
        {
            if (ModelState.IsValid)
            {
                db.Entry(certificated).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(certificated);
        }

        // GET: Certificateds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Certificated certificated = db.Certificateds.Find(id);
            if (certificated == null)
            {
                return HttpNotFound();
            }
            return View(certificated);
        }

        // POST: Certificateds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Certificated certificated = db.Certificateds.Find(id);
            db.Certificateds.Remove(certificated);
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
