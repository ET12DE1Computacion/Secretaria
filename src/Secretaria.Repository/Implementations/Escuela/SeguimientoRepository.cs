using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.Escuela;
using Secretaria.Repository.Interfaces.IEscuela;

namespace Secretaria.Repository.Implementations.Escuela
{
    public class SeguimientoRepository: Repository<Seguimiento>, ISeguimientoRepository
    {
        public SeguimientoRepository(DbContext context): base(context)
        {
            
        }
    }
}
