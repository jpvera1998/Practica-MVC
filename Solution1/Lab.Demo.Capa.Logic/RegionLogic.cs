using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.Capas.Data;
using Lab.Demo.Capas.Entity;

namespace Lab.Demo.Capa.Logic
{
    public class RegionLogic
    {

        private readonly NorthwindDB context;

        public RegionLogic()
        {
            this.context = new NorthwindDB();
        }

        public IEnumerable<Region> GetAll()
        {
            return this.context.Region.ToList();
        }

        public Region GetById(Int32 id)
        {
            return this.context.Region.Single(r => r.RegionID == id);
            //return this.context.Regions.Where(r => r.RegionID == id).Single();
            //return this.context.Regions.Find(id);
            //return this.context.Regions.First(r => r.RegionID == id);
        }

        public void TeElimino(Int32 id)
        {
            NorthwindDB dt = new NorthwindDB();

            Region region = dt.Region.Where(x => x.RegionID == id).FirstOrDefault();

            dt.Region.Remove(region);

            dt.SaveChanges();

        }
    }
}
