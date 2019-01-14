using Lab.JJ2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.JJ2.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(Product model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}