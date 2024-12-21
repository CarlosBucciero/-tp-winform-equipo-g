using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TP_WinForm
{
    public partial class frmAgregar : Form
    {
        private Articulo ArticuloNuevo = null;

        public frmAgregar()
        {
            InitializeComponent();
        }

        public frmAgregar(Articulo nuevo)
        {
            InitializeComponent();
            this.ArticuloNuevo = nuevo;
            Text = "Modificar Artículo";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (ArticuloNuevo == null)
                    ArticuloNuevo = new Articulo();
                ArticuloNuevo.Codigo = text_Codigo.Text;
                ArticuloNuevo.Nombre = text_Nombre.Text;
                ArticuloNuevo.Descripcion = text_Descripcion.Text;
                ArticuloNuevo.Marca = (Marca)cbo_Marca.SelectedItem;
                ArticuloNuevo.Categoria = (Categoria)cbo_Categoria.SelectedItem;
                if (decimal.TryParse(text_Precio.Text, out decimal precio))
                {
                    ArticuloNuevo.Precio = precio;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un precio válido.");
                    return;
                }
                if (ArticuloNuevo.Id != 0)
                {
                    negocio.modificar(ArticuloNuevo);
                    //negocio.agregarImagen(nuevo);
                    MessageBox.Show("Modificado exitosamente.");
                }
                else
                {
                    negocio.agregar(ArticuloNuevo);
                    // negocio.modificarImagen(nuevo);
                    MessageBox.Show("Agregado exitosamente.");
                }
                //Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {


            ArticuloNegocio MarcaCategoria = new ArticuloNegocio();
         
            try
            {
                cbo_Marca.DataSource = MarcaCategoria.listarMarca();
                cbo_Marca.ValueMember = "Id";
                cbo_Marca.DisplayMember = "Descripcion";
                cbo_Categoria.DataSource = MarcaCategoria.listarCategoria();
                cbo_Categoria.ValueMember = "Id";
                cbo_Categoria.DisplayMember = "Descripcion";
                if (ArticuloNuevo != null)
                {
                    text_Codigo.Text = ArticuloNuevo.Codigo;
                    text_Nombre.Text = ArticuloNuevo.Nombre;
                    text_Descripcion.Text = ArticuloNuevo.Descripcion;
                    text_Precio.Text = ArticuloNuevo.Precio.ToString();
                    text_ImagenUrl.Text = ArticuloNuevo.Imagen.Url;
                   
                    cbo_Marca.SelectedValue = ArticuloNuevo.Marca.Descripcion;
                    cbo_Categoria.SelectedValue = ArticuloNuevo.Categoria.Descripcion;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        

        
    }
}
