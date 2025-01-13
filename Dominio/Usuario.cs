using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        public string NombreUsuario { get; set; }

        public string Contra { get; set; }

        public string Email { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
