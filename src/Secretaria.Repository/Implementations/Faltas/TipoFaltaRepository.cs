using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.Faltas;
using Secretaria.Repository.Interfaces.IFaltas;

namespace Secretaria.Repository.Implementations.Faltas
{
    public class TipoFaltaRepository: Repository<TipoFalta>, ITipoFaltaRepository
    {
        public TipoFaltaRepository(DbContext context): base(context)
        {
            
        }
    }
}
