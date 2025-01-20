using Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ListaData
    {

        public List<Tarea> listar()
        {
            List<Tarea> listaTareas = new List<Tarea>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT T.TareaID as Tarea,T.Titulo,T.Descripcion,T.Prioridad,T.Estado ,T.FechaCreacion, T.FechaCompletada, U.NombreUsuario ,U.UsuarioID FROM dbo.Tareas T JOIN dbo.Users U ON U.UsuarioID = T.UsuarioID \r\n");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Tarea aux = new Tarea();

                    aux.TareaID = (int)datos.Lector["Tarea"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Prioridad = (string)datos.Lector["Prioridad"];
                    aux.Estado = (string)datos.Lector["Estado"];
                    aux.FechaCreacion = (DateTime)datos.Lector["FechaCreacion"];
                    aux.FechaCompletada = (DateTime)datos.Lector["FechaCompletada"];


                    aux.Usuario = new Usuario
                    {
                        UsuarioID = (int)datos.Lector["UsuarioID"],
                        NombreUsuario = (string)datos.Lector["NombreUsuario"]
                    };

                    listaTareas.Add(aux);
                }

                return listaTareas;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            finally
            {

                datos.cerrarConexion();
            }
        }

        //public void AgregarContacto(Contacto nuevo)
        //{

        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {

        //        datos.setearConsulta("insert into Contactos(Nombre,Telefono,Email,Direccion) values(@Nombre,@Telefono,@Email,@Direccion)");
        //        datos.setearParametro("@Nombre", nuevo.Nombre);
        //        datos.setearParametro("@Telefono", nuevo.Telefono);
        //        datos.setearParametro("@Email", nuevo.Email);
        //        datos.setearParametro("@Direccion", nuevo.Direccion);

        //        datos.ejecutarAccion();

        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {

        //        datos.cerrarConexion();
        //    }
        //}

        //public void modificar(Contacto cont)
        //{

        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {

        //        datos.setearConsulta("update Contactos set Nombre = @Nombre,Telefono = @Telefono,Email = @Email,Direccion = @Direccion WHERE ContactoID = @ContactoID");
        //        datos.setearParametro("@Nombre", cont.Nombre);
        //        datos.setearParametro("@Telefono", cont.Telefono);
        //        datos.setearParametro("@Email", cont.Email);
        //        datos.setearParametro("@Direccion", cont.Direccion);
        //        datos.setearParametro("@ContactoID", cont.Id);

        //        datos.ejecutarAccion();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}

        //public void eliminar(int id)
        //{

        //    try
        //    {

        //        AccesoDatos datos = new AccesoDatos();

        //        datos.setearConsulta("delete from Contactos where ContactoID = @ContactoID");
        //        datos.setearParametro("@ContactoID", id);

        //        datos.ejecutarAccion();


        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

    }
}
