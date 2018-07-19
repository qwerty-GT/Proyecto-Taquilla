namespace ADMIN
{
    partial class frm_salas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_salas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_salasSalir = new System.Windows.Forms.Button();
            this.Btn_salasAceptar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_salasColumnas = new System.Windows.Forms.Label();
            this.Txt_salasColumnas = new System.Windows.Forms.TextBox();
            this.Lbl_salasFilas = new System.Windows.Forms.Label();
            this.Txt_salasFilas = new System.Windows.Forms.TextBox();
            this.Lbl_salasIdioma = new System.Windows.Forms.Label();
            this.Txt_salasIdioma = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Lbl_GestioSalas = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabControl1.TabIndex = 12;
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_salasSalir);
            this.groupBox1.Controls.Add(this.Btn_salasAceptar);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.Lbl_salasColumnas);
            this.groupBox1.Controls.Add(this.Txt_salasColumnas);
            this.groupBox1.Controls.Add(this.Lbl_salasFilas);
            this.groupBox1.Controls.Add(this.Txt_salasFilas);
            this.groupBox1.Controls.Add(this.Lbl_salasIdioma);
            this.groupBox1.Controls.Add(this.Txt_salasIdioma);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NUEVA SALA";
            // 
            // Btn_salasSalir
            // 
            this.Btn_salasSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salasSalir.Image")));
            this.Btn_salasSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_salasSalir.Location = new System.Drawing.Point(548, 383);
            this.Btn_salasSalir.Name = "Btn_salasSalir";
            this.Btn_salasSalir.Size = new System.Drawing.Size(82, 43);
            this.Btn_salasSalir.TabIndex = 42;
            this.Btn_salasSalir.Text = "SALIR";
            this.Btn_salasSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_salasSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_salasSalir.UseVisualStyleBackColor = true;
            this.Btn_salasSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_salasAceptar
            // 
            this.Btn_salasAceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salasAceptar.Image")));
            this.Btn_salasAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_salasAceptar.Location = new System.Drawing.Point(445, 383);
            this.Btn_salasAceptar.Name = "Btn_salasAceptar";
            this.Btn_salasAceptar.Size = new System.Drawing.Size(97, 43);
            this.Btn_salasAceptar.TabIndex = 41;
            this.Btn_salasAceptar.Text = "ACEPTAR";
            this.Btn_salasAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_salasAceptar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(0, 432);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 41);
            this.panel3.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 41);
            this.panel4.TabIndex = 38;
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
            // Lbl_salasColumnas
            // 
            this.Lbl_salasColumnas.AutoSize = true;
            this.Lbl_salasColumnas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_salasColumnas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_salasColumnas.Location = new System.Drawing.Point(51, 244);
            this.Lbl_salasColumnas.Name = "Lbl_salasColumnas";
            this.Lbl_salasColumnas.Size = new System.Drawing.Size(99, 15);
            this.Lbl_salasColumnas.TabIndex = 22;
            this.Lbl_salasColumnas.Text = "NO. COLUMNAS:";
            // 
            // Txt_salasColumnas
            // 
            this.Txt_salasColumnas.Location = new System.Drawing.Point(163, 241);
            this.Txt_salasColumnas.Name = "Txt_salasColumnas";
            this.Txt_salasColumnas.Size = new System.Drawing.Size(379, 20);
            this.Txt_salasColumnas.TabIndex = 21;
            // 
            // Lbl_salasFilas
            // 
            this.Lbl_salasFilas.AutoSize = true;
            this.Lbl_salasFilas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_salasFilas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_salasFilas.Location = new System.Drawing.Point(51, 214);
            this.Lbl_salasFilas.Name = "Lbl_salasFilas";
            this.Lbl_salasFilas.Size = new System.Drawing.Size(65, 15);
            this.Lbl_salasFilas.TabIndex = 20;
            this.Lbl_salasFilas.Text = "NO. FILAS:";
            // 
            // Txt_salasFilas
            // 
            this.Txt_salasFilas.Location = new System.Drawing.Point(163, 211);
            this.Txt_salasFilas.Name = "Txt_salasFilas";
            this.Txt_salasFilas.Size = new System.Drawing.Size(379, 20);
            this.Txt_salasFilas.TabIndex = 19;
            // 
            // Lbl_salasIdioma
            // 
            this.Lbl_salasIdioma.AutoSize = true;
            this.Lbl_salasIdioma.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_salasIdioma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_salasIdioma.Location = new System.Drawing.Point(51, 185);
            this.Lbl_salasIdioma.Name = "Lbl_salasIdioma";
            this.Lbl_salasIdioma.Size = new System.Drawing.Size(51, 15);
            this.Lbl_salasIdioma.TabIndex = 18;
            this.Lbl_salasIdioma.Text = "IDIOMA:";
            // 
            // Txt_salasIdioma
            // 
            this.Txt_salasIdioma.Location = new System.Drawing.Point(163, 182);
            this.Txt_salasIdioma.Name = "Txt_salasIdioma";
            this.Txt_salasIdioma.Size = new System.Drawing.Size(379, 20);
            this.Txt_salasIdioma.TabIndex = 17;
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
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 473);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSQUEDA SALA";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(548, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 43);
            this.button2.TabIndex = 42;
            this.button2.Text = "SALIR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(436, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 43);
            this.button3.TabIndex = 41;
            this.button3.Text = "BUSCAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(0, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 41);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 41);
            this.panel2.TabIndex = 38;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(74, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "NO. SALA:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(164, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(379, 20);
            this.textBox4.TabIndex = 8;
            // 
            // Lbl_GestioSalas
            // 
            this.Lbl_GestioSalas.AutoSize = true;
            this.Lbl_GestioSalas.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GestioSalas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_GestioSalas.Location = new System.Drawing.Point(12, 11);
            this.Lbl_GestioSalas.Name = "Lbl_GestioSalas";
            this.Lbl_GestioSalas.Size = new System.Drawing.Size(157, 21);
            this.Lbl_GestioSalas.TabIndex = 11;
            this.Lbl_GestioSalas.Text = "GESTION SALAS";
            // 
            // frm_salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(684, 556);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Lbl_GestioSalas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_salas";
            this.Text = "Salas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Lbl_GestioSalas;
        private System.Windows.Forms.Label Lbl_salasColumnas;
        private System.Windows.Forms.TextBox Txt_salasColumnas;
        private System.Windows.Forms.Label Lbl_salasFilas;
        private System.Windows.Forms.TextBox Txt_salasFilas;
        private System.Windows.Forms.Label Lbl_salasIdioma;
        private System.Windows.Forms.TextBox Txt_salasIdioma;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_salasAceptar;
        private System.Windows.Forms.Button Btn_salasSalir;
        private System.Windows.Forms.Button button2;
    }
}