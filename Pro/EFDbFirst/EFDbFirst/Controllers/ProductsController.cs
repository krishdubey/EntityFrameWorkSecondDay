using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirst.Models;
namespace EFDbFirst.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindDbEntities db = new NorthwindDbEntities();
        public ActionResult Index( int id)
        {
           List<tblProduct> products =  db.tblProducts.Where(x => x.Category_CategoryId == id).ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            return View(db.tblProducts.Single(x => x.ProductId == id));
        }
    }
}