using Ejercicio.EFU.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.EF.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customers> GetAll()
        {
            return _northwindContext.Customers.ToList();
        }


        public Customers GetOne(int id)
        {
            try
            {
                return _northwindContext.Customers.First(c => c.CustomerID.Equals(id));
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
        }

        public Customers Add(Customers newCustomer)
        {
            _northwindContext.Customers.Add(newCustomer);
            _northwindContext.SaveChanges();
            return newCustomer;
        }

       

       
    }
}
