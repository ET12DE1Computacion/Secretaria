using System;
using Secretaria.Domain.Escuela;
using Secretaria.Domain.DatosPersonales;
using System.Linq;

namespace Secretaria.FrontEnd.Models.Components
{
    public class SaveEditModel
    {
        public string Titulo {get; set;}
        public bool Save {get; set;}
        public Alumno alumno {get; set;}
        public short Libro {get; set;}
        public byte Folio {get; set;}

    }
}
