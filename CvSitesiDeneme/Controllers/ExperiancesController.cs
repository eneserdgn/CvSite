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
    public class ExperiancesController : Controller
    {
        private CvContext db = new CvContext();

        // GET: Experiances
        public ActionResult Index()
        {
            return View(db.Experiances.ToList());
        }

        // GET: Experiances/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Experiance experiance = db.Experiances.Find(id);
            if (experiance == null)
            {
                return HttpNotFound();
            }
            return View(experiance);
        }

        // GET: Experiances/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Experiances/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,StartDate,StopDate,JobName,CompanyName,Where,Explanation")] Experiance experiance)
        {
            if (ModelState.IsValid)
            {
                db.Experiances.Add(experiance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(experiance);
        }

        // GET: Experiances/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Experiance experiance = db.Experiances.Find(id);
            if (experiance == null)
            {
                return HttpNotFound();
            }
            return View(experiance);
        }

        // POST: Experiances/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,StartDate,StopDate,JobName,CompanyName,Where,Explanation")] Experiance experiance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(experiance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(experiance);
        }

        // GET: Experiances/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Experiance experiance = db.Experiances.Find(id);
            if (experiance == null)
            {
                return HttpNotFound();
            }
            return View(experiance);
        }

        // POST: Experiances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Experiance experiance = db.Experiances.Find(id);
            db.Experiances.Remove(experiance);
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
