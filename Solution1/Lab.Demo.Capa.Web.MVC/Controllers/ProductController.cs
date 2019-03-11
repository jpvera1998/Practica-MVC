using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab.Demo.Capa.Logic;
using Lab.Demo.Capas.Entity;

namespace Lab.Demo.Capa.Web.MVC.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index(string search)
        {
            ProductLogic logic = new ProductLogic();
            return View(logic.ProductSearch(search));
        }

        public ActionResult Detalles(int id)
        {
            ProductLogic logic = new ProductLogic();
            return View(logic.Detalles(id));
        }

        public ActionResult Ordenes(int id)
        {
            ProductLogic logic = new ProductLogic();
            return View(logic.DarOrdenes(id));
        }

        public ActionResult AddView()
        {
            return View();
        }

        public ActionResult AddProduct(ProductViewModel model)
        {
            ProductLogic logic = new ProductLogic();
            logic.AgregarProducto(model);

            return RedirectToAction("Index");
        }
    }
}