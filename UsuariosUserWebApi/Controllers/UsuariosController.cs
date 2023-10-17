using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet(Name = "GetUsuarios")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBussiness.GetUsuarios().ToArray();
        }

        [HttpDelete(Name = "EliminarUsuarios")]
        public void Delete([FromBody] Usuario usuario)
        {
            UsuarioBussiness.EliminarUsuario(usuario);
        }

        [HttpPut(Name = "ModificarUsuarios")]
        public void Put([FromBody] Usuario usuario)
        {
            UsuarioBussiness.ModificarUsuario(usuario);
        }

        [HttpPost(Name = "AltaUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBussiness.AltaUsuario(usuario);
        }
    }
}