using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.DatosPersonales;
using Secretaria.Repository.Interfaces.IDatosPersonales;

namespace Secretaria.Repository.Implementations.DatosPersonales
{
    public class NacionalidadRepository: Repository<Nacionalidad>, INacionalidadRepository
    {
        public NacionalidadRepository(DbContext context): base(context)
        {
            
        }
    }
}
