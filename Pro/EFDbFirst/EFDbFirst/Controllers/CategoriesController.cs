using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirst.Models;

namespace EFDbFirst.Controllers
{
    public class CategoriesController : Controller
    {
        NorthwindDbEntities db = new NorthwindDbEntities();
        public ActionResult Index()
        {
            return View(db.tblCategories.ToList());

        }
    }
}