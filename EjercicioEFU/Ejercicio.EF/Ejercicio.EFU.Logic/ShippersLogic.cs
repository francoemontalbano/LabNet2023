using Ejercicio.EFU.Entities;
using Ejercicio.EFU.Logic;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio.EF.Logic
{
    public class ShippersLogic : BaseLogic, ILogic<Shippers>
    {
        public List<Shippers> GetAll()
        {
            return _northwindContext.Shippers.ToList();
        }

        public Shippers GetOne(int id)
        {
            var shippers = _northwindContext.Shippers.FirstOrDefault(s => s.ShipperID == id);
            if (shippers == null)
            {
                return null;
            }
            return shippers;
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

        public bool GetOrdersByShiperId(int shipperId)
        {
            return _northwindContext.Orders.Any(o => o.ShipVia == shipperId);
        }


    }
}