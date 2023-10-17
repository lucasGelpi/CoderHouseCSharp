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
        public static List<Venta> ObtenerVenta(int IdVenta)
        {
            List<Venta> lista = new List<Venta>();
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "SELECT Id, Comentarios, IdUsuario FROM Venta Where Id=@IdVenta;";
            try
            {

                    using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        var parametro = new SqlParameter();
                        parametro.ParameterName = "IdVenta";
                        parametro.SqlDbType = SqlDbType.Int;
                        parametro.Value = IdVenta;

                        comando.Parameters.Add(parametro);

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

                    // Opcional
                    conexion.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<Venta> ListarVentas()
        {
            List<Venta> lista = new List<Venta>();
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "SELECT Id, Comentarios, IdUsuario FROM Venta;";
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

                    // Opcional
                    conexion.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void CrearVenta(Venta venta)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True;";
            var query = "INSERT INTO Venta (Comentarios, IdUsuario)" +
                "VALUES (@Comentarios, @IdUsuario)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = venta.IdUsuario });
                }
                conexion.Close();
            }
        }

        public static void ModificarVenta(Venta venta)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True;";
            string query = "UPDATE Venta " +
                "SET Comentarios = @Comentarios , IdUsuario = @IdUsuario " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });
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

        public static void EliminarVenta(Venta venta)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SistemaGestion;Trusted_Connection=True";
            string query = "DELETE FROM Venta " +
                " WHERE Id = @Id";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = venta.Id });
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