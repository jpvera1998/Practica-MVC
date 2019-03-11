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
        

        public IEnumerable<Territories> Territory()
        {

            return this.context.Territories.ToList();
        }

        public ICollection<TerritorieVM> ListOFTheSelectedItems { get; set; }

        public void AddtoTheList(List<TerritorieVM> newTerritorie)
        {
            foreach(var item in newTerritorie)
            {
                ListOFTheSelectedItems.Add(new TerritorieVM() {
                    TerritoryDescription=item.TerritoryDescription
                });
            }
        }

        public List<TerritorieVM> DarLaLista()
        {
            var listaVM = new List<TerritorieVM>();

            var lista = this.context.Territories.ToList();

            for(int i=0; i < lista.Count(); i++)
            {
                listaVM.Add(new TerritorieVM() {
                    TerritoryDescription = lista[i].TerritoryDescription,
                    IsSelected = false
                });
            }

            return listaVM;
        }


        public List<TerritorieVM> GetChecked(List<TerritorieVM> lista)
        {
            List<Territories> territories = this.context.Territories.ToList();
            for (int i = 0; i < lista.Count(); i++)
            {
                lista[i].TerritoryDescription = territories[i].TerritoryDescription;
            }


            List<TerritorieVM> nueva = new List<TerritorieVM>();

            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].IsSelected == true)
                {
                    TerritorieVM nuevoTer = new TerritorieVM()
                    {
                        TerritoryDescription = lista[i].TerritoryDescription,
                        IsSelected = true
                    };
                    nueva.Add(nuevoTer);
                }
            }
            return nueva;
        }

    }
}
