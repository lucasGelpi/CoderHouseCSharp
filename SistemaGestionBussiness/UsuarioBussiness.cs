using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        public static List<Usuario> GetUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }

        public static void AltaUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            UsuarioData.ModificarUsuario(usuario);
        }

        public static void EliminarUsuario(int  Id)
        {
            UsuarioData.EliminarUsuario(Id);
        }

        public static Usuario IsValidUser(string nombreUsuario, string contraseña)
        {
            return UsuarioData.IsValidUser(nombreUsuario, contraseña);
        }
    }
}