using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Secretaria.Domain.DatosPersonales;
using Secretaria.Repository;

namespace Secretaria.FrontEnd.Controllers.Administracion
{
    public class TipoDocumentoController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TipoDocumentoController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<TipoDocumento> tipoDocumentos = this.unitOfWork.TiposDeDocumentos.GetTs().OrderBy(x => x.Cadena);
            ViewBag.tipoDocumentos =  tipoDocumentos;

            return View("Index");
        }

        [HttpPost]
        public IActionResult Index(TipoDocumento tipoDocumento)
        {
            this.unitOfWork.TiposDeDocumentos.Insert(tipoDocumento);
            this.unitOfWork.SaveChanges();
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EliminarTipoDocumento(int id)
        {
            TipoDocumento tipoDocumento = this.unitOfWork.TiposDeDocumentos.GetTs().FirstOrDefault(x => x.Id == id);
            if (tipoDocumento != null)
            {
                this.unitOfWork.TiposDeDocumentos.Delete(tipoDocumento);
                this.unitOfWork.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult EditarTipoDocumento(TipoDocumento tipoDocumento)
        {
            this.unitOfWork.TiposDeDocumentos.GetTs().FirstOrDefault(x => x.Id == tipoDocumento.Id).Cadena = tipoDocumento.Cadena;
            this.unitOfWork.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
