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

        public static void AltaProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }

        public static void ModificarProducto(Producto producto)
        {
            ProductoData.ModificarProducto(producto);
        }

        public static void EliminarProducto(Producto producto)
        {
            ProductoData.EliminarProducto(producto);
        }
    }
}