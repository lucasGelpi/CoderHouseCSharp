using Microsoft.Data.SqlClient;
using SistemaGestionData;
using SistemaGestionEntities;
using System.Data;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        public static List<Venta> GetVentas()
        {
            return VentaData.ListarVentas();
        }

        public static void CargarVenta(long idUsuario, List<ProductoVendido> listProductosVendidos)
        {
            VentaData.CargarVenta(idUsuario, listProductosVendidos);
        }

        public static void AltaVenta(int ventaId, string nuevoComentario)
        {
            VentaData.AltaVenta(ventaId, nuevoComentario);
        }

        public static void EliminarVenta(int Id)
        {
            VentaData.EliminarVenta(Id);
        }
    }
}