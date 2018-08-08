namespace LICAS
{
    partial class frm_estrenos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_estrenos));
            this.Txt_Sinopsis = new System.Windows.Forms.TextBox();
            this.Cbo_peliculas = new System.Windows.Forms.ComboBox();
            this.Btn_misionSalir = new System.Windows.Forms.Button();
            this.Panel_abajo = new System.Windows.Forms.Panel();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.Btn_Trailer = new System.Windows.Forms.Button();
            this.Lbl_tituloSinopsis = new System.Windows.Forms.Label();
            this.Lbl_Clasificacion = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Pic_imagen = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Sinopsis
            // 
            this.Txt_Sinopsis.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_Sinopsis.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.Txt_Sinopsis.Location = new System.Drawing.Point(52, 317);
            this.Txt_Sinopsis.Multiline = true;
            this.Txt_Sinopsis.Name = "Txt_Sinopsis";
            this.Txt_Sinopsis.Size = new System.Drawing.Size(569, 126);
            this.Txt_Sinopsis.TabIndex = 61;
            this.Txt_Sinopsis.Visible = false;
            // 
            // Cbo_peliculas
            // 
            this.Cbo_peliculas.FormattingEnabled = true;
            this.Cbo_peliculas.Location = new System.Drawing.Point(52, 76);
            this.Cbo_peliculas.Name = "Cbo_peliculas";
            this.Cbo_peliculas.Size = new System.Drawing.Size(121, 21);
            this.Cbo_peliculas.TabIndex = 60;
            this.Cbo_peliculas.Text = "SELECCIONE...";
            this.Cbo_peliculas.SelectedIndexChanged += new System.EventHandler(this.Cbo_peliculas_SelectedIndexChanged);
            // 
            // Btn_misionSalir
            // 
            this.Btn_misionSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_misionSalir.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_misionSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_misionSalir.Image")));
            this.Btn_misionSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_misionSalir.Location = new System.Drawing.Point(579, 468);
            this.Btn_misionSalir.Name = "Btn_misionSalir";
            this.Btn_misionSalir.Size = new System.Drawing.Size(93, 41);
            this.Btn_misionSalir.TabIndex = 57;
            this.Btn_misionSalir.Text = "SALIR";
            this.Btn_misionSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_misionSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_misionSalir.UseVisualStyleBackColor = true;
            this.Btn_misionSalir.Click += new System.EventHandler(this.Btn_misionSalir_Click);
            // 
            // Panel_abajo
            // 
            this.Panel_abajo.BackColor = System.Drawing.Color.Yellow;
            this.Panel_abajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_abajo.Location = new System.Drawing.Point(0, 515);
            this.Panel_abajo.Name = "Panel_abajo";
            this.Panel_abajo.Size = new System.Drawing.Size(684, 41);
            this.Panel_abajo.TabIndex = 59;
            // 
            // Panel_arriba
            // 
            this.Panel_arriba.BackColor = System.Drawing.Color.Yellow;
            this.Panel_arriba.Controls.Add(this.Pic_logo);
            this.Panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.Panel_arriba.Name = "Panel_arriba";
            this.Panel_arriba.Size = new System.Drawing.Size(684, 41);
            this.Panel_arriba.TabIndex = 58;
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
            // Btn_Trailer
            // 
            this.Btn_Trailer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Trailer.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Trailer.Image")));
            this.Btn_Trailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Trailer.Location = new System.Drawing.Point(294, 185);
            this.Btn_Trailer.Name = "Btn_Trailer";
            this.Btn_Trailer.Size = new System.Drawing.Size(146, 43);
            this.Btn_Trailer.TabIndex = 56;
            this.Btn_Trailer.Text = "VER TRAILER";
            this.Btn_Trailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Trailer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Trailer.UseVisualStyleBackColor = true;
            this.Btn_Trailer.Visible = false;
            this.Btn_Trailer.Click += new System.EventHandler(this.Btn_Trailer_Click);
            // 
            // Lbl_tituloSinopsis
            // 
            this.Lbl_tituloSinopsis.AutoSize = true;
            this.Lbl_tituloSinopsis.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_tituloSinopsis.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tituloSinopsis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Lbl_tituloSinopsis.Location = new System.Drawing.Point(325, 285);
            this.Lbl_tituloSinopsis.Name = "Lbl_tituloSinopsis";
            this.Lbl_tituloSinopsis.Size = new System.Drawing.Size(74, 17);
            this.Lbl_tituloSinopsis.TabIndex = 55;
            this.Lbl_tituloSinopsis.Text = "SINÓPSIS";
            this.Lbl_tituloSinopsis.Visible = false;
            // 
            // Lbl_Clasificacion
            // 
            this.Lbl_Clasificacion.AutoSize = true;
            this.Lbl_Clasificacion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Lbl_Clasificacion.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Clasificacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Clasificacion.Location = new System.Drawing.Point(291, 133);
            this.Lbl_Clasificacion.Name = "Lbl_Clasificacion";
            this.Lbl_Clasificacion.Size = new System.Drawing.Size(123, 17);
            this.Lbl_Clasificacion.TabIndex = 53;
            this.Lbl_Clasificacion.Text = "CLASIFICACION";
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(291, 103);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(86, 18);
            this.Lbl_Titulo.TabIndex = 52;
            this.Lbl_Titulo.Text = "PELICULA";
            // 
            // Pic_imagen
            // 
            this.Pic_imagen.Location = new System.Drawing.Point(52, 103);
            this.Pic_imagen.Name = "Pic_imagen";
            this.Pic_imagen.Size = new System.Drawing.Size(138, 204);
            this.Pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_imagen.TabIndex = 62;
            this.Pic_imagen.TabStop = false;
            this.Pic_imagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_estrenos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 556);
            this.Controls.Add(this.Pic_imagen);
            this.Controls.Add(this.Txt_Sinopsis);
            this.Controls.Add(this.Cbo_peliculas);
            this.Controls.Add(this.Btn_misionSalir);
            this.Controls.Add(this.Panel_abajo);
            this.Controls.Add(this.Panel_arriba);
            this.Controls.Add(this.Btn_Trailer);
            this.Controls.Add(this.Lbl_tituloSinopsis);
            this.Controls.Add(this.Lbl_Clasificacion);
            this.Controls.Add(this.Lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_estrenos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTRENOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_estrenos_FormClosing);
            this.Load += new System.EventHandler(this.frm_estrenos_Load);
            this.Panel_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Sinopsis;
        private System.Windows.Forms.ComboBox Cbo_peliculas;
        private System.Windows.Forms.Button Btn_misionSalir;
        private System.Windows.Forms.Panel Panel_abajo;
        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.PictureBox Pic_logo;
        private System.Windows.Forms.Button Btn_Trailer;
        private System.Windows.Forms.Label Lbl_tituloSinopsis;
        private System.Windows.Forms.Label Lbl_Clasificacion;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.PictureBox Pic_imagen;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}