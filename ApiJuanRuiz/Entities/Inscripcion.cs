using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ApiJuanRuiz.Entities
{
    public class Inscripcion
    {

        public int Id { get; set; }

        //Documento Validation
        [Required(ErrorMessage = "Por favor Ingresar el documento del estudiante")]
        public int Documento { get; set; }

        //Nombre Validation
        [Required(ErrorMessage = "Por favor Ingresar el Nombre del solicitante")]
        [StringLength(20, ErrorMessage = "El nombre No puede superar los 20 caracteres")]
        public string Nombre { get; set; }

        //Apellido Validation
        [Required(ErrorMessage = "Por favor Ingresar el Apellido del solicitante")]
        [StringLength(20, ErrorMessage = "El Apellido No puede superar los 20 caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Por favor Ingresar la Edad del solicitante")]
        [Range(1, 99,ErrorMessage = "Error,La edad no puede superar los 2 digitos")]
        public int Edad { get; set; }


        [Required(ErrorMessage = "Por favor Ingresar la casa a la cual desea aspirar 1=")]
        [Range(1, 4, ErrorMessage = "Error,No tenemos inscripiones a otras Magic House")]
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
