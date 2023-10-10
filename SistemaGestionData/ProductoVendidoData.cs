using Microsoft.Data.SqlClient;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public static class ProductoVendidoData
    {
        public static List<ProductoVendido> ObtenerProductoVendido(int IdProductoVendido)
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "SELECT Id, IdProducto, CantidadVendida, IdVenta FROM ProductoVendido Where Id=@IdProductoVendido;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdProductoVendido";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdProductoVendido;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var productoVendido = new ProductoVendido();
                                productoVendido.Id = Convert.ToInt32(dr["id"]);
                                productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                productoVendido.CantidadVendida = Convert.ToInt32(dr["CantidadVendida"]);
                                productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                lista.Add(productoVendido);
                            }
                        }
                    }
                }
            }

            return lista;
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "SELECT Id, IdProducto, CantidadVendida, IdVenta FROM ProductoVendido;";

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
                                var productoVendido = new ProductoVendido();
                                productoVendido.Id = Convert.ToInt32(dr["id"]);
                                productoVendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                productoVendido.CantidadVendida = Convert.ToInt32(dr["CantidadVendida"]);
                                productoVendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                                lista.Add(productoVendido);
                            }
                        }
                    }
                }
            }

            return lista;
        }

        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "INSERT INTO ProductoVendido (IdProducto, CantidadVendida, IdVenta)" +
                "VALUES (@IdProducto, @CantidadVendida, @IdVenta)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                    comando.Parameters.Add(new SqlParameter("CantidadVendida", SqlDbType.Int) { Value = productoVendido.CantidadVendida });
                    comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoVendido.IdVenta });
                }
                conexion.Close();
            }
        }

        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "UPDATE ProductoVendido" +
                        "SET IdProducto = @IdProducto" +
                        ", CantidadVendida = @CantidadVendida" +
                        ", IdVenta = @IdVenta" +
                        "WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productoVendido.IdProducto });
                    comando.Parameters.Add(new SqlParameter("CantidadVendida", SqlDbType.Int) { Value = productoVendido.CantidadVendida });
                    comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productoVendido.IdVenta });
                }
                conexion.Close();
            }
        }

        public static void EliminarProductoVendido(ProductoVendido productoVendido)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "DELETE FROM ProductoVendido WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productoVendido.Id });
                }
                conexion.Close();
            }
        }
    }
}