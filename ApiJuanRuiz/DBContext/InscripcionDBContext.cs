using ApiJuanRuiz.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJuanRuiz.DBContext
{
    public class InscripcionDBContext : DbContext
    {
       
        public InscripcionDBContext(DbContextOptions<InscripcionDBContext> options) : base(options) {
        }

        public DbSet<Inscripcion> Inscripcion { get; set; }

        public DbSet<Casa> Casa { get; set; }

        protected override void OnModelCreating(ModelBuilder modeloCreador)
        {
            new Inscripcion.Mapeo(modeloCreador.Entity<Inscripcion>());
            new Casa.Mapeo(modeloCreador.Entity<Casa>());

        }

    }
    
}
