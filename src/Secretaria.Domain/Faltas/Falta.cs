﻿using Secretaria.Domain.Escuela;
using System;

namespace Secretaria.Domain.Faltas
{
    public class Falta
    {
        public int Libro { get; set; }

        public int Folio { get; set; }

        public DateTime Fecha { get; set; }

        public Alumno Alumno { get; set; }

        public TipoFalta TipoFalta { get; set; }

        public TipoAusencia TipoAusencia { get; set; }

        public Curso Curso { get; set; }

        public float Valor { get; set; }

        public bool Justificada { get; set; } = false;
    }
}