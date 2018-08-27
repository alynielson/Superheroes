using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Superheroes.Controllers
{
    public class SuperheroController : Controller
    {
        // GET: Superhero
        public ActionResult Index()
        {
            Models.ApplicationDbContext context = new Models.ApplicationDbContext();
            return View(context.Superhero);
        }

        public ActionResult CreateHero()
        {
            return View();
        }

        public ActionResult EditHero(int? id)
        {
            Models.ApplicationDbContext context = new Models.ApplicationDbContext();
            return View(context.Superhero.SingleOrDefault(s => id == s.Id));
        }

        public ActionResult DeleteHero(int? id)
        {
            Models.ApplicationDbContext context = new Models.ApplicationDbContext();
            return View(context.Superhero.SingleOrDefault(s => id == s.Id));
        }

        public ActionResult ViewDetails(int? id)
        {
            Models.ApplicationDbContext context = new Models.ApplicationDbContext();
            return View(context.Superhero.SingleOrDefault(s => id == s.Id));
        }

        [HttpPost]
        public ActionResult CreateHero(Models.Superhero superhero)
        {
            Models.ApplicationDbContext context = new Models.ApplicationDbContext();
            context.Superhero.Add(superhero);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteHero(Models.Superhero superhero)
        {
            Models.ApplicationDbContext context = new Models.ApplicationDbContext();
            context.Superhero.Attach(superhero);
            context.Superhero.Remove(superhero);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}