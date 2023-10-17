using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        [HttpGet(Name = "GetVentas")]
        public IEnumerable<Venta> Get()
        {
            return VentaBussiness.GetVentas().ToArray();
        }

        [HttpDelete(Name = "EliminarVentas")]
        public void Delete([FromBody] Venta venta)
        {
            VentaBussiness.EliminarVenta(venta);
        }

        [HttpPut(Name = "ModificarVentas")]
        public void Put([FromBody] Venta venta)
        {
            VentaBussiness.ModificarVenta(venta);
        }

        [HttpPost(Name = "AltaVenta")]
        public void Post([FromBody] Venta venta)
        {
            VentaBussiness.AltaVenta(venta);
        }
    }
}