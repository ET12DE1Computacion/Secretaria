using Secretaria.Domain.DatosPersonales;
using Secretaria.Domain.Util;

namespace Secretaria.Domain.Escuela
{
    public class Tutor : EsPersona
    {
        public int Id { get; set; }

        public Alumno Alumno { get; set; }

        public TipoTutor TipoTutor { get; set; }

        public Tutor() : base() { }

        public Tutor(Persona persona) : base(persona) { }
    }
}
