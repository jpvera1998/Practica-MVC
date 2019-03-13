using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.Capas.Data;
using Lab.Demo.Capas.Entity;
namespace Lab.Demo.Capa.Logic
{
    public class TerritoriesLogic
    {
        private readonly NorthwindDB context;

        public TerritoriesLogic()
        {
            this.context = new NorthwindDB();

        }
        
        public List<TerritorieVM> DarLaLista()
        {
            var listaVM = new List<TerritorieVM>();

            var lista = this.context.Territories.ToList();

            for(int i=0; i < lista.Count(); i++)
            {
                listaVM.Add(new TerritorieVM() {
                    TerritoryDescription = lista[i].TerritoryDescription
                    
                   
                });
            }

            return listaVM;
        }

       

    }
}
