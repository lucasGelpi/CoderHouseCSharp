namespace SistemaGestionEntities
{
    // Clase Usuario
    public class Usuario
    {
        // Propiedades privadas
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }
    }
}