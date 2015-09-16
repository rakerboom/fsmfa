using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FSMFMVC.Models;
using System.Web.Security;

namespace FSMFMVC.Controllers
{
    public class EntrantsController : Controller
    {
        private StaticDataDBContext db = new StaticDataDBContext();

        // GET: Entrants
        [Authorize]
        public ActionResult Index()
        {
            var entrants = from m in db.Entrants
                         select m;

                if (!String.IsNullOrEmpty(User.Identity.Name))
                {
                    entrants = entrants.Where(s => s.UserEmail.Contains(User.Identity.Name));
                    return View(entrants);
                }

            return View(new List<Entrant>());
        }

        // GET: Entrants/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrant entrant = db.Entrants.Find(id);
            if (entrant == null)
            {
                return HttpNotFound();
            }
            return View(entrant);
        }

        // GET: Entrants/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entrants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "FirstName,LastName,PhoneNumber,Address,City,Province,PostalCode,SchoolAttending,GradeInSchool,Email,GradeInMusic,Age,ClassName,ClassNumber,Instruments,Selection,PerformanceTime,NumberOfParicipants,ParicipantsNames,NameofAccompanist,MusicSupervisorsFirstName,MusicSupervisorsLastName,MusicSupervisorsPhone,MusicSupervisorsAlternatePhone,MusicSupervisorsEmail,VolunteerFirstName,VolunteerLastName,VolunteerPhone,SpecialRequests")] Entrant entrant)
        {
            entrant.UserEmail = User.Identity.Name;

            if (ModelState.IsValid)
            {
                db.Entrants.Add(entrant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entrant);
        }

        // GET: Entrants/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrant entrant = db.Entrants.Find(id);
            if (entrant == null)
            {
                return HttpNotFound();
            }
            return View(entrant);
        }

        // POST: Entrants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,PhoneNumber,Address,City,Province,PostalCode,SchoolAttending,GradeInSchool,Email,GradeInMusic,Age,ClassName,ClassNumber,Instruments,Selection,PerformanceTime,NumberOfParicipants,ParicipantsNames,NameofAccompanist,MusicSupervisorsFirstName,MusicSupervisorsLastName,MusicSupervisorsPhone,MusicSupervisorsAlternatePhone,MusicSupervisorsEmail,VolunteerFirstName,VolunteerLastName,VolunteerPhone,SpecialRequests")] Entrant entrant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entrant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entrant);
        }

        // GET: Entrants/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrant entrant = db.Entrants.Find(id);
            if (entrant == null)
            {
                return HttpNotFound();
            }
            return View(entrant);
        }

        // POST: Entrants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Entrant entrant = db.Entrants.Find(id);
            db.Entrants.Remove(entrant);
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
