using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.Capas.Data;
using Lab.Demo.Capas.Entity;
namespace Lab.Demo.Capa.Logic
{
    public class ProductLogic
    {

        public IEnumerable<Products> GetProducts()
        {
            NorthwindDB dt = new NorthwindDB();
            return dt.Products.ToList();
        }
        public Products Detalles(int id)
        {
            NorthwindDB dt = new NorthwindDB();
            return dt.Products.Single(r => r.ProductID == id);

        }
        public Object DarOrdenes(int id)
        {
            NorthwindDB dt = new NorthwindDB();
            var ordenes = dt.Order_Details.Where(r => r.ProductID == id);
            return ordenes.ToList();
        }

        public IEnumerable<Products> ProductSearch(string search)
        {
            NorthwindDB db = new NorthwindDB();
            var SearchList = db.Products.Where(x => x.ProductName.Contains(search) || search == null).ToList();
            return SearchList;
        }

        public void AgregarProducto(ProductViewModel model)
        {
            NorthwindDB db = new NorthwindDB();

            db.Products.Add(new Products()
            {
                ProductName=model.Producto.ProductName,
                QuantityPerUnit=model.Producto.QuantityPerUnit,
                UnitPrice=model.Producto.UnitPrice,
                UnitsInStock=model.Producto.UnitsInStock
            });

            db.SaveChanges();
        }
    }
}
