using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.Faltas;
using Secretaria.Repository.Interfaces.IFaltas;

namespace Secretaria.Repository.Implementations.Faltas
{
    public class FaltaRepository: Repository<Falta>, IFaltaRepository
    {
        public FaltaRepository(DbContext context): base(context)
        {
            
        }
    }
}
