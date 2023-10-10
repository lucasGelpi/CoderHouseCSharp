namespace SistemaGestionEntities
{
    // Clase Producto
    public class Producto
    {
        // Propiedades privadas
        public int Id { get; set; }
        public string Descripciones { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
    }
}