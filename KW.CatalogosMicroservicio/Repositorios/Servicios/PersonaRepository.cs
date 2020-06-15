using KW.CatalogosMicroservicio.Contexto;
using KW.CatalogosMicroservicio.Modelos;
using KW.CatalogosMicroservicio.Repositorios.Contratos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KW.CatalogosMicroservicio.Repositorios.Servicios
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly CatalogosDbContext _catalogosDbContext;

        public PersonaRepository(CatalogosDbContext catalogosDbContext)
        {
            _catalogosDbContext = catalogosDbContext;
        }

        public async Task<List<Persona>> GetPersonas()
        {
            try
            {
                return await _catalogosDbContext.Personas.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}
