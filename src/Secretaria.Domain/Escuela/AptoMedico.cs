using System;

namespace Secretaria.Domain.Escuela
{
    public class AptoMedico: EsDeAlumno
    {
        public DateTime Vencimiento { get; set; }
        public bool EsValido => Vencimiento >= DateTime.Now.Date;
        public AptoMedico(Alumno alumno, DateTime vencimiento) :
            base(alumno) => Vencimiento = vencimiento;
    }
}