using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinForm
{
     class ArticuloNegocio
    {
        public List<Articulo> listar()

        {

            List<Articulo> lista = new List<Articulo>(); // este método devuelve una lista


            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataReader lector;



            try

            {

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select A.Id, Codigo, Nombre, A.Descripcion, Precio, ImagenUrl, I.IdArticulo, C.Descripcion ,C.Id, M.Descripcion,M.Id \nFrom ARTICULOS A, IMAGENES I, CATEGORIAS C, MARCAS M \nWhere I.Id = A.Id AND C.Id = A.IdCategoria AND M.Id = A.IdMarca";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (Decimal)lector["Precio"];
                    aux.Imagen = new Imagen();
                    aux.Imagen.Url = (string)lector["ImagenUrl"];
                    aux.Imagen.IdArticulo = (int)lector["IdArticulo"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)lector["Descripcion"];
                    aux.Categoria.Id = (int)lector["Id"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Descripcion"];
                    aux.Marca.Id = (int)lector["Id"];

                    lista.Add(aux);
                }

                conexion.Close();

                return lista;

            }

            catch (Exception ex)

            {
                //MessageBox.Show("no funca");
                throw ex;

            }

        }

        public List<Marca> listarMarca()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From MARCAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

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

        public List<Categoria> listarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From CATEGORIAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

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

        public void modificar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio WHERE Id = @Id");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.ejecutarAccion();

                datos.ejecutarAccion();
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

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.ejecutarAccion();
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

