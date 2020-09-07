using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.Escuela;
using Secretaria.Repository.Interfaces.IEscuela;

namespace Secretaria.Repository.Implementations.Escuela
{
    public class CursoRepository: Repository<Curso>, ICursoRepository
    {
        public CursoRepository(DbContext context): base(context)
        {
            
        }
    }
}
