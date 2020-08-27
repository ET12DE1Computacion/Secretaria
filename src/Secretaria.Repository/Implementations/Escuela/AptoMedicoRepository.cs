using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.Escuela;
using Secretaria.Repository.Interfaces.IEscuela;

namespace Secretaria.Repository.Implementations.Escuela
{
    public class AptoMedicoRepository: Repository<AptoMedico>, IAptoMedicoRepository
    {
        public AptoMedicoRepository(DbContext context): base(context)
        {
            
        }
    }
}
