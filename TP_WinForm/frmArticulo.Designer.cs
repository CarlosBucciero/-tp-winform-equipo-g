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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Articulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Articulo
            // 
            this.dgv_Articulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Articulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Articulo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Articulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Articulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulo.Location = new System.Drawing.Point(35, 53);
            this.dgv_Articulo.Name = "dgv_Articulo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Articulo.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Articulo.Size = new System.Drawing.Size(362, 245);
            this.dgv_Articulo.TabIndex = 0;
            this.dgv_Articulo.SelectionChanged += new System.EventHandler(this.dgv_Articulo_SelectionChanged);
            // 
            // ptb_Articulo
            // 
            this.ptb_Articulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Articulo.Location = new System.Drawing.Point(446, 53);
            this.ptb_Articulo.Name = "ptb_Articulo";
            this.ptb_Articulo.Size = new System.Drawing.Size(331, 306);
            this.ptb_Articulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Articulo.TabIndex = 1;
            this.ptb_Articulo.TabStop = false;
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptb_Articulo);
            this.Controls.Add(this.dgv_Articulo);
            this.Name = "frmArticulo";
            this.Text = "frmPrueba";
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Articulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Articulo;
        private System.Windows.Forms.PictureBox ptb_Articulo;
    }
}