﻿using ADSProject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProyect.Models
{
    public class GruposViewModel
    {
        [Display(Name = "ID Grupo")]
        public int idGrupo { get; set; }

        [Display(Name = "ID Carrera")]
        public int idCarrera { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "ID Materia")]
        public int idMateria { get; set; }
        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]

        [Display(Name = "ID Profesor")]
        public int idProfesor { get; set; }
        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]

        [Display(Name = "Ciclo")]
        public int ciclo { get; set; }
        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [Display(Name = "Año")]
        public int anio { get; set; }
    }
}
