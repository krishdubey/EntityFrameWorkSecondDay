using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCrub.Models;

namespace MvcCrub.Controllers
{
    public class CustemerController : Controller
    {
        // GET: Custemer
        public ActionResult Index()
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.Customers.ToList());
            }
        }

        // GET: Custemer/Details/5
        public ActionResult Details(int id)
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.Customers.Where(x => x.Id == id).FirstOrDefault());
            }
               
        }

        // GET: Custemer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Custemer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {

                using (DbModel dbModel = new DbModel())
                {
                    dbModel.Customers.Add(customer);
                    dbModel.SaveChanges();
                }
                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Custemer/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.Customers.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Custemer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                using (DbModel dbModel = new DbModel())
                {
                    dbModel.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                    dbModel.SaveChanges();
                }
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Custemer/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.Customers.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Custemer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModel dbModel = new DbModel())
                {
                    Customer customer = dbModel.Customers.Where(x => x.Id == id).FirstOrDefault();
                    dbModel.SaveChanges();
                }
                    // TODO: Add delete logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
