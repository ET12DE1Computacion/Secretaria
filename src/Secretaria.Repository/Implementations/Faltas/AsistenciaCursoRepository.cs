using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.Faltas;
using Secretaria.Repository.Interfaces.IFaltas;

namespace Secretaria.Repository.Implementations.Faltas
{
    public class AsistenciaCursoRepository: Repository<AsistenciaCurso>, IAsistenciaCursoRepository
    {
        public AsistenciaCursoRepository(DbContext context): base(context)
        {
            
        }
    }
}
