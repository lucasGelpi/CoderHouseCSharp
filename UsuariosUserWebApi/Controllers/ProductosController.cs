using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        [HttpGet(Name = "GetProductos")]
        public IEnumerable<Producto> Get()
        {
            return ProductoBussiness.GetProductos().ToArray();
        }

        [HttpDelete(Name = "EliminarProductos")]
        public void Delete([FromBody] int Id)
        {
            ProductoBussiness.EliminarProducto(Id);
        }

        [HttpPut(Name = "ModificarProductos")]
        public void Put([FromBody] Producto producto)
        {
            ProductoBussiness.ModificarProducto(producto);
        }

        [HttpPost(Name = "AltaProducto")]
        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.AltaProducto(producto);
        }
    }
}