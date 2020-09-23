using Secretaria.Domain.Escuela;
using Secretaria.Domain.Faltas;
using Secretaria.Domain.DatosPersonales;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.Context.DatosPersonalesConfiguracion;
using Secretaria.Domain.Context.EscuelaConfiguracion;
using Secretaria.Domain.Context.FaltasConfiguracion;

namespace Secretaria.Domain
{
    public class SecretariaDbContext : DbContext
    {
        public SecretariaDbContext()
        {

        }

        public SecretariaDbContext(DbContextOptions<SecretariaDbContext> options) : base(options)
        {
            
        }

        //Datos personales
        public DbSet<Persona> Personas { get; set; }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        
        public DbSet<Domicilio> Domicilios { get; set; }
        
        public DbSet<Localidad> Localidades { get; set; }
        
        public DbSet<Nacionalidad> Nacionalidades { get; set; }

        //Secretaria
        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Cursada> Cursadas { get; set; }

        public DbSet<Seguimiento> Seguimientos { get; set; }

        public DbSet<AptoMedico> AptosMedicos { get; set; }

        ////public DbSet<TipoTutor> TipoTutores { get; set; }

        ////public DbSet<Tutor> Tutores { get; set; }

        ////Faltas
        public DbSet<TipoAusencia> TipoAusencias { get; set; }

        public DbSet<TipoFalta> TipoFaltas { get; set; }

        public DbSet<AsistenciaCurso> AsistenciaCursos { get; set; }

        public DbSet<Falta> Faltas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {   
            //Datos Personales
            mb.ApplyConfiguration(new PersonaConfiguracion());

            mb.ApplyConfiguration(new TipoDocumentoConfiguracion());

            mb.ApplyConfiguration(new DomicilioConfiguracion());

            mb.ApplyConfiguration(new LocalidadConfiguracion());

            mb.ApplyConfiguration(new NacionalidadConfiguracion());

            //Secretaria
            mb.ApplyConfiguration(new CursoConfiguracion());

            mb.ApplyConfiguration(new CursadaConfiguracion());

            mb.ApplyConfiguration(new SeguimientoConfiguracion());

            mb.ApplyConfiguration(new AlumnoConfiguracion());

            mb.ApplyConfiguration(new AptoMedicoConfiguracion());

            ////mb.ApplyConfiguration(new TipoTutorConfiguracion());

            ////mb.ApplyConfiguration(new TutorConfiguracion());

            ////Faltas
            mb.ApplyConfiguration(new AsistenciaCursoConfiguracion());

            mb.ApplyConfiguration(new TipoAusenciaConfiguracion());

            mb.ApplyConfiguration(new TipoFaltaConfiguracion());

            mb.ApplyConfiguration(new FaltaConfiguracion());

            base.OnModelCreating(mb);
        }
    }
}
