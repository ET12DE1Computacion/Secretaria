using Secretaria.Domain.Escuela;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Secretaria.Domain.DatosPersonales
{
    public class Persona
    {        
        public int NroDocumento { get; set; }
        
        public byte IdTipoDocumento { get; set; }
        
        public virtual TipoDocumento TipoDocumento { get; set; }
        
        public string Nombre { get; set; }
        
        public string Apellido { get; set; }
        
        public virtual Domicilio Domicilio { get; set; }   
        
        public string Mail { get; set; } 
        
        public virtual Nacionalidad Nacionalidad { get; set; }
        
        public DateTime Nacimiento { get; set; }
        
        public long? Telefono1 { get; set; }
        
        public long? Telefono2 { get; set; }

        public IEnumerable<Alumno> Alumnos { get; set; }

        public Persona()
        {
            Alumnos = new List<Alumno>();
        }


        [NotMapped]
        public byte Edad 
        {
            get
            {
                DateTime ahora = DateTime.Today;
                byte edad = Convert.ToByte(ahora.Year - Nacimiento.Year);

                if (ahora.Month < Nacimiento.Month || (ahora.Month == Nacimiento.Month && ahora.Day < Nacimiento.Day))
                    edad--;

                return edad;
            }
        }
    }
}