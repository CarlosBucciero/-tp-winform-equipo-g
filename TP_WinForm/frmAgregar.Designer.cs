namespace TP_WinForm
{
    partial class frmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            this.label1 = new System.Windows.Forms.Label();
            this.text_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_Descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_ImagenUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_Marca = new System.Windows.Forms.ComboBox();
            this.cbo_Categoria = new System.Windows.Forms.ComboBox();
            this.groupB = new System.Windows.Forms.GroupBox();
            this.text_Precio = new System.Windows.Forms.TextBox();
            this.text_Codigo = new System.Windows.Forms.TextBox();
            this.groupB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_Nombre
            // 
            this.text_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Nombre.Location = new System.Drawing.Point(193, 65);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.Size = new System.Drawing.Size(124, 29);
            this.text_Nombre.TabIndex = 2;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Agregar.FlatAppearance.BorderSize = 5;
            this.btn_Agregar.Location = new System.Drawing.Point(250, 303);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(125, 46);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción Producto";
            // 
            // text_Descripcion
            // 
            this.text_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Descripcion.Location = new System.Drawing.Point(193, 101);
            this.text_Descripcion.Name = "text_Descripcion";
            this.text_Descripcion.Size = new System.Drawing.Size(124, 29);
            this.text_Descripcion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marca Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoria Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Imagen Producto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // text_ImagenUrl
            // 
            this.text_ImagenUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ImagenUrl.Location = new System.Drawing.Point(193, 206);
            this.text_ImagenUrl.Name = "text_ImagenUrl";
            this.text_ImagenUrl.Size = new System.Drawing.Size(124, 29);
            this.text_ImagenUrl.TabIndex = 10;
            this.text_ImagenUrl.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Código Producto";
            // 
            // cbo_Marca
            // 
            this.cbo_Marca.FormattingEnabled = true;
            this.cbo_Marca.Location = new System.Drawing.Point(193, 137);
            this.cbo_Marca.Name = "cbo_Marca";
            this.cbo_Marca.Size = new System.Drawing.Size(124, 24);
            this.cbo_Marca.TabIndex = 16;
            // 
            // cbo_Categoria
            // 
            this.cbo_Categoria.FormattingEnabled = true;
            this.cbo_Categoria.Location = new System.Drawing.Point(193, 172);
            this.cbo_Categoria.Name = "cbo_Categoria";
            this.cbo_Categoria.Size = new System.Drawing.Size(124, 24);
            this.cbo_Categoria.TabIndex = 17;
            // 
            // groupB
            // 
            this.groupB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupB.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupB.Controls.Add(this.text_Precio);
            this.groupB.Controls.Add(this.text_Codigo);
            this.groupB.Controls.Add(this.cbo_Categoria);
            this.groupB.Controls.Add(this.cbo_Marca);
            this.groupB.Controls.Add(this.label7);
            this.groupB.Controls.Add(this.label6);
            this.groupB.Controls.Add(this.text_ImagenUrl);
            this.groupB.Controls.Add(this.label5);
            this.groupB.Controls.Add(this.label4);
            this.groupB.Controls.Add(this.label3);
            this.groupB.Controls.Add(this.text_Descripcion);
            this.groupB.Controls.Add(this.label2);
            this.groupB.Controls.Add(this.btn_Agregar);
            this.groupB.Controls.Add(this.text_Nombre);
            this.groupB.Controls.Add(this.label1);
            this.groupB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupB.Location = new System.Drawing.Point(331, 239);
            this.groupB.Name = "groupB";
            this.groupB.Size = new System.Drawing.Size(381, 355);
            this.groupB.TabIndex = 3;
            this.groupB.TabStop = false;
            this.groupB.Text = "PRODUCTO ";
            // 
            // text_Precio
            // 
            this.text_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Precio.Location = new System.Drawing.Point(193, 245);
            this.text_Precio.Name = "text_Precio";
            this.text_Precio.Size = new System.Drawing.Size(124, 29);
            this.text_Precio.TabIndex = 19;
            // 
            // text_Codigo
            // 
            this.text_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Codigo.Location = new System.Drawing.Point(193, 34);
            this.text_Codigo.Name = "text_Codigo";
            this.text_Codigo.Size = new System.Drawing.Size(124, 29);
            this.text_Codigo.TabIndex = 18;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 786);
            this.Controls.Add(this.groupB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.groupB.ResumeLayout(false);
            this.groupB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_ImagenUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_Marca;
        private System.Windows.Forms.ComboBox cbo_Categoria;
        private System.Windows.Forms.GroupBox groupB;
        private System.Windows.Forms.TextBox text_Precio;
        private System.Windows.Forms.TextBox text_Codigo;
    }
}