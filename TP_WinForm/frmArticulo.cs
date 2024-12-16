using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ArticuloData data = new ArticuloData();
            listaarticulo = data.listar();
            dgv_Articulo.DataSource = listaarticulo;
            cargarImagen(listaarticulo[0].ImagenUrl);
        }

        private void dgv_Articulo_SelectionChanged(object sender, EventArgs e)
        {
           Articulo seleccionado = (Articulo)dgv_Articulo.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                ptb_Articulo.Load(imagen);
            }
            catch (Exception ex)
            {

                ptb_Articulo.Load("https://mimotic.com/wp-content/uploads/2020/03/error-en-composer-wp-cli.jpg");
            }
        }
    }
}
