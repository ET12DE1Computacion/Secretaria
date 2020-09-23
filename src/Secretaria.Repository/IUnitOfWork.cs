using System;
using Secretaria.Repository.Interfaces.IDatosPersonales;
using Secretaria.Repository.Interfaces.IEscuela;
using Secretaria.Repository.Interfaces.IFaltas;

namespace Secretaria.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        // Datos Personales
        IDomicilioRepository Domicilios {get;}
        ILocalidadRepository Localidades {get;}
        INacionalidadRepository Nacionalidades {get;}
        IPersonaRepository Personas {get;}
        ITipoDocumentoRepository TiposDeDocumentos {get;}

        // Escuela
        IAlumnoRepository Alumnos {get;}
        IAptoMedicoRepository AptosMedicos {get;}
        ICursadaRepository Cursadas {get;}
        ICursoRepository Cursos {get;}
        ISeguimientoRepository Seguimientos {get;}

        // Faltas
        IAsistenciaCursoRepository AsistenciasDeCursos {get;}
        IFaltaRepository Faltas {get;}
        ITipoAusenciaRepository TiposDeAusencias {get;}
        ITipoFaltaRepository TiposDeFaltas {get;}

        void SaveChanges();
    }
}
