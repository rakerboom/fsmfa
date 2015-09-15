using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FSMFMVC.Models;

namespace FSMFMVC.Controllers
{
    public class ExecutivesController : Controller
    {
        private MusicFestivalDBContext db = new MusicFestivalDBContext();

        // GET: Executives
        public ActionResult Index()
        {
            return View(db.Executive.ToList());
        }

        // GET: Executives/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Executive executive = db.Executive.Find(id);
            if (executive == null)
            {
                return HttpNotFound();
            }
            return View(executive);
        }

        // GET: Executives/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Executives/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,Title,Description,ImagePath")] Executive executive)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Executive.Add(executive);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(executive);
        //}

        //// GET: Executives/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Executive executive = db.Executive.Find(id);
        //    if (executive == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(executive);
        //}

        //// POST: Executives/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Title,Description,ImagePath")] Executive executive)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(executive).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(executive);
        //}

        //// GET: Executives/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Executive executive = db.Executive.Find(id);
        //    if (executive == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(executive);
        //}

        //// POST: Executives/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Executive executive = db.Executive.Find(id);
        //    db.Executive.Remove(executive);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
