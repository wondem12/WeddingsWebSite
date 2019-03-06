using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Serg_1._0.Controllers
{
    public class BusController : Controller
    {
        Serg_DBEntities serg = new Serg_DBEntities();
        public ActionResult Dj()
        {
            return View(serg.Businesses.ToList());
        }
        public ActionResult Photography()
        {
            return View(serg.Businesses.ToList());
        }
        public ActionResult BrightHairdress()
        {
            return View(serg.Businesses.ToList());
        }
        public ActionResult bridesmakeup()
        {
            return View(serg.Businesses.ToList());
        }
        public ActionResult WeddingDresses()
        {

            return View(serg.Businesses.ToList());
        }
        public ActionResult GroomSuit()
        {

            return View(serg.Businesses.ToList());
        }
        public ActionResult HennaProductions()
        {

            return View(serg.Businesses.ToList());
        }
        public ActionResult Drinks()
        {

            return View(serg.Businesses.ToList());
        }
    }
}