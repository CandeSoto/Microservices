using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KW.CatalogosMicroservicio.Modelos
{
    [Table("Persons")]
    public class Persona
    {
        [Column("PersonId")]
        public int PersonaId { get; set; }
        [Column("Name")]
        public string Nombre { get; set; }
    }
}
