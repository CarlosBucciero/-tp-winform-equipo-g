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
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.btnAgregar_2 = new System.Windows.Forms.Button();
            this.btnArticulo_2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
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
            this.btnArticulo.Location = new System.Drawing.Point(253, 238);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(112, 91);
            this.btnArticulo.TabIndex = 1;
            this.btnArticulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArticulo.UseVisualStyleBackColor = false;
            this.btnArticulo.Click += new System.EventHandler(this.btn_Articulo_Click);
            // 
            // btnAgregar_2
            // 
            this.btnAgregar_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar_2.Location = new System.Drawing.Point(451, 355);
            this.btnAgregar_2.Name = "btnAgregar_2";
            this.btnAgregar_2.Size = new System.Drawing.Size(106, 35);
            this.btnAgregar_2.TabIndex = 11;
            this.btnAgregar_2.Text = "AGREGAR ARTICULOS";
            this.btnAgregar_2.UseVisualStyleBackColor = false;
            this.btnAgregar_2.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnArticulo_2
            // 
            this.btnArticulo_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArticulo_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnArticulo_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulo_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulo_2.Location = new System.Drawing.Point(253, 356);
            this.btnArticulo_2.Name = "btnArticulo_2";
            this.btnArticulo_2.Size = new System.Drawing.Size(112, 34);
            this.btnArticulo_2.TabIndex = 15;
            this.btnArticulo_2.Text = "LISTADO DE ARTICULOS";
            this.btnArticulo_2.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnAgregar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(451, 238);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 99);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(108, 95);
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
            this.ClientSize = new System.Drawing.Size(868, 629);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnArticulo_2);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAgregar_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
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
        private System.Windows.Forms.Button btnArticulo_2;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.Label label8;
    }
}