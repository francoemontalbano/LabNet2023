using Ejercicio.LQ.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio.LQ.Logic
{
    public class ProductLogic : BaseLogic
    {
        public List<Products> GetProductSinStock()
        {
            var productoSinStock = (from p in _northwindContext.Products
                                    where p.UnitsInStock == 0
                                    select p).ToList();
            return productoSinStock;
        }

        public List<Products> GetProductConStockMayorA3()
        {
            var productoConStockMayorA3 = (from p in _northwindContext.Products
                                           where p.UnitsInStock > 0 && p.UnitPrice > 3
                                           select p).ToList();
            return productoConStockMayorA3;
        }

        public Products GetProductConID789()
        {
            var productoConId789 = (from p in _northwindContext.Products
                                    where p.ProductID == 789
                                    select p).FirstOrDefault();
            return productoConId789;
        }

        public List<Products> GetProductPorNombre()
        {
            var productoPorNombre = _northwindContext.Products
                                                .OrderBy(p => p.ProductName)
                                                .ToList();

            return productoPorNombre;
        }

        public List<Products> GetProductPorStockMayor()
        {
            var productoPorStockMayor = _northwindContext.Products
                                               .OrderByDescending(p => p.UnitsInStock)
                                               .ToList();

            return productoPorStockMayor;
        }

        public Products GetProductPrimerElemento()
        {
            var productoPrimerElemento = _northwindContext.Products
                                         .FirstOrDefault();

            return productoPrimerElemento;
        }
    }
}