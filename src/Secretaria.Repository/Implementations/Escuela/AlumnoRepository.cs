using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.Escuela;
using Secretaria.Repository.Interfaces.IEscuela;

namespace Secretaria.Repository.Implementations.Escuela
{
    public class AlumnoRepository: Repository<Alumno>, IAlumnoRepository
    {
        public AlumnoRepository(DbContext context): base(context)
        {
            
        }
    }
}
