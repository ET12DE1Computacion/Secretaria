using System.Collections.Generic;
using Secretaria.Domain.DatosPersonales;
using Secretaria.Domain.Faltas;

namespace Secretaria.Domain.Escuela
{
    public class Alumno
    {
        public short Libro { get; set; }
        
        public byte Folio { get; set; }

        public Curso CursoActual { get; set; }

        public int NroDocumento { get; set; }

        public byte IdTipoDocumento { get; set; }

        public Persona Persona { get; set; }

        public IEnumerable<Seguimiento> Seguimientos { get; set; }

        //public IEnumerable<Tutor> Tutores { get; set; }
        
        public IEnumerable<Cursada> Cursadas { get; set; }

        public IEnumerable<Falta> Faltas { get; set; }

        public IEnumerable<AptoMedico> AptoMedicos { get; set; }

        public Alumno()
        {
            iniciarListas();
        }

        private void iniciarListas()
        {
            //Tutores = new List<Tutor>();

            Seguimientos = new List<Seguimiento>();

            Cursadas = new List<Cursada>();

            Faltas = new List<Falta>();

            AptoMedicos = new List<AptoMedico>();
        }
    }
}