using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KallSonys_B2C_v1._1.Controllers
{


    public class LogicaController : Controller
    {
        // GET: Logica
        public ActionResult Index()
        {
            return View();
        }

        // GET: Logica/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Logica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Logica/Create
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

        // GET: Logica/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Logica/Edit/5
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

        // GET: Logica/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Logica/Delete/5
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
