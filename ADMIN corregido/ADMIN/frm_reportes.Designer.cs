namespace ADMIN
{
    partial class frm_reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reportes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_reportesSalir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_reportesEstadisticas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_reportesPeliculas = new System.Windows.Forms.Button();
            this.Btn_reportesHorarios = new System.Windows.Forms.Button();
            this.Btn_reportesFunciones = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Btn_reportesSalir);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btn_reportesEstadisticas);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Btn_reportesPeliculas);
            this.groupBox1.Controls.Add(this.Btn_reportesHorarios);
            this.groupBox1.Controls.Add(this.Btn_reportesFunciones);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(677, 549);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GENERACION DE REPORTES";
            // 
            // Btn_reportesSalir
            // 
            this.Btn_reportesSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_reportesSalir.Image")));
            this.Btn_reportesSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_reportesSalir.Location = new System.Drawing.Point(476, 403);
            this.Btn_reportesSalir.Name = "Btn_reportesSalir";
            this.Btn_reportesSalir.Size = new System.Drawing.Size(82, 43);
            this.Btn_reportesSalir.TabIndex = 21;
            this.Btn_reportesSalir.Text = "SALIR";
            this.Btn_reportesSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_reportesSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_reportesSalir.UseVisualStyleBackColor = true;
            this.Btn_reportesSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(188, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btn_reportesEstadisticas
            // 
            this.btn_reportesEstadisticas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_reportesEstadisticas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reportesEstadisticas.BackgroundImage")));
            this.btn_reportesEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reportesEstadisticas.Location = new System.Drawing.Point(64, 50);
            this.btn_reportesEstadisticas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reportesEstadisticas.Name = "btn_reportesEstadisticas";
            this.btn_reportesEstadisticas.Size = new System.Drawing.Size(94, 100);
            this.btn_reportesEstadisticas.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_reportesEstadisticas, "Ganancias");
            this.btn_reportesEstadisticas.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Yellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 168);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(514, 291);
            this.dataGridView1.TabIndex = 4;
            // 
            // Btn_reportesPeliculas
            // 
            this.Btn_reportesPeliculas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_reportesPeliculas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_reportesPeliculas.BackgroundImage")));
            this.Btn_reportesPeliculas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_reportesPeliculas.Location = new System.Drawing.Point(476, 50);
            this.Btn_reportesPeliculas.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_reportesPeliculas.Name = "Btn_reportesPeliculas";
            this.Btn_reportesPeliculas.Size = new System.Drawing.Size(94, 100);
            this.Btn_reportesPeliculas.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Btn_reportesPeliculas, "Puntos de cliente");
            this.Btn_reportesPeliculas.UseVisualStyleBackColor = false;
            // 
            // Btn_reportesHorarios
            // 
            this.Btn_reportesHorarios.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_reportesHorarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_reportesHorarios.BackgroundImage")));
            this.Btn_reportesHorarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_reportesHorarios.Location = new System.Drawing.Point(334, 50);
            this.Btn_reportesHorarios.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_reportesHorarios.Name = "Btn_reportesHorarios";
            this.Btn_reportesHorarios.Size = new System.Drawing.Size(94, 100);
            this.Btn_reportesHorarios.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Btn_reportesHorarios, "Horarios");
            this.Btn_reportesHorarios.UseVisualStyleBackColor = false;
            // 
            // Btn_reportesFunciones
            // 
            this.Btn_reportesFunciones.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_reportesFunciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_reportesFunciones.BackgroundImage")));
            this.Btn_reportesFunciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_reportesFunciones.Location = new System.Drawing.Point(198, 50);
            this.Btn_reportesFunciones.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_reportesFunciones.Name = "Btn_reportesFunciones";
            this.Btn_reportesFunciones.Size = new System.Drawing.Size(94, 100);
            this.Btn_reportesFunciones.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Btn_reportesFunciones, "Peliculas taquilleras");
            this.Btn_reportesFunciones.UseVisualStyleBackColor = false;
            // 
            // frm_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(684, 556);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTES";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_reportesPeliculas;
        private System.Windows.Forms.Button Btn_reportesHorarios;
        private System.Windows.Forms.Button Btn_reportesFunciones;
        private System.Windows.Forms.Button btn_reportesEstadisticas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_reportesSalir;
    }
}