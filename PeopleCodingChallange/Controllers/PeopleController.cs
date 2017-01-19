using PeopleCodingChallange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeopleCodingChallange.Controllers
{
    public class PeopleController : Controller
    {
        PeopleConext db = new PeopleConext();
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(People p)
        {
            db.people.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Search (string txt)
        {
            IEnumerable<People> searchResult = db.people.Where(s => s.Name.Contains(txt)).ToList();
            return PartialView("search", searchResult);
            //return View(searchResult);
        }
    }
}