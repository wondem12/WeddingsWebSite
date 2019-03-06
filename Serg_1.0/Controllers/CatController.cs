using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Serg_1._0.Controllers
{
    public class CatController : Controller
    {
        Serg_DBEntities serg = new Serg_DBEntities();
        public ActionResult Index()
        {
            return View(serg.Categories.ToList());
        }
    }
}