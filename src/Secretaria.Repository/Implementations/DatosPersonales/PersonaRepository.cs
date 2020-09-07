using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.DatosPersonales;
using Secretaria.Repository.Interfaces.IDatosPersonales;

namespace Secretaria.Repository.Implementations.DatosPersonales
{
    public class PersonaRepository: Repository<Persona>, IPersonaRepository
    {
        public PersonaRepository(DbContext context): base(context)
        {
            
        }
    }
}
