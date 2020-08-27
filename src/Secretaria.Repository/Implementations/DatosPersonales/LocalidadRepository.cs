using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.DatosPersonales;
using Secretaria.Repository.Interfaces.IDatosPersonales;

namespace Secretaria.Repository.Implementations.DatosPersonales
{
    public class LocalidadRepository: Repository<Localidad>, ILocalidadRepository
    {
        public LocalidadRepository(DbContext context): base(context)
        {
            
        }
    }
}
