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
    public class PersonaController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public PersonaController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Persona> personas = this.unitOfWork.Personas.GetTs();

            return View();
        }
    }
}