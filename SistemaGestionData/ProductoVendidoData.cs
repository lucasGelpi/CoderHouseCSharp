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
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True";
            string query = "SELECT Id, IdProducto, CantidadVendida, IdVenta FROM ProductoVendido;";

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
    }
}