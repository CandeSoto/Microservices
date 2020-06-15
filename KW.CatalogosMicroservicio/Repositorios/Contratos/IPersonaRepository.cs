using KW.CatalogosMicroservicio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KW.CatalogosMicroservicio.Repositorios.Contratos
{
    public interface IPersonaRepository
    {
        Task<List<Persona>> GetPersonas();
    }
}
