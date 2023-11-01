using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System.Data;

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
        public void Delete([FromBody] int Id)
        {
            VentaBussiness.EliminarVenta(Id);
        }

        [HttpPost("CargarVenta", Name = "CargarVenta")]
        public IActionResult PostCargarVenta(long idUsuario, [FromBody] List<ProductoVendido> listProductosVendidos)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True";
            if (listProductosVendidos == null || listProductosVendidos.Count == 0)
            {
                return BadRequest("La lista de productos vendidos no puede estar vacía.");
            }

            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                var transaction = conexion.BeginTransaction();
                try
                {
                    foreach (var productoVendido in listProductosVendidos)
                    {
                        // Verificar si el producto con el ID proporcionado existe
                        string productoExistQuery = "SELECT COUNT(*) FROM Producto WHERE Id = @IdProducto";
                        using (var productoExistComando = new SqlCommand(productoExistQuery, conexion, transaction))
                        {
                            productoExistComando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                            int productCount = (int)productoExistComando.ExecuteScalar();

                            if (productCount == 0)
                            {
                                // El producto no existe, por lo tanto, devolvemos un mensaje de error
                                transaction.Rollback();
                                return BadRequest($"El producto con ID {productoVendido.IdProducto} no existe.");
                            }
                        }

                        // Verificar si hay suficiente stock para la cantidad vendida
                        string stockQuery = "SELECT Stock FROM Producto WHERE Id = @IdProducto";
                        using (var stockComando = new SqlCommand(stockQuery, conexion, transaction))
                        {
                            stockComando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                            int stock = (int)stockComando.ExecuteScalar();

                            if (stock < productoVendido.CantidadVendida)
                            {
                                // No hay suficiente stock, por lo tanto, devolvemos un mensaje de error
                                transaction.Rollback();
                                return BadRequest($"No hay suficiente stock para el producto con ID {productoVendido.IdProducto}.");
                            }
                        }

                        // Restar la cantidad vendida del stock
                        string updateStockQuery = "UPDATE Producto SET Stock = Stock - @Cantidad WHERE Id = @IdProducto";
                        using (var updateStockComando = new SqlCommand(updateStockQuery, conexion, transaction))
                        {
                            updateStockComando.Parameters.Add(new SqlParameter("Cantidad", SqlDbType.Int) { Value = productoVendido.CantidadVendida });
                            updateStockComando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });

                            updateStockComando.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }

            // Si todo sale bien, devolvemos un mensaje de éxito
            return Ok("Venta cargada exitosamente.");
        }

        [HttpPost("AltaVenta", Name = "AltaVenta")]
        public void PostAltaVenta(int ventaId, [FromBody] string nuevoComentario)
        {
            VentaBussiness.AltaVenta(ventaId, nuevoComentario);
        }
    }
}