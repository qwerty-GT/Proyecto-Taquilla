namespace Taquilla
{
    partial class frm_peli5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_peli5));
            this.Lbl_purgaDescripcion = new System.Windows.Forms.Label();
            this.Lbl_purgaSinopsis = new System.Windows.Forms.Label();
            this.Lbl_purgaClasificacion = new System.Windows.Forms.Label();
            this.Lbl_purgaFecha = new System.Windows.Forms.Label();
            this.Pic_imagen = new System.Windows.Forms.PictureBox();
            this.Lbl_purgaHora = new System.Windows.Forms.Label();
            this.Lbl_purgaTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_purgaSalir = new System.Windows.Forms.Button();
            this.Panel_abajo = new System.Windows.Forms.Panel();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.Btn_purgaTrailer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagen)).BeginInit();
            this.Panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_purgaDescripcion
            // 
            this.Lbl_purgaDescripcion.AutoSize = true;
            this.Lbl_purgaDescripcion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_purgaDescripcion.Location = new System.Drawing.Point(5, 314);
            this.Lbl_purgaDescripcion.Name = "Lbl_purgaDescripcion";
            this.Lbl_purgaDescripcion.Size = new System.Drawing.Size(680, 102);
            this.Lbl_purgaDescripcion.TabIndex = 20;
            this.Lbl_purgaDescripcion.Text = resources.GetString("Lbl_purgaDescripcion.Text");
            // 
            // Lbl_purgaSinopsis
            // 
            this.Lbl_purgaSinopsis.AutoSize = true;
            this.Lbl_purgaSinopsis.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_purgaSinopsis.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_purgaSinopsis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Lbl_purgaSinopsis.Location = new System.Drawing.Point(324, 274);
            this.Lbl_purgaSinopsis.Name = "Lbl_purgaSinopsis";
            this.Lbl_purgaSinopsis.Size = new System.Drawing.Size(67, 17);
            this.Lbl_purgaSinopsis.TabIndex = 19;
            this.Lbl_purgaSinopsis.Text = "Sinopsis";
            // 
            // Lbl_purgaClasificacion
            // 
            this.Lbl_purgaClasificacion.AutoSize = true;
            this.Lbl_purgaClasificacion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_purgaClasificacion.Location = new System.Drawing.Point(266, 195);
            this.Lbl_purgaClasificacion.Name = "Lbl_purgaClasificacion";
            this.Lbl_purgaClasificacion.Size = new System.Drawing.Size(17, 17);
            this.Lbl_purgaClasificacion.TabIndex = 18;
            this.Lbl_purgaClasificacion.Text = "R";
            this.toolTip1.SetToolTip(this.Lbl_purgaClasificacion, "No apto para menores de 18 años");
            this.Lbl_purgaClasificacion.Click += new System.EventHandler(this.Lbl_clasificacion_Click);
            // 
            // Lbl_purgaFecha
            // 
            this.Lbl_purgaFecha.AutoSize = true;
            this.Lbl_purgaFecha.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_purgaFecha.Location = new System.Drawing.Point(243, 158);
            this.Lbl_purgaFecha.Name = "Lbl_purgaFecha";
            this.Lbl_purgaFecha.Size = new System.Drawing.Size(282, 17);
            this.Lbl_purgaFecha.TabIndex = 17;
            this.Lbl_purgaFecha.Text = "Fecha de Estreno: Jueves, 23 de agosto";
            // 
            // Pic_imagen
            // 
            this.Pic_imagen.Image = global::Taquilla.Properties.Resources.purga;
            this.Pic_imagen.Location = new System.Drawing.Point(24, 61);
            this.Pic_imagen.Name = "Pic_imagen";
            this.Pic_imagen.Size = new System.Drawing.Size(160, 207);
            this.Pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_imagen.TabIndex = 16;
            this.Pic_imagen.TabStop = false;
            // 
            // Lbl_purgaHora
            // 
            this.Lbl_purgaHora.AutoSize = true;
            this.Lbl_purgaHora.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_purgaHora.Location = new System.Drawing.Point(343, 195);
            this.Lbl_purgaHora.Name = "Lbl_purgaHora";
            this.Lbl_purgaHora.Size = new System.Drawing.Size(32, 17);
            this.Lbl_purgaHora.TabIndex = 21;
            this.Lbl_purgaHora.Text = "120";
            // 
            // Lbl_purgaTitulo
            // 
            this.Lbl_purgaTitulo.AutoSize = true;
            this.Lbl_purgaTitulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_purgaTitulo.Location = new System.Drawing.Point(369, 91);
            this.Lbl_purgaTitulo.Name = "Lbl_purgaTitulo";
            this.Lbl_purgaTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_purgaTitulo.Size = new System.Drawing.Size(93, 17);
            this.Lbl_purgaTitulo.TabIndex = 23;
            this.Lbl_purgaTitulo.Text = "The Purge 4";
            // 
            // Btn_purgaSalir
            // 
            this.Btn_purgaSalir.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_purgaSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_purgaSalir.Image")));
            this.Btn_purgaSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_purgaSalir.Location = new System.Drawing.Point(587, 419);
            this.Btn_purgaSalir.Name = "Btn_purgaSalir";
            this.Btn_purgaSalir.Size = new System.Drawing.Size(93, 41);
            this.Btn_purgaSalir.TabIndex = 47;
            this.Btn_purgaSalir.Text = "SALIR";
            this.Btn_purgaSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_purgaSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_purgaSalir.UseVisualStyleBackColor = true;
            this.Btn_purgaSalir.Click += new System.EventHandler(this.Btn_purgaSalir_Click);
            // 
            // Panel_abajo
            // 
            this.Panel_abajo.BackColor = System.Drawing.Color.Yellow;
            this.Panel_abajo.Location = new System.Drawing.Point(2, 466);
            this.Panel_abajo.Name = "Panel_abajo";
            this.Panel_abajo.Size = new System.Drawing.Size(681, 41);
            this.Panel_abajo.TabIndex = 49;
            // 
            // Panel_arriba
            // 
            this.Panel_arriba.BackColor = System.Drawing.Color.Yellow;
            this.Panel_arriba.Controls.Add(this.Pic_logo);
            this.Panel_arriba.Location = new System.Drawing.Point(2, 4);
            this.Panel_arriba.Name = "Panel_arriba";
            this.Panel_arriba.Size = new System.Drawing.Size(681, 41);
            this.Panel_arriba.TabIndex = 48;
            // 
            // Pic_logo
            // 
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(6, 3);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(91, 38);
            this.Pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_logo.TabIndex = 0;
            this.Pic_logo.TabStop = false;
            // 
            // Btn_purgaTrailer
            // 
            this.Btn_purgaTrailer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_purgaTrailer.Image = ((System.Drawing.Image)(resources.GetObject("Btn_purgaTrailer.Image")));
            this.Btn_purgaTrailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_purgaTrailer.Location = new System.Drawing.Point(415, 195);
            this.Btn_purgaTrailer.Name = "Btn_purgaTrailer";
            this.Btn_purgaTrailer.Size = new System.Drawing.Size(146, 43);
            this.Btn_purgaTrailer.TabIndex = 46;
            this.Btn_purgaTrailer.Text = "VER TRAILER";
            this.Btn_purgaTrailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_purgaTrailer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_purgaTrailer.UseVisualStyleBackColor = true;
            // 
            // frm_peli5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 487);
            this.Controls.Add(this.Btn_purgaSalir);
            this.Controls.Add(this.Panel_abajo);
            this.Controls.Add(this.Panel_arriba);
            this.Controls.Add(this.Btn_purgaTrailer);
            this.Controls.Add(this.Lbl_purgaTitulo);
            this.Controls.Add(this.Lbl_purgaHora);
            this.Controls.Add(this.Lbl_purgaDescripcion);
            this.Controls.Add(this.Lbl_purgaSinopsis);
            this.Controls.Add(this.Lbl_purgaClasificacion);
            this.Controls.Add(this.Lbl_purgaFecha);
            this.Controls.Add(this.Pic_imagen);
            this.Name = "frm_peli5";
            this.Text = "THE PURGE 4";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagen)).EndInit();
            this.Panel_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_purgaDescripcion;
        private System.Windows.Forms.Label Lbl_purgaSinopsis;
        private System.Windows.Forms.Label Lbl_purgaClasificacion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Lbl_purgaFecha;
        private System.Windows.Forms.PictureBox Pic_imagen;
        private System.Windows.Forms.Label Lbl_purgaHora;
        private System.Windows.Forms.Label Lbl_purgaTitulo;
        private System.Windows.Forms.Button Btn_purgaSalir;
        private System.Windows.Forms.Panel Panel_abajo;
        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.PictureBox Pic_logo;
        private System.Windows.Forms.Button Btn_purgaTrailer;
    }
}