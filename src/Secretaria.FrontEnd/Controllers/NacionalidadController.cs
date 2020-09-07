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

        [HttpGet]
        public IActionResult EliminarNacionalidad(int id)
        {
            Nacionalidad nacionalidad = this.unitOfWork.Nacionalidades.GetTs().FirstOrDefault(x => x.Id == id);
            if (nacionalidad != null)
            {
                this.unitOfWork.Nacionalidades.Delete(nacionalidad);
                this.unitOfWork.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult EditarNacionalidad(Nacionalidad nacionalidad)
        {
            this.unitOfWork.Nacionalidades.GetTs().FirstOrDefault(x => x.Id == nacionalidad.Id).Cadena = nacionalidad.Cadena;
            this.unitOfWork.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
