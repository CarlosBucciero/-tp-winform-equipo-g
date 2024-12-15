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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar ventanaAgregar = new frmAgregar();
            ventanaAgregar.ShowDialog();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar ventanaBuscar = new frmBuscar();
            ventanaBuscar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar ventanaEliminar = new frmEliminar();
            ventanaEliminar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificar ventanaModificar = new frmModificar();
            ventanaModificar.ShowDialog();
        }

     

        private void btn_Articulo_Click(object sender, EventArgs e)
        {
            frmArticulo ventana = new frmArticulo();
            ventana.ShowDialog();
        }
    }
}
