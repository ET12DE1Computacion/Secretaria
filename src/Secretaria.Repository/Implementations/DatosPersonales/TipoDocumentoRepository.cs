using System;
using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.DatosPersonales;
using Secretaria.Repository.Interfaces.IDatosPersonales;

namespace Secretaria.Repository.Implementations.DatosPersonales
{
    public class TipoDocumentoRepository: Repository<TipoDocumento>, ITipoDocumentoRepository
    {
        public TipoDocumentoRepository(DbContext context): base(context)
        {
            
        }
    }
}
