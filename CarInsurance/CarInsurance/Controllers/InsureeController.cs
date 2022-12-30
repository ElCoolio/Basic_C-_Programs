using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTicket,CoverageType")] Insuree insuree)
        {
            // intial quote of $50
            decimal quote = 50m;

            // var used to determine age
            int age = DateTime.Today.Year - insuree.DateOfBirth.Year;

            // logic for additonal to quote based off the insuree's age
            if (age <= 18)
            {
                quote += 100m;
            }
            else if (age > 18 && age <= 25)
            {
                quote += 50m;
            }
            else
            {
                quote += 25m;
            }

            // logic for car year
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
            {
                quote += 25m;
            }

            // logic for car make and model
            if (insuree.CarMake.ToLower() == "porsche")
            {
                quote += 25m;
                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    quote += 25m;
                }
            }

            //speeding ticket logic

            decimal speedingQuote;
            if(insuree.SpeedingTicket < 0)
            {
                speedingQuote = 0;
                insuree.SpeedingTicket = 0;
            }
            else
            {
                speedingQuote = insuree.SpeedingTicket * 10m;
            }
            quote += speedingQuote;

            //DUI logic
            decimal duiQuote = 0m;
            if (insuree.DUI)
            {
                duiQuote = (quote / 4);
            }
            quote += duiQuote;


            //Full coverage logic
            decimal fullCoverageQuote = 0m;
            if (insuree.CoverageType)
            {
                fullCoverageQuote = (quote / 2);
            }
            quote += fullCoverageQuote;

            insuree.Quote = quote;

            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTicket,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
