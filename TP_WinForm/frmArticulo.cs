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

            cbo_Campo.Items.Add("Número");
            cbo_Campo.Items.Add("Nombre");
            cbo_Campo.Items.Add("Precio");
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaarticulo = negocio.listar();
                dgv_Articulo.DataSource = listaarticulo;
                ocultarColummnas();
                cargarImagen(listaarticulo[0].Imagen.Url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            if (dgv_Articulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgv_Articulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen.Url);
            }
        }

       

        private void btn_Modificar_Click_1(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgv_Articulo.CurrentRow.DataBoundItem;

            frmAgregar modificar = new frmAgregar(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

   

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminar el articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgv_Articulo.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void text_FiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = text_FiltroRapido.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaarticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaarticulo;
            }
            dgv_Articulo.DataSource = null;
            dgv_Articulo.DataSource = listaFiltrada;
            ocultarColummnas();
        }



        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string campo = cbo_Campo.SelectedItem.ToString();
                string criterio = cbo_Criterio.SelectedItem.ToString();
                string filtro = text_FiltroAvanzando.Text;
                dgv_Articulo.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void cbo_Campo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbo_Campo.SelectedItem.ToString();
            if (opcion == "Número")
            {
                cbo_Criterio.Items.Clear();
                cbo_Criterio.Items.Add("Mayor a");
                cbo_Criterio.Items.Add("Menor a");
                cbo_Criterio.Items.Add("Igual a");

            }
            else if (opcion == "Nombre")
            {
                cbo_Criterio.Items.Clear();
                cbo_Criterio.Items.Add("Comienza con");
                cbo_Criterio.Items.Add("Termina con");
                cbo_Criterio.Items.Add("Contiene");
            }
            else if (opcion == "Precio")
            {
                cbo_Criterio.Items.Add("Mayor a");
                cbo_Criterio.Items.Add("Menor a");
                cbo_Criterio.Items.Add("Igual a");
            }
        }
    }
    }



//