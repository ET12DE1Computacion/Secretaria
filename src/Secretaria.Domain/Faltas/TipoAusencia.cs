using Secretaria.Domain.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secretaria.Domain.Faltas
{
    public class TipoAusencia : TextoSencillo
    {
        public float Valor { get; set; }

        public IEnumerable<Falta> Faltas { get; set; }

        public TipoAusencia() 
        {
            Faltas = new List<Falta>();
        }
    }
}
