namespace TP_WinForm
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.btnAgregar_2 = new System.Windows.Forms.Button();
            this.btbBuscar_2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnModificar_2 = new System.Windows.Forms.Button();
            this.btnArticulo_2 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeArticulosToolStripMenuItem,
            this.agregarProductosToolStripMenuItem,
            this.eliminarProductosToolStripMenuItem,
            this.modificarProductosToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // listadoDeArticulosToolStripMenuItem
            // 
            this.listadoDeArticulosToolStripMenuItem.Name = "listadoDeArticulosToolStripMenuItem";
            this.listadoDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listadoDeArticulosToolStripMenuItem.Text = "Listado de Articulos";
            this.listadoDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // agregarProductosToolStripMenuItem
            // 
            this.agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
            this.agregarProductosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.agregarProductosToolStripMenuItem.Text = "Agregar Productos";
            this.agregarProductosToolStripMenuItem.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // eliminarProductosToolStripMenuItem
            // 
            this.eliminarProductosToolStripMenuItem.Name = "eliminarProductosToolStripMenuItem";
            this.eliminarProductosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.eliminarProductosToolStripMenuItem.Text = "Eliminar Productos";
            this.eliminarProductosToolStripMenuItem.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // modificarProductosToolStripMenuItem
            // 
            this.modificarProductosToolStripMenuItem.Name = "modificarProductosToolStripMenuItem";
            this.modificarProductosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.modificarProductosToolStripMenuItem.Text = "Modificar Productos";
            this.modificarProductosToolStripMenuItem.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnArticulo
            // 
            this.btnArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArticulo.BackColor = System.Drawing.SystemColors.Window;
            this.btnArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnArticulo.Image")));
            this.btnArticulo.Location = new System.Drawing.Point(416, 197);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(112, 91);
            this.btnArticulo.TabIndex = 1;
            this.btnArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArticulo.UseVisualStyleBackColor = false;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // btnAgregar_2
            // 
            this.btnAgregar_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar_2.Location = new System.Drawing.Point(196, 433);
            this.btnAgregar_2.Name = "btnAgregar_2";
            this.btnAgregar_2.Size = new System.Drawing.Size(106, 35);
            this.btnAgregar_2.TabIndex = 11;
            this.btnAgregar_2.Text = "AGREGAR ARTICULOS";
            this.btnAgregar_2.UseVisualStyleBackColor = false;
            this.btnAgregar_2.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btbBuscar_2
            // 
            this.btbBuscar_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btbBuscar_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btbBuscar_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbBuscar_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBuscar_2.Location = new System.Drawing.Point(644, 433);
            this.btbBuscar_2.Name = "btbBuscar_2";
            this.btbBuscar_2.Size = new System.Drawing.Size(112, 35);
            this.btbBuscar_2.TabIndex = 12;
            this.btbBuscar_2.Text = "BUSQUEDA DE ARTICULOS";
            this.btbBuscar_2.UseVisualStyleBackColor = false;
            this.btbBuscar_2.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(196, 602);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 37);
            this.button6.TabIndex = 13;
            this.button6.Text = "ELIMINAR ARTICULOS";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar_2
            // 
            this.btnModificar_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar_2.Location = new System.Drawing.Point(644, 600);
            this.btnModificar_2.Name = "btnModificar_2";
            this.btnModificar_2.Size = new System.Drawing.Size(112, 40);
            this.btnModificar_2.TabIndex = 14;
            this.btnModificar_2.Text = "MODICAR ARTICULOS";
            this.btnModificar_2.UseVisualStyleBackColor = false;
            this.btnModificar_2.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnArticulo_2
            // 
            this.btnArticulo_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArticulo_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnArticulo_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulo_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulo_2.Location = new System.Drawing.Point(416, 294);
            this.btnArticulo_2.Name = "btnArticulo_2";
            this.btnArticulo_2.Size = new System.Drawing.Size(112, 34);
            this.btnArticulo_2.TabIndex = 15;
            this.btnArticulo_2.Text = "LISTADO DE ARTICULOS";
            this.btnArticulo_2.UseVisualStyleBackColor = false;
            this.btnArticulo_2.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Lavender;
            this.btnEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(196, 506);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 91);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAgregar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(196, 328);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 99);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.Lavender;
            this.btnModificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(644, 506);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 92);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.TabStop = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(644, 328);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 99);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(154, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(641, 44);
            this.label8.TabIndex = 20;
            this.label8.Text = " SOFTWARE DE GESTIÓN COMERCIAL";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 790);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnArticulo_2);
            this.Controls.Add(this.btnModificar_2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btbBuscar_2);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAgregar_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.Button btnAgregar_2;
        private System.Windows.Forms.Button btbBuscar_2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnModificar_2;
        private System.Windows.Forms.Button btnArticulo_2;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.PictureBox btnModificar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem listadoDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductosToolStripMenuItem;
        private System.Windows.Forms.Label label8;
    }
}