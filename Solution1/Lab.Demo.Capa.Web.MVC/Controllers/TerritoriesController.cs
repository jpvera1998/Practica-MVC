using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab.Demo.Capa.Logic;
using Lab.Demo.Capas.Entity;
using Lab.Demo.Capas.Data;
namespace Lab.Demo.Capa.Web.MVC.Controllers
{
    public class TerritoriesController : Controller
    {
        private readonly TerritoriesLogic territoriesLogic;

        public TerritoriesController()
        {
            this.territoriesLogic = new TerritoriesLogic();
        }

        public ActionResult Index()
        {
            return View(this.territoriesLogic.DarLaLista());
        }
        [HttpPost]
        public ActionResult Check(List<TerritorieVM> lista)
        {
           
            
            List<TerritorieVM> chekeados = this.territoriesLogic.GetChecked(lista);
                return View(chekeados);
           
        }
    


        //public ActionResult Index()
        //{
        //    var lista = this.territoriesLogic.Territory();

        //    List<TerritorieVM> ListOfVM = new List<TerritorieVM>();

        //    foreach(var item in lista)
        //    {
        //        ListOfVM.Add(new TerritorieVM() {
        //            TerritoryDescription = item.TerritoryDescription,
        //            IsSelected = false
                    
        //        });
        //    }

        //    return View(ListOfVM);
        //}
        
        //[HttpPost]
        //public ActionResult SelectedItem(List<TerritorieVM> viewModel)
        //{
            
        //    return View(viewModel);

        //}

        //public ActionResult SelectedList(List<Territories> lista)
        //{
        //    return View(lista);
        //}
       
    }
}