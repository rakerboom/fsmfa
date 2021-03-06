﻿using System;
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
    public class DonorsController : Controller
    {
        private StaticDataDBContext db = new StaticDataDBContext();

        // GET: Donors
        public ActionResult Index()
        {
            return View(db.Donor.ToList());
        }

        // GET: Donors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donor donor = db.Donor.Find(id);
            var d = from m in db.Donor2
                    where m.donor_id == id
                    select m;

            if (donor == null)
            {
                return HttpNotFound();
            }

            ViewBag.level = donor.Title;

            return View(db.Donor2.Where(u => u.donor_id == id).ToList());
        }

        // GET: Donors/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Donors/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,Title,Description,ImagePath")] Donor donor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Donors.Add(donor);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(donor);
        //}

        //// GET: Donors/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Donor donor = db.Donors.Find(id);
        //    if (donor == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(donor);
        //}

        //// POST: Donors/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Title,Description,ImagePath")] Donor donor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(donor).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(donor);
        //}

        //// GET: Donors/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Donor donor = db.Donors.Find(id);
        //    if (donor == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(donor);
        //}

        //// POST: Donors/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Donor donor = db.Donors.Find(id);
        //    db.Donors.Remove(donor);
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
