using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJuanRuiz.Entities
{
    public class Casa
    {

        public int Id { get; set; }
        public string NombreCasa { get; set; }


        public class Mapeo
        {


            public Mapeo(EntityTypeBuilder<Casa> MapeoIns)
            {
                MapeoIns.HasKey(x => x.Id);
            }

        }
    }
}
