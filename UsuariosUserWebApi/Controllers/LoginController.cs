using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.NombreUsuario) || string.IsNullOrWhiteSpace(request.Contraseña))
            {
                return BadRequest("Nombre de usuario y contraseña son obligatorios.");
            }

            var usuario = UsuarioBussiness.IsValidUser(request.NombreUsuario, request.Contraseña);

            if (usuario != null)
            {
                return Ok($"Inicio de sesión exitoso. Bienvenido, {usuario.Nombre} {usuario.Apellido}.");
            }
            else
            {
                return Unauthorized("Nombre de usuario o contraseña incorrectos");
            }
        }
    }
}