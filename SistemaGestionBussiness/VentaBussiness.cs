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
    }
}