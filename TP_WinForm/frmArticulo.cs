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
    public partial class frmArticulo : Form
    {
        private List<Articulo> listaarticulo;

        public frmArticulo()
        {
            InitializeComponent();
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            ArticuloNegocio data = new ArticuloNegocio();
            listaarticulo = data.listar();
            dgv_Articulo.DataSource = listaarticulo;
            ocultarColummnas();
            cargarImagen(listaarticulo[0].Imagen.Url);
        }



        private void cargarImagen(string Imagen)
        {
            try
            {
                ptb_Articulo.Load(Imagen);
            }


            catch (Exception ex)
            {
                ptb_Articulo.Load("https://mimotic.com/wp-content/uploads/2020/03/error-en-composer-wp-cli.jpg");
            }
        }

        private void ocultarColummnas()
        {
            dgv_Articulo.Columns["Id"].Visible = false;
            dgv_Articulo.Columns["Imagen"].Visible = false;
            dgv_Articulo.Columns["Codigo"].Visible = false;
            dgv_Articulo.Columns["Marca"].Visible = false;
            dgv_Articulo.Columns["Categoria"].Visible = false;
        }

        private void dgv_Articulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgv_Articulo.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.Url);
        } 



    }
}


//