using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinForm
{
     class ArticuloData
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
                comando.CommandText = "Select Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio, ImagenUrl From ARTICULOS A, IMAGENES I Where I.Id = A.Id";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.IdMarca = (int)lector["IdMarca"];
                    aux.IdCategoria = (int)lector["IdCategoria"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];

                    lista.Add(aux);
                }

                conexion.Close();

                return lista;

            }

            catch (Exception ex)

            {
                MessageBox.Show("no funca");
                throw ex;

            }

        }
    }
}

