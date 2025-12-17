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

        private decimal Quote(Insuree insuree)
        {
            // Start with base price of $50/month
            decimal monthlyTotal = 50.0m;

            // Age-based calculations
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            // Adjust age if birthday hasn't occurred yet this year
            if (insuree.DateOfBirth.Date > DateTime.Now.AddYears(-age)) age--;

            if (age <= 18)
            {
                monthlyTotal += 100.0m;
            }
            else if (age >= 19 && age <= 25)
            {
                monthlyTotal += 50.0m;
            }
            else // age >= 26
            {
                monthlyTotal += 25.0m;
            }

            // Car year-based calculations
            if (insuree.CarYear < 2000)
            {
                monthlyTotal += 25.0m;
            }
            else if (insuree.CarYear > 2015)
            {
                monthlyTotal += 25.0m;
            }

            // Car make and model calculations
            if (insuree.CarMake.ToLower() == "porsche")
            {
                monthlyTotal += 25.0m;

                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    monthlyTotal += 25.0m;
                }
            }

            // Speeding ticket calculations
            monthlyTotal += 10.0m * insuree.SpeedingTickets;

            // Apply DUI surcharge if applicable (25% increase)
            if (insuree.DUI)
            {
                monthlyTotal *= 1.25m;
            }

            // Apply full coverage surcharge if applicable (50% increase)
            if (insuree.CoverageType)
            {
                monthlyTotal *= 1.5m;
            }

            return monthlyTotal;
        }



        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Calculate and set the quote before saving
                insuree.Quote = Quote(insuree);

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // POST: Insuree/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Calculate and set the quote before saving
                insuree.Quote = Quote(insuree);

                db.Entry(insuree).State = EntityState.Modified;
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


        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
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
