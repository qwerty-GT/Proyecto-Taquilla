namespace ADMIN
{
    partial class Ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda));
            this.Gpb1 = new System.Windows.Forms.GroupBox();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Gbp2 = new System.Windows.Forms.GroupBox();
            this.Llbl1 = new System.Windows.Forms.LinkLabel();
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
            this.Gpb1.Controls.Add(this.Btn2);
            this.Gpb1.Controls.Add(this.Btn1);
            this.Gpb1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb1.Location = new System.Drawing.Point(2, 59);
            this.Gpb1.Margin = new System.Windows.Forms.Padding(2);
            this.Gpb1.Name = "Gpb1";
            this.Gpb1.Padding = new System.Windows.Forms.Padding(2);
            this.Gpb1.Size = new System.Drawing.Size(506, 237);
            this.Gpb1.TabIndex = 0;
            this.Gpb1.TabStop = false;
            this.Gpb1.Text = "AYUDA DESTACADA";
            this.Gpb1.Enter += new System.EventHandler(this.Gbp1);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn2.BackgroundImage")));
            this.Btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn2.Location = new System.Drawing.Point(280, 34);
            this.Btn2.Margin = new System.Windows.Forms.Padding(2);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(125, 137);
            this.Btn2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Btn2, "Diccionario de Conceptos");
            this.Btn2.UseVisualStyleBackColor = false;
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn1.BackgroundImage")));
            this.Btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn1.Location = new System.Drawing.Point(92, 34);
            this.Btn1.Margin = new System.Windows.Forms.Padding(2);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(132, 137);
            this.Btn1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Btn1, "Manual de Usuario");
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Gbp2
            // 
            this.Gbp2.BackColor = System.Drawing.SystemColors.Control;
            this.Gbp2.Controls.Add(this.Llbl1);
            this.Gbp2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbp2.Location = new System.Drawing.Point(2, 300);
            this.Gbp2.Margin = new System.Windows.Forms.Padding(2);
            this.Gbp2.Name = "Gbp2";
            this.Gbp2.Padding = new System.Windows.Forms.Padding(2);
            this.Gbp2.Size = new System.Drawing.Size(506, 144);
            this.Gbp2.TabIndex = 1;
            this.Gbp2.TabStop = false;
            this.Gbp2.Text = "PREGUNTAS FRECUENTES";
            this.Gbp2.Enter += new System.EventHandler(this.Gbp2_Enter);
            // 
            // Llbl1
            // 
            this.Llbl1.AutoSize = true;
            this.Llbl1.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.Llbl1.Location = new System.Drawing.Point(68, 32);
            this.Llbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Llbl1.Name = "Llbl1";
            this.Llbl1.Size = new System.Drawing.Size(409, 15);
            this.Llbl1.TabIndex = 0;
            this.Llbl1.TabStop = true;
            this.Llbl1.Text = "¿Qué hacer en caso de que el servidor de base de datos se desconecte?";
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
            // Ayuda
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
            this.Name = "Ayuda";
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
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.GroupBox Gbp2;
        private System.Windows.Forms.LinkLabel Llbl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}