using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wikipages.Models;
using Microsoft.EntityFrameworkCore;

namespace Wikipages.Controllers
{
    public class BusinessesController : Controller
    {
        // GET: /<controller>/
        private WikipagesDBContext db = new WikipagesDBContext();
        public IActionResult Index()
        {
            return View(db.Businesses.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisBusiness = db.Businesses.FirstOrDefault(businesses => businesses.BusinessId == id);
            return View(thisBusiness);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Business business)
        {
            db.Businesses.Add(business);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisBusiness = db.Businesses.FirstOrDefault(businesses => businesses.BusinessId == id);
            return View(thisBusiness);
        }
        [HttpPost]
        public IActionResult Edit(Business business)
        {
            db.Entry(business).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisBusiness = db.Businesses.FirstOrDefault(businesses => businesses.BusinessId == id);
            return View(thisBusiness);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisBusiness = db.Businesses.FirstOrDefault(businesses => businesses.BusinessId == id);
            db.Businesses.Remove(thisBusiness);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
