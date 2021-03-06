﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using SistemaEncuestas.Models;

namespace SistemaEncuestas.Models.Domain
{
    public class Respuesta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [ForeignKey("Preguntas")]
        public int IdPreguntas { get; set; }

        [ForeignKey("AspNetUsers")]
        public string IdUsuario { get; set; }

        public virtual Pregunta Preguntas { get; set; }

        public virtual ApplicationUser AspNetUsers { get;set;}
    }
}