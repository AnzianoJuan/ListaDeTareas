using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public  class UsuarioData
    {

        public List<Usuario> listarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT UsuarioID, NombreUsuario, Contraseña, Email FROM Users");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario
                    {
                        UsuarioID = (int)datos.Lector["UsuarioID"],
                        NombreUsuario = (string)datos.Lector["NombreUsuario"],
                        Contra = (string)datos.Lector["Contraseña"],  // 🔹 Corrección aquí
                        Email = (string)datos.Lector["Email"]         // 🔹 Corrección aquí
                    };

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;
        }

    }
}
