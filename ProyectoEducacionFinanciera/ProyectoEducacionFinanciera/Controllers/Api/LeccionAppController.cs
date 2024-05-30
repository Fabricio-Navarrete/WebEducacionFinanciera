﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoEducacionFinanciera.Data;
using ProyectoEducacionFinanciera.Data.Dto;

namespace ProyectoEducacionFinanciera.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeccionAppController : ControllerBase
    {
        private readonly DbProyectoContext _context;
        public LeccionAppController(DbProyectoContext context)
        {
            _context = context;
        }
        [HttpGet("ListTemas")]
        public async Task<IActionResult> ListTemas()
        {
            try
            {
                var lista = await _context.Temas.ToListAsync();
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
        [HttpGet("ListLecciones")]
        public async Task<IActionResult> ListLecciones(int idTema)
        {
            try
            {
                var lista = await _context.Lecciones.Where(t => t.IdTema == idTema).ToListAsync();
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
        [HttpGet("ListContenidoLecciones")]
        public async Task<IActionResult> ListContenidoLecciones(int idLeccion)
        {
            try
            {
                var lista = await _context.Contenido_Lecciones.Where(t => t.IdLeccion == idLeccion).ToListAsync();
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
        [HttpGet("ListPreguntas")]
        public async Task<IActionResult> ListPreguntas(int idLeccion)
        {
            try
            {
                var lista = await _context.Preguntas.Where(t => t.IdLeccion == idLeccion).ToListAsync();
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
        [HttpGet("ListRespuestas")]
        public async Task<IActionResult> ListRespuestas(int idPregunta)
        {
            try
            {
                var lista = await _context.Respuestas.Where(t => t.IdPregunta == idPregunta).ToListAsync();
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
        [HttpPost("ActualizarProgreso")]
        public async Task<IActionResult> ActualizarProgreso(Lecciones model)
        {
            try
            {
                var leccion = await _context.Lecciones.FirstOrDefaultAsync(t => t.IdLeccion == model.IdLeccion);
                if (leccion == null)
                {
                    return NotFound();
                }
                leccion.Progreso = model.Progreso;
                var estudiante = await _context.Estudiantes.FirstOrDefaultAsync(t => t.IdEstudiante == model.IdEstudiante);
                if (estudiante != null)
                {
                    estudiante.Puntaje = (leccion.Progreso == 1.0m) ? estudiante.Puntaje+=0.5m : estudiante.Puntaje+=0;
                    if(estudiante.Puntaje == 1.0m)
                    {
                        estudiante.Nivel = estudiante.Nivel += 1;
                        estudiante.Puntaje = 0;
                    }
                    _context.Update(estudiante);
                }
                _context.Update(leccion);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetNivelEstudiante")]
        public async Task<IActionResult> GetNivelEstudiante(int idEstudiante)
        {
            try
            {
                var estudiante = await _context.Estudiantes.FirstOrDefaultAsync(t => t.IdEstudiante == idEstudiante);
                if (estudiante == null)
                {
                    return NotFound();
                }
                var objeto = new GetNivelEstudiante
                {
                    IdEstudiante = estudiante.IdEstudiante,
                    Nivel = estudiante.Nivel.Value
                };
                return Ok(objeto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
