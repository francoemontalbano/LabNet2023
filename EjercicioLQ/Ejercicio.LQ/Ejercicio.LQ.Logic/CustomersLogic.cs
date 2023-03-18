using Ejercicio.LQ.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Ejercicio.LQ.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public Customers GetCustomers()
        {
            var customerObjeto = (from c in _northwindContext.Customers
                                  where c.CustomerID == "ALFKI"
                                  select c).FirstOrDefault();
            return customerObjeto;
        }

        public List<Customers> GetCustomersRegionWA()
        {
            var customersEnRegionWA = (from c in _northwindContext.Customers
                                       where c.Region == "WA"
                                       select c).ToList();
            return customersEnRegionWA;
        }

        public List<string> GetCustomersMYM()
        {
            var customerNombres = _northwindContext.Customers
                                    .Select(c => c.CompanyName)
                                    .ToList();

            var nombresEnMayuscula = customerNombres.Select(n => n.ToUpper()).ToList();
            var nombresEnMinuscula = customerNombres.Select(n => n.ToLower()).ToList();

            var result = nombresEnMayuscula.Concat(nombresEnMinuscula).ToList();

            return result;
        }

        public List<DTOCustomer> GetCustomersYOrders()
        {
            var query = from c in _northwindContext.Customers
                        join o in _northwindContext.Orders
                        on c.CustomerID equals o.CustomerID
                        where c.Region == "WA" && o.OrderDate > new DateTime(1997, 1, 1)
                        select new DTOCustomer
                        {
                            CustomerID = c.CustomerID,
                            CompanyName = c.CompanyName,
                            ContactName = c.ContactName,
                            OrderDate = o.OrderDate,
                            OrderID = o.OrderID
                        };

            return query.ToList();
        }

        public List<Customers> GetCustomersThree()
        {
            var customersThree = _northwindContext.Customers
                                    .Where(c => c.Region == "WA")
                                    .Take(3)
                                    .ToList();

            return customersThree;
        }

        public List<DTOCustomer> GetCustomersOrdenesAsociadas()
        {
            var customers = _northwindContext.Customers
                .Select(c => new DTOCustomer
                {
                    ContactName = c.ContactName,
                    OrderCount = c.Orders.Count()
                }).ToList();

            return customers;
        }
    }
}