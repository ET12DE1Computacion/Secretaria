using Secretaria.Domain.Faltas;
using System.Collections.Generic;

namespace Secretaria.Domain.Escuela
{
    public class Curso
    {
        public int IdCurso { get; set; }

        public byte Division { get; set; }

        public byte Anio { get; set; }
        
        public IEnumerable<Alumno> Alumnos { get; set; }

        public IEnumerable<Falta> Faltas { get; set; }

        public IEnumerable<AsistenciaCurso> AsistenciaCurso { get; set; }

        public Curso()
        {
            Alumnos = new List<Alumno>();

            AsistenciaCurso = new List<AsistenciaCurso>();

            Faltas = new List<Falta>();
        }
    }
}
