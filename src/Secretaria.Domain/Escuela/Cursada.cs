using Secretaria.Domain.Faltas;
using System;
using System.Collections.Generic;

namespace Secretaria.Domain.Escuela
{
    public class Cursada
    {
        public int IdCursada { get; set; }

        public int Libro { get; set; }

        public int Folio { get; set; }

        public Alumno Alumno { get; set; }

        public Curso Curso { get; set; }

        public short CicloLectivo { get; set; }

        public DateTime Inscripcion { get; set; }

        public IEnumerable<Falta> Faltas { get; set; }
    }
}
