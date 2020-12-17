using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Query;
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

        public IIncludableQueryable<Alumno, object> Include(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

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
        // public void Edit(Persona persona, short libro, byte folio, int nroDocumento, byte idTipoDocumento)
        // {
            // this.Persona = persona;
            // this.Libro = libro;
            // this.Folio = folio;
            // this.NroDocumento = NroDocumento;
            // this.IdTipoDocumento = idTipoDocumento;
        // }
        public void Edit(Alumno alumno)
        {
            this.Persona = alumno.Persona;
            this.Libro = alumno.Libro;
            this.Folio = alumno.Folio;
            this.NroDocumento = alumno.NroDocumento;
            this.IdTipoDocumento = alumno.IdTipoDocumento;
        }
    }
}