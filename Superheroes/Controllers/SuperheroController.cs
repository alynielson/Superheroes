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

        public ActionResult EditHero()
        {
            return View();
        }

        public ActionResult DeleteHero()
        {
            return View();
        }

        public ActionResult ViewDetails(int? id)
        {
            Models.ApplicationDbContext context = new Models.ApplicationDbContext();
            return View(context.Superhero.Where(s => id == s.Id));
        }
    }
}