using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Secretaria.Domain.DatosPersonales;
using Secretaria.FrontEnd.Models.Components;
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
            ViewBag.datos =  localidades;

            return ViewComponent ("CommonViewDP", new SimpleText {Title = "Localidad", TextForm = "Ingrese la localidad ej. Retiro..."});
            // return RedirectToAction ("Index");
        }

        [HttpPost]
        public IActionResult Index(SimpleText localidadTest)
        {
            Localidad localidad = new Localidad() {Cadena=localidadTest.Cadena};
            this.unitOfWork.Localidades.Insert(localidad);
            this.unitOfWork.SaveChanges();
            // IEnumerable<Localidad> localidades = this.unitOfWork.Localidades.GetTs();
            
            return RedirectToAction("Index");
        }

        // Revicións
        [HttpGet]
        public IActionResult EliminarLocalidad(int id)
        {
            Localidad localidad = this.unitOfWork.Localidades.GetTs().FirstOrDefault(x=> x.Id==id);
            if (localidad != null)
            {
                this.unitOfWork.Localidades.Delete(localidad);
                this.unitOfWork.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult EditarLocalidad(Localidad localidad)
        {
            this.unitOfWork.Localidades.GetTs().FirstOrDefault(x => x.Id == localidad.Id).Cadena = localidad.Cadena;
            this.unitOfWork.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}
