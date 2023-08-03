using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public object MessageBox { get; private set; }

        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select  Codigo, A.Id, Nombre, A.Descripcion, ImagenUrl, IdMarca, IdCategoria, C.Descripcion as Categoria, M.Descripcion as Marca, Precio From ARTICULOS A, CATEGORIAS C, MARCAS M where C.id = IdCategoria AND M.id = idMarca";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Id = (int)lector["Id"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    if (!(lector.IsDBNull(lector.GetOrdinal("ImagenUrl"))))
                        aux.ImagenUrl = (string)lector["ImagenUrl"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Precio = (decimal)lector["Precio"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public void agregar(Articulos nuevo)
        {
            Accesoadatos datos = new Accesoadatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values('" + nuevo.Codigo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "',@IdMarca, @IdCategoria,'" + nuevo.ImagenUrl + "','" + nuevo.Precio + "')");
                datos.setearParametro("@idMarca", nuevo.Marca.Id);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }

        }
        public void modificar(Articulos modificar)
        {
            Accesoadatos datos = new Accesoadatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Nombre = @Nombre, Codigo = @Codigo, Descripcion = @Descripcion, ImagenUrl = @ImagenUrl, IdCategoria = @IdCategoria, IdMarca = @IdMarca, Precio = @Precio where id = @id");
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Codigo", modificar.Codigo);
                datos.setearParametro("@Descripcion", modificar.Descripcion);
                datos.setearParametro("@ImagenUrl", modificar.ImagenUrl);
                datos.setearParametro("@IdCategoria", modificar.Categoria.Id);
                datos.setearParametro("@IdMarca", modificar.Marca.Id);
                datos.setearParametro("@id", modificar.Id);
                datos.setearParametro("@Precio", modificar.Precio);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }

        public List<Articulos> filtrar(string campo, string criterio, string filtro) 
        {
            List<Articulos> lista = new List<Articulos>();
            Accesoadatos datos = new Accesoadatos();
            try
            {
                string consulta = ("Select  Codigo, A.Id, Nombre, A.Descripcion, ImagenUrl, IdMarca, IdCategoria, C.Descripcion as Categoria, M.Descripcion as Marca, Precio From ARTICULOS A, CATEGORIAS C, MARCAS M where C.id = IdCategoria AND M.id = idMarca AND ");

                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Precio < " + filtro;
                            break;
                        default:
                            consulta += "Precio = " + filtro;
                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "M.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "M.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "M.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "C.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "C.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "C.Descripcion like '%" + filtro + "%'";
                            break;

                    }
                }

                    datos.setearConsulta(consulta);
                    datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("ImagenUrl"))))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
               

               
                return lista;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 

        public void eliminar(int id) 
        {
            try
            {
                Accesoadatos datos = new Accesoadatos();
                datos.setearConsulta("Delete From ARTICULOS where id = @id");
                datos.setearParametro("@id",id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }     
        }
    }
    
}
