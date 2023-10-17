using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductosVendidos")]
        public IEnumerable<ProductoVendido> Get()
        {
            return ProductoVendidoBussiness.GetProductoVendidos().ToArray();
        }

        [HttpDelete(Name = "EliminarProductosVendidos")]
        public void Delete([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.EliminarProductoVendido(productoVendido);
        }

        [HttpPut(Name = "ModificarProductosVendidos")]
        public void Put([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.ModificarProductoVendido(productoVendido);
        }

        [HttpPost(Name = "AltaProductoVendido")]
        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.AltaProductoVendido(productoVendido);
        }
    }
}