using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecretSatanWebMVC.Models;
using SecretSatan.App;

namespace SecretSatanWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(People People)
        {
            if (People.Text == null || People.Text.Trim() == "")
                return View();

            People.Names = People.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            People.Pairs = SatanRandomizer.RandomizeSatanPairs(People.Names);
            People.IsSet = true;
            return View(People);
        }
    }
}