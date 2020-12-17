using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Secretaria.Domain.Escuela;
using Secretaria.Domain.DatosPersonales;
using Secretaria.Repository;
using Microsoft.EntityFrameworkCore;
using Secretaria.FrontEnd.Models.Components;

namespace Secretaria.FrontEnd.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public AlumnoController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // [HttpGet]
        // public async Task<IActionResult> IndexAsync()
        // {
        //     ViewBag.alumnos = this.unitOfWork.Alumnos.GetAll(include: I => I
        //         .Include(x => x.Persona)
        //             .ThenInclude(x => x.Nacionalidad));

        //     return View("Alumnos");
        // }
        [HttpGet]
        public IEnumerable<Alumno> Alumnos()
        {
             return this.unitOfWork.Alumnos.GetAll(include: I => I
                .Include(x => x.Persona)
                    .ThenInclude(x => x.Nacionalidad));
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Localidad> localidades = this.unitOfWork.Localidades.GetTs().OrderBy(x => x.Cadena);
            ViewBag.localidades = localidades;

            IEnumerable<Nacionalidad> nacionalidades = this.unitOfWork.Nacionalidades.GetTs().OrderBy(x => x.Cadena);
            ViewBag.nacionalidades = nacionalidades;

            IEnumerable<TipoDocumento> tipoDocumentos = this.unitOfWork.TiposDeDocumentos.GetTs().OrderBy(x => x.Cadena);
            ViewBag.tipoDocumentos = tipoDocumentos;

            return View("Index", Alumnos());
        }

        [HttpGet]
        public IActionResult EditarAlumno(string id)
        {
            // Alumno esta vacio - Lo esperaba
            return View("EditAlumno", Alumno(id));
        }

        [HttpGet]
        public IActionResult RegistrarAlumno()
        {
            // Alumno esta vacio - Lo esperaba
            Alumno alumno = new Alumno();

            alumno.Folio = 0;
            alumno.Libro = 0;
            

            return View("RegistrarAlumno", alumno);
        }

        [HttpPost]
        public IActionResult SaveEditAlumno(SaveEditModel alumnoOfTest)
        {
            // SimpleText
            Localidad localidad = this.unitOfWork.Localidades.GetTs().FirstOrDefault(x => x.Id == alumnoOfTest.alumno.Persona.Domicilio.Localidad.Id);
            alumnoOfTest.alumno.Persona.Domicilio.Localidad = localidad;

            TipoDocumento tipoDocumento = this.unitOfWork.TiposDeDocumentos.GetTs().FirstOrDefault(x => x.Id == alumnoOfTest.alumno.Persona.TipoDocumento.Id);
            alumnoOfTest.alumno.Persona.TipoDocumento = tipoDocumento;
            alumnoOfTest.alumno.IdTipoDocumento = tipoDocumento.Id;
            alumnoOfTest.alumno.NroDocumento = alumnoOfTest.alumno.Persona.NroDocumento;

            Nacionalidad nacionalidad = this.unitOfWork.Nacionalidades.GetTs().FirstOrDefault(x => x.Id == alumnoOfTest.alumno.Persona.Nacionalidad.Id);
            alumnoOfTest.alumno.Persona.Nacionalidad = nacionalidad;

            Alumno alumno = new Alumno();
            alumno = alumnoOfTest.alumno;

            // Curso curso = new Curso();
            // //curso = this.unitOfWork.Cursos.GetTs().FirstOrDefault(x => x.Anio == 0 && x.Division == 0);
            // curso = this.unitOfWork.Cursos.GetOne(x => x.Anio == 1 && x.Division == 4);
            alumno.CursoActual.Division = 0;
            alumno.CursoActual.Anio = 0;

            if (alumnoOfTest.Save)
            {
                this.unitOfWork.Alumnos.Insert(alumno);
            }
            else
            {
                this.unitOfWork.Alumnos.GetOne(x => x.Folio == alumnoOfTest.Folio && x.Libro == alumnoOfTest.Libro).Edit(alumno);
            }

            this.unitOfWork.SaveChanges();

            return RedirectToAction("Index");
        }

        public Alumno Alumno(string id)
        {
            int Libro = Convert.ToInt32(id.Substring(0, id.IndexOf('-')));
            int Folio = Convert.ToInt32(id.Substring(id.IndexOf('-') + 1));

            return this.unitOfWork.Alumnos.GetOne(x => x.Libro == Libro && x.Folio == Folio);
        }

        [HttpGet]
        public IActionResult EliminarAlumno(string id)
        {
            this.unitOfWork.Alumnos.Delete(Alumno(id));
            this.unitOfWork.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}