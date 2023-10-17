using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        public static List<Venta> GetVentas()
        {
            return VentaData.ListarVentas();
        }

        public static void AltaVenta(Venta venta)
        {
            VentaData.CrearVenta(venta);
        }

        public static void ModificarVenta(Venta venta)
        {
            VentaData.ModificarVenta(venta);
        }

        public static void EliminarVenta(Venta venta)
        {
            VentaData.EliminarVenta(venta);
        }
    }
}