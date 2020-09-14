using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.Faltas;
using Secretaria.Repository.Interfaces.IFaltas;

namespace Secretaria.Repository.Implementations.Faltas
{
    public class TipoAusenciaRepository: Repository<TipoAusencia>, ITipoAusenciaRepository
    {
        public TipoAusenciaRepository(DbContext context): base(context)
        {
            
        }
    }
}
