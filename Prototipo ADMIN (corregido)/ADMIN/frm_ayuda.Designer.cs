namespace ADMIN
{
    partial class frm_ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ayuda));
            this.Gpb1 = new System.Windows.Forms.GroupBox();
            this.Btn_ayudaManual = new System.Windows.Forms.Button();
            this.Btn_ayudaHerramientas = new System.Windows.Forms.Button();
            this.Gbp2 = new System.Windows.Forms.GroupBox();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Lbl_ServidorDesconecte = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Gpb1.SuspendLayout();
            this.Gbp2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpb1
            // 
            this.Gpb1.BackColor = System.Drawing.SystemColors.Control;
            this.Gpb1.Controls.Add(this.Btn_ayudaManual);
            this.Gpb1.Controls.Add(this.Btn_ayudaHerramientas);
            this.Gpb1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb1.Location = new System.Drawing.Point(2, 59);
            this.Gpb1.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb1.Name = "Gpb1";
            this.Gpb1.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb1.Size = new System.Drawing.Size(506, 200);
            this.Gpb1.TabIndex = 0;
            this.Gpb1.TabStop = false;
            this.Gpb1.Text = "AYUDA DESTACADA";
            this.Gpb1.Enter += new System.EventHandler(this.Gbp1);
            // 
            // Btn_ayudaManual
            // 
            this.Btn_ayudaManual.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ayudaManual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ayudaManual.BackgroundImage")));
            this.Btn_ayudaManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ayudaManual.Location = new System.Drawing.Point(280, 34);
            this.Btn_ayudaManual.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ayudaManual.Name = "Btn_ayudaManual";
            this.Btn_ayudaManual.Size = new System.Drawing.Size(125, 137);
            this.Btn_ayudaManual.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Btn_ayudaManual, "Diccionario de Conceptos");
            this.Btn_ayudaManual.UseVisualStyleBackColor = false;
            // 
            // Btn_ayudaHerramientas
            // 
            this.Btn_ayudaHerramientas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_ayudaHerramientas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ayudaHerramientas.BackgroundImage")));
            this.Btn_ayudaHerramientas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ayudaHerramientas.Location = new System.Drawing.Point(92, 34);
            this.Btn_ayudaHerramientas.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ayudaHerramientas.Name = "Btn_ayudaHerramientas";
            this.Btn_ayudaHerramientas.Size = new System.Drawing.Size(132, 137);
            this.Btn_ayudaHerramientas.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Btn_ayudaHerramientas, "Manual de Usuario");
            this.Btn_ayudaHerramientas.UseVisualStyleBackColor = false;
            this.Btn_ayudaHerramientas.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Gbp2
            // 
            this.Gbp2.BackColor = System.Drawing.SystemColors.Control;
            this.Gbp2.Controls.Add(this.Btn_salir);
            this.Gbp2.Controls.Add(this.Lbl_ServidorDesconecte);
            this.Gbp2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbp2.Location = new System.Drawing.Point(2, 263);
            this.Gbp2.Margin = new System.Windows.Forms.Padding(2);
            this.Gbp2.Name = "Gbp2";
            this.Gbp2.Padding = new System.Windows.Forms.Padding(2);
            this.Gbp2.Size = new System.Drawing.Size(506, 135);
            this.Gbp2.TabIndex = 1;
            this.Gbp2.TabStop = false;
            this.Gbp2.Text = "PREGUNTAS FRECUENTES";
            this.Gbp2.Enter += new System.EventHandler(this.Gbp2_Enter);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_salir.Location = new System.Drawing.Point(419, 87);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(82, 43);
            this.Btn_salir.TabIndex = 21;
            this.Btn_salir.Text = "SALIR";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_ServidorDesconecte
            // 
            this.Lbl_ServidorDesconecte.AutoSize = true;
            this.Lbl_ServidorDesconecte.LinkColor = System.Drawing.Color.Red;
            this.Lbl_ServidorDesconecte.Location = new System.Drawing.Point(68, 32);
            this.Lbl_ServidorDesconecte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ServidorDesconecte.Name = "Lbl_ServidorDesconecte";
            this.Lbl_ServidorDesconecte.Size = new System.Drawing.Size(409, 15);
            this.Lbl_ServidorDesconecte.TabIndex = 0;
            this.Lbl_ServidorDesconecte.TabStop = true;
            this.Lbl_ServidorDesconecte.Text = "¿Qué hacer en caso de que el servidor de base de datos se desconecte?";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(2, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(506, 41);
            this.panel4.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(2, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 41);
            this.panel1.TabIndex = 23;
            // 
            // frm_ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Gbp2);
            this.Controls.Add(this.Gpb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_ayuda";
            this.Text = "Ayuda";
            this.Gpb1.ResumeLayout(false);
            this.Gbp2.ResumeLayout(false);
            this.Gbp2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb1;
        private System.Windows.Forms.Button Btn_ayudaManual;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Btn_ayudaHerramientas;
        private System.Windows.Forms.GroupBox Gbp2;
        private System.Windows.Forms.LinkLabel Lbl_ServidorDesconecte;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_salir;
    }
}