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
            return View();
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

        public ActionResult ViewDetails()
        {
            return View();
        }
    }
}