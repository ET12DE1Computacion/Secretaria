using System;
using Secretaria.Domain.ADO;
// Implementations
using Secretaria.Repository.Implementations.DatosPersonales;
using Secretaria.Repository.Implementations.Escuela;
using Secretaria.Repository.Implementations.Faltas;
// Interfaces
using Secretaria.Repository.Interfaces.IDatosPersonales;
using Secretaria.Repository.Interfaces.IEscuela;
using Secretaria.Repository.Interfaces.IFaltas;


namespace Secretaria.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private SecretariaDbContext context;

        // Datos personales
        private ILocalidadRepository localidadRepository;
        private IDomicilioRepository domicilioRepository;
        private INacionalidadRepository nacionalidadRepository;
        private IPersonaRepository personaRepository;
        private ITipoDocumentoRepository tipoDocumentoRepository;

        // Escuela
        private IAlumnoRepository alumnoRepository;
        private IAptoMedicoRepository aptoMedicoRepository;
        private ICursadaRepository cursadaRepository;
        private ICursoRepository cursoRepository;
        private ISeguimientoRepository seguimientoRepository;

        // Faltas
        private IAsistenciaCursoRepository asistenciaCursoRepository;
        private IFaltaRepository faltaRepository;
        private ITipoAusenciaRepository tipoAusenciaRepository;
        private ITipoFaltaRepository tipoFaltaRepository;


        public UnitOfWork(SecretariaDbContext context)
        {
            this.context = context;
        }

        // Datos Personales
        public IDomicilioRepository Domicilios 
                => domicilioRepository ?? new DomicilioRepository(context);

        public ILocalidadRepository Localidades
                => localidadRepository ?? new LocalidadRepository(context);

        public INacionalidadRepository Nacionalidades
                => nacionalidadRepository ?? new NacionalidadRepository(context);

        public IPersonaRepository Personas
                => personaRepository ?? new PersonaRepository(context);

        public ITipoDocumentoRepository TiposDeDocumentos
                => tipoDocumentoRepository ?? new TipoDocumentoRepository(context);

        // Escuela
        public IAlumnoRepository Alumnos
                => alumnoRepository ?? new AlumnoRepository(context);
        
        public IAptoMedicoRepository AptosMedicos
                => aptoMedicoRepository ?? new AptoMedicoRepository(context);
        
        public ICursadaRepository Cursadas
                => cursadaRepository ?? new CursadaRepository(context);

        public ICursoRepository Cursos
                => cursoRepository ?? new CursoRepository(context);

        public ISeguimientoRepository Seguimientos
                => seguimientoRepository ?? new SeguimientoRepository(context);


        // Faltas
        public IAsistenciaCursoRepository AsistenciasDeCursos
                => asistenciaCursoRepository ?? new AsistenciaCursoRepository(context);

        public IFaltaRepository Faltas
                => faltaRepository ?? new FaltaRepository(context);

        public ITipoAusenciaRepository TiposDeAusencias
                => tipoAusenciaRepository ?? new TipoAusenciaRepository(context);

        public ITipoFaltaRepository TiposDeFaltas
                => tipoFaltaRepository ?? new TipoFaltaRepository(context);

        public void Dispose()
        {
            context.Dispose();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
