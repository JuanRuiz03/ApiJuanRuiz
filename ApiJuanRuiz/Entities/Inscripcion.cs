using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJuanRuiz.Entities
{
    public class Inscripcion
    {

        public int Id { get; set; }

        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public int IdCasa { get; set; }

        public Casa Casa { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<Inscripcion> MapeoIns)
            {
                MapeoIns.HasKey(x => x.Id);
                MapeoIns.HasOne(x => x.Casa);
            }

        }
    }
}
