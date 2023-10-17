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

        public static void AltaProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.CrearProductoVendido(productoVendido);
        }

        public static void ModificarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(productoVendido);
        }

        public static void EliminarProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.EliminarProductoVendido(productoVendido);
        }
    }
}