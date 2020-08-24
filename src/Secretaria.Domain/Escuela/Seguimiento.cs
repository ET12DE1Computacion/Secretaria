using System;

namespace Secretaria.Domain.Escuela
{
    public class Seguimiento: EsDeAlumno
    {
        public string Observacion { get; set; }        
        public DateTime Fecha { get; set; }
        public Seguimiento(Alumno alumno, DateTime fecha, string observacion)
            :base(alumno)
        {
            Fecha = fecha;
            Observacion = observacion;
        }
        public Seguimiento(Alumno alumno, string observacion)
            : this(alumno, DateTime.Now, observacion) { }
    }
}