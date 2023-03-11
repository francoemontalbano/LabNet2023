using EjercicioEF.Data;
using EjercicioEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    public class ProductLogic
    {
        private NorthwindContext _northwindContext; 

        public ProductLogic()
        {
            _northwindContext = new NorthwindContext();
        }

        public List<Products> GetAll()
        {
            return _northwindContext.Products.ToList();
        }
    }
}
