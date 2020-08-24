namespace Secretaria.Domain.Escuela
{
    public abstract class EsDeAlumno
    {
        public short Libro { get; set; }
        public byte Folio { get; set; }
        public Alumno Alumno { get; set; }

        public EsDeAlumno() {}
        public EsDeAlumno(Alumno alumno)
        {
            Alumno = alumno;
            Libro = alumno.Libro;
            Folio = alumno.Folio;
        }
    }
}