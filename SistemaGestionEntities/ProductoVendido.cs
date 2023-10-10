namespace SistemaGestionEntities
{
    // Clase ProductoVendido
    public class ProductoVendido
    {
        // Propiedades privadas
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int CantidadVendida { get; set; }
        public int IdVenta { get; set; }
    }
}