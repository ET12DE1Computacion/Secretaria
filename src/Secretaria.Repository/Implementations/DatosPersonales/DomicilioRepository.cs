using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.DatosPersonales;
using Secretaria.Repository.Interfaces.IDatosPersonales;

namespace Secretaria.Repository.Implementations.DatosPersonales
{
    public class DomicilioRepository : Repository<Domicilio>, IDomicilioRepository
    {
        public DomicilioRepository(DbContext context) : base(context)
        {
            
        }
    }
}
