using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoEducacionFinanciera.Data;

namespace ProyectoEducacionFinanciera.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosAppController : ControllerBase
    {
        private readonly DbProyectoContext _context;
        public UsuariosAppController(DbProyectoContext context)
        {
            _context = context;
        }
        [HttpGet("ValidarAcceso")]
        public async Task<IActionResult> ValidarAcceso(string user, string pwd)
        {
            try
            {
                var lista = await _context.Estudiantes.Where(t => t.Usuario == user && t.Contraseña == pwd).FirstOrDefaultAsync();
                if (lista == null)
                {
                    return NotFound();
                }
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("ObtenerEstudiante")]
        public async Task<IActionResult> ObtenerEstudiante(int id)
        {
            var lista = await _context.Estudiantes.Where(t => t.IdEstudiante == id).FirstOrDefaultAsync();
            if (lista == null)
            {
                return NotFound();
            }
            return Ok(lista);
        }
        [HttpPost("RegistrarEstudiante")]
        public async Task<IActionResult> RegistrarEstudiante(Estudiante estudiante)
        {
            try
            {
                estudiante.Puntaje = 0;
                estudiante.Nivel = 0;
                _context.Estudiantes.Add(estudiante);
                await _context.SaveChangesAsync();
                return Ok(estudiante);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
