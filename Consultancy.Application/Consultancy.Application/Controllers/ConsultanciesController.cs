using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Consultancy.Application.Controllers
{
    public class ConsultanciesController : Controller
    {
        // GET: Consultancies
        public ActionResult Index()
        {
            return View();
        }

        // GET: Consultancies/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Consultancies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consultancies/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consultancies/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Consultancies/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Consultancies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Consultancies/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
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
