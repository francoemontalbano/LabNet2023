using Ejercicio.EF.Logic;
using Ejercicio.EFU.Data;
using Ejercicio.EFU.Entities;
using Ejercicio.EFU.WA.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ejercicio.EFU.WA.Controllers
{
    public class ShippersController : ApiController
    {

        private readonly NorthwindContext _northwindContext;


        private ShippersLogic shippersLogic = new ShippersLogic();

        public ShippersController()
        {
            _northwindContext = new NorthwindContext();
        }

        public IEnumerable<Shippers> GetAll()
        {
            return shippersLogic.GetAll();
        }

        [HttpGet]
        [Route("api/shippers/{id}")]
        public IHttpActionResult Get(string id)
        {
            int shipperId;
            if (!int.TryParse(id, out shipperId))
            {
                return BadRequest("El identificador del transportista debe ser un número entero. Inténtelo nuevamente.");
            }

            if (shipperId <= 0)
            {
                return BadRequest("El valor de id debe ser mayor que cero. Inténtelo nuevamente");
            }

            Shippers shipper = shippersLogic.GetOne(shipperId);
            if (shipper == null)
            {
                return BadRequest("El id que ingresaste no existe. Inténtelo nuevamente");
            }

            return Ok(shipper);
        }

        [HttpPost]
        [Route("api/shippers/add")]
        public IHttpActionResult Add(ShippersViewModel newShipper)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Shippers shipper = new Shippers
            {
                CompanyName = newShipper.CompanyName,
                Phone = newShipper.Phone
            };

            shippersLogic.Add(shipper);

            return Ok(shipper);
        }

        [HttpPut]
        [Route("api/shippers/update/{id}")]
        public IHttpActionResult Update(int id, ShippersViewModel newShipper)
        {
            Shippers shipperAModificar = shippersLogic.GetOne(id);
            if (shipperAModificar == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            shipperAModificar.CompanyName = newShipper.CompanyName;
            shipperAModificar.Phone = newShipper.Phone;

            shippersLogic.Update(shipperAModificar, id);

            return Ok(shipperAModificar);
        }

        [HttpDelete]
        [Route("api/shippers/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            Shippers shipperAEliminar = shippersLogic.GetOne(id);
            if (shipperAEliminar == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"No se encontró el shipper con el ID {id}");
            }

            shippersLogic.Delete(id);

            return Request.CreateResponse(HttpStatusCode.OK, new { message = "El shipper se eliminó correctamente" });
        }
    }
}