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

        public Customers Update(Customers newCustomer, int id)
        {
            Customers customerAModificar = GetOne(id);
            customerAModificar.CompanyName = newCustomer.CompanyName;
            customerAModificar.ContactName = newCustomer.ContactName;
            customerAModificar.Address = newCustomer.Address;
            customerAModificar.City = newCustomer.City;
            customerAModificar.Country = newCustomer.Country;

        }

        public void Delete(int, id)
        {
            Customers customerAEliminar = GetOne(id);
            _northwindContext.Customers.Remove(customerAEliminar);
            _northwindContext.SaveChanges();
        }
    }
}
