using KW.CatalogosMicroservicio.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KW.CatalogosMicroservicio.Contexto
{
    public class CatalogosDbContext : DbContext
    {
        public CatalogosDbContext(DbContextOptions<CatalogosDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasKey(h => h.PersonaId);
        }

        public DbSet<Persona> Personas { get; set; }
    }
}
