using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KW.CatalogosMicroservicio.Repositorios.Contratos;
using Microsoft.AspNetCore.Mvc;

namespace KW.CatalogosMicroservicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly IPersonaRepository personaRepository;

        public PersonasController(IPersonaRepository persona)
        {
            this.personaRepository = persona;
        }

        [HttpGet]
        public async Task<IActionResult> GetPersonas()
        {
            return Ok(new { data = await personaRepository.GetPersonas() });
        }
    }
}
