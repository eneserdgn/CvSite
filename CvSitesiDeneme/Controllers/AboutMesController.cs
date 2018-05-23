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
    public class AboutMesController : Controller
    {
        private CvContext db = new CvContext();

        // GET: AboutMes
        public ActionResult Index()
        {
            return View(db.AboutMes.ToList());
        }

        // GET: AboutMes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutMe aboutMe = db.AboutMes.Find(id);
            if (aboutMe == null)
            {
                return HttpNotFound();
            }
            return View(aboutMe);
        }

        // GET: AboutMes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AboutMes/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Date,Address,Nationality,Phone,Mail,Objective,WhatIDo")] AboutMe aboutMe)
        {
            if (ModelState.IsValid)
            {
                db.AboutMes.Add(aboutMe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutMe);
        }

        // GET: AboutMes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutMe aboutMe = db.AboutMes.Find(id);
            if (aboutMe == null)
            {
                return HttpNotFound();
            }
            return View(aboutMe);
        }

        // POST: AboutMes/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Date,Address,Nationality,Phone,Mail,Objective,WhatIDo")] AboutMe aboutMe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutMe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutMe);
        }

        // GET: AboutMes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutMe aboutMe = db.AboutMes.Find(id);
            if (aboutMe == null)
            {
                return HttpNotFound();
            }
            return View(aboutMe);
        }

        // POST: AboutMes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AboutMe aboutMe = db.AboutMes.Find(id);
            db.AboutMes.Remove(aboutMe);
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
