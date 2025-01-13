﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tarea
    {
        public int TareaID { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public string Prioridad { get; set; }

        public string Estado { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaCompletada { get; set; }

        public Usuario Usuario { get; set; }
    }
}
