﻿using System;
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

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            vtn_Articulos ventana = new vtn_Articulos();
            ventana.ShowDialog();
        }
    }
}