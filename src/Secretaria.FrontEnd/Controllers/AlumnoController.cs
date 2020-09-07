using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Secretaria.Domain.ADO;
using Secretaria.Domain.Escuela;
using Secretaria.Repository;

namespace Secretaria.FrontEnd.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public AlumnoController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Alumno> alumnos = this.unitOfWork.Alumnos.GetTs();

            return View();
        }
    }
}