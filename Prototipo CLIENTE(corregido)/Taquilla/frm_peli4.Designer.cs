namespace Taquilla
{
    partial class frm_peli4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_peli4));
            this.Lbl_hotelDescripcion = new System.Windows.Forms.Label();
            this.Lbl_hotelSinopsis = new System.Windows.Forms.Label();
            this.Lbl_hotelHora = new System.Windows.Forms.Label();
            this.Lbl_hotelClasificacion = new System.Windows.Forms.Label();
            this.Lbl_hotelFecha = new System.Windows.Forms.Label();
            this.Lbl_hotelTitulo = new System.Windows.Forms.Label();
            this.Pic_imagen = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_hotelSalir = new System.Windows.Forms.Button();
            this.Panel_abajo = new System.Windows.Forms.Panel();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.Btn_hotelTrailer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagen)).BeginInit();
            this.Panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_hotelDescripcion
            // 
            this.Lbl_hotelDescripcion.AutoSize = true;
            this.Lbl_hotelDescripcion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hotelDescripcion.Location = new System.Drawing.Point(9, 280);
            this.Lbl_hotelDescripcion.Name = "Lbl_hotelDescripcion";
            this.Lbl_hotelDescripcion.Size = new System.Drawing.Size(674, 136);
            this.Lbl_hotelDescripcion.TabIndex = 23;
            this.Lbl_hotelDescripcion.Text = resources.GetString("Lbl_hotelDescripcion.Text");
            this.Lbl_hotelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_hotelDescripcion.Click += new System.EventHandler(this.Lbl6_Click);
            // 
            // Lbl_hotelSinopsis
            // 
            this.Lbl_hotelSinopsis.AutoSize = true;
            this.Lbl_hotelSinopsis.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_hotelSinopsis.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hotelSinopsis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Lbl_hotelSinopsis.Location = new System.Drawing.Point(329, 252);
            this.Lbl_hotelSinopsis.Name = "Lbl_hotelSinopsis";
            this.Lbl_hotelSinopsis.Size = new System.Drawing.Size(67, 17);
            this.Lbl_hotelSinopsis.TabIndex = 22;
            this.Lbl_hotelSinopsis.Text = "Sinopsis";
            // 
            // Lbl_hotelHora
            // 
            this.Lbl_hotelHora.AutoSize = true;
            this.Lbl_hotelHora.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hotelHora.Location = new System.Drawing.Point(346, 188);
            this.Lbl_hotelHora.Name = "Lbl_hotelHora";
            this.Lbl_hotelHora.Size = new System.Drawing.Size(32, 17);
            this.Lbl_hotelHora.TabIndex = 20;
            this.Lbl_hotelHora.Text = "100";
            // 
            // Lbl_hotelClasificacion
            // 
            this.Lbl_hotelClasificacion.AutoSize = true;
            this.Lbl_hotelClasificacion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hotelClasificacion.Location = new System.Drawing.Point(277, 188);
            this.Lbl_hotelClasificacion.Name = "Lbl_hotelClasificacion";
            this.Lbl_hotelClasificacion.Size = new System.Drawing.Size(18, 17);
            this.Lbl_hotelClasificacion.TabIndex = 19;
            this.Lbl_hotelClasificacion.Text = "A";
            this.toolTip1.SetToolTip(this.Lbl_hotelClasificacion, "Apta para todo el público");
            // 
            // Lbl_hotelFecha
            // 
            this.Lbl_hotelFecha.AutoSize = true;
            this.Lbl_hotelFecha.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hotelFecha.Location = new System.Drawing.Point(286, 141);
            this.Lbl_hotelFecha.Name = "Lbl_hotelFecha";
            this.Lbl_hotelFecha.Size = new System.Drawing.Size(274, 17);
            this.Lbl_hotelFecha.TabIndex = 18;
            this.Lbl_hotelFecha.Text = "Fecha de Estreno: Jueves, 2 de agosto";
            // 
            // Lbl_hotelTitulo
            // 
            this.Lbl_hotelTitulo.AutoSize = true;
            this.Lbl_hotelTitulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hotelTitulo.Location = new System.Drawing.Point(351, 72);
            this.Lbl_hotelTitulo.Name = "Lbl_hotelTitulo";
            this.Lbl_hotelTitulo.Size = new System.Drawing.Size(150, 17);
            this.Lbl_hotelTitulo.TabIndex = 17;
            this.Lbl_hotelTitulo.Text = "Hotel Transilvania 3";
            // 
            // Pic_imagen
            // 
            this.Pic_imagen.Image = global::Taquilla.Properties.Resources.Hotel;
            this.Pic_imagen.Location = new System.Drawing.Point(34, 58);
            this.Pic_imagen.Name = "Pic_imagen";
            this.Pic_imagen.Size = new System.Drawing.Size(160, 207);
            this.Pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_imagen.TabIndex = 16;
            this.Pic_imagen.TabStop = false;
            // 
            // Btn_hotelSalir
            // 
            this.Btn_hotelSalir.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_hotelSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_hotelSalir.Image")));
            this.Btn_hotelSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_hotelSalir.Location = new System.Drawing.Point(587, 419);
            this.Btn_hotelSalir.Name = "Btn_hotelSalir";
            this.Btn_hotelSalir.Size = new System.Drawing.Size(93, 41);
            this.Btn_hotelSalir.TabIndex = 47;
            this.Btn_hotelSalir.Text = "SALIR";
            this.Btn_hotelSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_hotelSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_hotelSalir.UseVisualStyleBackColor = true;
            this.Btn_hotelSalir.Click += new System.EventHandler(this.Btn_hotelSalir_Click);
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
            // Btn_hotelTrailer
            // 
            this.Btn_hotelTrailer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_hotelTrailer.Image = ((System.Drawing.Image)(resources.GetObject("Btn_hotelTrailer.Image")));
            this.Btn_hotelTrailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_hotelTrailer.Location = new System.Drawing.Point(437, 175);
            this.Btn_hotelTrailer.Name = "Btn_hotelTrailer";
            this.Btn_hotelTrailer.Size = new System.Drawing.Size(146, 43);
            this.Btn_hotelTrailer.TabIndex = 46;
            this.Btn_hotelTrailer.Text = "VER TRAILER";
            this.Btn_hotelTrailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_hotelTrailer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_hotelTrailer.UseVisualStyleBackColor = true;
            // 
            // frm_peli4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 487);
            this.Controls.Add(this.Btn_hotelSalir);
            this.Controls.Add(this.Panel_abajo);
            this.Controls.Add(this.Panel_arriba);
            this.Controls.Add(this.Btn_hotelTrailer);
            this.Controls.Add(this.Lbl_hotelDescripcion);
            this.Controls.Add(this.Lbl_hotelSinopsis);
            this.Controls.Add(this.Lbl_hotelHora);
            this.Controls.Add(this.Lbl_hotelClasificacion);
            this.Controls.Add(this.Lbl_hotelFecha);
            this.Controls.Add(this.Lbl_hotelTitulo);
            this.Controls.Add(this.Pic_imagen);
            this.Name = "frm_peli4";
            this.Text = "HOTEL TRANSILVANIA 3";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagen)).EndInit();
            this.Panel_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_hotelDescripcion;
        private System.Windows.Forms.Label Lbl_hotelSinopsis;
        private System.Windows.Forms.Label Lbl_hotelHora;
        private System.Windows.Forms.Label Lbl_hotelClasificacion;
        private System.Windows.Forms.Label Lbl_hotelFecha;
        private System.Windows.Forms.Label Lbl_hotelTitulo;
        private System.Windows.Forms.PictureBox Pic_imagen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Btn_hotelSalir;
        private System.Windows.Forms.Panel Panel_abajo;
        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.PictureBox Pic_logo;
        private System.Windows.Forms.Button Btn_hotelTrailer;
    }
}