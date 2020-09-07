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
    public class DomicilioController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public DomicilioController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Domicilio> domicilios = this.unitOfWork.Domicilios.GetTs();

            return View();
        }
    }
}
