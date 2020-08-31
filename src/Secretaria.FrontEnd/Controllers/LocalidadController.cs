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
    public class LocalidadController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public LocalidadController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Localidad> localidades = this.unitOfWork.Localidades.GetTs().OrderBy(x => x.Cadena);
            ViewBag.localidades =  localidades;

            return View("Index");
        }

        [HttpPost]
        public IActionResult Index(Localidad localidad)
        {
            this.unitOfWork.Localidades.Insert(localidad);
            this.unitOfWork.SaveChanges();
            // IEnumerable<Localidad> localidades = this.unitOfWork.Localidades.GetTs();
            
            return RedirectToAction("Index");
        }

        // Revición
        [HttpPost]
        public IActionResult Eliminar(int IdL)
        {

            if (IdL == 0)
            {
                IEnumerable<Localidad> localidades = this.unitOfWork.Localidades.GetTs();
                this.unitOfWork.Localidades.Delete(localidades.First(x => x.Id == IdL));
                this.unitOfWork.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
