using Ejercicio.EF.Logic;
using Ejercicio.EFU.Entities;
using Ejercicio.EFU.MVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Ejercicio.EFU.MVC.Controllers
{
    public class ShippersController : Controller
    {
        public ActionResult Index()
        {
            var shippersLogic = new ShippersLogic();
            var shippers = shippersLogic.GetAll();

            List<ShippersViewModel> shippersViews = (from shipper in shippers
                                                     select new ShippersViewModel()
                                                     {
                                                         Id = shipper.ShipperID,
                                                         CompanyName = shipper.CompanyName,
                                                         Phone = shipper.Phone
                                                     }).ToList();
            return View(shippersViews);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(ShippersViewModel shipper)
        {
            if (ModelState.IsValid)
            {
                var shippersLogic = new ShippersLogic();
                var shipperEntity = new Shippers() { CompanyName = shipper.CompanyName, Phone = shipper.Phone };
                shippersLogic.Add(shipperEntity);
                return RedirectToAction("Index");
            }
            return View(shipper);
        }

        public ActionResult Eliminar(int id)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            bool shipperTieneOrdenes = shippersLogic.GetOrdersByShiperId(id);

            if (shipperTieneOrdenes)
            {
                TempData["ErrorMessage"] = "No se puede eliminar este transportista porque tiene órdenes relacionadas.";
                return RedirectToAction("Index");
            }

            shippersLogic.Delete(id);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            ShippersViewModel model = new ShippersViewModel();

            var entity = shippersLogic.GetOne(id);
            model.Id = entity.ShipperID;
            model.CompanyName = entity.CompanyName;
            model.Phone = entity.Phone;

            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(ShippersViewModel shipper, int id)
        {
            if (ModelState.IsValid)
            {
                ShippersLogic shippersLogic = new ShippersLogic();
                var shipperAModificar = new Shippers() { ShipperID = shipper.Id, CompanyName = shipper.CompanyName, Phone = shipper.Phone };
                shippersLogic.Update(shipperAModificar, id);
                return RedirectToAction("Index");
            }

            return View(shipper);
        }
    }
}