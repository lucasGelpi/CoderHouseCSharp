using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SistemaGestionData
{
    public static class VentaData
    {
        public static List<Venta> ListarVentas()
        {
            List<Venta> lista = new List<Venta>();
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True";
            string query = "SELECT Id, Comentarios, IdUsuario FROM Venta;";
            try
            {
                    using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var venta = new Venta();
                                    venta.Id = Convert.ToInt32(dr["id"]);
                                    venta.Comentarios = dr["Comentarios"].ToString();
                                    venta.IdUsuario = dr["IdUsuario"].ToString();
                                    lista.Add(venta);
                                }
                            }
                        }
                    }
                    conexion.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void CargarVenta(long idUsuario, List<ProductoVendido> listProductosVendidos)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                SqlTransaction transaction = conexion.BeginTransaction();

                try
                {
                    // Insertar la nueva venta
                    string ventaQuery = "INSERT INTO Venta (Comentarios, IdUsuario) VALUES (@Comentarios, @IdUsuario); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand ventaComando = new SqlCommand(ventaQuery, conexion, transaction))
                    {
                        ventaComando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = "Comentarios de la venta" });
                        ventaComando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = idUsuario });

                        long ventaId = Convert.ToInt64(ventaComando.ExecuteScalar());

                        // Insertar los productos vendidos
                        foreach (var productoVendido in listProductosVendidos)
                        {
                            string productoQuery = "INSERT INTO ProductosVendidos (IdVenta, IdProducto, Cantidad) VALUES (@IdVenta, @IdProducto, @Cantidad)";
                            using (SqlCommand productoComando = new SqlCommand(productoQuery, conexion, transaction))
                            {
                                productoComando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = ventaId });
                                productoComando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                                productoComando.Parameters.Add(new SqlParameter("Cantidad", SqlDbType.Int) { Value = productoVendido.CantidadVendida });

                                productoComando.ExecuteNonQuery();

                                // Actualizar el stock del producto
                                string updateStockQuery = "UPDATE Producto SET Stock = Stock - @Cantidad WHERE Id = @IdProducto";
                                using (SqlCommand updateStockComando = new SqlCommand(updateStockQuery, conexion, transaction))
                                {
                                    updateStockComando.Parameters.Add(new SqlParameter("Cantidad", SqlDbType.Int) { Value = productoVendido.CantidadVendida });
                                    updateStockComando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });

                                    updateStockComando.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public static void AltaVenta(int ventaId, string nuevoComentario)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True";
            string query = "UPDATE Venta SET Comentarios = @NuevoComentario WHERE Id = @VentaId;";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("VentaId", SqlDbType.Int) { Value = ventaId });
                        comando.Parameters.Add(new SqlParameter("NuevoComentario", SqlDbType.VarChar) { Value = nuevoComentario });
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void EliminarVenta(int Id)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True";
            string query = "DELETE FROM Venta " + "WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Id });
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #region Usuario
        #endregion

        #region Venta
        #endregion

        #region ProductoVendido
        #endregion
    }
}