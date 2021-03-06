﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Secretaria.FrontEnd.ViewModels.Administracion
{
    public class EditarRolViewModel
    {
        public EditarRolViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Es obligatorio el Nombre del rol")]
        public string NombreRol { get; set; }

        [Required(ErrorMessage = "Es obligatorio el Area del rol")]
        public string Area { get; set; }

        public string CreatedBy { get; set; }
        public string CreationDate { get; set; }
        public string CreationIp { get; set; }

        public List<string> Users { get; set; }
    }
}
