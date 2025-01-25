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

        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select UsuarioID,NombreUsuario,Email,Contraseña from Users");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Usuario aux = new Usuario();

                    aux.UsuarioID = (int)datos.Lector["UsuarioID"];
                    aux.NombreUsuario = (string)datos.Lector["NombreUsuario"];
                    aux.Email = (string)datos.Lector["Email"];
                    aux.Contra = (string)datos.Lector["Contraseña"];


                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                datos.cerrarConexion();

            }
        }

    }
}
