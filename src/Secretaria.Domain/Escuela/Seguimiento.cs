﻿using System;

namespace Secretaria.Domain.Escuela
{
    public class Seguimiento
    {
        public int IdSeguimiento { get; set; }

        public int Libro { get; set; }

        public int Folio { get; set; }

        public Alumno Alumno { get; set; }
        
        public string Observacion { get; set; }
        
        public DateTime Fecha { get; set; }
    }
}
