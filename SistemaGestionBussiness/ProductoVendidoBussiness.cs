using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class ProductoVendidoBussiness
    {
        public static List<ProductoVendido> GetProductoVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }
    }
}