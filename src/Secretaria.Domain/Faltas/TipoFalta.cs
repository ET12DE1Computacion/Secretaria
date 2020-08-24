using Secretaria.Domain.Util;
using System.Collections.Generic;

namespace Secretaria.Domain.Faltas
{
    public class TipoFalta : TextoSencillo
    {
        public IEnumerable<Falta> Faltas { get; set; }

        public IEnumerable<AsistenciaCurso> AsistenciaCurso { get; set; }

        public TipoFalta()
        {
            Faltas = new List<Falta>();

            AsistenciaCurso = new List<AsistenciaCurso>();
        }
    }
}