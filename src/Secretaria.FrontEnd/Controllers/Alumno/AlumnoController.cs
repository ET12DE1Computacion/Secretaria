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

namespace Secretaria.FrontEnd.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public AlumnoController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Alumno> alumnos = this.unitOfWork.Alumnos.GetAll(include: I => I
                .Include(x => x.Persona)
                    .ThenInclude(x => x.Nacionalidad));

            foreach (var alumno in alumnos)
            {
                Console.WriteLine($"Nacionalidad: {alumno.Persona.Nacionalidad.Cadena} Id: {alumno.Persona.Nacionalidad.Id}");
                Console.WriteLine($"Apellido: {alumno.Persona.Apellido}");
            }

            return View("Index", alumnos);
        }

        [HttpGet]
        public IActionResult RegistrarAlumno()
        {
            IEnumerable<Localidad> localidades = this.unitOfWork.Localidades.GetTs().OrderBy(x => x.Cadena);
            ViewBag.localidades = localidades;

            IEnumerable<Nacionalidad> nacionalidades = this.unitOfWork.Nacionalidades.GetTs().OrderBy(x => x.Cadena);
            ViewBag.nacionalidades = nacionalidades;

            IEnumerable<TipoDocumento> tipoDocumentos = this.unitOfWork.TiposDeDocumentos.GetTs().OrderBy(x => x.Cadena);
            ViewBag.tipoDocumentos = tipoDocumentos;

            return View("RegistrarAlumno");
        }

        [HttpPost]
        public IActionResult Registrar(Alumno alumnoTest)
        {

            // Domicilio
            Domicilio domicilio = new Domicilio();
            domicilio = alumnoTest.Persona.Domicilio;

            Console.WriteLine(alumnoTest.Persona.Domicilio.Localidad.Id);
            Localidad localidad = new Localidad();
            localidad = this.unitOfWork.Localidades.GetTs().FirstOrDefault(x => x.Id == alumnoTest.Persona.Domicilio.Localidad.Id);
            domicilio.Localidad = localidad;

            // Persona
            Persona persona = new Persona();
            persona = alumnoTest.Persona;
            persona.Domicilio = domicilio;

            TipoDocumento tipoDocumento = new TipoDocumento();
            tipoDocumento = this.unitOfWork.TiposDeDocumentos.GetTs().FirstOrDefault(x => x.Id == alumnoTest.Persona.TipoDocumento.Id);
            persona.TipoDocumento = tipoDocumento;
            persona.IdTipoDocumento = persona.TipoDocumento.Id;

            Nacionalidad nacionalidad = new Nacionalidad();
            nacionalidad = this.unitOfWork.Nacionalidades.GetTs().FirstOrDefault(x => x.Id == alumnoTest.Persona.Nacionalidad.Id);
            persona.Nacionalidad = nacionalidad;

            // Alumno
            Alumno alumno = new Alumno();

            alumno = alumnoTest;
            alumno.Persona = persona;
            alumno.IdTipoDocumento = persona.IdTipoDocumento;
            alumno.NroDocumento = persona.NroDocumento;

            Curso curso = new Curso();
            //curso = this.unitOfWork.Cursos.GetTs().FirstOrDefault(x => x.Anio == 0 && x.Division == 0);
            curso = this.unitOfWork.Cursos.GetOne(x => x.Anio == 0 && x.Division == 0);
            alumno.CursoActual = curso;

            Console.WriteLine(alumno.Libro);
            Console.WriteLine(alumno.Folio);
            // Console.WriteLine(alumno.Persona.Nacimiento);
            // Console.WriteLine(alumno.Persona.Domicilio.observacionDomicilio);

            Console.WriteLine($"Nacionalidad: {alumno.Persona.Nacionalidad.Cadena} Id: {alumno.Persona.Nacionalidad.Id}");
            Console.WriteLine($"Localidad: {alumno.Persona.Domicilio.Localidad.Cadena} Id: {alumno.Persona.Domicilio.Localidad.Id}");
            Console.WriteLine($"Tipo Docuemnto: {alumno.Persona.TipoDocumento.Cadena} Id: {alumno.Persona.TipoDocumento.Id}");

            this.unitOfWork.Alumnos.Insert(alumno);
            this.unitOfWork.SaveChanges();

            return View("Index");
        }
    }
}