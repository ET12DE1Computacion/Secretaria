using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.Escuela;
using Secretaria.Repository.Interfaces.IEscuela;

namespace Secretaria.Repository.Implementations.Escuela
{
    public class CursadaRepository: Repository<Cursada>, ICursadaRepository
    {
        public CursadaRepository(DbContext context): base(context)
        {
            
        }
    }
}
