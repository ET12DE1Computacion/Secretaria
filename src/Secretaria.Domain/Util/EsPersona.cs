﻿using Secretaria.Domain.DatosPersonales;
using System.ComponentModel.DataAnnotations.Schema;

namespace Secretaria.Domain.Util
{
    public abstract class EsPersona
    {        
        [ForeignKey("idPersona")]
        public Persona Persona { get; set; }

        public EsPersona() { }

        public EsPersona(Persona persona)
        {
            this.Persona = persona;
        }

        [NotMapped]
        public string Nombre => Persona.Nombre;

        [NotMapped]
        public string Apellido => Persona.Apellido;

        [NotMapped]
        public Domicilio Domicilio => Persona.Domicilio;
    }
}
