using ApiJuanRuiz.Entities;
using ApiJuanRuiz.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJuanRuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscripcionController : ControllerBase
    {
        private readonly InscripcionService _inscripcionServicio;
        public InscripcionController(InscripcionService inscripcionServicio)
        {
            _inscripcionServicio = inscripcionServicio;
        }



       
        [HttpGet]
        
        public IActionResult Ver()
        {
          return Ok(_inscripcionServicio.VerListado());
            
        }

        
        [HttpGet("{Id}")]
        
        public IActionResult PorID(int Id)
        {
            return Ok(_inscripcionServicio.ObtenerPorID(Id));
        }


        
        [HttpPost]
        
        public IActionResult Agregar([FromBody] Inscripcion Agregar)
        {
            if (_inscripcionServicio.Agregar(Agregar))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }





        
        [HttpPut("{Id}")]
        
        public IActionResult Editar([FromBody] Inscripcion Editar)
        {
            if (_inscripcionServicio.Editar(Editar))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpDelete("{Id}")]
      
        public IActionResult Eliminar(int Id)
        {
            if (_inscripcionServicio.Eliminar(Id))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }


    }
}
