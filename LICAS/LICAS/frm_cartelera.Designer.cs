namespace LICAS
{
    partial class frm_cartelera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cartelera));
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.Panel_abajo = new System.Windows.Forms.Panel();
            this.dgb_pelicula = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Género = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Cmb_Sub = new System.Windows.Forms.ComboBox();
            this.Cmb_Idioma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_menuCine = new System.Windows.Forms.Label();
            this.Lbl_menuCiudad = new System.Windows.Forms.Label();
            this.Cmb_menuCine = new System.Windows.Forms.ComboBox();
            this.Cmb_menuCiudad = new System.Windows.Forms.ComboBox();
            this.cmb_formato = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.cmb_experiencia = new System.Windows.Forms.ComboBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Btn_ayudaSalir = new System.Windows.Forms.Button();
            this.Panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_pelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_arriba
            // 
            this.Panel_arriba.BackColor = System.Drawing.Color.Yellow;
            this.Panel_arriba.Controls.Add(this.Pic_logo);
            this.Panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.Panel_arriba.Name = "Panel_arriba";
            this.Panel_arriba.Size = new System.Drawing.Size(684, 41);
            this.Panel_arriba.TabIndex = 211;
            // 
            // Pic_logo
            // 
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(12, 3);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(91, 38);
            this.Pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_logo.TabIndex = 0;
            this.Pic_logo.TabStop = false;
            this.Pic_logo.Click += new System.EventHandler(this.Pic_logo_Click);
            // 
            // Panel_abajo
            // 
            this.Panel_abajo.BackColor = System.Drawing.Color.Yellow;
            this.Panel_abajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_abajo.Location = new System.Drawing.Point(0, 515);
            this.Panel_abajo.Name = "Panel_abajo";
            this.Panel_abajo.Size = new System.Drawing.Size(684, 41);
            this.Panel_abajo.TabIndex = 212;
            // 
            // dgb_pelicula
            // 
            this.dgb_pelicula.AllowUserToAddRows = false;
            this.dgb_pelicula.AllowUserToDeleteRows = false;
            this.dgb_pelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_pelicula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Nombre,
            this.Género,
            this.Clasificación,
            this.Column1,
            this.Column2,
            this.Formato,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgb_pelicula.Location = new System.Drawing.Point(9, 173);
            this.dgb_pelicula.Margin = new System.Windows.Forms.Padding(2);
            this.dgb_pelicula.Name = "dgb_pelicula";
            this.dgb_pelicula.ReadOnly = true;
            this.dgb_pelicula.RowTemplate.Height = 24;
            this.dgb_pelicula.Size = new System.Drawing.Size(664, 290);
            this.dgb_pelicula.TabIndex = 316;
            this.dgb_pelicula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_pelicula_CellClick);
            this.dgb_pelicula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_pelicula_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Funcion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Película";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Género
            // 
            this.Género.HeaderText = "Género";
            this.Género.Name = "Género";
            this.Género.ReadOnly = true;
            this.Género.Width = 75;
            // 
            // Clasificación
            // 
            this.Clasificación.HeaderText = "Clasificación";
            this.Clasificación.Name = "Clasificación";
            this.Clasificación.ReadOnly = true;
            this.Clasificación.Width = 75;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Horario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Formato
            // 
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            this.Formato.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Experiencia";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 73;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Idioma";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Subtitulos";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cine";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 83;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Font = new System.Drawing.Font("Rockwell", 9.25F);
            this.button6.Location = new System.Drawing.Point(572, 107);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(21, 21);
            this.button6.TabIndex = 315;
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Rockwell", 9.25F);
            this.button5.Location = new System.Drawing.Point(572, 137);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 21);
            this.button5.TabIndex = 314;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Rockwell", 9.25F);
            this.button4.Location = new System.Drawing.Point(322, 103);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 21);
            this.button4.TabIndex = 313;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Rockwell", 9.25F);
            this.button3.Location = new System.Drawing.Point(322, 136);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 21);
            this.button3.TabIndex = 312;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Rockwell", 9.25F);
            this.button2.Location = new System.Drawing.Point(636, 61);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 21);
            this.button2.TabIndex = 311;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.25F);
            this.button1.Location = new System.Drawing.Point(456, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 310;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cmb_Sub
            // 
            this.Cmb_Sub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Sub.FormattingEnabled = true;
            this.Cmb_Sub.Location = new System.Drawing.Point(472, 137);
            this.Cmb_Sub.Name = "Cmb_Sub";
            this.Cmb_Sub.Size = new System.Drawing.Size(95, 21);
            this.Cmb_Sub.TabIndex = 309;
            this.Cmb_Sub.SelectedIndexChanged += new System.EventHandler(this.Cmb_Sub_SelectedIndexChanged);
            // 
            // Cmb_Idioma
            // 
            this.Cmb_Idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Idioma.FormattingEnabled = true;
            this.Cmb_Idioma.Location = new System.Drawing.Point(472, 107);
            this.Cmb_Idioma.Name = "Cmb_Idioma";
            this.Cmb_Idioma.Size = new System.Drawing.Size(95, 21);
            this.Cmb_Idioma.TabIndex = 308;
            this.Cmb_Idioma.SelectedIndexChanged += new System.EventHandler(this.Cmb_Idioma_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 307;
            this.label3.Text = "SUBTITULADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 306;
            this.label2.Text = "IDIOMA";
            // 
            // Lbl_menuCine
            // 
            this.Lbl_menuCine.AutoSize = true;
            this.Lbl_menuCine.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_menuCine.Location = new System.Drawing.Point(482, 64);
            this.Lbl_menuCine.Name = "Lbl_menuCine";
            this.Lbl_menuCine.Size = new System.Drawing.Size(48, 18);
            this.Lbl_menuCine.TabIndex = 305;
            this.Lbl_menuCine.Text = "CINE";
            // 
            // Lbl_menuCiudad
            // 
            this.Lbl_menuCiudad.AutoSize = true;
            this.Lbl_menuCiudad.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_menuCiudad.Location = new System.Drawing.Point(285, 62);
            this.Lbl_menuCiudad.Name = "Lbl_menuCiudad";
            this.Lbl_menuCiudad.Size = new System.Drawing.Size(70, 18);
            this.Lbl_menuCiudad.TabIndex = 304;
            this.Lbl_menuCiudad.Text = "CIUDAD";
            // 
            // Cmb_menuCine
            // 
            this.Cmb_menuCine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_menuCine.FormattingEnabled = true;
            this.Cmb_menuCine.Location = new System.Drawing.Point(536, 61);
            this.Cmb_menuCine.Name = "Cmb_menuCine";
            this.Cmb_menuCine.Size = new System.Drawing.Size(95, 21);
            this.Cmb_menuCine.TabIndex = 303;
            this.Cmb_menuCine.SelectedIndexChanged += new System.EventHandler(this.Cmb_menuCIne_SelectedIndexChanged);
            // 
            // Cmb_menuCiudad
            // 
            this.Cmb_menuCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_menuCiudad.FormattingEnabled = true;
            this.Cmb_menuCiudad.Location = new System.Drawing.Point(356, 61);
            this.Cmb_menuCiudad.Name = "Cmb_menuCiudad";
            this.Cmb_menuCiudad.Size = new System.Drawing.Size(95, 21);
            this.Cmb_menuCiudad.TabIndex = 302;
            this.Cmb_menuCiudad.SelectedIndexChanged += new System.EventHandler(this.Cmb_menuCiudadd_SelectedIndexChanged);
            // 
            // cmb_formato
            // 
            this.cmb_formato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_formato.FormattingEnabled = true;
            this.cmb_formato.Location = new System.Drawing.Point(222, 136);
            this.cmb_formato.Name = "cmb_formato";
            this.cmb_formato.Size = new System.Drawing.Size(95, 21);
            this.cmb_formato.TabIndex = 301;
            this.cmb_formato.SelectedIndexChanged += new System.EventHandler(this.Cbo_formato_SelectedIndexChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(103, 134);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(91, 18);
            this.Label4.TabIndex = 296;
            this.Label4.Text = "FORMATO";
            // 
            // cmb_experiencia
            // 
            this.cmb_experiencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_experiencia.FormattingEnabled = true;
            this.cmb_experiencia.Location = new System.Drawing.Point(222, 103);
            this.cmb_experiencia.Name = "cmb_experiencia";
            this.cmb_experiencia.Size = new System.Drawing.Size(95, 21);
            this.cmb_experiencia.TabIndex = 300;
            this.cmb_experiencia.SelectedIndexChanged += new System.EventHandler(this.Cbo_experiencia_SelectedIndexChanged);
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.Location = new System.Drawing.Point(103, 103);
            this.Label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(116, 18);
            this.Label26.TabIndex = 297;
            this.Label26.Text = "EXPERIENCIA";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label1.Location = new System.Drawing.Point(5, 61);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(235, 19);
            this.Label1.TabIndex = 298;
            this.Label1.Text = "CARTELERA DE PELICULAS";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_ayudaSalir
            // 
            this.Btn_ayudaSalir.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayudaSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayudaSalir.Image")));
            this.Btn_ayudaSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ayudaSalir.Location = new System.Drawing.Point(580, 468);
            this.Btn_ayudaSalir.Name = "Btn_ayudaSalir";
            this.Btn_ayudaSalir.Size = new System.Drawing.Size(93, 41);
            this.Btn_ayudaSalir.TabIndex = 317;
            this.Btn_ayudaSalir.Text = "SALIR";
            this.Btn_ayudaSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ayudaSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ayudaSalir.UseVisualStyleBackColor = true;
            this.Btn_ayudaSalir.Click += new System.EventHandler(this.Btn_ayudaSalir_Click);
            // 
            // frm_cartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 556);
            this.Controls.Add(this.Btn_ayudaSalir);
            this.Controls.Add(this.dgb_pelicula);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cmb_Sub);
            this.Controls.Add(this.Cmb_Idioma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_menuCine);
            this.Controls.Add(this.Lbl_menuCiudad);
            this.Controls.Add(this.Cmb_menuCine);
            this.Controls.Add(this.Cmb_menuCiudad);
            this.Controls.Add(this.cmb_formato);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cmb_experiencia);
            this.Controls.Add(this.Label26);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel_abajo);
            this.Controls.Add(this.Panel_arriba);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_cartelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARTELERA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_cartelera_FormClosing);
            this.Load += new System.EventHandler(this.frm_cartelera_Load);
            this.Panel_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_pelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.PictureBox Pic_logo;
        private System.Windows.Forms.Panel Panel_abajo;
        private System.Windows.Forms.DataGridView dgb_pelicula;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Cmb_Sub;
        private System.Windows.Forms.ComboBox Cmb_Idioma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_menuCine;
        private System.Windows.Forms.Label Lbl_menuCiudad;
        public System.Windows.Forms.ComboBox Cmb_menuCine;
        public System.Windows.Forms.ComboBox Cmb_menuCiudad;
        private System.Windows.Forms.ComboBox cmb_formato;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.ComboBox cmb_experiencia;
        private System.Windows.Forms.Label Label26;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Btn_ayudaSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Género;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}