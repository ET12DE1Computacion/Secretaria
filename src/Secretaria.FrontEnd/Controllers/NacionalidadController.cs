using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Secretaria.Domain.ADO;
using Secretaria.Domain.DatosPersonales;
using Secretaria.Repository;

namespace Secretaria.FrontEnd.Controllers.Administracion
{
    public class NacionalidadController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public NacionalidadController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Nacionalidad> nacionalidades = this.unitOfWork.Nacionalidades.GetTs().OrderBy(x => x.Cadena);
            ViewBag.nacionalidades =  nacionalidades;

            return View("Index");
        }

        [HttpPost]
        public IActionResult Index(Nacionalidad nacionalidad)
        {
            this.unitOfWork.Nacionalidades.Insert(nacionalidad);
            this.unitOfWork.SaveChanges();
            
            return RedirectToAction("Index");
        }

        // Revición
        [HttpPost]
        public IActionResult Eliminar(int IdL)
        {
            IEnumerable<Nacionalidad> nacionalidades = this.unitOfWork.Nacionalidades.GetTs();
            this.unitOfWork.Nacionalidades.Delete(nacionalidades.SingleOrDefault(x => x.Id == IdL));
            this.unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
