namespace Taquilla
{
    partial class frm_peli1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_peli1));
            this.Lbl_misionDescripcion = new System.Windows.Forms.Label();
            this.Lbl_misionSinopsis = new System.Windows.Forms.Label();
            this.Lbl_misionHora = new System.Windows.Forms.Label();
            this.Lbl_misionCasificacion = new System.Windows.Forms.Label();
            this.Lbl_misionFecha = new System.Windows.Forms.Label();
            this.Lbl_misionTitulo = new System.Windows.Forms.Label();
            this.Pic_imagen = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Btn_misionSalir = new System.Windows.Forms.Button();
            this.Panel_abajo = new System.Windows.Forms.Panel();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.Btn_misionTrailer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagen)).BeginInit();
            this.Panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_misionDescripcion
            // 
            this.Lbl_misionDescripcion.AutoSize = true;
            this.Lbl_misionDescripcion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_misionDescripcion.Location = new System.Drawing.Point(-1, 319);
            this.Lbl_misionDescripcion.Name = "Lbl_misionDescripcion";
            this.Lbl_misionDescripcion.Size = new System.Drawing.Size(692, 102);
            this.Lbl_misionDescripcion.TabIndex = 15;
            this.Lbl_misionDescripcion.Text = resources.GetString("Lbl_misionDescripcion.Text");
            // 
            // Lbl_misionSinopsis
            // 
            this.Lbl_misionSinopsis.AutoSize = true;
            this.Lbl_misionSinopsis.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_misionSinopsis.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_misionSinopsis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Lbl_misionSinopsis.Location = new System.Drawing.Point(325, 291);
            this.Lbl_misionSinopsis.Name = "Lbl_misionSinopsis";
            this.Lbl_misionSinopsis.Size = new System.Drawing.Size(67, 17);
            this.Lbl_misionSinopsis.TabIndex = 14;
            this.Lbl_misionSinopsis.Text = "Sinopsis";
            // 
            // Lbl_misionHora
            // 
            this.Lbl_misionHora.AutoSize = true;
            this.Lbl_misionHora.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_misionHora.Location = new System.Drawing.Point(360, 208);
            this.Lbl_misionHora.Name = "Lbl_misionHora";
            this.Lbl_misionHora.Size = new System.Drawing.Size(32, 17);
            this.Lbl_misionHora.TabIndex = 13;
            this.Lbl_misionHora.Text = "147";
            // 
            // Lbl_misionCasificacion
            // 
            this.Lbl_misionCasificacion.AutoSize = true;
            this.Lbl_misionCasificacion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_misionCasificacion.Location = new System.Drawing.Point(291, 208);
            this.Lbl_misionCasificacion.Name = "Lbl_misionCasificacion";
            this.Lbl_misionCasificacion.Size = new System.Drawing.Size(33, 17);
            this.Lbl_misionCasificacion.TabIndex = 12;
            this.Lbl_misionCasificacion.Text = "B15";
            this.toolTip1.SetToolTip(this.Lbl_misionCasificacion, "No apto para menores de 15 años");
            // 
            // Lbl_misionFecha
            // 
            this.Lbl_misionFecha.AutoSize = true;
            this.Lbl_misionFecha.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_misionFecha.Location = new System.Drawing.Point(278, 152);
            this.Lbl_misionFecha.Name = "Lbl_misionFecha";
            this.Lbl_misionFecha.Size = new System.Drawing.Size(268, 17);
            this.Lbl_misionFecha.TabIndex = 11;
            this.Lbl_misionFecha.Text = "Fecha de Estreno: Jueves, 26 de julio";
            // 
            // Lbl_misionTitulo
            // 
            this.Lbl_misionTitulo.AutoSize = true;
            this.Lbl_misionTitulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_misionTitulo.Location = new System.Drawing.Point(294, 79);
            this.Lbl_misionTitulo.Name = "Lbl_misionTitulo";
            this.Lbl_misionTitulo.Size = new System.Drawing.Size(230, 17);
            this.Lbl_misionTitulo.TabIndex = 10;
            this.Lbl_misionTitulo.Text = "Misión Imposible: Repercución";
            // 
            // Pic_imagen
            // 
            this.Pic_imagen.Image = global::Taquilla.Properties.Resources.Mision_Imposible;
            this.Pic_imagen.Location = new System.Drawing.Point(26, 66);
            this.Pic_imagen.Name = "Pic_imagen";
            this.Pic_imagen.Size = new System.Drawing.Size(175, 216);
            this.Pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_imagen.TabIndex = 9;
            this.Pic_imagen.TabStop = false;
            // 
            // Btn_misionSalir
            // 
            this.Btn_misionSalir.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_misionSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_misionSalir.Image")));
            this.Btn_misionSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_misionSalir.Location = new System.Drawing.Point(587, 419);
            this.Btn_misionSalir.Name = "Btn_misionSalir";
            this.Btn_misionSalir.Size = new System.Drawing.Size(93, 41);
            this.Btn_misionSalir.TabIndex = 47;
            this.Btn_misionSalir.Text = "SALIR";
            this.Btn_misionSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_misionSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_misionSalir.UseVisualStyleBackColor = true;
            this.Btn_misionSalir.Click += new System.EventHandler(this.Btn_misionSalir_Click);
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
            // Btn_misionTrailer
            // 
            this.Btn_misionTrailer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_misionTrailer.Image = ((System.Drawing.Image)(resources.GetObject("Btn_misionTrailer.Image")));
            this.Btn_misionTrailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_misionTrailer.Location = new System.Drawing.Point(415, 195);
            this.Btn_misionTrailer.Name = "Btn_misionTrailer";
            this.Btn_misionTrailer.Size = new System.Drawing.Size(146, 43);
            this.Btn_misionTrailer.TabIndex = 46;
            this.Btn_misionTrailer.Text = "VER TRAILER";
            this.Btn_misionTrailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_misionTrailer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_misionTrailer.UseVisualStyleBackColor = true;
            // 
            // frm_peli1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(684, 487);
            this.Controls.Add(this.Btn_misionSalir);
            this.Controls.Add(this.Panel_abajo);
            this.Controls.Add(this.Panel_arriba);
            this.Controls.Add(this.Btn_misionTrailer);
            this.Controls.Add(this.Lbl_misionDescripcion);
            this.Controls.Add(this.Lbl_misionSinopsis);
            this.Controls.Add(this.Lbl_misionHora);
            this.Controls.Add(this.Lbl_misionCasificacion);
            this.Controls.Add(this.Lbl_misionFecha);
            this.Controls.Add(this.Lbl_misionTitulo);
            this.Controls.Add(this.Pic_imagen);
            this.Name = "frm_peli1";
            this.Text = "MISION IMPOSIBLE REPERCUSION ";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagen)).EndInit();
            this.Panel_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_misionDescripcion;
        private System.Windows.Forms.Label Lbl_misionSinopsis;
        private System.Windows.Forms.Label Lbl_misionHora;
        private System.Windows.Forms.Label Lbl_misionCasificacion;
        private System.Windows.Forms.Label Lbl_misionFecha;
        private System.Windows.Forms.Label Lbl_misionTitulo;
        private System.Windows.Forms.PictureBox Pic_imagen;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Btn_misionSalir;
        private System.Windows.Forms.Panel Panel_abajo;
        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.PictureBox Pic_logo;
        private System.Windows.Forms.Button Btn_misionTrailer;
    }
}