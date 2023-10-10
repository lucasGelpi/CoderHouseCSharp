using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class ProductoBussiness
    {
        public static List<Producto> GetProductos()
        {
            return ProductoData.ListarProductos();
        }
    }
}