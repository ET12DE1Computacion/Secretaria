using Secretaria.Domain.Faltas;
using System;
using System.Collections.Generic;

namespace Secretaria.Domain.Escuela
{
    public class Cursada
    {
        public short Libro { get; set; }

        public byte Folio { get; set; }

        public Alumno Alumno { get; set; }

        public Curso Curso { get; set; }

        public short CicloLectivo { get; set; }

        public DateTime Inscripcion { get; set; }       
    }
}
