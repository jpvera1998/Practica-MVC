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

        //[HttpPost]
        //public string Index(IEnumerable<TerritorieVM> lista)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("Your selected -");


        //    //foreach (var item in lista)
        //    //{
        //    //    if (item.IsSelected == true)
        //    //    {
        //    //        sb.Append(item.TerritoryDescription + ",");


        //    //    }

        //    //}

        //    //return sb.ToString();



        //    if (lista.Where(x=>x.IsSelected==true).Count()==0)
        //    {
        //        return "No seleccionaste nada vieja";
        //    }
        //    else
        //    {



        //        foreach (TerritorieVM territorie in lista)
        //        {
        //            if (territorie.IsSelected)
        //            {
        //                sb.Append(territorie.TerritoryDescription + ",");
        //            }
        //        }
        //        return sb.ToString();
        //    }
        //}

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