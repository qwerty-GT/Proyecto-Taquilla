namespace ADMIN
{
    partial class frm_peliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_peliculas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_peliculasSalir = new System.Windows.Forms.Button();
            this.Btn_peliculasAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_peliculasVideo = new System.Windows.Forms.Label();
            this.Txt_peliculasVideo = new System.Windows.Forms.TextBox();
            this.Lbl_peliculasFormato = new System.Windows.Forms.Label();
            this.Cmb_peliculasFormato = new System.Windows.Forms.ComboBox();
            this.Lbl_peliculasIdioma = new System.Windows.Forms.Label();
            this.Cmb_peliculasIdioma = new System.Windows.Forms.ComboBox();
            this.Lbl_peliculasGenero = new System.Windows.Forms.Label();
            this.Cmb_peliculasGenero = new System.Windows.Forms.ComboBox();
            this.Lbl_peliculasSinopsis = new System.Windows.Forms.Label();
            this.Lbl_peliculasNombre = new System.Windows.Forms.Label();
            this.Txt_peliculasSinopsis = new System.Windows.Forms.TextBox();
            this.Txt_peliculasNombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Lbl_gestionPeliculas = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 511);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "INGRESAR";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Btn_peliculasSalir);
            this.groupBox1.Controls.Add(this.Btn_peliculasAceptar);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.Lbl_peliculasVideo);
            this.groupBox1.Controls.Add(this.Txt_peliculasVideo);
            this.groupBox1.Controls.Add(this.Lbl_peliculasFormato);
            this.groupBox1.Controls.Add(this.Cmb_peliculasFormato);
            this.groupBox1.Controls.Add(this.Lbl_peliculasIdioma);
            this.groupBox1.Controls.Add(this.Cmb_peliculasIdioma);
            this.groupBox1.Controls.Add(this.Lbl_peliculasGenero);
            this.groupBox1.Controls.Add(this.Cmb_peliculasGenero);
            this.groupBox1.Controls.Add(this.Lbl_peliculasSinopsis);
            this.groupBox1.Controls.Add(this.Lbl_peliculasNombre);
            this.groupBox1.Controls.Add(this.Txt_peliculasSinopsis);
            this.groupBox1.Controls.Add(this.Txt_peliculasNombre);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NUEVA PELICULA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Btn_peliculasSalir
            // 
            this.Btn_peliculasSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_peliculasSalir.Image")));
            this.Btn_peliculasSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_peliculasSalir.Location = new System.Drawing.Point(548, 383);
            this.Btn_peliculasSalir.Name = "Btn_peliculasSalir";
            this.Btn_peliculasSalir.Size = new System.Drawing.Size(82, 43);
            this.Btn_peliculasSalir.TabIndex = 38;
            this.Btn_peliculasSalir.Text = "SALIR";
            this.Btn_peliculasSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_peliculasSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_peliculasSalir.UseVisualStyleBackColor = true;
            this.Btn_peliculasSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_peliculasAceptar
            // 
            this.Btn_peliculasAceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_peliculasAceptar.Image")));
            this.Btn_peliculasAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_peliculasAceptar.Location = new System.Drawing.Point(445, 383);
            this.Btn_peliculasAceptar.Name = "Btn_peliculasAceptar";
            this.Btn_peliculasAceptar.Size = new System.Drawing.Size(97, 43);
            this.Btn_peliculasAceptar.TabIndex = 37;
            this.Btn_peliculasAceptar.Text = "ACEPTAR";
            this.Btn_peliculasAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_peliculasAceptar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(0, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 41);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 41);
            this.panel2.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_peliculasVideo
            // 
            this.Lbl_peliculasVideo.AutoSize = true;
            this.Lbl_peliculasVideo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_peliculasVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_peliculasVideo.Location = new System.Drawing.Point(146, 250);
            this.Lbl_peliculasVideo.Name = "Lbl_peliculasVideo";
            this.Lbl_peliculasVideo.Size = new System.Drawing.Size(45, 15);
            this.Lbl_peliculasVideo.TabIndex = 22;
            this.Lbl_peliculasVideo.Text = "VIDEO:";
            // 
            // Txt_peliculasVideo
            // 
            this.Txt_peliculasVideo.Location = new System.Drawing.Point(251, 246);
            this.Txt_peliculasVideo.Name = "Txt_peliculasVideo";
            this.Txt_peliculasVideo.Size = new System.Drawing.Size(245, 20);
            this.Txt_peliculasVideo.TabIndex = 21;
            // 
            // Lbl_peliculasFormato
            // 
            this.Lbl_peliculasFormato.AutoSize = true;
            this.Lbl_peliculasFormato.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_peliculasFormato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_peliculasFormato.Location = new System.Drawing.Point(146, 334);
            this.Lbl_peliculasFormato.Name = "Lbl_peliculasFormato";
            this.Lbl_peliculasFormato.Size = new System.Drawing.Size(66, 15);
            this.Lbl_peliculasFormato.TabIndex = 20;
            this.Lbl_peliculasFormato.Text = "FORMATO:";
            // 
            // Cmb_peliculasFormato
            // 
            this.Cmb_peliculasFormato.FormattingEnabled = true;
            this.Cmb_peliculasFormato.Location = new System.Drawing.Point(251, 332);
            this.Cmb_peliculasFormato.Name = "Cmb_peliculasFormato";
            this.Cmb_peliculasFormato.Size = new System.Drawing.Size(245, 21);
            this.Cmb_peliculasFormato.TabIndex = 19;
            // 
            // Lbl_peliculasIdioma
            // 
            this.Lbl_peliculasIdioma.AutoSize = true;
            this.Lbl_peliculasIdioma.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_peliculasIdioma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_peliculasIdioma.Location = new System.Drawing.Point(146, 306);
            this.Lbl_peliculasIdioma.Name = "Lbl_peliculasIdioma";
            this.Lbl_peliculasIdioma.Size = new System.Drawing.Size(51, 15);
            this.Lbl_peliculasIdioma.TabIndex = 18;
            this.Lbl_peliculasIdioma.Text = "IDIOMA:";
            // 
            // Cmb_peliculasIdioma
            // 
            this.Cmb_peliculasIdioma.FormattingEnabled = true;
            this.Cmb_peliculasIdioma.Location = new System.Drawing.Point(251, 304);
            this.Cmb_peliculasIdioma.Name = "Cmb_peliculasIdioma";
            this.Cmb_peliculasIdioma.Size = new System.Drawing.Size(245, 21);
            this.Cmb_peliculasIdioma.TabIndex = 17;
            // 
            // Lbl_peliculasGenero
            // 
            this.Lbl_peliculasGenero.AutoSize = true;
            this.Lbl_peliculasGenero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_peliculasGenero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_peliculasGenero.Location = new System.Drawing.Point(146, 277);
            this.Lbl_peliculasGenero.Name = "Lbl_peliculasGenero";
            this.Lbl_peliculasGenero.Size = new System.Drawing.Size(57, 15);
            this.Lbl_peliculasGenero.TabIndex = 14;
            this.Lbl_peliculasGenero.Text = "GENERO:";
            // 
            // Cmb_peliculasGenero
            // 
            this.Cmb_peliculasGenero.FormattingEnabled = true;
            this.Cmb_peliculasGenero.Location = new System.Drawing.Point(251, 275);
            this.Cmb_peliculasGenero.Name = "Cmb_peliculasGenero";
            this.Cmb_peliculasGenero.Size = new System.Drawing.Size(245, 21);
            this.Cmb_peliculasGenero.TabIndex = 13;
            // 
            // Lbl_peliculasSinopsis
            // 
            this.Lbl_peliculasSinopsis.AutoSize = true;
            this.Lbl_peliculasSinopsis.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_peliculasSinopsis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_peliculasSinopsis.Location = new System.Drawing.Point(146, 110);
            this.Lbl_peliculasSinopsis.Name = "Lbl_peliculasSinopsis";
            this.Lbl_peliculasSinopsis.Size = new System.Drawing.Size(65, 15);
            this.Lbl_peliculasSinopsis.TabIndex = 11;
            this.Lbl_peliculasSinopsis.Text = "SINOPSIS:";
            // 
            // Lbl_peliculasNombre
            // 
            this.Lbl_peliculasNombre.AutoSize = true;
            this.Lbl_peliculasNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_peliculasNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_peliculasNombre.Location = new System.Drawing.Point(146, 85);
            this.Lbl_peliculasNombre.Name = "Lbl_peliculasNombre";
            this.Lbl_peliculasNombre.Size = new System.Drawing.Size(60, 15);
            this.Lbl_peliculasNombre.TabIndex = 10;
            this.Lbl_peliculasNombre.Text = "NOMBRE:";
            this.Lbl_peliculasNombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // Txt_peliculasSinopsis
            // 
            this.Txt_peliculasSinopsis.Location = new System.Drawing.Point(251, 108);
            this.Txt_peliculasSinopsis.Multiline = true;
            this.Txt_peliculasSinopsis.Name = "Txt_peliculasSinopsis";
            this.Txt_peliculasSinopsis.Size = new System.Drawing.Size(245, 129);
            this.Txt_peliculasSinopsis.TabIndex = 9;
            // 
            // Txt_peliculasNombre
            // 
            this.Txt_peliculasNombre.Location = new System.Drawing.Point(251, 81);
            this.Txt_peliculasNombre.Name = "Txt_peliculasNombre";
            this.Txt_peliculasNombre.Size = new System.Drawing.Size(245, 20);
            this.Txt_peliculasNombre.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MODIFICAR/ELIMINAR";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 473);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSQUEDA PELICULA";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(548, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 43);
            this.button2.TabIndex = 21;
            this.button2.Text = "SALIR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(0, 432);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 41);
            this.panel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 41);
            this.panel4.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(438, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 43);
            this.button3.TabIndex = 30;
            this.button3.Text = "BUSCAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(76, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "PELICULA:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(166, 178);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(379, 20);
            this.textBox4.TabIndex = 8;
            // 
            // Lbl_gestionPeliculas
            // 
            this.Lbl_gestionPeliculas.AutoSize = true;
            this.Lbl_gestionPeliculas.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_gestionPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_gestionPeliculas.Location = new System.Drawing.Point(12, 11);
            this.Lbl_gestionPeliculas.Name = "Lbl_gestionPeliculas";
            this.Lbl_gestionPeliculas.Size = new System.Drawing.Size(198, 21);
            this.Lbl_gestionPeliculas.TabIndex = 9;
            this.Lbl_gestionPeliculas.Text = "GESTION PELICULAS";
            // 
            // frm_peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(684, 556);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Lbl_gestionPeliculas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_peliculas";
            this.Text = "PELICULAS";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_peliculasGenero;
        private System.Windows.Forms.ComboBox Cmb_peliculasGenero;
        private System.Windows.Forms.Label Lbl_peliculasSinopsis;
        private System.Windows.Forms.Label Lbl_peliculasNombre;
        private System.Windows.Forms.TextBox Txt_peliculasSinopsis;
        private System.Windows.Forms.TextBox Txt_peliculasNombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Lbl_gestionPeliculas;
        private System.Windows.Forms.Label Lbl_peliculasFormato;
        private System.Windows.Forms.ComboBox Cmb_peliculasFormato;
        private System.Windows.Forms.Label Lbl_peliculasIdioma;
        private System.Windows.Forms.ComboBox Cmb_peliculasIdioma;
        private System.Windows.Forms.Label Lbl_peliculasVideo;
        private System.Windows.Forms.TextBox Txt_peliculasVideo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_peliculasAceptar;
        private System.Windows.Forms.Button Btn_peliculasSalir;
        private System.Windows.Forms.Button button2;
    }
}