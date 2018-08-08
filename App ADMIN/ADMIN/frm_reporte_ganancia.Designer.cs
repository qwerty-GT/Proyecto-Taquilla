namespace ADMIN
{
    partial class frm_reporte_ganancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reporte_ganancia));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_loginSalir = new System.Windows.Forms.Button();
            this.Btn_Consulta = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_formatoAceptar = new System.Windows.Forms.Button();
            this.tbc_informacion = new System.Windows.Forms.TabControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tbc_informacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.Btn_loginSalir);
            this.tabPage1.Controls.Add(this.Btn_Consulta);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.Btn_formatoAceptar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(897, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "REPORTE";
            // 
            // Btn_loginSalir
            // 
            this.Btn_loginSalir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_loginSalir.Image")));
            this.Btn_loginSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_loginSalir.Location = new System.Drawing.Point(784, 7);
            this.Btn_loginSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_loginSalir.Name = "Btn_loginSalir";
            this.Btn_loginSalir.Size = new System.Drawing.Size(109, 53);
            this.Btn_loginSalir.TabIndex = 63;
            this.Btn_loginSalir.Text = "SALIR";
            this.Btn_loginSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_loginSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_loginSalir.UseVisualStyleBackColor = true;
            this.Btn_loginSalir.Click += new System.EventHandler(this.Btn_loginSalir_Click);
            // 
            // Btn_Consulta
            // 
            this.Btn_Consulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Consulta.BackgroundImage")));
            this.Btn_Consulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Consulta.Location = new System.Drawing.Point(661, 26);
            this.Btn_Consulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Consulta.Name = "Btn_Consulta";
            this.Btn_Consulta.Size = new System.Drawing.Size(39, 34);
            this.Btn_Consulta.TabIndex = 62;
            this.toolTip1.SetToolTip(this.Btn_Consulta, "Buscar datos");
            this.Btn_Consulta.UseVisualStyleBackColor = true;
            this.Btn_Consulta.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(135, 51);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(519, 22);
            this.dateTimePicker2.TabIndex = 30;
            this.dateTimePicker2.TabStop = false;
            this.dateTimePicker2.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "FECHA LIMITE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 20);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(519, 22);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "FECHA INICIO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(5, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 386);
            this.dataGridView1.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(7, 592);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 50);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_formatoAceptar
            // 
            this.Btn_formatoAceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_formatoAceptar.Image")));
            this.Btn_formatoAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_formatoAceptar.Location = new System.Drawing.Point(680, 530);
            this.Btn_formatoAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_formatoAceptar.Name = "Btn_formatoAceptar";
            this.Btn_formatoAceptar.Size = new System.Drawing.Size(211, 53);
            this.Btn_formatoAceptar.TabIndex = 22;
            this.Btn_formatoAceptar.Text = "GENERAR REPORTE";
            this.Btn_formatoAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_formatoAceptar.UseVisualStyleBackColor = true;
            this.Btn_formatoAceptar.Click += new System.EventHandler(this.Btn_formatoAceptar_Click);
            // 
            // tbc_informacion
            // 
            this.tbc_informacion.Controls.Add(this.tabPage1);
            this.tbc_informacion.Location = new System.Drawing.Point(3, 2);
            this.tbc_informacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbc_informacion.Name = "tbc_informacion";
            this.tbc_informacion.SelectedIndex = 0;
            this.tbc_informacion.Size = new System.Drawing.Size(905, 678);
            this.tbc_informacion.TabIndex = 27;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "GANANCIA";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CINEMA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frm_reporte_ganancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(912, 684);
            this.Controls.Add(this.tbc_informacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_reporte_ganancia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GANANCIAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_reporte_ganancia_FormClosing);
            this.Load += new System.EventHandler(this.frm_reporte_peliculas_taquilleras_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tbc_informacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Btn_loginSalir;
        private System.Windows.Forms.Button Btn_Consulta;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_formatoAceptar;
        private System.Windows.Forms.TabControl tbc_informacion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}