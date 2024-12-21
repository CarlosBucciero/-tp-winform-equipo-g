namespace TP_WinForm
{
    partial class frmArticulo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulo));
            this.dgv_Articulo = new System.Windows.Forms.DataGridView();
            this.ptb_Articulo = new System.Windows.Forms.PictureBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.text_FiltroRapido = new System.Windows.Forms.TextBox();
            this.CAMPO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CRITERIO = new System.Windows.Forms.Label();
            this.cbo_Criterio = new System.Windows.Forms.ComboBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cbo_Campo = new System.Windows.Forms.ComboBox();
            this.text_FiltroAvanzando = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Articulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Articulo
            // 
            this.dgv_Articulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Articulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Articulo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_Articulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulo.Location = new System.Drawing.Point(44, 103);
            this.dgv_Articulo.Name = "dgv_Articulo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Articulo.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Articulo.Size = new System.Drawing.Size(422, 280);
            this.dgv_Articulo.TabIndex = 0;
            this.dgv_Articulo.SelectionChanged += new System.EventHandler(this.dgv_Articulo_SelectionChanged);
            // 
            // ptb_Articulo
            // 
            this.ptb_Articulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Articulo.Location = new System.Drawing.Point(501, 103);
            this.ptb_Articulo.Name = "ptb_Articulo";
            this.ptb_Articulo.Size = new System.Drawing.Size(302, 280);
            this.ptb_Articulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Articulo.TabIndex = 1;
            this.ptb_Articulo.TabStop = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(83, 409);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(106, 45);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click_1);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(279, 409);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(119, 45);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "ELiminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filtro.Location = new System.Drawing.Point(25, 67);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(72, 20);
            this.lbl_Filtro.TabIndex = 4;
            this.lbl_Filtro.Text = "FILTRO";
            // 
            // text_FiltroRapido
            // 
            this.text_FiltroRapido.Location = new System.Drawing.Point(103, 67);
            this.text_FiltroRapido.Name = "text_FiltroRapido";
            this.text_FiltroRapido.Size = new System.Drawing.Size(363, 20);
            this.text_FiltroRapido.TabIndex = 5;
            this.text_FiltroRapido.TextChanged += new System.EventHandler(this.text_FiltroRapido_TextChanged);
            // 
            // CAMPO
            // 
            this.CAMPO.AutoSize = true;
            this.CAMPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAMPO.Location = new System.Drawing.Point(54, 516);
            this.CAMPO.Name = "CAMPO";
            this.CAMPO.Size = new System.Drawing.Size(71, 20);
            this.CAMPO.TabIndex = 6;
            this.CAMPO.Text = "CAMPO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "FILTRO AVANZADO";
            // 
            // CRITERIO
            // 
            this.CRITERIO.AutoSize = true;
            this.CRITERIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRITERIO.Location = new System.Drawing.Point(54, 545);
            this.CRITERIO.Name = "CRITERIO";
            this.CRITERIO.Size = new System.Drawing.Size(94, 20);
            this.CRITERIO.TabIndex = 8;
            this.CRITERIO.Text = "CRITERIO";
            // 
            // cbo_Criterio
            // 
            this.cbo_Criterio.FormattingEnabled = true;
            this.cbo_Criterio.Location = new System.Drawing.Point(250, 546);
            this.cbo_Criterio.Name = "cbo_Criterio";
            this.cbo_Criterio.Size = new System.Drawing.Size(177, 21);
            this.cbo_Criterio.TabIndex = 10;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(468, 533);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(119, 45);
            this.btn_Buscar.TabIndex = 12;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // cbo_Campo
            // 
            this.cbo_Campo.FormattingEnabled = true;
            this.cbo_Campo.Location = new System.Drawing.Point(250, 515);
            this.cbo_Campo.Name = "cbo_Campo";
            this.cbo_Campo.Size = new System.Drawing.Size(177, 21);
            this.cbo_Campo.TabIndex = 13;
            this.cbo_Campo.SelectedIndexChanged += new System.EventHandler(this.cbo_Campo_SelectedIndexChanged);
            // 
            // text_FiltroAvanzando
            // 
            this.text_FiltroAvanzando.Location = new System.Drawing.Point(250, 576);
            this.text_FiltroAvanzando.Name = "text_FiltroAvanzando";
            this.text_FiltroAvanzando.Size = new System.Drawing.Size(177, 20);
            this.text_FiltroAvanzando.TabIndex = 14;
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 629);
            this.Controls.Add(this.text_FiltroAvanzando);
            this.Controls.Add(this.cbo_Campo);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.cbo_Criterio);
            this.Controls.Add(this.CRITERIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CAMPO);
            this.Controls.Add(this.text_FiltroRapido);
            this.Controls.Add(this.lbl_Filtro);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.ptb_Articulo);
            this.Controls.Add(this.dgv_Articulo);
            this.Name = "frmArticulo";
            this.Text = "frmPrueba";
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Articulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Articulo;
        private System.Windows.Forms.PictureBox ptb_Articulo;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.TextBox text_FiltroRapido;
        private System.Windows.Forms.Label CAMPO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CRITERIO;
        private System.Windows.Forms.ComboBox cbo_Criterio;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cbo_Campo;
        private System.Windows.Forms.TextBox text_FiltroAvanzando;
    }
}