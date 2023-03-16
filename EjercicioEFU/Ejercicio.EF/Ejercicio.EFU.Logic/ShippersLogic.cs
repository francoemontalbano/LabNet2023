using Ejercicio.EFU.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio.EF.Logic
{
    public class ShippersLogic : BaseLogic
    {
        public List<Shippers> GetAll()
        {
            return _northwindContext.Shippers.ToList();
        }

        public Shippers GetOne(int id)
        {
            try
            {
                return _northwindContext.Shippers.First(s => s.ShipperID.Equals(id));
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("No se encontró ningún Shipper con el ID proporcionado", ex);
            }
        }

        public Shippers Add(Shippers newShipper)
        {
            _northwindContext.Shippers.Add(newShipper);
            _northwindContext.SaveChanges();
            return newShipper;
        }

        public Shippers Update(Shippers newShipper, int id)
        {
            Shippers shipperAModificar = GetOne(id);
            shipperAModificar.CompanyName = newShipper.CompanyName;
            shipperAModificar.Phone = newShipper.Phone;
            _northwindContext.SaveChanges();
            return shipperAModificar;
        }

        public void Delete(int id)
        {
            Shippers shipperAEliminar = GetOne(id);
            _northwindContext.Shippers.Remove(shipperAEliminar);
            _northwindContext.SaveChanges();
        }
    }
}