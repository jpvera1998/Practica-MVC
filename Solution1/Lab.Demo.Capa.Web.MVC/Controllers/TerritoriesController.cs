using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab.Demo.Capa.Logic;
using Lab.Demo.Capas.Entity;
using Lab.Demo.Capas.Data;
using System.Text;
namespace Lab.Demo.Capa.Web.MVC.Controllers
{
    public class TerritoriesController : Controller
    {
        private readonly TerritoriesLogic territoriesLogic;

        public TerritoriesController()
        {
            this.territoriesLogic = new TerritoriesLogic();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(this.territoriesLogic.DarLaLista());
        }

        

        [HttpPost]
        public ActionResult Index(IEnumerable<TerritorieVM> lista)
        {

            List<TerritorieVM> SelectedList = new List<TerritorieVM>();
            
            if (lista.Where(x => x.IsSelected == true).Count() == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {

                foreach (var item in lista)
                {
                    if (item.IsSelected)
                    {
                        SelectedList.Add(item);
                    }
                }
                return View(SelectedList);
            }
        }

    }
}