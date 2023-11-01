namespace SistemaGestionEntities
{
    public class ProductoVendido
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int CantidadVendida { get; set; }
        public int IdVenta { get; set; }
    }
}