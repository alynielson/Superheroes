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
            Models.ApplicationDbContext context = new Models.ApplicationDbContext();
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
    }
}