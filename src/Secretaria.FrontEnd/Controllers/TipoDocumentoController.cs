using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Secretaria.Domain.ADO;
using Secretaria.Domain.DatosPersonales;
using Secretaria.Repository;

namespace Secretaria.FrontEnd.Controllers
{
    public class TipoDocumentoController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TipoDocumentoController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        
        public IActionResult Index()
        {
            IEnumerable<TipoDocumento> tipoDocumentos = this.unitOfWork.TiposDeDocumentos.GetTs();

            return View();
        }
    }
}