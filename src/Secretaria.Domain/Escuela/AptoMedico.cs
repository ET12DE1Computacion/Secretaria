using System;

namespace Secretaria.Domain.Escuela
{
    public class AptoMedico
    {
        public DateTime Vencimiento { get; set; }

        public int Libro { get; set; }

        public int Folio { get; set; }

        public Alumno Alumno { get; set; }
    }
}
